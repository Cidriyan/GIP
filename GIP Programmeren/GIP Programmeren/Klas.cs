using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_Programmeren
{
    class Klas
    {
        private DateTime _tijdstip;
        private String _richting;
        private int _jaar;
        private List<Leerling> = new List<Leerling>();

        public DateTime dtTijdstip
        {
            get { return _tijdstip; }
            set { _tijdstip = value; }
        }

        public String strRichting
        {
            get { return _richting; }
            set { _richting = value; }
        }

        public int intJaar
        {
            get { return _jaar; }
            set { _jaar = value; }
        }
        


    }
}
