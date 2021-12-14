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
    //dette er mig opret bruger page
    public partial class OpretBrugerPage : Page
    {
        public OpretBrugerPage()
        {
            InitializeComponent();
        }
        //dette er min opret bruger knap metode som sender værdierne fra min værdi kasser til min sql database og dermed opretter en ny bruger i databasen
        private void OpretBrugerButton(object sender, RoutedEventArgs e)
        {
            MainWindow.cnn.Open();
            try
            {
                MainWindow.sql = $"insert into Bruger values('{Brugernavn.Text}','{Password.Password}',{Privilege.Text});";

                MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

                MainWindow.adapter.InsertCommand = MainWindow.command;
                MainWindow.adapter.InsertCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Privilege skal være et tal mellem 1-3. standard bruger = 1, super bruger = 2, administrator = 3");
            }
            MainWindow.command.Dispose();
            MainWindow.cnn.Close();
        }
    }
}
