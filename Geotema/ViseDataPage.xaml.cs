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
using System.Data;

namespace Geotema
{
    /// <summary>
    /// Interaction logic for ViseDataPage.xaml
    /// </summary>
    public partial class ViseDataPage : Page
    {
        public ViseDataPage()
        {
            InitializeComponent();

            MainWindow.cnn.Open();
            MainWindow.sql = "select Land.ID, Land, Verdensdel, Rang, Fødselsrate from Land full outer join Rang on Land.ID=Rang.ID order by Land.ID";
            MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

            MainWindow.adapter = new SqlDataAdapter(MainWindow.command);
            DataTable data = new DataTable();
            MainWindow.adapter.Fill(data);

            GeotemaData.ItemsSource = data.DefaultView;
            MainWindow.cnn.Close();
        }
    }
}
