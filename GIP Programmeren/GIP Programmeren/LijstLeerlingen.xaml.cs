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

namespace GIP_Programmeren
{
    /// <summary>
    /// Interaction logic for LijstLeerlingen.xaml
    /// </summary>
    public partial class LijstLeerlingen : Window
    {
        public LijstLeerlingen()
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
                lstLeerlingenLijst.Items.Add(objLeerling);
            }

            conn.Close();
        }

        private void UpdateDBStatus()
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", "Denzel");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("");
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtZoekNaam_KeyUp(object sender, KeyEventArgs e)
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", "Denzel");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("SELECT * from leerling where LeerlingVNaam like '{0}%' ", txtZoekNaam.Text);
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            lstLeerlingenLijst.Items.Clear();
            while (dr.Read())
            {
                
                Leerling objLeerling = new Leerling(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt16(dr[3]), Convert.ToBoolean(dr[4]), Convert.ToBoolean(dr[5]), Convert.ToBoolean(dr[6]), Convert.ToBoolean(dr[7]));
                lstLeerlingenLijst.Items.Add(objLeerling);
            }

            conn.Close();
        }
    }
}
