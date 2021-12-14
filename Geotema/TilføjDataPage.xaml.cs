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
    //dette er min tilføj data page som tilføjer data til sql databasen
    public partial class TilføjDataPage : Page
    {
        public TilføjDataPage()
        {
            InitializeComponent();
        }
        //dette er min tilføj data knap(metode) som tag data fra tekt kasserne og tilføjer dem til databasen
        private void TilføjDataButton(object sender, RoutedEventArgs e)
        {
            MainWindow.cnn.Open();
            try
            {
                MainWindow.sql = $"insert into Land (ID,Land,Verdensdel) values({ID.Text},'{Land.Text}','{Verdensdel.Text}');" +
                    $"insert into Rang (ID,Rang,Fødselsrate) values({ID.Text},'{Rang.Text}','{Fødselsrate.Text}');";

                MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

                MainWindow.adapter.InsertCommand = MainWindow.command;
                MainWindow.adapter.InsertCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("ID, Rang og Fødselsrate skal være et tal");
            }
            MainWindow.command.Dispose();
            MainWindow.cnn.Close();
        }
    }
}
