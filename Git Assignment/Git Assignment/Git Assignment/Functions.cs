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
    public partial class Functions : Form
    {
        #region array
        int[] array;
        public Functions()
        {
            InitializeComponent();

            array = new int[Convert.ToInt16(tbxArray.Text)]; 
        }
 
            Random randm = new Random();
            string output = "";
        private void btnCalculate_Click(object sender, EventArgs e)
        {


           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randm.Next(5, 20);
                output += array[i] + "\n";
            }


            MessageBox.Show(output);
        }
        #endregion
        private void btnMin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
