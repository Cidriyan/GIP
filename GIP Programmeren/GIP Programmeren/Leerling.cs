using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_Programmeren
{
    class Leerling
    {
        private string _idnummer;
        private int _klasnummer;
        private string _voornaam;
        private string _achternaam;

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

        public void VoegLeerlingToeAanDB()
        {

        }

        public void VerwijderLeerlingUitDB()
        {

        }



    }
}
