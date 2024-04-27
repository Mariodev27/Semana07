using Bussiness;
using Entity;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Semana07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Client> listClients = new List<Client>();

        public MainWindow()
        {
            InitializeComponent();
            LoadClients();
            dataGrid.ItemsSource = listClients;
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {

            BClient bussiness = new BClient();
            var client = bussiness.GetByName(txtSearchByName.Text);

            if (client.Count > 0)
            {
                MessageBox.Show("Información" +
                    "\nNombre: " + client[0].Name +
                    "\nDirección: " + client[0].Address +
                    "\nTélefono: " + client[0].Phone +
                    "\nActivo: " + client[0].Active,
                        "Cliente Encontrado");

            }
            else
            {
                MessageBox.Show("No se ha encontrado a ningun cliente",
                    "Advertencia");
            }

        }

        private void LoadClients()
        {
            BClient clients = new BClient();

            foreach (var client in clients.ListClients())
            {

                listClients.Add(client);

            }
        }

        public void PageNewClient(object sender, RoutedEventArgs e)
        {

            NewClient newclient = new NewClient();
            this.Close();
            newclient.Show();

        }

        public void PageUpdateClient(object sender, RoutedEventArgs e)
        {

            UpdateClient updateclient = new UpdateClient();
            this.Close();
            updateclient.Show();

        }

        public void PageDeleteClient(Object sender, RoutedEventArgs e)
        {

            DeleteClient deleteclient = new DeleteClient();
            this.Close();
            deleteclient.Show();

        }

        private void txtSearchByName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}