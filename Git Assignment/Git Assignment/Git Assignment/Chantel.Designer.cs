﻿namespace Git_Assignment
{
    partial class Chantel
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
            this.rtbxChantel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxChantel
            // 
            this.rtbxChantel.Location = new System.Drawing.Point(12, 12);
            this.rtbxChantel.Name = "rtbxChantel";
            this.rtbxChantel.Size = new System.Drawing.Size(260, 238);
            this.rtbxChantel.TabIndex = 0;
            this.rtbxChantel.Text = "";
            // 
            // Chantel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtbxChantel);
            this.Name = "Chantel";
            this.Text = "Chantel";
            this.Load += new System.EventHandler(this.Chantel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxChantel;
    }
}