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
    /// Lógica de interacción para DeleteClient.xaml
    /// </summary>
    public partial class DeleteClient : Window
    {
        public DeleteClient()
        {
            InitializeComponent();
        }

        public void SearchClientId(object sender, RoutedEventArgs e)
        {

            BClient bussiness = new BClient();
            var client = bussiness.GetById(int.Parse(txtSearchId.Text));

            if (client.Count > 0)
            {

                txtName.Text = client[0].Name;
                txtAddress.Text = client[0].Address;
                txtPhone.Text = client[0].Phone;

            }
            else
            {

                txtSearchId.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                MessageBox.Show("No se ha encontrado a ningun cliente",
                    "Advertencia");

            }

        }

        public void Button_Delete(object sender, RoutedEventArgs e)
        {

            try
            {

                BClient client = new BClient();

                if (txtSearchId.Text == "")
                {

                    MessageBox.Show("Porfavor Indique el Id", "Advertencia");

                }
                else
                {

                    var result = MessageBox.Show("¿Esta seguro de querer eliminar?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);

                    switch (result)
                    {
                        case MessageBoxResult.Yes:

                            client.DeleteClient(

                                int.Parse(txtSearchId.Text)

                            );

                            MessageBox.Show("Cliente eliminado correctamente",
                                "Advertencia");

                            txtSearchId.Text = "";
                            txtName.Text = "";
                            txtPhone.Text = "";
                            txtAddress.Text = "";

                            break;
                        case MessageBoxResult.No:
                            MessageBox.Show("Operación Cancelada",
                                "Advertencia");
                            break;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);

            }

        }

        public void Return(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            this.Close();
            main.Show();

        }

    }
}
