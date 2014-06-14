using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace TransactionManual_CI
{
    public partial class frmListConstants : Form
    {
        public class MergeEventArg : EventArgs
        {
            public List<ConstantsEnt> ListNewConstants { get; set; }
            public bool SaveConstantsFile { get; set; }
            public bool AppendConstantsFile { get; set; }
        }
        public event OnMergeAllFileContent MergeAllFileContent;
        public delegate void OnMergeAllFileContent(object sender, MergeEventArg e);

        public frmListConstants()
        {
            InitializeComponent();
        }

        public frmListConstants(List<ConstantsEnt> listConstants)
            : this(listConstants, null)
        {

        }

        public frmListConstants(List<ConstantsEnt> listConstants, List<ConstantsEnt> listConstantsDict)
            : this()
        {
            if (listConstantsDict != null && listConstantsDict.Count > 0)
            {
                listConstants = (from c in listConstants
                                 join a in listConstantsDict on c.Value equals a.Value into grp1
                                 from grp2 in grp1.DefaultIfEmpty()
                                 select MappingConstants(c, grp2)
                                 ).ToList();
                                 //select new ConstantsEnt{
                                 //    Key="",
                                 //    Value="",
                                 //    ACong="",
                                 //    Line="",
                                 //    IsRemove=false,
                                 //    PathFiles=null
                                 //}).ToList();
            }
            lblInfo.Text = "Total constants: " + listConstants.Count;
            dgvListConstants.DataSource = listConstants;
            dgvListConstants.Columns[0].Width = 100;
            dgvListConstants.Columns[1].Width = 400;
            dgvListConstants.Columns[1].Width = 100;

        }
        private ConstantsEnt MappingConstants(ConstantsEnt source, ConstantsEnt destination)
        {
            if (destination == null)
                return source;
            destination.Line = source.Line;
            destination.PathFiles = source.PathFiles;
            destination.IsRemove = source.IsRemove;
            return destination;
        }
        private void browseFile_ChoosedFile(object sender, CodeGenerator.OnChoosedFileEventArg e)
        {
            //var listConstantsDict = GetConstantVar(e.FilePath);
            //foreach (DataGridViewRow dr in dgvListConstants.Rows)
            //{

            //}
        }

        //private List<ConstantsEnt> GetConstantVar(string filePath)
        //{
        //    List<ConstantsEnt> tmpList = new List<ConstantsEnt>();
        //    //var testDDD = Regex.Matches("public const string Test = \"Hello VN\";", "(?:const (?<k>) = (\"(?<v>[^\"]*)\"))");
        //    var matches = Regex.Matches(File.ReadAllText(filePath), "(?: const (?<t>.*) (?<k>.*) = (?<a>[@]?)(\"(?<v>[^;\"]*)\"))", RegexOptions.Multiline);
        //    foreach (Match item in matches)
        //    {
        //        tmpList.Add(new ConstantsEnt
        //        {
        //            Key = item.Groups["k"].Value,
        //            Value = item.Groups["v"].Value,
        //            ACong = item.Groups["a"].Value
        //            //Type = item.Groups["t"].Value
        //        });
        //    }

        //    return tmpList;
        //}

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (IsDupplicateKey())
                return;

            var newListConstants = (from c in dgvListConstants.DataSource as List<ConstantsEnt>
                                    where !c.IsRemove
                                    select c).ToList();

            this.MergeAllFileContent(sender, new MergeEventArg
            {
                ListNewConstants = newListConstants,
                SaveConstantsFile = chkSaveConstantsFile.Checked,
                AppendConstantsFile = chkAppendFile.Checked
            });
            //if (!string.IsNullOrEmpty(browseFile.FilePath))
            //{
            //    if (chkAppendFile.Checked)
            //    {
            //        //Read file and append
            //    }
            //    else
            //    {
            //        //Save new file
            //    }
            //}
        }

        private bool IsDupplicateKey()
        {
            bool result = false;
            List<string> listKeys = new List<string>();
            string key = string.Empty;
            foreach (DataGridViewRow item in dgvListConstants.Rows)
            {
                if (item.IsNewRow || (bool)item.Cells["IsRemove"].Value)
                    continue;
                if (ObjectIsNullEmpty(item.Cells[0]))
                {
                    dgvListConstants.CurrentCell = item.Cells[0];
                    MessageBox.Show("This cell key is null or empty.");
                    result = true;
                    break;
                }
                else if (item.Cells[0].Value.ToString().Length > 50)
                {
                    dgvListConstants.CurrentCell = item.Cells[0];
                    MessageBox.Show("This cell length value over long.");
                    result = true;
                    break;
                }
                //else if (ObjectIsNullEmpty(item.Cells[1]))
                //{
                //    dgvListConstants.CurrentCell = item.Cells[1];
                //    MessageBox.Show("This cell value is null or empty.");
                //    result = true;
                //    break;
                //}

                key = item.Cells[0].Value.ToString();

                if (key.IndexOf(" ") != -1)
                {
                    dgvListConstants.CurrentCell = item.Cells[0];
                    MessageBox.Show("This cell " + item.Index + " key is contain space char. Please, remove space char.");
                    result = true;
                    break;
                }
                else if (listKeys.IndexOf(key) == -1)
                    listKeys.Add(item.Cells[0].Value.ToString());
                else
                {
                    dgvListConstants.CurrentCell = item.Cells[0];
                    MessageBox.Show("This cell " + item.Index + " key is dupplicate.");
                    result = true;
                    break;
                }
            }
            if (result)
                dgvListConstants.BeginEdit(true);
            return result;
        }
        private bool ObjectIsNullEmpty(object obj)
        {
            if (obj == null)
                return true;
            return string.IsNullOrEmpty(obj.ToString());
        }
        private void dgvListConstants_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0 && ObjectIsNullEmpty(e.FormattedValue))
            {
                MessageBox.Show("Please input constants key");
                e.Cancel = true;
            }
            //else if (e.ColumnIndex == 1)
            //    e.Cancel = true; //Not allow modified value of constants
        }

        private void dgvListConstants_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void btnDeleteSelectedRow_Click(object sender, EventArgs e)
        {
            if (dgvListConstants.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListConstants.SelectedRows)
                {
                    bool oldValue = (bool)row.Cells["IsRemove"].Value;
                    row.Cells["IsRemove"].Value = !oldValue;
                    ChangeRowColor(row);
                }
            }
        }

        private static void ChangeRowColor(DataGridViewRow row)
        {
            bool isRemove = (bool)row.Cells["IsRemove"].Value;
            if (isRemove)
            {
                //True, Remove
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgvListConstants_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < 3)
            {
                DataGridViewRow currentRow = dgvListConstants.CurrentRow;
                if (currentRow.DefaultCellStyle.BackColor != Color.WhiteSmoke && currentRow.DefaultCellStyle.BackColor != Color.LightGray)
                {
                    currentRow.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void dgvListConstants_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvListConstants.CurrentRow;
            if (e.ColumnIndex == 4)
            {
                ChangeRowColor(currentRow);
            }
            else if (currentRow.DefaultCellStyle.BackColor == Color.WhiteSmoke)
            {
                currentRow.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgvListConstants_SelectionChanged(object sender, EventArgs e)
        {
            GetDGVInfo();
        }

        private void GetDGVInfo()
        {
            int totalSelected = dgvListConstants.SelectedRows.Count;
            if (dgvListConstants.SelectedRows.Count > 0)
            {
                string selectionInfo = "Rows selected from {0} to {1}";
                string selectedIndexInfo = "Row {0}/{1}";
                int currentRow = dgvListConstants.SelectedRows[0].Index;
                if (totalSelected > 1)
                {
                    lblListInfo.Text = string.Format(selectionInfo, currentRow, currentRow + totalSelected);
                }
                else
                {
                    lblListInfo.Text = string.Format(selectedIndexInfo, currentRow, dgvListConstants.RowCount);
                }
            }
            else if (dgvListConstants.SelectedCells.Count > 0)
            {
                DataGridViewCell currentCell = dgvListConstants.SelectedCells[0];
                //Cell Selected
                string selectedIndexInfo = "RowIndex: {0}, ColumnIndex: {1}, TextLength: {2}";
                lblListInfo.Text = string.Format(selectedIndexInfo, currentCell.RowIndex, currentCell.ColumnIndex, currentCell.Value == null ? 0 : currentCell.Value.ToString().Length);
            }
        }

        private void dgvListConstants_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C && dgvListConstants.SelectedCells.Count == 1)
                lblClipboard.Text = dgvListConstants.SelectedCells[0].Value.ToString();
        }
    }
}
