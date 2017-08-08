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
    public partial class frmGitAssignment : Form
    {
        public frmGitAssignment()
        {
            InitializeComponent();
            
        }

        private void btnWerner_Click(object sender, EventArgs e)
        {
            Werner BioWerner = new Werner();
            BioWerner.Show();
        }

        private void btnFunctions_Click(object sender, EventArgs e)
        {
            Functions func = new Functions();
            func.Show();
        }

        private void btnChantel_Click(object sender, EventArgs e)
        {
            Chantel BioChantel = new Chantel();
            BioChantel.Show();
        }
    }
}
