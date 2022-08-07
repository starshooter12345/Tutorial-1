using System;
using System.ServiceModel;
//namespace ServerProg
//{
//    internal class DataServerInterface
//    {
//        internal object GetNumEntries()
//        {
//            throw new NotImplementedException();
//        }

//        internal void GetValuesForEntry(int index, out uint acct, out uint pin, out int bal, out string fName, out string lName)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

    namespace ServerProg
{
    [ServiceContract]

    public interface DataServerInterface
    {
        [OperationContract]
        int GetNumEntries();
        [OperationContract]

        void GetValuesForEntry(int index, out uint acctNo, out uint pin, out int bal,
            out string fName, out string lName);
    }
}