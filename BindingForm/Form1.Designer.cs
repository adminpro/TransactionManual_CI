namespace BindingForm
{
    partial class Form1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.rtbHtml = new System.Windows.Forms.RichTextBox();
            this.btnRichTextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(65, 109);
            this.maskedTextBox1.Mask = "aaa: A";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.Enter += new System.EventHandler(this.maskedTextBox1_Enter);
            // 
            // rtbHtml
            // 
            this.rtbHtml.Location = new System.Drawing.Point(12, 175);
            this.rtbHtml.Name = "rtbHtml";
            this.rtbHtml.Size = new System.Drawing.Size(214, 143);
            this.rtbHtml.TabIndex = 3;
            this.rtbHtml.Text = "";
            // 
            // btnRichTextBox
            // 
            this.btnRichTextBox.Location = new System.Drawing.Point(247, 295);
            this.btnRichTextBox.Name = "btnRichTextBox";
            this.btnRichTextBox.Size = new System.Drawing.Size(90, 23);
            this.btnRichTextBox.TabIndex = 4;
            this.btnRichTextBox.Text = "RichTextBox";
            this.btnRichTextBox.UseVisualStyleBackColor = true;
            this.btnRichTextBox.Click += new System.EventHandler(this.btnRichTextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 330);
            this.Controls.Add(this.btnRichTextBox);
            this.Controls.Add(this.rtbHtml);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RichTextBox rtbHtml;
        private System.Windows.Forms.Button btnRichTextBox;
    }
}

