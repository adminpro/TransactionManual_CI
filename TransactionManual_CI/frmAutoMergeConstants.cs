using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TransactionManual_CI
{
    public partial class frmAutoMergeConstants : Form
    {
        #region "Variable"
        private List<PathFile> m_ListFiles;
        private List<ConstantsEnt> m_ListConstants;
        private List<ConstantsEnt> m_ListConstantsDict;
        #endregion "Variable"

        #region "Property"
        public List<PathFile> ListFiles
        {
            get
            {
                if (m_ListFiles == null)
                    m_ListFiles = new List<PathFile>();
                return m_ListFiles;
            }
            set
            {
                m_ListFiles = value;
            }
        }
        public List<ConstantsEnt> ListConstants
        {
            get
            {
                if (m_ListConstants == null)
                    m_ListConstants = new List<ConstantsEnt>();
                return m_ListConstants;
            }
            set
            {
                m_ListConstants = value;
            }
        }
        public List<ConstantsEnt> ListConstantsDict
        {
            get
            {
                if (m_ListConstantsDict == null)
                    m_ListConstantsDict = new List<ConstantsEnt>();
                return m_ListConstantsDict;
            }
            set
            {
                m_ListConstantsDict = value;
            }
        }
        #endregion "Property"

        #region "Initialization"
        public frmAutoMergeConstants()
        {
            InitializeComponent();

            //string strTest = "txtId.Text = \"123\"; lblId.Value = \"456\"";
        }
        #endregion "Initialize"

        #region "Event Function"
        #region "Delegate Handle"
        /// <summary>
        /// Forms the content of the list constants_ merge all file.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void formListConstants_MergeAllFileContent(object sender, frmListConstants.MergeEventArg e)
        {
            if (e.ListNewConstants != null)
            {
                if (e.SaveConstantsFile && !SaveConstantsFile(e.ListNewConstants, string.Format(txtClassName.Text)))
                    return;

                this.MergeAllFileConstants(e.ListNewConstants);
            }
        }
        #endregion

        #region "Button Command"
        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (Directory.Exists(txtFolder.Text))
                folderDialog.SelectedPath = txtFolder.Text;
            folderDialog.Description = "Choose folder source file project";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                lsvFile.Items.Clear();
                txtFolder.Text = folderDialog.SelectedPath;
                FilterFile(txtFolder.Text, txtFilterFile.Text.ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            //this.ListConstants.Clear();
            for (int i = 0; i < lsvFile.Items.Count; i++)
            {
                string fileName = string.Concat(txtFolder.Text, lsvFile.Items[i].SubItems[1].Text);
                if (!lsvFile.Items[i].Checked)
                    continue;
                if (fileName.ToLower().LastIndexOf(".designer.") != -1)
                    continue;
                if (fileName.LastIndexOf("AssemblyInfo.cs") != -1 || fileName.LastIndexOf("Reference.cs") != -1)
                    continue;
                GetConstantsInFile(fileName);
            }

            //Export to CSV file
            if (this.ListConstants.Count > 0)
            {
                frmListConstants formListConstants = new frmListConstants(this.ListConstants, this.ListConstantsDict);
                formListConstants.MergeAllFileContent += new frmListConstants.OnMergeAllFileContent(formListConstants_MergeAllFileContent);
                formListConstants.ShowDialog();
                this.ListConstants.Clear();
            }
            else
                MessageBox.Show("Can't not find constants hard code of project.");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnViewConstants_Click(object sender, EventArgs e)
        {
            List<ConstantsEnt> listConstants = new List<ConstantsEnt>();
            var fileText = rtbTextFile.Lines;
            int k = -1, begin = -1, end = -1;
            string line = string.Empty, strConstants = string.Empty;
            while (k < fileText.Length - 1)
            {
                k++;
                line = fileText[k].Trim();
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                else if (line.IndexOf(" const ") != -1)
                {
                    continue;
                }
                else if (line.IndexOf("///") == 0)
                {
                    continue;
                }
                else if (line.IndexOf("//") == 0)
                {
                    continue;
                }
                else if (line.IndexOf("using") == 0)
                {
                    continue;
                }
                else if (line.IndexOf("namespace") == 0)
                {
                    continue;
                }
                else
                {
                    begin = -1; end = -1;
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == '"')
                        {
                            if (begin == -1)
                            {
                                begin = j + 1;
                            }
                            else if (begin > end)
                            {
                                end = j;
                                strConstants = line.Substring(begin, end - begin);
                                if (!string.IsNullOrEmpty(strConstants) && !listConstants.Any(c => c.Value.Equals(strConstants)))
                                {
                                    listConstants.Add(new ConstantsEnt(strConstants));
                                    begin = -1;
                                    end = -1;
                                }
                            }
                        }
                    }
                }
            }//End while
            if (listConstants.Count > 0)
                new frmListConstants(listConstants).ShowDialog();
            else
                MessageBox.Show("Can't find constants hard code.");
        }
        #endregion "Button Command"

        #region "Control Handle"
        private void lsvFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvFile.SelectedItems.Count > 0)
            {
                ListViewItem lsvItem = lsvFile.SelectedItems[0];
                rtbTextFile.Text = File.ReadAllText(string.Concat(txtFolder.Text, lsvItem.SubItems[1].Text));
            }
        }
        private void browseFile_ChoosedFile(object sender, CodeGenerator.OnChoosedFileEventArg e)
        {
            this.ListConstants.Clear();
            this.ListConstants.AddRange(GetConstantVar(browseFile.FilePath));
        }
        private void chooseConstantsDict_ChoosedFile(object sender, CodeGenerator.OnChoosedFileEventArg e)
        {
            this.ListConstantsDict.Clear();
            this.ListConstantsDict.AddRange(GetConstantVar(chooseConstantsDict.FilePath));
        }
        #endregion "Control Handle"
        #endregion "Event Function"

        #region "Private Function"
        private void FilterFile(string folderPath, string[] filter)
        {
            DirectoryInfo dicInfo = new DirectoryInfo(folderPath);
            FileInfo[] lstFileFilter = dicInfo.GetFiles("*", SearchOption.AllDirectories).Where(c => filter.Contains(c.Extension.ToLower())).ToArray();

            for (int i = 0; i < lstFileFilter.Length; i++)
            {
                AddWithTextAndSubItems(lsvFile.Items, i.ToString("00"), new string[] { 
                    lstFileFilter[i].FullName.Replace(txtFolder.Text,string.Empty), 
                    lstFileFilter[i].Extension, 
                    lstFileFilter[i].CreationTime.ToString("dd/MM/yyyy") 
                });
            }
        }
        private void AddWithTextAndSubItems(ListView.ListViewItemCollection col, string text, params string[] subItems)
        {
            var item = new ListViewItem(text);
            foreach (var subItem in subItems)
            {
                item.SubItems.Add(subItem);
            }
            item.Checked = true;
            col.Add(item);
        }
        private bool SaveConstantsFile(List<ConstantsEnt> listNewConstants, string fileName)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "VB Code File (.vb)|*.vb|CSharp Code File (.cs)|*.cs";
            saveDialog.FileName = fileName + ".cs";

            //first time, only support build csharp constants code file
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sbWriteConstants = new StringBuilder();
                string tempateFile = File.ReadAllText(@"Template\Constants_Template.txt");
                foreach (var item in listNewConstants)
                {
                    sbWriteConstants.AppendLine(string.Format("\t\tpublic const string {0} = {1}\"{2}\";\r\n", item.Key, item.ACong, item.Value));
                }
                File.WriteAllText(saveDialog.FileName,
                    tempateFile.Replace("{Namesapce}", txtNameSpace.Text)
                        .Replace("{ClassName}", txtClassName.Text)
                        .Replace("{ListConstants}", sbWriteConstants.ToString())
                );
                return true;
            }
            return false;
        }
        private void MergeAllFileConstants(List<ConstantsEnt> listConstants)
        {
            BackupListFiles("BAK/OLD");

            string nameSpace = string.Format("using {0};\r\n", txtNameSpace.Text);
            string fullNamespace = txtClassName.Text;
            foreach (var item in this.ListFiles)
            {
                if (item.Exists)
                {
                    var allConstants = (from c in listConstants
                                        where c.PathFiles.Any(d => d.Path.Equals(item.Path))
                                        select c).ToList();


                    if (chkAppendNamespace.Checked)
                    {
                        if (item.ToText.IndexOf(nameSpace) == -1)
                            item.ToText = item.ToText.Insert(0, nameSpace);
                        //else
                        //    MessageBox.Show("Dupplicate name space");
                    }
                    else
                        fullNamespace = string.Format("{0}.{1}", txtNameSpace.Text, txtClassName.Text);

                    foreach (var itemConst in allConstants)
                    {
                        string oldValue = string.Format("{0}\"{1}\"", itemConst.ACong, itemConst.Value);
                        string newValue = string.Format("{0}.{1}", fullNamespace, itemConst.Key);
                        item.ToText = item.ToText.Replace(oldValue, newValue);
                    }
                    item.Save();
                }
            }

            BackupListFiles("BAK/NEW");
        }
        private bool BackupListFiles(string folder)
        {
            try
            {
                //if (!Directory.Exists(Path.Combine(txtFolder.Text, backupFolder)))
                //    Directory.CreateDirectory(Path.Combine(txtFolder.Text, backupFolder));

                foreach (var item in this.ListFiles)
                {
                    item.CopyTo(txtFolder.Text, folder);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void GetConstantsInFile(string fileName)
        {
            string[] fileText = File.ReadAllLines(fileName);

            //Regex pattern = new Regex(@"(?:(?<key>[a-zA-Z0-9_]+)\.[Text|Value]+[\s]?\=[\s]?\""(?<value>[\s\S]*?)\""|(?<key>[a-zA-Z0-9_]*)[\s]?\=[\s]?\""""(?<value>[\s\S]*?)\"")");
            //Regex pattern = new Regex(@"(?:(?<key>[a-zA-Z0-9_]*(.DisplayMember|.ValueMember))[\s]?\=[\s]?\""(?<value>[\s\S]*?)\""|(?<key>[a-zA-Z0-9_]+)\.[Text|Value]+[\s]?\=[\s]?\""(?<value>[\s\S]*?)\""|(?<key>[a-zA-Z0-9_]*)[\s]?\=[\s]?\""(?<value>[\s\S]*?)\"")", RegexOptions.Compiled);
            Regex pattern = new Regex(@"(?:(?<key>[a-zA-Z0-9_]*(.DisplayMember|.ValueMember))[\s]?\=[\s]?(?<acong>[@]?)\""(?<value>[\s\S]*?)\""|(?<key>[a-zA-Z0-9_]+)\.[Text|Value]+[\s]?\=[\s]?(?<acong>[@]?)\""(?<value>[\s\S]*?)\""|(?<key>[a-zA-Z0-9_]*)[\s]?\=[\s]?(?<acong>[@]?)\""(?<value>[\s\S]*?)\"")", RegexOptions.Compiled);

            int k = -1, begin = -1, end = -1;
            string line = string.Empty, strConstants = string.Empty;
            while (k < fileText.Length - 1)
            {
                k++;
                line = fileText[k].Trim();
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                else if (line.IndexOf(" const string") != -1)
                {
                    continue;
                }
                else if (line.IndexOf("///") == 0)
                {
                    continue;
                }
                else if (line.IndexOf("//") == 0)
                {
                    continue;
                }
                else if (line.IndexOf("using") == 0)
                {
                    continue;
                }
                else if (line.IndexOf("namespace") == 0)
                {
                    continue;
                }
                else if (line.IndexOf("#region") == 0)
                {
                    continue;
                }
                else
                {
                    var allMatch = pattern.Matches(line);
                    if (allMatch.Count > 0)
                    {
                        foreach (Match match in allMatch)
                        {
                            strConstants = match.Groups["value"].Value;
                            if (!string.IsNullOrEmpty(strConstants))
                            {
                                ConstantsEnt existsConstants = this.ListConstants.FirstOrDefault(c => c.Value.Equals(strConstants));
                                if (this.ListFiles.FirstOrDefault(c => c.Path.Equals(fileName)) == null)
                                    this.ListFiles.Add(new PathFile(fileName));
                                if (existsConstants == null)
                                {
                                    existsConstants = new ConstantsEnt(fileName, match.Groups["key"].Value, strConstants, line, match.Groups["ACong"].Value);
                                    this.ListConstants.Add(existsConstants);
                                }
                                else
                                {
                                    PathFile existsPathFile = existsConstants.PathFiles.FirstOrDefault(c => c.Path.Equals(fileName));
                                    if (existsPathFile == null)
                                    {
                                        existsPathFile = new PathFile(fileName);
                                        existsConstants.PathFiles.Add(existsPathFile);
                                    }
                                    else
                                    {
                                        existsPathFile.IncreaseMatch(1);
                                    }
                                }
                            }
                        }
                        //continue;
                    }

                    begin = end = -1;
                    bool Acong = false;
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (begin == -1 && line[j] == '@')
                            Acong = true;
                        else if (line[j] == '"')
                        {
                            if (begin == -1)
                            {
                                begin = j + 1;
                            }
                            else if (begin > end && (Acong || line[j - 1] != '\\'))
                            {
                                end = j;
                                strConstants = line.Substring(begin, end - begin);
                                if (!string.IsNullOrEmpty(strConstants))
                                {
                                    ConstantsEnt existsConstants = this.ListConstants.FirstOrDefault(c => c.Value.Equals(strConstants));
                                    if (this.ListFiles.FirstOrDefault(c => c.Path.Equals(fileName)) == null)
                                        this.ListFiles.Add(new PathFile(fileName));
                                    if (existsConstants == null)
                                    {
                                        existsConstants = new ConstantsEnt(fileName, strConstants, line);
                                        this.ListConstants.Add(existsConstants);
                                    }
                                    else
                                    {
                                        PathFile existsPathFile = existsConstants.PathFiles.FirstOrDefault(c => c.Path.Equals(fileName));
                                        if (existsPathFile == null)
                                        {
                                            existsPathFile = new PathFile(fileName);
                                            //this.ListFiles.Add(existsPathFile);
                                            existsConstants.PathFiles.Add(existsPathFile);
                                        }
                                        else
                                        {
                                            existsPathFile.IncreaseMatch(1);
                                        }
                                    }

                                    begin = end = -1;
                                    Acong = false;
                                }
                            }
                        }
                    } //end for line
                }
            }
        }
        private List<ConstantsEnt> GetConstantVar(string filePath)
        {
            List<ConstantsEnt> tmpList = new List<ConstantsEnt>();
            //var testDDD = Regex.Matches("public const string Test = \"Hello VN\";", "(?:const (?<k>) = (\"(?<v>[^\"]*)\"))");
            var matches = Regex.Matches(File.ReadAllText(filePath), "(?: const (?<t>.*) (?<k>.*) = (?<a>[@]?)(\"(?<v>[^;\"]*)\"))", RegexOptions.Multiline);
            foreach (Match item in matches)
            {
                tmpList.Add(new ConstantsEnt
                {
                    Key = item.Groups["k"].Value,
                    Value = item.Groups["v"].Value,
                    ACong = item.Groups["a"].Value
                    //Type = item.Groups["t"].Value
                });
            }

            return tmpList;
        }
        #endregion "Private Function"
    }
    public class ConstantsEnt
    {
        #region "Private Variable"
        private List<PathFile> m_PathFiles;
        private Dictionary<string, string> listDictionarySpecial = new Dictionary<string, string>
        {
            {"<", "LessThan"},
            {">", "GreatThan"},
            {".", "Dotted"},
            {"AndLessThan", "&lt;"},
            {"AndGreatThan", "&gt;"},
            {"0", "Number_Zero"},
            {"1", "Number_One"},
            {"2", "Number_Two"},
            {"3", "Number_Three"},
            {"4", "Number_Four"},
            {"5", "Number_Five"},
            {"6", "Number_Six"},
            {"7", "Number_Seven"},
            {"8", "Number_Eight"},
            {"9", "Number_Nine"},
            {"10", "Number_Ten"},
            {"11", "Number_Eleven"},
            {"12", "Number_Twelve"},
            {"13", "Number_Thirteen"},
            {"14", "Number_Fourteen"},
            {"in", "Str_In"},
            {"out", "Str_Out"},
            {"for", "Str_For"},
            {"while", "Str_While"},
            {"if", "Str_If"},
            {"switch", "Str_Switch"},
            {"case", "Str_Case"},
            {"typeof", "Str_Typeof"},
            {"true", "Str_true"},
            {"false", "Str_false"},
            {"@", "Str_Acong"}
        };
        #endregion

        #region "Property"
        public string Key { get; set; }
        public string Value { get; set; }
        public string ACong { get; set; }
        public string Line { get; set; }
        public bool IsRemove { get; set; }
        public List<PathFile> PathFiles
        {
            get
            {
                if (m_PathFiles == null)
                    m_PathFiles = new List<PathFile>();
                return m_PathFiles;
            }
            set
            {
                m_PathFiles = value;
            }
        }
        //public string Type { get; set; }
        #endregion

        #region "Initialize"
        public ConstantsEnt()
        {

        }
        public ConstantsEnt(string value)
        {
            this.Key = GetKey(value);
            this.Value = value;
        }
        public ConstantsEnt(string pathFile, string value, string line)
        {
            this.Key = GetKey(value);
            this.Value = value;
            this.Line = line;
            if (this.Line.IndexOf(string.Format("@\"{0}\"", value)) > 0)
                this.ACong = "@";
            PathFile pFile = this.PathFiles.FirstOrDefault(c => c.Path.Equals(pathFile));
            if (pFile == null)
                this.PathFiles.Add(new PathFile(pathFile));
            else
                pFile.MatchCount++;
        }
        public ConstantsEnt(string pathFile, string key, string value, string line, string aCong)
        {
            this.Key = string.IsNullOrEmpty(key) ? GetKey(value) : GetRegexKey(key);
            this.Value = value;
            this.Line = line;
            this.ACong = aCong;
            PathFile pFile = this.PathFiles.FirstOrDefault(c => c.Path.Equals(pathFile));
            if (pFile == null)
                this.PathFiles.Add(new PathFile(pathFile));
            else
                pFile.MatchCount++;
        }
        #endregion

        #region "Public Function"

        #endregion

        #region "Private Function"
        private string GetRegexKey(string strKey)
        {
            return strKey.Replace("txt", string.Empty).Replace("combo", string.Empty).Replace("mcb", string.Empty).Replace(".", string.Empty)
                .Replace("rtb", string.Empty).Replace("cbo", string.Empty).Replace("btn", string.Empty).Replace("cbb", string.Empty);
        }
        private string GetKey(string strValue)
        {
            if (strValue.IndexOf(" ") > 0)
                strValue = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(strValue);
            strValue = GetRegexKey(strValue);
            string key = string.Empty;
            if (listDictionarySpecial.ContainsKey(strValue))
                key = listDictionarySpecial[strValue];
            else
                key = Regex.Replace(strValue, @"\W+", string.Empty);
            //return string.IsNullOrEmpty(key) ? "Empty" : char.IsNumber(key[0]) && strValue.Length > 1 ? "Format_" + key : key;
            return string.IsNullOrEmpty(key) ? "Empty" : strValue.IndexOf("}") > strValue.IndexOf("{") ? "Format_" + key : key;
            //remove special char
            //return strValue.Replace(" ", "_").Replace(@"/", "_").Replace(@"\", " ").Replace("{", string.Empty).Replace("}", string.Empty).Replace("~", string.Empty);
        }
        #endregion
    }

    public class PathFile
    {
        #region "Private Variable"
        private string m_ToText;
        #endregion

        #region "Property"
        public string Path { get; set; }
        public int MatchCount { get; set; }
        public string ToText
        {
            get
            {
                if (m_ToText == null && this.Exists)
                    m_ToText = File.ReadAllText(this.Path);
                return m_ToText;
            }
            set
            {
                m_ToText = value;
            }
        }
        #endregion

        #region "Initialize"
        public PathFile(string pathFile)
        {
            this.Path = pathFile;
            this.MatchCount = 1;
        }
        #endregion

        #region "Public Function"
        public int IncreaseMatch(int inc)
        {
            this.MatchCount += inc;
            return this.MatchCount;
        }
        public bool Exists
        {
            get
            {
                return File.Exists(this.Path);
            }
        }
        public bool IsReadonly
        {
            get
            {
                return new FileInfo(this.Path).IsReadOnly;
            }
        }
        public void CopyTo(string rootFolder, string backupFolder)
        {
            string filePath = this.Path
                .Insert(rootFolder.Length, "\\" + backupFolder);
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath.Replace(System.IO.Path.GetFileName(this.Path), string.Empty));
            if (File.Exists(filePath))
                File.Delete(filePath);

            new FileInfo(this.Path).CopyTo(filePath);
        }
        public bool Save()
        {
            try
            {
                if (!this.Exists)
                    return false;
                File.WriteAllText(this.Path, this.ToText, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Save(string otherPath)
        {
            try
            {
                File.WriteAllText(otherPath, this.ToText, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region "Private Function"

        #endregion
    }
}
