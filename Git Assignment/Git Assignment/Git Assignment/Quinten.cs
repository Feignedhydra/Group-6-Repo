using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Assignment
{
    public partial class Quinten : Form
    {
        public Quinten()
        {
            InitializeComponent();
            rtbBioQuinten.Text = "Quinten Douglas Crawford\n Quinten Crawford is a South-African citizen and lives in Durban, Amanzimtoti since 1996.Quinten matriculated in 2014 at Kuswag School in Amanizimtoti.Since 2015, Quinten has been a student of the North-West University, where he is studding B.Sc Information Technology.";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
