using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class dbgenerator : dbstorage
    {
        private string GetFirstname()
        {
            return firstName;
        }

        private string GetLastName()
        {
            return lastName;
        }

        private uint GetPIN()
        {
            return pin;
        }

        private uint GetAcctNo()
        {
            return accNo;
        }

        private int GetBalance()
        {
            return balance;
        }

        public void GetNextAccount(out uint pin, out uint acctNo, out string firstName, out string
        lastName, out int balance)
        {
            pin = GetPIN();
            acctNo=GetAcctNo();
            firstName=GetFirstname();
            lastName=GetLastName();
            balance=GetBalance();

            
        }
    }
}
