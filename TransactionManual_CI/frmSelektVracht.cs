using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DPD.Util;

namespace TransactionManual_CI
{
    public partial class frmSelektVracht : Form
    {
        public frmSelektVracht()
        {
            InitializeComponent();

            SelektVrachtDB selektVrachtDB = new SelektVrachtDB(@"Selekt_Vracht\Data\");
            cboSelekt.DataSource = selektVrachtDB.Lists;
            cboSelekt.DisplayMember = "ConsignorId";
            cboSelekt.ValueMember = "ConsignorId";

            FormValidation(this.Controls.OfType<Control>().ToArray());
        }

        public void FormValidation(Control[] listControlValidate)
        {
            Type[] excludeType = new Type[] { 
                typeof(Form),
                typeof(GroupBox),
                typeof(Panel),
                typeof(SplitContainer),
                typeof(FlowLayoutPanel),
                typeof(TabControl),
                typeof(TableLayoutPanel)
            };
            foreach (Control ctrl in listControlValidate)
            {
                if (!excludeType.Contains(ctrl.GetType()))
                    ctrl.Validating += new CancelEventHandler(this.control_Validating);
                if (ctrl.Controls.Count > 0)
                    FormValidation(ctrl.Controls.OfType<Control>().ToArray());
            }
        }

        private void control_Validating(object sender, CancelEventArgs e)
        {
            string typeName = string.Empty;
            if (sender.GetType().BaseType.Equals(typeof(ButtonBase)) || sender.GetType().BaseType.Equals(typeof(Control)))
                typeName = sender.GetType().FullName;
            else
                typeName = sender.GetType().BaseType.FullName;
            switch (typeName)
            {
                case "System.Windows.Forms.TextBoxBase":
                    TextBoxBase txt = sender as TextBoxBase;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        txt.BackColor = SystemColors.Info;
                        e.Cancel = true;
                    }
                    else
                        txt.BackColor = SystemColors.Window;
                    break;
                case "System.Windows.Forms.RadioButton":
                    break;
                case "System.Windows.Forms.CheckBox":
                    //CheckBox chk = sender as CheckBox;
                    break;
                case "System.Windows.Forms.CheckedListBox":
                    CheckedListBox chkListBox = sender as CheckedListBox;
                    if (chkListBox.CheckedItems.Count == 0)
                    {
                        chkListBox.BackColor = SystemColors.Info;
                        e.Cancel = true;
                    }
                    else
                        chkListBox.BackColor = SystemColors.Window;
                    break;
                case "System.Windows.Forms.ListControl":
                    ListControl lstCtrl = sender as ListControl;
                    if (lstCtrl.SelectedIndex == -1)
                    {
                        lstCtrl.BackColor = SystemColors.Info;
                        e.Cancel = true;
                    }
                    else
                        lstCtrl.BackColor = SystemColors.Window;
                    break;
                case "System.Windows.Forms.UpDownBase":
                    UpDownBase updownBase = sender as UpDownBase;
                    if (string.IsNullOrEmpty(updownBase.Text))
                    {
                        updownBase.BackColor = SystemColors.Info;
                        e.Cancel = true;
                    }
                    else
                        updownBase.BackColor = SystemColors.Window;
                    break;
                case "System.Windows.Forms.ListView":
                    ListView lstView = sender as ListView;
                    if (lstView.SelectedItems.Count == 0)
                    {
                        lstView.BackColor = SystemColors.Info;
                        e.Cancel = true;
                    }
                    else
                        lstView.BackColor = SystemColors.Window;
                    break;
            }
            if (e.Cancel)
            {
                toolTip1.SetToolTip(sender as Control, "Require field!");
            }
        }

        private void checkBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void checkedListBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void listView1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void radioButton1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }
    }

}
