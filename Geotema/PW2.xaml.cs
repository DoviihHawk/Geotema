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

namespace Geotema
{
    /// <summary>
    /// Interaction logic for PW2.xaml
    /// </summary>
    public partial class PW2 : Window
    {
        public PW2()
        {
            InitializeComponent();
        }

        private void ViseDataPageButton(object sender, RoutedEventArgs e)
        {
            indhold.Content = new ViseDataPage();
        }

        private void TilføjDataPageButton(object sender, RoutedEventArgs e)
        {
            indhold.Content = new TilføjDataPage();
        }
    }
}
