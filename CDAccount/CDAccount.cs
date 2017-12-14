using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDAccount
{
    class CDAccount : SavingsAccount
    {
        //create the field maturity date
        private string _maturityDate;

        public CDAccount() {
            _maturityDate = "";
        }

        //Maturity Date property
        public string MaturityDate {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
