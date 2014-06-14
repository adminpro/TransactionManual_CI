namespace TransactionManual_CI
{
    partial class frmRijndaelManaged
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
            this.txtEncryptKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncryptIV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncryptText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecryptKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecryptIV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDecryptText = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEncryptKey = new System.Windows.Forms.CheckBox();
            this.chkEncryptIV = new System.Windows.Forms.CheckBox();
            this.chkDecryptKey = new System.Windows.Forms.CheckBox();
            this.chkDecryptIV = new System.Windows.Forms.CheckBox();
            this.btnKeyToClipboard = new System.Windows.Forms.Button();
            this.btnIVToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Key";
            // 
            // txtEncryptKey
            // 
            this.txtEncryptKey.Location = new System.Drawing.Point(121, 28);
            this.txtEncryptKey.Name = "txtEncryptKey";
            this.txtEncryptKey.Size = new System.Drawing.Size(224, 20);
            this.txtEncryptKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generate IV";
            // 
            // txtEncryptIV
            // 
            this.txtEncryptIV.Location = new System.Drawing.Point(121, 54);
            this.txtEncryptIV.Name = "txtEncryptIV";
            this.txtEncryptIV.Size = new System.Drawing.Size(224, 20);
            this.txtEncryptIV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text to Encrypt";
            // 
            // txtEncryptText
            // 
            this.txtEncryptText.Location = new System.Drawing.Point(121, 80);
            this.txtEncryptText.Name = "txtEncryptText";
            this.txtEncryptText.Size = new System.Drawing.Size(224, 20);
            this.txtEncryptText.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(270, 106);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Generate Key";
            // 
            // txtDecryptKey
            // 
            this.txtDecryptKey.Location = new System.Drawing.Point(511, 28);
            this.txtDecryptKey.Name = "txtDecryptKey";
            this.txtDecryptKey.Size = new System.Drawing.Size(224, 20);
            this.txtDecryptKey.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Generate IV";
            // 
            // txtDecryptIV
            // 
            this.txtDecryptIV.Location = new System.Drawing.Point(511, 54);
            this.txtDecryptIV.Name = "txtDecryptIV";
            this.txtDecryptIV.Size = new System.Drawing.Size(224, 20);
            this.txtDecryptIV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Text to Decrypt";
            // 
            // txtDecryptText
            // 
            this.txtDecryptText.Location = new System.Drawing.Point(511, 80);
            this.txtDecryptText.Name = "txtDecryptText";
            this.txtDecryptText.Size = new System.Drawing.Size(224, 20);
            this.txtDecryptText.TabIndex = 1;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(660, 106);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "<=>";
            // 
            // chkEncryptKey
            // 
            this.chkEncryptKey.AutoSize = true;
            this.chkEncryptKey.Checked = true;
            this.chkEncryptKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncryptKey.Location = new System.Drawing.Point(351, 31);
            this.chkEncryptKey.Name = "chkEncryptKey";
            this.chkEncryptKey.Size = new System.Drawing.Size(15, 14);
            this.chkEncryptKey.TabIndex = 4;
            this.chkEncryptKey.UseVisualStyleBackColor = true;
            this.chkEncryptKey.CheckedChanged += new System.EventHandler(this.chkEncryptKey_CheckedChanged);
            // 
            // chkEncryptIV
            // 
            this.chkEncryptIV.AutoSize = true;
            this.chkEncryptIV.Checked = true;
            this.chkEncryptIV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncryptIV.Location = new System.Drawing.Point(351, 57);
            this.chkEncryptIV.Name = "chkEncryptIV";
            this.chkEncryptIV.Size = new System.Drawing.Size(15, 14);
            this.chkEncryptIV.TabIndex = 4;
            this.chkEncryptIV.UseVisualStyleBackColor = true;
            this.chkEncryptIV.CheckedChanged += new System.EventHandler(this.chkEncryptIV_CheckedChanged);
            // 
            // chkDecryptKey
            // 
            this.chkDecryptKey.AutoSize = true;
            this.chkDecryptKey.Checked = true;
            this.chkDecryptKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDecryptKey.Location = new System.Drawing.Point(741, 31);
            this.chkDecryptKey.Name = "chkDecryptKey";
            this.chkDecryptKey.Size = new System.Drawing.Size(15, 14);
            this.chkDecryptKey.TabIndex = 4;
            this.chkDecryptKey.UseVisualStyleBackColor = true;
            this.chkDecryptKey.CheckedChanged += new System.EventHandler(this.chkDecryptKey_CheckedChanged);
            // 
            // chkDecryptIV
            // 
            this.chkDecryptIV.AutoSize = true;
            this.chkDecryptIV.Checked = true;
            this.chkDecryptIV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDecryptIV.Location = new System.Drawing.Point(741, 57);
            this.chkDecryptIV.Name = "chkDecryptIV";
            this.chkDecryptIV.Size = new System.Drawing.Size(15, 14);
            this.chkDecryptIV.TabIndex = 4;
            this.chkDecryptIV.UseVisualStyleBackColor = true;
            this.chkDecryptIV.CheckedChanged += new System.EventHandler(this.chkDecryptIV_CheckedChanged);
            // 
            // btnKeyToClipboard
            // 
            this.btnKeyToClipboard.Location = new System.Drawing.Point(30, 106);
            this.btnKeyToClipboard.Name = "btnKeyToClipboard";
            this.btnKeyToClipboard.Size = new System.Drawing.Size(105, 23);
            this.btnKeyToClipboard.TabIndex = 5;
            this.btnKeyToClipboard.Text = "Key to Clipboard";
            this.btnKeyToClipboard.UseVisualStyleBackColor = true;
            this.btnKeyToClipboard.Click += new System.EventHandler(this.btnKeyToClipboard_Click);
            // 
            // btnIVToClipboard
            // 
            this.btnIVToClipboard.Location = new System.Drawing.Point(141, 106);
            this.btnIVToClipboard.Name = "btnIVToClipboard";
            this.btnIVToClipboard.Size = new System.Drawing.Size(105, 23);
            this.btnIVToClipboard.TabIndex = 5;
            this.btnIVToClipboard.Text = "IV to Clipboard";
            this.btnIVToClipboard.UseVisualStyleBackColor = true;
            this.btnIVToClipboard.Click += new System.EventHandler(this.btnIVToClipboard_Click);
            // 
            // frmRijndaelManaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 147);
            this.Controls.Add(this.btnIVToClipboard);
            this.Controls.Add(this.btnKeyToClipboard);
            this.Controls.Add(this.chkDecryptIV);
            this.Controls.Add(this.chkEncryptIV);
            this.Controls.Add(this.chkDecryptKey);
            this.Controls.Add(this.chkEncryptKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDecryptText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEncryptText);
            this.Controls.Add(this.txtDecryptIV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEncryptIV);
            this.Controls.Add(this.txtDecryptKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncryptKey);
            this.Controls.Add(this.label1);
            this.Name = "frmRijndaelManaged";
            this.Text = "frmRijndaelManaged";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryptKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncryptIV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncryptText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDecryptKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecryptIV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDecryptText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkEncryptKey;
        private System.Windows.Forms.CheckBox chkEncryptIV;
        private System.Windows.Forms.CheckBox chkDecryptKey;
        private System.Windows.Forms.CheckBox chkDecryptIV;
        private System.Windows.Forms.Button btnKeyToClipboard;
        private System.Windows.Forms.Button btnIVToClipboard;
    }
}