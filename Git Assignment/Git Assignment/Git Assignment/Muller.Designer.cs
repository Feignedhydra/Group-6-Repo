namespace Git_Assignment
{
    partial class Muller
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
            this.rtbxMuller = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxMuller
            // 
            this.rtbxMuller.Location = new System.Drawing.Point(44, 45);
            this.rtbxMuller.Name = "rtbxMuller";
            this.rtbxMuller.Size = new System.Drawing.Size(376, 320);
            this.rtbxMuller.TabIndex = 0;
            this.rtbxMuller.Text = "";
            // 
            // Muller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 454);
            this.Controls.Add(this.rtbxMuller);
            this.Name = "Muller";
            this.Text = "Muller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxMuller;
    }
}