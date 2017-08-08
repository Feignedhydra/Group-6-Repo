namespace Git_Assignment
{
    partial class Werner
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
            this.rtbxWerner = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxWerner
            // 
            this.rtbxWerner.Location = new System.Drawing.Point(12, 12);
            this.rtbxWerner.Name = "rtbxWerner";
            this.rtbxWerner.Size = new System.Drawing.Size(260, 238);
            this.rtbxWerner.TabIndex = 0;
            this.rtbxWerner.Text = "";
            this.rtbxWerner.TextChanged += new System.EventHandler(this.rtbxWerner_TextChanged);
            // 
            // Werner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtbxWerner);
            this.Name = "Werner";
            this.Text = "Werner";
            this.Load += new System.EventHandler(this.Werner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxWerner;
    }
}