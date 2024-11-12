```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTools
{
    class Transaction_old
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public String Comment { get; set; }
        public String CommitedBy { get; set; }
        public Int64 Id { get; set; }
        public Subscriber_old Subscriber { get; set; }

        public Transaction_old(Decimal amount, DateTime creationDate, String comment, String commitedBy, Int64 id, Subscriber_old Subscriber)
        {
            this.Amount = amount;
            this.Date = creationDate;
            this.Comment = comment;
            this.CommitedBy = commitedBy;
            this.Id = id;
            this.Subscriber = Subscriber;
        }
    }
}
```