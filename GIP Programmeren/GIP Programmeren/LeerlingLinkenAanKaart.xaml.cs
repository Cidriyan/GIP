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

            Klassen KlassenLijst = new Klassen();
        }
        public void KlassenLijstTonen()
        {
            {
                string _conn = string.Format("server=84.196.202.210;user id=Dylan;database=arduino;password={0}", "Devaien");
                MySqlConnection conn = new MySqlConnection(_conn);
                conn.Open();
                string _cmd = string.Format("SELECT KlasNaam from klassen");
                MySqlCommand cmd = new MySqlCommand(_cmd, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Klassen objKlas = new Klassen();
                    LitBox.Items.Add(objKlas);
                }

                conn.Close();
            }
        }
    }
}
