using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDAccount
{
    class SavingsAccount
    {
        //Create the fields 
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;

        //create the constructor for the class
        public SavingsAccount() {
            _accountNumber = "";
            _interestRate = 0m;
            _balance = 0m;
        }

        //create the properties for the 
        public string AccountNumber {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public decimal InterestRate {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        public decimal Balance {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
