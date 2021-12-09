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
    //dette er Privilege Window 3 den er til de administratorer som benytter programet den kalder på vise data page, tilføj data page, nulstil data page og opret bruger page
    public partial class PW3 : Window
    {
        public PW3()
        {
            InitializeComponent();
        }

        private void OpretBrugerPageButton(object sender, RoutedEventArgs e)
        {
            indhold.Content = new OpretBrugerPage();
        }

        private void NulstilKodePageButton(object sender, RoutedEventArgs e)
        {
            indhold.Content = new NulstilKodePage();
        }

        private void TilføjDataPageButton(object sender, RoutedEventArgs e)
        {
            indhold.Content = new TilføjDataPage();
        }

        private void ViseDataPageButton(object sender, RoutedEventArgs e)
        {
            indhold.Content = new ViseDataPage();
        }
    }
}
