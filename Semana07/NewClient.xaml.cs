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
    /// Lógica de interacción para NewClient.xaml
    /// </summary>
    public partial class NewClient : Window
    {
        public NewClient()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                BClient client = new BClient();
                client.InsertClient(
                    txtName.Text,
                    txtAddress.Text,
                    txtPhone.Text
                   );

                MessageBox.Show("Cliente creado correctamente");

                txtName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";


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
