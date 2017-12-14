using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Get the data 
        private void GetCDData(CDAccount account) {
            //Temporary Variables to hold the interest rate and the balance
            decimal interestRate;
            decimal balance;

            //get the information
            account.AccountNumber = accountNumberTextBox.Text;

            account.MaturityDate = maturityDateTextBox.Text;

            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a CDAccount Object
            CDAccount cdAccount = new CDAccount();

            //get the CDAccount Data 
            GetCDData(cdAccount);

            //Display the account data 
            accountNumberLabel.Text = cdAccount.AccountNumber;
            interestRateLabel.Text = cdAccount.InterestRate.ToString("c");
            balanceLabel.Text = cdAccount.Balance.ToString("c");
            maturityDateLabel.Text = cdAccount.MaturityDate;
        }
    }
}
