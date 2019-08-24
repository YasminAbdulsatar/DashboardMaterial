using System;

using System.Collections.Generic;

using System.Linq;

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

namespace MaterialDashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Client client = new Client();

            DataContext = new ConsumoViewModel(client);
        }

        private void BTNClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        internal class ConsumoViewModel

        {

            public List<Client> Clients { get; private set; }



            public ConsumoViewModel(Client consumo)

            {

                Clients = new List<Client>();

                Clients.Add(consumo);

            }

        }



        internal class Client

        {

            public string Title { get; private set; }

            public int Percentage { get; private set; }



            public Client()

            {

                Title = "Clients";

                Percentage = CalcularPorcentagem();

            }



            private int CalcularPorcentagem()

            {

                return 47; //Calculo da porcentagem de consumo

            }

        }

    }
}
