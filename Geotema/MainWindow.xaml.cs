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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Geotema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //her laver jeg nogle properties og tildeler dem nogle værdier fra en constructor fordi de bliver brugt i mange af metode-rne og class-erne
        static public SqlConnection cnn { get; set; }
        static public SqlCommand command { get; set; }
        static public SqlDataAdapter adapter { get; set; }
        static public string sql { get; set; }

        public MainWindow()
        {
            cnn.Open();
            InitializeComponent();
        }
        //denne metode tag dataen fra tekt kasserne finder deres privilege level og sender dem til det window de skal bruge
        private void PWselect(object sender, RoutedEventArgs e)
        {
            SqlDataReader datareader;

            sql = $"select Privilege from Bruger where Brugernavn='{Brugernavn.Text}' and Passw0rd='{Password.Password}'";

            command = new SqlCommand(sql, cnn);

            datareader = command.ExecuteReader();

            string PL = "";

            while (datareader.Read())
            {
                PL += datareader.GetValue(0);
            }
            datareader.Close();
            cnn.Close();

            switch (PL)
            {
                case "1":
                    PW1 privilegeWindow1 = new PW1();
                    privilegeWindow1.Show();
                    break;
                case "2":
                    PW2 privilegeWindow2 = new PW2();
                    privilegeWindow2.Show();
                    break;
                case "3":
                    PW3 privilegeWindow3 = new PW3();
                    privilegeWindow3.Show();
                    break;
            }
            this.Close();
        }

        private void Brugernavn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
        }
        //her er min constructor som tildeler min properties værdierne som bliver brugt oftest
        static MainWindow()
        {
            string connetionString = @"Data Source=192.168.4.122;Initial Catalog=GeoTema;User ID=sa;Password=Passw0rd;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connetionString);
            cnn = connection;
            adapter = new SqlDataAdapter();
        }

    }
}
