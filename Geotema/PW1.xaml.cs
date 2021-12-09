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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Geotema
{
    //public class Data
    //{
    //    public int ID { get; set; }
    //    public char Land { get; set; }
    //    public char Verdensdel { get; set; }
    //    public char Rang { get; set; }
    //    public decimal Fødselsrate { get; set; }
    //}
    public partial class PW1 : Window
    {
        //public List<Data> Altdata()
        //{
        //    MainWindow.cnn.Open();
        //    MainWindow.sql = "select Land.ID, Land, Verdensdel, Rang, Fødselsrate from Land full outer join Rang on Land.ID=Rang.ID order by Land.ID";
        //    MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

        //    SqlDataReader datareader;

        //    datareader = MainWindow.command.ExecuteReader();

        //    List<Data> DataSet = new List<Data>();

        //    while (datareader.Read())
        //    {
        //        DataSet.Add(new Data()
        //        {
        //            ID = datareader.GetInt32(0),
        //            Land = datareader.GetChar(1),
        //            Verdensdel = datareader.GetChar(2),
        //            Rang = datareader.GetChar(3),
        //            Fødselsrate = datareader.GetDecimal(4)
        //        });
        //    }
        //    MainWindow.cnn.Close();
        //    datareader.Close();
        //    return DataSet;
        //}
        //public static void Altdata()
        //{
        //    MainWindow.cnn.Open();
        //    MainWindow.sql = "select Land.ID, Land, Verdensdel, Rang, Fødselsrate from Land full outer join Rang on Land.ID=Rang.ID order by Land.ID";
        //    MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

        //    MainWindow.adapter = new SqlDataAdapter(MainWindow.command);
        //    DataTable data = new DataTable();
        //    MainWindow.adapter.Fill(data);

        //    return data;
        //}
        public PW1()
        {
            //GeotemaData.ItemsSource = Altdata();
            
            InitializeComponent();

            MainWindow.cnn.Open();
            MainWindow.sql = "select Land.ID, Land, Verdensdel, Rang, Fødselsrate from Land full outer join Rang on Land.ID=Rang.ID order by Land.ID";
            MainWindow.command = new SqlCommand(MainWindow.sql, MainWindow.cnn);

            MainWindow.adapter = new SqlDataAdapter(MainWindow.command);
            DataTable data = new DataTable();
            MainWindow.adapter.Fill(data);

            GeotemaData.ItemsSource = data.DefaultView;
        }
    }
}
