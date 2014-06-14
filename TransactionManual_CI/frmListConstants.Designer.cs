namespace TransactionManual_CI
{
    partial class frmListConstants
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListConstants = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.chkAppendFile = new System.Windows.Forms.CheckBox();
            this.chkSaveConstantsFile = new System.Windows.Forms.CheckBox();
            this.btnDeleteSelectedRow = new System.Windows.Forms.Button();
            this.lblListInfo = new System.Windows.Forms.Label();
            this.lblClipboard = new System.Windows.Forms.Label();
            this.browseFile = new CodeGenerator.BrowseFile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListConstants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListConstants
            // 
            this.dgvListConstants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListConstants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListConstants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListConstants.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListConstants.Location = new System.Drawing.Point(12, 71);
            this.dgvListConstants.Name = "dgvListConstants";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListConstants.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListConstants.Size = new System.Drawing.Size(587, 419);
            this.dgvListConstants.TabIndex = 0;
            this.dgvListConstants.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvListConstants_CellBeginEdit);
            this.dgvListConstants.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvListConstants_CellValidating);
            this.dgvListConstants.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListConstants_CellEndEdit);
            this.dgvListConstants.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListConstants_KeyDown);
            this.dgvListConstants.SelectionChanged += new System.EventHandler(this.dgvListConstants_SelectionChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 1;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(524, 42);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // chkAppendFile
            // 
            this.chkAppendFile.AutoSize = true;
            this.chkAppendFile.Location = new System.Drawing.Point(199, 47);
            this.chkAppendFile.Name = "chkAppendFile";
            this.chkAppendFile.Size = new System.Drawing.Size(79, 17);
            this.chkAppendFile.TabIndex = 3;
            this.chkAppendFile.Text = "Append file";
            this.chkAppendFile.UseVisualStyleBackColor = true;
            // 
            // chkSaveConstantsFile
            // 
            this.chkSaveConstantsFile.AutoSize = true;
            this.chkSaveConstantsFile.Checked = true;
            this.chkSaveConstantsFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveConstantsFile.Location = new System.Drawing.Point(284, 46);
            this.chkSaveConstantsFile.Name = "chkSaveConstantsFile";
            this.chkSaveConstantsFile.Size = new System.Drawing.Size(116, 17);
            this.chkSaveConstantsFile.TabIndex = 5;
            this.chkSaveConstantsFile.Text = "Save constants file";
            this.chkSaveConstantsFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedRow
            // 
            this.btnDeleteSelectedRow.Location = new System.Drawing.Point(12, 41);
            this.btnDeleteSelectedRow.Name = "btnDeleteSelectedRow";
            this.btnDeleteSelectedRow.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteSelectedRow.TabIndex = 6;
            this.btnDeleteSelectedRow.Text = "Check Deleted Row";
            this.btnDeleteSelectedRow.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedRow.Click += new System.EventHandler(this.btnDeleteSelectedRow_Click);
            // 
            // lblListInfo
            // 
            this.lblListInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblListInfo.AutoSize = true;
            this.lblListInfo.Location = new System.Drawing.Point(12, 503);
            this.lblListInfo.Name = "lblListInfo";
            this.lblListInfo.Size = new System.Drawing.Size(52, 13);
            this.lblListInfo.TabIndex = 7;
            this.lblListInfo.Text = "Page 0/0";
            // 
            // lblClipboard
            // 
            this.lblClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClipboard.AutoSize = true;
            this.lblClipboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClipboard.Location = new System.Drawing.Point(284, 503);
            this.lblClipboard.Name = "lblClipboard";
            this.lblClipboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClipboard.Size = new System.Drawing.Size(53, 15);
            this.lblClipboard.TabIndex = 7;
            this.lblClipboard.Text = "Clipboard";
            // 
            // browseFile
            // 
            this.browseFile.Filter = ".cs";
            this.browseFile.Location = new System.Drawing.Point(195, 7);
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(404, 28);
            this.browseFile.TabIndex = 4;
            this.browseFile.ChoosedFile += new CodeGenerator.BrowseFile.OnChoosedEventHandle(this.browseFile_ChoosedFile);
            // 
            // frmListConstants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 525);
            this.Controls.Add(this.lblClipboard);
            this.Controls.Add(this.lblListInfo);
            this.Controls.Add(this.btnDeleteSelectedRow);
            this.Controls.Add(this.chkSaveConstantsFile);
            this.Controls.Add(this.browseFile);
            this.Controls.Add(this.chkAppendFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvListConstants);
            this.Name = "frmListConstants";
            this.Text = "List Constants Key";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListConstants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListConstants;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.CheckBox chkAppendFile;
        private CodeGenerator.BrowseFile browseFile;
        private System.Windows.Forms.CheckBox chkSaveConstantsFile;
        private System.Windows.Forms.Button btnDeleteSelectedRow;
        private System.Windows.Forms.Label lblListInfo;
        private System.Windows.Forms.Label lblClipboard;
    }
}