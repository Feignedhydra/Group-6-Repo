﻿using System;
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
 
            Random randm = new Random();
            string output;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            array = new int[Convert.ToInt16(tbxArray.Text)];
            Array.Clear(array,0, array.Length);
            output = "";
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
           MessageBox.Show( Convert.ToString("The min value is " + array.Min()));
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString("The max value is " + array.Max()));
        }
    }
}
