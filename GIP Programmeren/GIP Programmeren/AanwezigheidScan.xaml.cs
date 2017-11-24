using System;
using System.IO;
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
        string strfileName;
        string strPath;
        public AanwezigheidScan()
        {
            InitializeComponent();
            strfileName = txtImage.Text;
            strPath = System.IO.Path.Combine(Environment.CurrentDirectory, "@LeerlingFoto's/", "TestFoto.jpg");
            Uri imageUri = new Uri("C:/Users/Denzel/Source/Repos/GIP/GIP Programmeren/GIP Programmeren/bin/Debug/Data/LeerlingFoto's/TestFoto.png");
            imgFotoMain.Source = new BitmapImage(imageUri);
        }

        public void FotoVerplaatsen()
        {
            if (txtImage.Text == null)
            {
                return;
            }
            strfileName = txtImage.Text;
            strPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"LeerlingFoto's/", txtImage.Text);
            txtImage.Text = strPath;
            //Uri imageUri = new Uri(strPath);
            //imgFotoMain.Source = new BitmapImage(imageUri);
            //imgFoto1.Source = imgFoto2.Source;
            //imgFoto2.Source = imgFoto3.Source;
            //imgFoto3.Source = imgFoto4.Source;
            //imgFoto4.Source = imgFotoMain.Source;

        }

        private void btnFotoVerplaatsen_Click(object sender, RoutedEventArgs e)
        {
            FotoVerplaatsen();
        }
    }
}
