using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class dbstorage
    {
        public uint accNo;
        public uint pin;
        public int balance;
        public string firstName;
        public string lastName;

        public dbstorage()
        {
            accNo = 0;
            pin = 0;
            balance = 0;
            firstName = "";
            lastName = "";


        }

    }
}
