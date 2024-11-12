```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTools
{
    public class CKComb
    {

        private int _SbsbCK;
        private int _MemeCK;
        private int _BleiCK;

        public int SbsbCK { get { return _SbsbCK; } set { _SbsbCK = value; } }
        public int MemeCK { get { return _MemeCK; } set { _MemeCK = value; } }
        public int BleiCK { get { return _BleiCK; } set { _BleiCK = value; } }

        public CKComb(int SbsbCK, int MemeCK, int BleiCK)
        {
            this._SbsbCK = SbsbCK;
            this._MemeCK = MemeCK;
            this._BleiCK = BleiCK;
        }


    }
}
```