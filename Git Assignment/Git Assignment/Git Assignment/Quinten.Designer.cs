namespace Git_Assignment
{
    partial class Quinten
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
            this.rtbBioQuinten = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbBioQuinten
            // 
            this.rtbBioQuinten.Location = new System.Drawing.Point(12, 12);
            this.rtbBioQuinten.Name = "rtbBioQuinten";
            this.rtbBioQuinten.Size = new System.Drawing.Size(260, 238);
            this.rtbBioQuinten.TabIndex = 0;
            this.rtbBioQuinten.Text = "";
            this.rtbBioQuinten.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Quinten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtbBioQuinten);
            this.Name = "Quinten";
            this.Text = "Quinten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBioQuinten;
    }
}