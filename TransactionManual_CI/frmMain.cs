using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Linq;
using System.IO;
using TrackingEngine.BLL.Repository;
using System.Xml;
using System.Text.RegularExpressions;

namespace TransactionManual_CI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lsvTransact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTransact.SelectedItems != null)
            {

            }
        }

        private void btnParseDate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());
            DateTime dt = DateTime.ParseExact(txtDateTime.Text, @"M/dd/yyyy h:mm:ss tt", null);
            string test = dt.ToString();
            MessageBox.Show(test);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            XDocument xdoc = XDocument.Load("Aramex_201309260601.xml");
            var output = xdoc.Descendants("Name").Select(c => "<File>" + c.Value + "</File>");
            result = string.Join(Environment.NewLine, output.ToArray());
            XDocument xdoc1 = XDocument.Load("Asendia_201309260601.xml");
            var output1 = xdoc1.Descendants("Name").Select(c => "<File>" + c.Value + "</File>");
            result = string.Join(Environment.NewLine, output.ToArray());
        }

        private void btnSetCarrierId_Click(object sender, EventArgs e)
        {
            ShipmentRepository shipRepo = new ShipmentRepository();
            var allShipmentsNull = shipRepo.SelectAll(c => c.CarrierReference == null).ToList();

            string partern = "Asendia_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
            List<string> allCR = new List<string>();
            for (int i = 0; i < listAsendiaFiles.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listAsendiaFiles[i].FullName).Descendants("Item").Select(c => c.Attribute("CarrierReference").Value));
            }
            allCR = allCR.Distinct().ToList();
            int iCount = 0;
            foreach (var shipment in allShipmentsNull)
            {
                iCount++;
                //if (allCR.IndexOf(shipment.CustomerReference) > 0)
                //    shipment.CarrierId = 8;
            }
            //shipRepo.SubmitChanges();
        }

        FileInfo[] GetAllFiles(string partern)
        {
            DirectoryInfo di = new DirectoryInfo("Log");
            return di.GetFiles(partern, SearchOption.AllDirectories);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partern = "Asendia_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
        }

        private void btnAramex_Click(object sender, EventArgs e)
        {
            string partern = "Aramex_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
            List<string> allCR = new List<string>();
            for (int i = 0; i < listAsendiaFiles.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listAsendiaFiles[i].FullName).Descendants("Item").Select(c => c.Attribute("CarrierReferenceNo").Value));
            }
            allCR = allCR.Distinct().ToList();
            MessageBox.Show(allCR.Count.ToString());
        }

        private void btnDHL_Click(object sender, EventArgs e)
        {
            string partern = "DHL_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
            List<string> allCR = new List<string>();
            for (int i = 0; i < listAsendiaFiles.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listAsendiaFiles[i].FullName).Descendants("Item").Select(c => c.Attribute("CarrierReference").Value));
            }
            allCR = allCR.Distinct().ToList();
            MessageBox.Show(allCR.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listFindMax = GetAllFiles(@"D:\Config\Projects\Carrier_New\FTP_DHL\Aramex\20130927", "*.xml");
            List<string> allCR = new List<string>();
            for (int i = 0; i < listFindMax.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listFindMax[i].FullName).Descendants("HAWBUpdate").Select(c => c.Element("Comment1").Value + c.Element("Comment2").Value));
                if (allCR.Any(c => c.Length == 117))
                {
                }
            }


        }

        FileInfo[] GetAllFiles(string folder, string partern)
        {
            DirectoryInfo di = new DirectoryInfo(folder);
            return di.GetFiles(partern, SearchOption.AllDirectories);
        }

        private void btnXmlWriter_Click(object sender, EventArgs e)
        {
            XmlWriterSettings xmlSettings = new XmlWriterSettings();

            using (XmlWriter xmlWriter = XmlWriter.Create(@"INT_ 201310081555.xml"))
            {

                xmlWriter.WriteStartElement("HAWBUpdate");
                xmlWriter.WriteElementString("OrderId", "534133763");
                xmlWriter.WriteElementString("TrackingNumber", "00006675212810281726");
                xmlWriter.WriteElementString("StatusFlag", "SHDL");
                xmlWriter.WriteElementString("StatusDetailMsg", "SHIPMENT DELIVERED");
                xmlWriter.WriteElementString("Location", "Ha Noi - Viet Nam");
                xmlWriter.WriteElementString("DateTime", DateTime.Now.ToString());
                xmlWriter.WriteElementString("Shipper", "00007");
                xmlWriter.WriteElementString("ShipperDesc", "DHL Express");
                xmlWriter.WriteEndElement();
            }
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            string path = @"D:\Config\Projects\Carrier_Newsest\TrackingPortal\TrackingPortal\TaskScheduleTracking\bin\DHL_Asendia_Aramex_30_09_2013";
            string folder = "Log";

            string fullPath = Path.Combine(path, folder);

            int fileCount = Directory.GetFiles(fullPath, "*", SearchOption.AllDirectories).Count();

            string configFileName = "Config.xml";

            XDocument xDoc = XDocument.Load(Path.Combine(path, configFileName));

            var listComplete = xDoc.Root.Elements("Log").Where(c => c.Attribute("IsComplete") != null && c.Attribute("IsComplete").Value.Equals("1"));

            var allFiles = listComplete.SelectMany(c => c.Elements("File"));
            StringBuilder sbOutput = new StringBuilder();
            foreach (var item in allFiles)
            {
                sbOutput.AppendLine(item.Value);
            }
        }

        private void btnMatchStringLine_Click(object sender, EventArgs e)
        {
            var output = MatchStringLine(txtStringLine.Text);
        }

        private Dictionary<string, string> MatchStringLine(string line)
        {
            string strConstants = string.Empty;
            Dictionary<string, string> result = new Dictionary<string, string>();

            int begin = -1, end = -1;
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
                            result.Add(GetKey(strConstants), strConstants);
                            begin = end = -1;
                        }
                    }
                }
            } //end for line
            return result;
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
        private string GetRegexKey(string strKey)
        {
            return strKey.Replace("txt", string.Empty).Replace("combo", string.Empty).Replace("mcb", string.Empty).Replace(".", string.Empty)
                .Replace("rtb", string.Empty).Replace("cbo", string.Empty).Replace("btn", string.Empty).Replace("cbb", string.Empty);
        }

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
    }
}
