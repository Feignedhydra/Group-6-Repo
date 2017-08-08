namespace Git_Assignment
{
    partial class Armand
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
            this.rTbxBio = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTbxBio
            // 
            this.rTbxBio.Location = new System.Drawing.Point(12, 12);
            this.rTbxBio.Name = "rTbxBio";
            this.rTbxBio.Size = new System.Drawing.Size(258, 342);
            this.rTbxBio.TabIndex = 0;
            this.rTbxBio.Text = "";
            // 
            // Armand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 366);
            this.Controls.Add(this.rTbxBio);
            this.Name = "Armand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Armand";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTbxBio;
    }
}