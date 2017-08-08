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
        }

        bool btnClicked = false;
        double globalMean = 0;

        Random randm = new Random();
        string output;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int test = 0;
            test = Convert.ToInt32(tbxArray.Text);
            if (test > 4 && test < 21)
            {
                array = new int[Convert.ToInt16(tbxArray.Text)];
                Array.Clear(array, 0, array.Length);
                output = "";
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = randm.Next(5, 20);
                    output += array[i] + "\n";
                }
                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("Please enter a number between 5 and 20");
            }
        }
        #endregion
        private void btnMin_Click(object sender, EventArgs e)
        {
           MessageBox.Show( Convert.ToString("The min value is " + array.Min()));
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString("The max value is " + array.Max()));
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            Array.Sort(array);
            decimal Median = 0;
            
            int size = array.Length;            
            int mid = size / 2;
            
            Median = (size % 2 != 0) ? (decimal)array[mid] : ((decimal)array[mid] + (decimal)array[mid + 1]) / 2;
         
         Convert.ToInt32(Math.Round(Median));

            MessageBox.Show(Convert.ToString(Math.Round(Median)));
        }

        private void btnMean_Click(object sender, EventArgs e)
        {
            int total = 0;
            int size = array.Length;
            btnClicked = true;

            foreach (int x in array)
            {
               total = total + x;           
            }
            double answer = total / size;
            MessageBox.Show("" + answer);
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            if(btnClicked==true)
            {

            }
            else
            {
                MessageBox.Show("Please click on the mean button first to get your mean, before trying to get the Standard Deviation","Error! - Missing Mean",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
