using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerfectNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Function to calculate/find perfect number
        private void FindPerfectNumber(int n)
        {
            //Variable to hold total number of N to find perfect number of it
            int totalN = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i==0)
                {
                    totalN = totalN+i;
                }
            }
            if (totalN == n)
            {
                MessageBox.Show("The Number (N) = " + n + " entered is a perfect number", "Number Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Number (N) = " + n + " entered is NOT a perfect number", "Number NOT Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                // call the method to find the evaluate the number, with error checking
                FindPerfectNumber(int.Parse(txtN.Text.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number before finding", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
