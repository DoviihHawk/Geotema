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
    /// <summary>
    /// Interaction logic for TilføjDataPage.xaml
    /// </summary>
    public partial class TilføjDataPage : Page
    {
        public TilføjDataPage()
        {
            InitializeComponent();
        }

        private void TilføjDataButton(object sender, RoutedEventArgs e)
        {
            MainWindow.sql = $"insert into Land (ID,Land,Verdensdel) values({ID.Text},'{Land.Text}','{Verdensdel.Text}');" +
                $"insert into Rang (ID,Rang,Fødselsrate) values({ID.Text},'{Rang.Text}','{Fødselsrate.Text}');";

            MainWindow.cnn.Open();

            MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

            MainWindow.adapter.InsertCommand = MainWindow.command;
            MainWindow.adapter.InsertCommand.ExecuteNonQuery();

            MainWindow.command.Dispose();
            MainWindow.cnn.Close();
        }
    }
}
