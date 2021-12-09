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
    //dette er Privilege Window 1 den er til de standard bruger som benytter programet den kalder på vise data page
    public partial class PW1 : Window
    {
        
        public PW1()
        {
            //GeotemaData.ItemsSource = Altdata();
            
            InitializeComponent();

            indhold.Content = new ViseDataPage();
        }
    }
}
