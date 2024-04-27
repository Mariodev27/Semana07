using Bussiness;
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
using System.Windows.Shapes;

namespace Semana07
{
    /// <summary>
    /// Lógica de interacción para UpdateClient.xaml
    /// </summary>
    public partial class UpdateClient : Window
    {
        public UpdateClient()
        {
            InitializeComponent();
        }

        public void Return(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            this.Close();
            main.Show();

        }

        public void SearchClientId(object sender, RoutedEventArgs e)
        {

            BClient bussiness = new BClient();

            if (txtSearchId.Text == "")
            {

                MessageBox.Show("Porfavor indique el Id", "Advertencia");

            }
            else
            {

                var client = bussiness.GetById(int.Parse(txtSearchId.Text));

                if (client.Count > 0)
                {

                    txtAddress.Text = client[0].Address;
                    txtPhone.Text = client[0].Phone;
                    txtName.Text = client[0].Name;

                }
                else
                {
                    txtName.Text = "";
                    txtSearchId.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    MessageBox.Show("No se ha encontrado a ningun cliente",
                        "Advertencia");

                }

            }

        }

        public void Botton_Update(object sender, RoutedEventArgs e)
        {

            try
            {
                BClient client = new BClient();
                client.UpdateClient(
                    int.Parse(txtSearchId.Text),
                    txtAddress.Text,
                    txtPhone.Text
                   );

                MessageBox.Show("Cliente actualizado correctamente",
                    "Advertencia");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);

            }

        }

    }
}
