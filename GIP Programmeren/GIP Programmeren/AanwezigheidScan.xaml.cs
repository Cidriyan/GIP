using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO.Ports;

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
            strPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Data/LeerlingFoto's/", "TestFoto.png");
            Uri imageUri = new Uri(strPath);
            imgFotoMain.Source = new BitmapImage(imageUri);
        }

        public void FotoVerplaatsen()
        {
            if (txtImage.Text == null)
            {
                return;
            }
            strfileName = txtImage.Text;
            strPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Data/LeerlingFoto's/", txtImage.Text);
            txtImage.Text = strPath;
            Uri imageUri = new Uri(strPath);
            
            imgFoto1.Source = imgFoto2.Source;
            imgFoto2.Source = imgFoto3.Source;
            imgFoto3.Source = imgFoto4.Source;
            imgFoto4.Source = imgFotoMain.Source;
            imgFotoMain.Source = new BitmapImage(imageUri);
        }

        private void btnFotoVerplaatsen_Click(object sender, RoutedEventArgs e)
        {
            FotoVerplaatsen();
        }




        public delegate void NoArgDelegate();
        SerialPort Sp;
        string data;
        int intData;
        string portName = "COM3";
        
            //    using (Sp = new SerialPort())
            //    {

            //        Sp.PortName = portName;
            //        Sp.BaudRate = 9600;
            //        Sp.Parity = Parity.None;
            //        Sp.StopBits = StopBits.One;
            //        Sp.DataBits = 8;
            //        Sp.Handshake = Handshake.None;
            //        Sp.DtrEnable = true;
            //        if (Sp.IsOpen == true)
            //        {
            //            Sp.Close();
            //        }
            //        Sp.Open();
            //        Sp.DataReceived +=  new SerialDataReceivedEventHandler(_OnDataRecieved);

            //    }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ThreadPool.SetMinThreads(2, 4);
            Sp = new SerialPort();
            Sp.PortName = portName;
            Sp.BaudRate = 9600;
            Sp.Parity = Parity.None;
            Sp.StopBits = StopBits.One;
            Sp.DataBits = 8;
            Sp.Handshake = Handshake.None;
            Sp.DtrEnable = true;
            Sp.RtsEnable = true;
            if (Sp.IsOpen == true)
            {
                Sp.Close();
            }
            Sp.DataReceived += new SerialDataReceivedEventHandler(_OnDataRecieved);
            Sp.Open();
            
        }


        private void _OnDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            base.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Send, (NoArgDelegate)delegate
                {
                    SerialPort Sp = (SerialPort)sender;
                    intData = Sp.ReadExisting();
                    txtSP.Text = intData.ToString();
                });





        }
        
        
        
    }
}
