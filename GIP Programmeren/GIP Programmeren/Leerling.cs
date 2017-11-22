using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GIP_Programmeren
{
    class Leerling
    {
        private string _idnummer;
        private int _klasnummer;
        private string _voornaam;
        private string _achternaam;
        private string _password;
        private bool _maandag;
        private bool _dinsdag;
        private bool _donderdag;
        private bool _vrijdag;

        public string strIdnummer
        {
            get { return _idnummer; }
            set { _idnummer = value; }
        }

        public int intKlasnummer
        {
            get { return _klasnummer; }
            set { _klasnummer = value; }
        }

        public string strVoornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string strAchternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        public string strPassword
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool blMaandag
        {
            get { return _maandag; }
            set { _maandag = value; }
        }

        public bool blDinsdag
        {
            get { return _dinsdag; }
            set { _dinsdag = value; }
        }

        public bool bldonderdag
        {
            get { return _donderdag; }
            set { _donderdag = value; }
        }

        public bool blvrijdag
        {
            get { return _vrijdag; }
            set { _vrijdag = value; }
        }






        public void VoegLeerlingToeAanDB()
        {
            string _conn = string.Format("server=84.196.202.210;user id=Denzel;database=arduino;password={0}", strPassword);
            MySqlConnection conn = new MySqlConnection(_conn);
            string _cmd = string.Format("INSERT INTO Leerling ('', '', '', '')",)
            MySqlCommand cmd = 




        }

        public void VerwijderLeerlingUitDB()
        {

        }

        public Leerling(string _strPW)
        {
            strPassword = _strPW;
        }


    }
}
