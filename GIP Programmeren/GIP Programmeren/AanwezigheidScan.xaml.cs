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
using System.Windows.Shapes;

namespace GIP_Programmeren
{
    /// <summary>
    /// Interaction logic for AanwezigheidScan.xaml
    /// </summary>
    public partial class AanwezigheidScan : Window
    {
        public AanwezigheidScan()
        {
            InitializeComponent();
        }

        public void FotoVerplaatsen()
        {
            imgFoto1.Source = imgFoto2.Source;
            imgFoto2.Source = imgFoto3.Source;
            imgFoto3.Source = imgFoto4.Source;
            imgFoto4.Source = imgFotoMain.Source;

        }

        private void btnFotoVerplaatsen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
