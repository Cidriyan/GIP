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
            
            Uri imageUri = new Uri("C:/Users/Denzel/Source/Repos/GIP/GIP Programmeren/GIP Programmeren/LeerlingFoto's/TestFoto.png");
            imgFotoMain.Source = new BitmapImage(imageUri);
        }

        public void FotoVerplaatsen()
        {

            if (txtImage.Text == null)
            {
                return;
            }
            imgFoto1.Source = imgFoto2.Source;
            imgFoto2.Source = imgFoto3.Source;
            imgFoto3.Source = imgFoto4.Source;
            imgFoto4.Source = imgFotoMain.Source;
            Uri imageUri = new Uri(String.Format("C:/Users/Denzel/Source/Repos/GIP/GIP Programmeren/GIP Programmeren/LeerlingFoto's/{0}", txtImage.Text));
            imgFotoMain.Source = new BitmapImage(imageUri);
            

        }

        private void btnFotoVerplaatsen_Click(object sender, RoutedEventArgs e)
        {
            FotoVerplaatsen();
        }
    }
}
