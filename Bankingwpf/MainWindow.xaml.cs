using ServerProg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bankingwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataServerInterface foob;

        public MainWindow()
        {
            InitializeComponent();

            ChannelFactory<ServerProg.DataServerInterface> foobFactory;
            NetTcpBinding tcp = new NetTcpBinding();

            string URL = "net.tcp://localhost:8100/DataService";
            foobFactory = new ChannelFactory<DataServerInterface>(tcp, URL);
            foob = foobFactory.CreateChannel();

            try
            {
                Total_Items.Text = foob.GetNumEntries().ToString();

            }
            catch(Exception e)
            {
                Console.WriteLine(e);

            }
            //Total_Items.Text = foob.GetNumEntries().ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {       

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;
            string fName = "Larr", lName = "tarra";
            int bal = 0;
            uint acct = 11, pin = 13332;
            //On click, Get the index....
            index = Int32.Parse(Index.Text);
            //Then, run our RPC function, using the out mode parameters...
            try {
                foob.GetValuesForEntry(index, out acct, out pin, out bal, out fName, out lName);
            }catch(Exception)
            {
                Console.WriteLine("error");
            }
            //foob.GetValuesForEntry(index, out acct, out pin, out bal, out fName, out lName);
            //And now, set the values in the GUI!
            
            First_Name.Text = fName;
            Last_Name.Text = lName;
            Balance.Text = bal.ToString("C");
            Account_No.Text = acct.ToString();
            Pin.Text = pin.ToString("D4");
        }
    }
}
