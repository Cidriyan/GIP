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

namespace GIP_Programmeren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            LeerlingDagInstelling objLLDagInstelling = new LeerlingDagInstelling();
            objLLDagInstelling.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AanwezigheidScan objAanwezigheidScan = new AanwezigheidScan();

            objAanwezigheidScan.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LijstLeerlingen objLijstLeerlingen = new LijstLeerlingen();

            objLijstLeerlingen.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LeerlingLinkenAanKaart objLeerlingLinkenAanKaart = new LeerlingLinkenAanKaart();
            objLeerlingLinkenAanKaart.Show();
        }
    }
}
