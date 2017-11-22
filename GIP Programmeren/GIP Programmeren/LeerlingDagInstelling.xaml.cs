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
using MySql.Data.MySqlClient;
using System.Data;

namespace GIP_Programmeren
{
    /// <summary>
    /// Interaction logic for LeerlingDagInstelling.xaml
    /// </summary>
    public partial class LeerlingDagInstelling : Window
    {
        private string _password;

        public string strPassword
        {
            get { return _password; }
            set { _password = value; }
        }

        public LeerlingDagInstelling()
        {
            InitializeComponent();
            OpvullenListBox();
        }
        

        public void OpvullenListBox()
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", "Denzel");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("SELECT * from leerling");
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Leerling objLeerling = new Leerling(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt16(dr[3]), Convert.ToBoolean(dr[4]), Convert.ToBoolean(dr[5]), Convert.ToBoolean(dr[6]), Convert.ToBoolean(dr[7]));
                lstLeerlingLijst.Items.Add(objLeerling);
            }

            conn.Close();
        }

        private void lstLeerlingLijst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Leerling objLeerling = (Leerling)lstLeerlingLijst.SelectedItem;
            chkMaandag.IsChecked = objLeerling.blMaandag;
            chkDinsdag.IsChecked = objLeerling.blDinsdag;
            chkDonderdag.IsChecked = objLeerling.blDonderdag;
            chkVrijdag.IsChecked = objLeerling.blVrijdag;
        }

        private void UpdateDBDag(CheckBox _chkDag, Leerling _objLeerling)
        {
            if (_chkDag.IsChecked == true)
            {
                
            }
        }

        private void chkMaandag_Click(object sender, RoutedEventArgs e)
        {
            Leerling objLeerling = (Leerling)lstLeerlingLijst.SelectedItem;
            UpdateDBDag(chkMaandag, objLeerling);
        }
    }
}
