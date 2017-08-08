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
    public partial class Werner : Form
    {
        public Werner()
        {
            InitializeComponent();
            rtbxWerner.Text = "Werner Peter Alberts \nWerner Alberts is a South-Africa citizen. Born in Heidelberg Gauteng in 1996, moved to Brakpan in 2005 then and attended Morewag primary in grade 4 in 2006, moved to Durban Amanzimtoti in 2006 and started grad 5 in 2007, matriculated in 2014 at kuswag school. Since 2015 started studying Information Technology at North-west university pukke.";
        }

        private void rtbxWerner_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
