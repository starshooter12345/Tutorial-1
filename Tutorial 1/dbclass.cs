using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//namespace Tutorial_1
//{
//    public class dbclass
//    {
//        List<dbstorage> dbsto;

//        public dbclass()
//        {
//            dbsto = new List<dbstorage>();



//            dbstorage record1 = new dbstorage();

//            record1.accNo = 1;
//            record1.pin = 123;
//            record1.balance = 344;
//            record1.firstName = "michale";
//            record1.lastName = "saa";

//            dbstorage record2 = new dbstorage();
//            record2.accNo = 2;
//            record2.pin = 111;
//            record2.balance = 788;
//            record2.firstName = "jjjj";
//            record2.lastName = "kkk";

//            dbstorage record3 = new dbstorage();
//            record3.accNo = 4;
//            record3.pin = 444;
//            record3.balance = 114489;
//            record3.firstName = "kasas";
//            record3.lastName = "looore";

//        }

//        public uint GetAcctNoByIndex(int index)
//        {
//            return dbsto[index].accNo;
//        }

//        public uint GetPINByIndex(int index)
//        {
//            return dbsto[index].pin;
//        }

//        public string GetFirstNameByIndex(int index)
//        {
//            return dbsto[index].firstName;
//        }

//        public string GetLastNameByIndex(int index)
//        {
//            return dbsto[index].lastName;
//        }

//        public int GetBalanceByIndex(int index)
//        {
//            return dbsto[index].balance;
//        }

//        public int GetNumRecords()
//        {
//            return dbsto.Count;
//        }




//    }
//}

namespace Tutorial_1
{
    public class dbclass
    {
        public static List<Account> Accounts()
        {
            List<Account> alist = new List<Account>();
            Account account1 = new Account();
            account1.accNo = 1;
            account1.pin = 123;
            account1.balance = 344;
            account1.firstName = "michale";
            account1.lastName = "saa";



            Account account2 = new Account();
            account2.accNo = 1;
            account2.pin = 123;
            account2.balance = 344;
            account2.firstName = "michale";
            account2.lastName = "saa";

            Account account3 = new Account();
            account3.accNo = 1;
            account3.pin = 123;
            account3.balance = 344;
            account3.firstName = "michale";
            account3.lastName = "saa";

            alist.Add(account1);
            alist.Add(account2);
            alist.Add(account3);

            return alist;


        }
        public uint GetAcctNoByIndex(int index)
       {
            return Accounts()[index].accNo;
       }

        public uint GetPINByIndex(int index)
        {
              return Accounts()[index].pin;
        }

        public string GetFirstNameByIndex(int index)
        {
        return Accounts()[index].firstName;
        }

        public string GetLastNameByIndex(int index)
        {
            return Accounts()[index].lastName;
        }

        public int GetBalanceByIndex(int index)
       {
            return Accounts()[index].balance;
       }

        public int GetNumRecords()
       {
            return Accounts().Count;
        }



    }
}

