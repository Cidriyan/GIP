using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GIP_Programmeren
{
    class Klassen
    {
        private string _Klassen;

        public string strKlassen
        {
            get { return _Klassen; }
            set { _Klassen = value; }
        }

        public void VoegKlassenToeAanListBox(ListBox LitBox)
        {
            LitBox.Items.Add(this);
        }
        public Klassen()
        {

        }
        public Klassen(string _Klassen)
        {
            strKlassen = _Klassen;
        }
    }
}
