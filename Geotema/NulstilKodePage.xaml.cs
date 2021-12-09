using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;

namespace Geotema
{
    //dette er min nulstil kode page some nulstiller en brugers kode
    public partial class NulstilKodePage : Page
    {
        public NulstilKodePage()
        {
            InitializeComponent();
        }
        //denne nulstil kode knap(metode) ta
        private void NulstilKodeButton(object sender, RoutedEventArgs e)
        {
            MainWindow.sql = $"update Bruger set Passw0rd = null where Brugernavn = '{Brugernavn.Text}'";

            MainWindow.cnn.Open();

            MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

            MainWindow.adapter.UpdateCommand = MainWindow.command;
            MainWindow.adapter.UpdateCommand.ExecuteNonQuery();

            MainWindow.command.Dispose();
            MainWindow.cnn.Close();
        }
    }
}
