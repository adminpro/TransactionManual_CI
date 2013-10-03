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
            this.brfChooseRDB = new CodeGenerator.BrowseFile();
            this.SuspendLayout();
            // 
            // brfChooseRDB
            // 
            this.brfChooseRDB.Filter = null;
            this.brfChooseRDB.Location = new System.Drawing.Point(12, 3);
            this.brfChooseRDB.Name = "brfChooseRDB";
            this.brfChooseRDB.Size = new System.Drawing.Size(404, 28);
            this.brfChooseRDB.TabIndex = 0;
            this.brfChooseRDB.ChoosedFile += new CodeGenerator.BrowseFile.OnChoosedEventHandle(this.brfChooseRDB_ChoosedFile);
            // 
            // frmDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 372);
            this.Controls.Add(this.brfChooseRDB);
            this.Name = "frmDepot";
            this.Text = "frmDepot";
            this.ResumeLayout(false);

        }

        #endregion

        private CodeGenerator.BrowseFile brfChooseRDB;
    }
}