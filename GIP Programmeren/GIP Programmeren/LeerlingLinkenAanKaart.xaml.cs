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
    /// Interaction logic for LeerlingLinkenAanKaart.xaml
    /// </summary>
    public partial class LeerlingLinkenAanKaart : Window
    {
        public LeerlingLinkenAanKaart()
        {
            InitializeComponent();
            KlassenLijstTonen();
        }
        public void KlassenLijstTonen()
        {
         
            string _conn = string.Format("server=84.196.202.210;user id=Dylan;database=arduino;password={0}", "Devaien");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("SELECT idKlassen, KlasNaam from klassen");
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Klassen objKlas = new Klassen(dr[1].ToString(), Convert.ToInt32(dr[0]));
                LitBox.Items.Add(objKlas);
            }
           
            conn.Close();
            
        }
        
        private void LitBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Klassen objKlas = (Klassen)LitBox.SelectedItem;
            string _conn = string.Format("server=84.196.202.210;user id=Dylan;database=arduino;password={0}", "Devaien");
            MySqlConnection conn = new MySqlConnection(_conn);
            conn.Open();
            string _cmd = string.Format("SELECT idLeerlingen, LeerlingVNaam, LeerlingANaam FROM leerling WHERE klassen_idKlassen = {0} AND WHERE LeerlingKaatID = null", objKlas.intidKlassen);
            MySqlCommand cmd = new MySqlCommand(_cmd, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Leerling objLeerling = new Leerling(dr[1].ToString(), (dr[0].ToString()));
                LitBox.Items.Add(objLeerling);
            }

            conn.Close();
            
        }
    }
}
