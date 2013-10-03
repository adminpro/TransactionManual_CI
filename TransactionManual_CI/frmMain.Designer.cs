namespace TransactionManual_CI
{
    partial class frmMain
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
            this.txtConfigFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lsvTransact = new System.Windows.Forms.ListView();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.btnParseDate = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnSetCarrierId = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAramex = new System.Windows.Forms.Button();
            this.btnDHL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config file";
            // 
            // txtConfigFile
            // 
            this.txtConfigFile.Location = new System.Drawing.Point(71, 6);
            this.txtConfigFile.Name = "txtConfigFile";
            this.txtConfigFile.Size = new System.Drawing.Size(261, 20);
            this.txtConfigFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(338, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // lsvTransact
            // 
            this.lsvTransact.Location = new System.Drawing.Point(15, 32);
            this.lsvTransact.Name = "lsvTransact";
            this.lsvTransact.Size = new System.Drawing.Size(349, 271);
            this.lsvTransact.TabIndex = 3;
            this.lsvTransact.UseCompatibleStateImageBehavior = false;
            this.lsvTransact.SelectedIndexChanged += new System.EventHandler(this.lsvTransact_SelectedIndexChanged);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(388, 6);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(178, 20);
            this.txtDateTime.TabIndex = 4;
            this.txtDateTime.Text = "9/25/2013 5:01:00 AM";
            // 
            // btnParseDate
            // 
            this.btnParseDate.Location = new System.Drawing.Point(572, 4);
            this.btnParseDate.Name = "btnParseDate";
            this.btnParseDate.Size = new System.Drawing.Size(75, 23);
            this.btnParseDate.TabIndex = 5;
            this.btnParseDate.Text = "Parse Date";
            this.btnParseDate.UseVisualStyleBackColor = true;
            this.btnParseDate.Click += new System.EventHandler(this.btnParseDate_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(398, 44);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 6;
            this.btnGet.Text = "button1";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnSetCarrierId
            // 
            this.btnSetCarrierId.Location = new System.Drawing.Point(572, 44);
            this.btnSetCarrierId.Name = "btnSetCarrierId";
            this.btnSetCarrierId.Size = new System.Drawing.Size(75, 23);
            this.btnSetCarrierId.TabIndex = 7;
            this.btnSetCarrierId.Text = "Set carrierID";
            this.btnSetCarrierId.UseVisualStyleBackColor = true;
            this.btnSetCarrierId.Click += new System.EventHandler(this.btnSetCarrierId_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "00006675212796024522";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAramex
            // 
            this.btnAramex.Location = new System.Drawing.Point(572, 73);
            this.btnAramex.Name = "btnAramex";
            this.btnAramex.Size = new System.Drawing.Size(75, 23);
            this.btnAramex.TabIndex = 9;
            this.btnAramex.Text = "Aramex";
            this.btnAramex.UseVisualStyleBackColor = true;
            this.btnAramex.Click += new System.EventHandler(this.btnAramex_Click);
            // 
            // btnDHL
            // 
            this.btnDHL.Location = new System.Drawing.Point(572, 102);
            this.btnDHL.Name = "btnDHL";
            this.btnDHL.Size = new System.Drawing.Size(75, 23);
            this.btnDHL.TabIndex = 10;
            this.btnDHL.Text = "DHL";
            this.btnDHL.UseVisualStyleBackColor = true;
            this.btnDHL.Click += new System.EventHandler(this.btnDHL_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Com Max";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDHL);
            this.Controls.Add(this.btnAramex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetCarrierId);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnParseDate);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.lsvTransact);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtConfigFile);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Run transaction manual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfigFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListView lsvTransact;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Button btnParseDate;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnSetCarrierId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAramex;
        private System.Windows.Forms.Button btnDHL;
        private System.Windows.Forms.Button button2;
    }
}

