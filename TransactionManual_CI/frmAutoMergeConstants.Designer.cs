namespace TransactionManual_CI
{
    partial class frmAutoMergeConstants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtFilterFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsvFile = new System.Windows.Forms.ListView();
            this.ORDER = new System.Windows.Forms.ColumnHeader();
            this.FileName = new System.Windows.Forms.ColumnHeader();
            this.Extension = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.rtbTextFile = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAppendNamespace = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewConstants = new System.Windows.Forms.Button();
            this.chooseConstantsDict = new CodeGenerator.BrowseFile();
            this.browseFile = new CodeGenerator.BrowseFile();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose folder:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(80, 26);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(299, 20);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.Text = "D:\\CommenCode\\CarrierIntegration.UI";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(385, 25);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(25, 23);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtFilterFile
            // 
            this.txtFilterFile.Location = new System.Drawing.Point(464, 23);
            this.txtFilterFile.Name = "txtFilterFile";
            this.txtFilterFile.Size = new System.Drawing.Size(93, 20);
            this.txtFilterFile.TabIndex = 3;
            this.txtFilterFile.Text = ".cs;.vb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "filter:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(563, 26);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Info";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(9, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsvFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbTextFile);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 395);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 5;
            // 
            // lsvFile
            // 
            this.lsvFile.CheckBoxes = true;
            this.lsvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ORDER,
            this.FileName,
            this.Extension,
            this.Date});
            this.lsvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFile.FullRowSelect = true;
            this.lsvFile.GridLines = true;
            this.lsvFile.HideSelection = false;
            this.lsvFile.Location = new System.Drawing.Point(0, 0);
            this.lsvFile.MultiSelect = false;
            this.lsvFile.Name = "lsvFile";
            this.lsvFile.Size = new System.Drawing.Size(383, 395);
            this.lsvFile.TabIndex = 0;
            this.lsvFile.UseCompatibleStateImageBehavior = false;
            this.lsvFile.View = System.Windows.Forms.View.Details;
            this.lsvFile.SelectedIndexChanged += new System.EventHandler(this.lsvFile_SelectedIndexChanged);
            // 
            // ORDER
            // 
            this.ORDER.Text = "ORDER";
            this.ORDER.Width = 52;
            // 
            // FileName
            // 
            this.FileName.Text = "FileName";
            this.FileName.Width = 200;
            // 
            // Extension
            // 
            this.Extension.Text = "Extension";
            this.Extension.Width = 58;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 80;
            // 
            // rtbTextFile
            // 
            this.rtbTextFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTextFile.Location = new System.Drawing.Point(0, 0);
            this.rtbTextFile.Name = "rtbTextFile";
            this.rtbTextFile.Size = new System.Drawing.Size(640, 395);
            this.rtbTextFile.TabIndex = 0;
            this.rtbTextFile.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chooseConstantsDict);
            this.groupBox1.Controls.Add(this.browseFile);
            this.groupBox1.Controls.Add(this.chkAppendNamespace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNameSpace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.txtFilterFile);
            this.groupBox1.Controls.Add(this.btnBrowseFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // chkAppendNamespace
            // 
            this.chkAppendNamespace.AutoSize = true;
            this.chkAppendNamespace.Checked = true;
            this.chkAppendNamespace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAppendNamespace.Location = new System.Drawing.Point(682, 25);
            this.chkAppendNamespace.Name = "chkAppendNamespace";
            this.chkAppendNamespace.Size = new System.Drawing.Size(45, 17);
            this.chkAppendNamespace.TabIndex = 13;
            this.chkAppendNamespace.Text = "Add";
            this.chkAppendNamespace.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Class name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(898, 23);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(57, 20);
            this.txtClassName.TabIndex = 11;
            this.txtClassName.Text = "Constants";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Namespace:";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(733, 23);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(92, 20);
            this.txtNameSpace.TabIndex = 9;
            this.txtNameSpace.Text = "CarrierIntegration.Service.Constants";
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(961, 21);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewConstants
            // 
            this.btnViewConstants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewConstants.Enabled = false;
            this.btnViewConstants.Location = new System.Drawing.Point(965, 544);
            this.btnViewConstants.Name = "btnViewConstants";
            this.btnViewConstants.Size = new System.Drawing.Size(89, 23);
            this.btnViewConstants.TabIndex = 10;
            this.btnViewConstants.Text = "View Constants";
            this.btnViewConstants.UseVisualStyleBackColor = true;
            this.btnViewConstants.Click += new System.EventHandler(this.btnViewConstants_Click);
            // 
            // chooseConstantsDict
            // 
            this.chooseConstantsDict.Filter = null;
            this.chooseConstantsDict.LabelText = "Dict file:";
            this.chooseConstantsDict.Location = new System.Drawing.Point(421, 49);
            this.chooseConstantsDict.Name = "chooseConstantsDict";
            this.chooseConstantsDict.Size = new System.Drawing.Size(359, 28);
            this.chooseConstantsDict.TabIndex = 15;
            this.chooseConstantsDict.ChoosedFile += new CodeGenerator.BrowseFile.OnChoosedEventHandle(this.chooseConstantsDict_ChoosedFile);
            // 
            // browseFile
            // 
            this.browseFile.Filter = ".cs";
            this.browseFile.LabelText = "Dict file exists:";
            this.browseFile.Location = new System.Drawing.Point(9, 49);
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(404, 28);
            this.browseFile.TabIndex = 14;
            this.browseFile.ChoosedFile += new CodeGenerator.BrowseFile.OnChoosedEventHandle(this.browseFile_ChoosedFile);
            // 
            // frmAutoMergeConstants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 576);
            this.Controls.Add(this.btnViewConstants);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAutoMergeConstants";
            this.Text = "Search and replace Constants";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtFilterFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvFile;
        private System.Windows.Forms.RichTextBox rtbTextFile;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader ORDER;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button btnViewConstants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.CheckBox chkAppendNamespace;
        private CodeGenerator.BrowseFile browseFile;
        private CodeGenerator.BrowseFile chooseConstantsDict;
    }
}