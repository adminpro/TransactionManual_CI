namespace TransactionManual_CI
{
    partial class frmDepot
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
            this.cboRDB = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToBase64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64ToImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTo1bppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertTo1bppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboRDB
            // 
            this.cboRDB.FormattingEnabled = true;
            this.cboRDB.Items.AddRange(new object[] {
            "COUNTRY",
            "DEPOTS",
            "LOCATION_DE",
            "LOCATION_EN",
            "LOCATION_FR",
            "ROUTES",
            "SERVICE",
            "SERVICEINFO_CS",
            "SERVICEINFO_DE",
            "SERVICEINFO_EN",
            "SERVICEINFO_ET",
            "ALLOW",
            "DENY",
            "CUSTOMS"});
            this.cboRDB.Location = new System.Drawing.Point(85, 31);
            this.cboRDB.Name = "cboRDB";
            this.cboRDB.Size = new System.Drawing.Size(206, 21);
            this.cboRDB.TabIndex = 0;
            this.cboRDB.SelectedIndexChanged += new System.EventHandler(this.cboRDB_SelectedIndexChanged);
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(15, 59);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(688, 360);
            this.dgvData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RBD Type";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(297, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToBase64ToolStripMenuItem,
            this.imageToBinaryToolStripMenuItem,
            this.base64ToImageToolStripMenuItem,
            this.imageToHexToolStripMenuItem,
            this.imageTo1bppToolStripMenuItem,
            this.convertTo1bppToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // imageToBase64ToolStripMenuItem
            // 
            this.imageToBase64ToolStripMenuItem.Name = "imageToBase64ToolStripMenuItem";
            this.imageToBase64ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.imageToBase64ToolStripMenuItem.Text = "Image to base64";
            this.imageToBase64ToolStripMenuItem.Click += new System.EventHandler(this.imageToBase64ToolStripMenuItem_Click);
            // 
            // imageToBinaryToolStripMenuItem
            // 
            this.imageToBinaryToolStripMenuItem.Name = "imageToBinaryToolStripMenuItem";
            this.imageToBinaryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.imageToBinaryToolStripMenuItem.Text = "Image to binary";
            this.imageToBinaryToolStripMenuItem.Click += new System.EventHandler(this.imageToBinaryToolStripMenuItem_Click);
            // 
            // base64ToImageToolStripMenuItem
            // 
            this.base64ToImageToolStripMenuItem.Name = "base64ToImageToolStripMenuItem";
            this.base64ToImageToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.base64ToImageToolStripMenuItem.Text = "Base64 to image";
            this.base64ToImageToolStripMenuItem.Click += new System.EventHandler(this.base64ToImageToolStripMenuItem_Click);
            // 
            // imageToHexToolStripMenuItem
            // 
            this.imageToHexToolStripMenuItem.Name = "imageToHexToolStripMenuItem";
            this.imageToHexToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.imageToHexToolStripMenuItem.Text = "Image to hex";
            this.imageToHexToolStripMenuItem.Click += new System.EventHandler(this.imageToHexToolStripMenuItem_Click);
            // 
            // imageTo1bppToolStripMenuItem
            // 
            this.imageTo1bppToolStripMenuItem.Name = "imageTo1bppToolStripMenuItem";
            this.imageTo1bppToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.imageTo1bppToolStripMenuItem.Text = "Image to 1bpp";
            this.imageTo1bppToolStripMenuItem.Click += new System.EventHandler(this.imageTo1bppToolStripMenuItem_Click);
            // 
            // convertTo1bppToolStripMenuItem
            // 
            this.convertTo1bppToolStripMenuItem.Name = "convertTo1bppToolStripMenuItem";
            this.convertTo1bppToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.convertTo1bppToolStripMenuItem.Text = "Convert to 1bpp";
            this.convertTo1bppToolStripMenuItem.Click += new System.EventHandler(this.convertTo1bppToolStripMenuItem_Click);
            // 
            // frmDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 431);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cboRDB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDepot";
            this.Text = "frmDepot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRDB;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToBase64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64ToImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTo1bppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertTo1bppToolStripMenuItem;

    }
}