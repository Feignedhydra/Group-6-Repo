namespace Git_Assignment
{
    partial class Functions
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.tbxArray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 42);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Generate array";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.Location = new System.Drawing.Point(93, 108);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(75, 42);
            this.btnStandard.TabIndex = 1;
            this.btnStandard.Text = "Standard Deviation";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(12, 60);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 42);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(12, 108);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 42);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMean
            // 
            this.btnMean.Location = new System.Drawing.Point(93, 60);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(75, 42);
            this.btnMean.TabIndex = 4;
            this.btnMean.Text = "Mean";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(12, 156);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(75, 42);
            this.btnMedian.TabIndex = 4;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // tbxArray
            // 
            this.tbxArray.Location = new System.Drawing.Point(93, 24);
            this.tbxArray.Name = "tbxArray";
            this.tbxArray.Size = new System.Drawing.Size(100, 20);
            this.tbxArray.TabIndex = 5;
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbxArray);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnMean);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Functions";
            this.Text = "Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMean;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.TextBox tbxArray;
    }
}