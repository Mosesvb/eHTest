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
            //
            FindPerfectNumber(int.Parse(txtN.Text.ToString()));
        }