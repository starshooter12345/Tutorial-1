using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
//first change
namespace Bankconsoleapp
{
    internal class Program
    {       static void Main(string[] args)
        {
            Console.WriteLine("hey so like welcome to my server");
            ServiceHost host;
            NetTcpBinding tcp = new NetTcpBinding();
            host = new ServiceHost(typeof(DatabaseServer));
            host.AddServiceEndpoint(typeof(BankingInterface), tcp,
            "net.tcp://0.0.0.0:8100/DataService");
            //host.AddServiceEndpoint(typeof(BankingInterface), tcp, "net.tcp://localhost:8100/DataService");

            host.Open();
            Console.WriteLine("System Online");
            Console.ReadLine();

            host.Close();

        }
    }
}
