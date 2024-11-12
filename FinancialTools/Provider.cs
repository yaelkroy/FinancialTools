using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTools
{
    public class Provider
    {
        private string _Name;
        private string _ID;
        private string _NPI;
        private int _GrgrCK;
        private DateTime _EffectiveDate;
        private DateTime _TerminationDate;


        public String Name { get { return _Name; } set { _Name = value; } }
        public String ID { get { return _ID; } set { _ID = value; } }
        public String NPI { get { return _NPI; } set { _NPI = value; } }
        public int GrgrCK { get { return _GrgrCK; } set { _GrgrCK = value; } }

        public DateTime EffectiveDate { get { return _EffectiveDate; } set { _EffectiveDate = value; } }
        public DateTime TerminationDate { get { return _TerminationDate; } set { _TerminationDate = value; } }

    }
}