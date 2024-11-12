```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTools
{
    class ExcelCell
    {
        private String _CIN;
        private String _Filename;
        private String _SheetId;
        private String _SheetName;
        private String _CellReference;

        public String CIN { get { return _CIN; } set { _CIN = value; } }
        public String Filename { get { return _Filename; } set { _Filename = value; } }
        public String SheetId { get { return _SheetId; } set { _SheetId = value; } }
        public String SheetName { get { return _SheetName; } set { _SheetName = value; } }
        public String CellReference { get { return _CellReference; } set { _CellReference = value; } }

        public ExcelCell(
            String CIN,
            String Filename,
            String SheetId,
            String SheetName,
            String CellReference
        )
        {
            this.CIN = CIN;
            this.Filename = Filename;
            this.SheetId = SheetId;
            this.SheetName = SheetName;
            this.CellReference = CellReference;
        }
    }
}
```