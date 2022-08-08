using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Tutorial_1;

namespace Bankconsoleapp
{
    [ServiceContract]
    public interface BankingInterface 
    {
        [OperationContract]
        int GetNumEntries();
        [OperationContract]
        void GetValuesForEntry(int index, out uint accNo, out uint pin, out int bal, out string fname, out string lName);

    }

        //service behaviour
        [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
        internal class DatabaseServer : BankingInterface
        {
            public DatabaseServer()
            {

            }
            public int GetNumEntries()
            {
                return dbclass.Accounts().Count;
            }

            public void GetValuesForEntry(int index, out uint acctNo,  out uint pin, out int bal,
            out string fName, out string lName)
            {
            //index = 0;
            //acctNo = 0;
            //pin = 0; 
            //bal = 0;
            //fName = "DDS";
            //lName = "jjjj";

            List<Account> alist = dbclass.Accounts();
            acctNo = alist[index - 1].accNo;
            pin = alist[index - 1].pin;
            bal = alist[index - 1].balance;
            fName = alist[index - 1].firstName;
            lName = alist[index - 1].lastName;
            


        }

           
        }

    }
