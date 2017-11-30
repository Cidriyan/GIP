using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_Programmeren
{
    class Aanwezigheid
    {
        DateTime _aankomsttijd;
        String _statusid;

        public DateTime dtAankomstTijd
        {
            get { return _aankomsttijd; }
            set { _aankomsttijd = value; }
        }

        public string strStatusId
        {
            get { return _statusid; }
            set { _statusid = value; }
        }

        public Aanwezigheid(DateTime aankomsttijd, String statusid)
        {
            _aankomsttijd = aankomsttijd;
            _statusid = statusid;
        }

        public Aanwezigheid()
        {

        }
    }
}
