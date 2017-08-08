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
        //global variables used in more than one function
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
            //Added boolean to test if button was clicked
            btnClicked = true;

            foreach (int x in array)
            {
               total = total + x;           
            }
            double answer = total / size;
            globalMean = answer;
            MessageBox.Show("" + answer);
        }

        //This class subtracts the mean from the value received
        public double subMean(double theValue)
        {
            double result = 0;
            result = Math.Pow((theValue - globalMean), 2);

            //send bacl calculated result
            return result;
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {           
            //Condition to insure that a global mean is set.
            if (btnClicked==true)
            {
                //String containing the array as message
                string standardArrayMessage = "";
                //Creaing the new array for the Standard Deviation set
                double[] standerdArray;
                standerdArray = new double[Convert.ToInt16(tbxArray.Text)];

                //Setting up and initializing variables
                double totalResults = 0;
                double variance = 0;
                double StandardDeviation = 0;

                //Loop to run thru the array and send values to subMean Class
                for (int i = 0; i < standerdArray.Length;i++)
                {
                    double subValue = 0;
                    //send the current array value to the subMean class to get calculated and receive a new value and set it to subValue
                    subValue = subMean(array[i]);
                    //Set the subValue in the same position as in array to the standartArray
                    standerdArray[i] = subValue;
                    //Add all the calculated values to one varaible to use for calculating the variance
                    totalResults += subValue;
                    //Create the standard array message
                    standardArrayMessage += standerdArray[i] + "\n";
                }

                //Calculates the variance
                variance = (totalResults / standerdArray.Length);
                //Calculate the Standard Deviation by Square rooting the Variance
                StandardDeviation = Math.Sqrt(variance);
                //Give output to the user
                MessageBox.Show(standardArrayMessage);
                MessageBox.Show("The Variance is: " + variance.ToString());
                MessageBox.Show("The Standard Deviation is: " + StandardDeviation.ToString());

            }
            else
            {
                //Give output to the user
                MessageBox.Show("Please click on the mean button first to get your mean, before trying to get the Standard Deviation","Error! - Missing Mean",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
