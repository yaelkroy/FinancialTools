paidMonthCount { get { return _UnpaidMonthCount; } set { _UnpaidMonthCount = value; } }
        public int LastUnpaidMonthCount { get { return _LastUnpaidMonthCount; } set { _LastUnpaidMonthCount = value; } }
        public DateTime MinDate { get { return _MinDate; } set { _MinDate = value; } }
        public DateTime MaxDate { get { return _MaxDate; } set { _MaxDate = value; } }
        public int SbsbCK { get { return _SbsbCK; } set { _SbsbCK = value; } }
        public int MemeCK { get { return _MemeCK; } set { _MemeCK = value; } }
        public int BleiCK { get { return _BleiCK; } set { _BleiCK = value; } }

        public SubscriberTotals()
        {
            _NetDueAmountDB = 0;
            _NetDueAmount = 0;
            _RemainingAmount = 0;
            _TotalBills = 0;
            _TotalDiscretionaryItems = 0;
            _TotalPayments = 0;
            _TotalRates = 0;
            _TotalDerivedPayments = 0;

            _MonthCount = 0;
            _PaidMonthCount = 0;
            _UnpaidMonthCount = 0;
            _LastUnpaidMonthCount = 0;

            _SbsbCK = 0;
            _MemeCK = 0;
            _BleiCK = 0;

            _MinDate = DateTime.MaxValue;
            _MaxDate = DateTime.MinValue;
        }

        public void UpdateTotals(DataTable dt, int sbsbCK, int memeCK, int bleiCK)
        {
            _SbsbCK = sbsbCK;
            _MemeCK = memeCK;
            _BleiCK = bleiCK;

            _TotalBills = 0;
            _TotalDiscretionaryItems = 0;
            _TotalPayments = 0;
            _TotalRates = 0;
            _TotalDerivedPayments = 0;

            _MonthCount = 0;
            _PaidMonthCount = 0;
            _UnpaidMonthCount = 0;
            _LastUnpaidMonthCount = 0;

            foreach (DataRow dr in dt.Rows)
            {
                DateTime billDate = Convert.ToDateTime(dr["BILL_DT"]);
                Decimal billAmount = Convert.ToDecimal(dr["BILL_AMT"]);
                Decimal discretionaryAmount = Convert.ToDecimal(dr["DISCRETIONARY_AMT"]);
                Decimal paymentAmount = Convert.ToDecimal(dr["PAYMENT_AMT"]);
                Decimal rateAmount = Convert.ToDecimal(dr["RATE_AMT"]);
                Decimal derivedPaymentAmount = Convert.ToDecimal(dr["DERIVED_PAYMENT_AMT"]);
                int paid = Convert.ToInt32(dr["PAID"]);

                _TotalBills += billAmount;
                _TotalDiscretionaryItems += discretionaryAmount;
                _TotalPayments += paymentAmount;
                _TotalRates += rateAmount;
                _TotalDerivedPayments += derivedPaymentAmount;

                if (paid == 1)
                {
                    _PaidMonthCount++;
                }
                else
                {
                    _UnpaidMonthCount++;
                    _LastUnpaidMonthCount = _MonthCount + 1;
                }

                _MonthCount++;

                if (billDate < _MinDate)
                    _MinDate = billDate;

                if (billDate > _MaxDate)
                    _MaxDate = billDate;
            }

            _NetDueAmountDB = _TotalBills - _TotalPayments - _TotalDerivedPayments;
            _NetDueAmount = _NetDueAmountDB + _TotalDiscretionaryItems - _TotalRates;
            _RemainingAmount = _NetDueAmountDB - _TotalPayments - _TotalDerivedPayments;
        }
    }
}; } set { _Bills = value; } }
        public List<Transaction> Payments { get { return _Payments; } set { _Payments = value; } }
        public List<Transaction> Rates { get { return _Rates; } set { _Rates = value; } }
        public List<Transaction> DerivedPayments { get { return _DerivedPayments; } set { _DerivedPayments = value; } }
        public List<Eligibility> Eligibilities { get { return _Eligibilities; } set { _Eligibilities = value; } }
        public List<SubscriberTotals> Totals { get { return _Totals; } set { _Totals = value; } }
        public List<Provider> Providers { get { return _Providers; } set { _Providers = value; } }


        public string FirstName { get { return _FirstName; } set { _FirstName = value; } }
        public string LastName { get { return _LastName; } set { _LastName = value; } }
        public string FullName { get { return _FullName; } set { _FullName = value; } }
        public string Sex { get { return _Sex; } set { _Sex = value; } }
        public string TrustNotice { get { return _TrustNotice; } set { _TrustNotice = value; } }


        public Subscriber(string Id, string FirstName, string LastName, string FullName, string Sex, string TrustNotice)
        {
            this._Id = Id;
            this._FirstName = FirstName;
            this._LastName = LastName;
            this._FullName = FullName;
            this._Sex = Sex;
            this._TrustNotice = TrustNotice;
        }
    };            }
        }

        public void AddPayment(Transaction transaction)
        {
            if (transaction != default)
            {
                if (_Payments == default) _Payments = new List<Transaction>();
                _Payments.Add(transaction);
                this.Totals.First(total => (total.SbsbCK == transaction.SbsbCK) && (total.MemeCK == transaction.MemeCK) && (total.BleiCK == transaction.BleiCK)).TotalPayments += transaction.Amou;
            }
        }

        public void AddDiscretionaryItem(Transaction transaction)
        {
            if (transaction != default)
            {
                if (_DiscretionaryItems == default) _DiscretionaryItems = new List<Transaction>();
                _DiscretionaryItems.Add(transaction);
                this.Totals.First(total => (total.SbsbCK == transaction.SbsbCK) && (total.MemeCK == transaction.MemeCK) && (total.BleiCK == transaction.BleiCK)).TotalDiscretionaryItems += transaction.Amou;
            }
        }

        public void AddEligibility(Eligibility eligibility)
        {
            if (eligibility != default)
            {
                if (_Eligibilities == default) _Eligibilities = new List<Eligibility>();
                _Eligibilities.Add(eligibility);
            }
        }

        public void AddProvider(Provider provider)
        {
            if (provider != default)
            {
                if (_Providers == default) _Providers = new List<Provider>();
                _Providers.Add(provider);
            }
        }

        public void AddRate(Transaction rate)
        {
            if (rate != default)
            {
                if (_Rates == default) _Rates = new List<Transaction>();
                _Rates.Add(rate);
            }
        }

        public void AddDerivedPayment(Transaction derivedPayment)
        {
            if (derivedPayment != default)
            {
                if (_DerivedPayments == default) _DerivedPayments = new List<Transaction>();
                _DerivedPayments.Add(derivedPayment);
            }
        }e)) this.Totals.First(total => (total.SbsbCK == transaction.SbsbCK) && (total.MemeCK == transaction.MemeCK) && (total.BleiCK == transaction.BleiCK)).MaxDate = transaction.EffectiveDate;
            }
        }
    }e;
                _LastName = LastEligibility.LastN;
                _DOB = LastEligibility.DOB;
                _Gender = LastEligibility.Gender;
                _CurrentStatus = LastEligibility.Status;
            }
        }public class ClassName
{
    private string _FirstName;
    private string _LastName;
    private string _FullName;
    private string _Sex;
    private List<Transaction> _Rates;

    public void ProcessEligibility(Eligibility eligibility)
    {
        if (eligibility != default)
        {
            _FirstName = eligibility.FirstName;
            _LastName = eligibility.LastName;
            _FullName = eligibility.FirstName + " " + eligibility.LastName;
            _Sex = eligibility.Sex;
            if ((eligibility.Eligible) && (eligibility.EffectiveDate < this.Totals.First(total => (total.SbsbCK == eligibility.SbsbCK) && (total.MemeCK == eligibility.MemeCK) && (total.BleiCK == eligibility.BleiCK)).MinDate))
                this.Totals.First(total => (total.SbsbCK == eligibility.SbsbCK) && (total.MemeCK == eligibility.MemeCK) && (total.BleiCK == eligibility.BleiCK)).MinDate = eligibility.EffectiveDate;
            if (eligibility.EffectiveDate > this.Totals.First(total => (total.SbsbCK == eligibility.SbsbCK) && (total.MemeCK == eligibility.MemeCK) && (total.BleiCK == eligibility.BleiCK)).MaxDate)
                this.Totals.First(total => (total.SbsbCK == eligibility.SbsbCK) && (total.MemeCK == eligibility.MemeCK) && (total.BleiCK == eligibility.BleiCK)).MaxDate = eligibility.EffectiveDate;
        }
    }

    public void AddRate(Transaction transaction)
    {
        if (transaction != default)
        {
            if (_Rates == default) _Rates = new List<Transaction>();
            _Rates.Add(transaction);
            this.Totals.First(total => (total.SbsbCK == transaction.SbsbCK) && (total.MemeCK == transaction.MemeCK) && (total.BleiCK == transaction.BleiCK)).TotalRates += transaction.Amount;
            if ((transaction.Amount > 0) && (transaction.EffectiveDate < this.Totals.First(total => (total.SbsbCK == transaction.SbsbCK) && (total.MemeCK == transaction.MemeCK) && (total.BleiCK == transaction.BleiCK)).MinDate)) this.Totals.First(total => (total.SbsbCK == transaction.SbsbCK) && (total.MemeCK == transaction.MemeCK) && (total.BleiCK == transaction.BleiCK)).MinDate = transaction.EffectiveDate;
            if ((transaction.Amount > 0) && (transaction.EffectiveDate > this.Total
        }
    }
}                CKComb CKComb = new CKComb(eligibility.SbsbCK, eligibility.MemeCK, eligibility.BleiCK);
                if (!CKCombList.Any(ckcomb => (ckcomb.SbsbCK == CKComb.SbsbCK) && (ckcomb.MemeCK == CKComb.MemeCK) && (ckcomb.BleiCK == CKComb.BleiCK))) 
                    CKCombList.Add(CKComb);
            }


            return CKCombList;
        }foreach (Eligibility eligibility in EligibilitiyList)
            {
                CKComb CKComb = new CKComb(eligibility.SbsbCK, eligibility.MemeCK, eligibility.BleiCK);
                if (!CKCombList.Any(ckcomb => (ckcomb.SbsbCK == CKComb.SbsbCK) && (ckcomb.MemeCK == CKComb.MemeCK) && (ckcomb.BleiCK == CKComb.BleiCK))) CKCombList.Add(CKComb);
            }

            return CKCombList;
        }foreach (Eligibility eligibility in EligibilitiyList)
            {
                CKComb CKComb = new CKComb(eligibility.SbsbCK, eligibility.MemeCK, eligibility.BleiCK);
                if (!CKCombList.Any(ckcomb => (ckcomb.SbsbCK == CKComb.SbsbCK) && (ckcomb.MemeCK == CKComb.MemeCK) && (ckcomb.BleiCK == CKComb.BleiCK))) CKCombList.Add(CKComb);
            }

            return CKCombList;
        }
        public decimal GetPaymentOnDate(DateTime date, CKComb ckComb)
        {
            decimal total = 0;


            if ((_Payments != null) && _Payments.Any(payment => (payment.SbsbCK == ckComb.SbsbCK) && (payment.MemeCK == ckComb.MemeCK) && (payment.BleiCK == ckComb.BleiCK) && (payment.EffectiveDate.Year == date.Year) && (payment.EffectiveDate.Month == date.Month)))
            {
                    List<Transaction> AllPaymentsInMonth = _Payments.FindAll(payment => (payment.SbsbCK == ckComb.SbsbCK)&&(payment.MemeCK == ckComb.MemeCK)&&(payment.BleiCK == ckComb.BleiCK) && (payment.EffectiveDate.Year == date.Year) && (payment.EffectiveDate.Month == date.Month));
                    foreach (Transaction transaction in AllPaymentsInMonth) total += transaction.Amount;
                }

            return total;
        }
        public decimal GetDiscretionaryItemOnDate(DateTime date, CKComb ckComb)
        {
            decimal total = 0;


                if ((_DiscretionaryItems != null)&& _DiscretionaryItems.Any(dbi => (dbi.EffectiveDate.Year == date.Year) && (dbi.EffectiveDate.Month == date.Month) && (dbi.SbsbCK == ckComb.SbsbCK) && (dbi.MemeCK == ckComb.MemeCK) && (dbi.BleiCK == ckComb.BleiCK)))
                {
                    List<Transaction> AllDiscretionaryItemsInMonth = _DiscretionaryItems.FindAll(dbi => (dbi.EffectiveDate.Year == date.Year) && (dbi.EffectiveDate.Month == date.Month) && (dbi.SbsbCK == ckComb.SbsbCK) && (dbi.MemeCK == ckComb.MemeCK) && (dbi.BleiCK == ckComb.BleiCK));
                    foreach (Transaction transaction in AllDiscretionaryItemsInMonth) total += transaction.Amount;
                }

            return total;
        }
            if ((_Eligibilities != null) && _Eligibilities.Any(elig => (((elig.EffectiveDate.Year == date.Year) && (elig.EffectiveDate.Month <= date.Month)) || (elig.EffectiveDate.Year < date.Year)) && (ckComb.SbsbCK == elig.SbsbCK) && (ckComb.MemeCK == elig.MemeCK) && (ckComb.BleiCK == elig.BleiCK) && (elig.Status == "Active"))
            {
                eligibility = true;
            }

            return eligibility;
        }decimal totalRate = 0;
int months = (date.Year - this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.Year) * 12 + date.Month - this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.Month;
if (months > 0)
{
    totalRate = this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).TotalRate / months;
}
return totalRate;.BleiCK)).MinDate.Month;
            for (int month = 0; month <= months ; month++)
            {
                totalRate += GetRateOnDate(new DateTime(this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.AddMonths(month).Year, this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.AddMonths(month).Month, 1), ckComb);
            }
            return totalRate;

        }
        

        public decimal GetTotalPaymentOnDate(DateTime date, CKComb ckComb)
        {
            decimal totalPayment = 0;

            int months = (date.Year - this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.Year) * 12 + date.Month - this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.Month;
            for (int month = 0; month <= months; month++)
            {
                totalPayment += GetPaymentOnDate(new DateTime(this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.AddMonths(month).Year, this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.AddMonths(month).Month, 1), ckComb);
            }
            return totalPayment;

        }
        public decimal GetTotalBillOnDate(DateTime date, CKComb ckComb)
        {
            decimal totalBill = 0;

            int months = (date.Year - this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.Year) * 12 + date.Month - this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (todecimal total = GetTotalOnDate(DateTime.Now, ckComb);
            decimal totalPayment = GetTotalPaymentOnDate(DateTime.Now, ckComb);
            decimal totalRate = GetTotalRateOnDate(DateTime.Now, ckComb);
            decimal totalDiscretionaryItem = GetTotalDiscretionaryItemOnDate(DateTime.Now, ckComb);

            if (total > 0)
            {
                Payment payment = new Payment();
                payment.CkComb = ckComb;
                payment.Date = DateTime.Now;
                payment.Amount = Math.Min(total, totalPayment);
                payment.DiscretionaryItem = Math.Min(total, totalDiscretionaryItem);
                payment.Rate = Math.Min(total, totalRate);
                payment.Save();
            }
        }DateTime.Now, default, default, default, default, default, default, default, default, default, default, default, default);
                    transaction.Save();
                    total -= rate;
                }
                else
                {
                    Transaction transaction = new Transaction(total, date, date, SbsbCKList.First(), MemeCKList.First(), BleiCKList.First(), default, default, DateTime.Now, default, default, default, default, default, default, default, default, default, default, default, default);
                    transaction.Save();
                    total = 0;
                    break;
                }*/
            }
        }// Sanitized code
default, default, default, true);
                total -= rate;
            }*/
            DateTime date = new DateTime(this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.AddMonths(month).Year, this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate.AddMonths(month).Month, 1);
            bool elig = GetEligibilityOnDate(date, ckComb);
            decimal rate = GetRateOnDate(date, ckComb);
            totalPayment += GetDiscretionaryItemOnDate(date, ckComb);
            this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MonthCount++;
            this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).UnpaidMonthCount++;
            this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).LastUnpaidMonthCount++;
            if ((totalPayment >= rate)&&(rate>0))
            {
                Transaction transaction = new Transaction(rate, date, date, ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK, default, default, default, default, default, true);
                AddDerivedPayment(transaction);
                totalPayment-= rate;
                this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK)).LastUnpaidMonthCount = 0;
                this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK)).UnpaidMonthCount--;
            }

        }
        this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK);moveAll(item1 => !GetCKCombByPdpdIDList(PdpdIDList).Any(item2 => ((item1.SbsbCK == item2.SbsbCK) && (item1.MemeCK == item2.MemeCK) && (item1.BleiCK == item2.BleiCK))));
            if (CscsIDList != null)
                if (CscsIDList.Count > 0) CKCombList.RemoveAll(item1 => !GetCKCombByCscsIDList(CscsIDList).Any(item2 => ((item1.SbsbCK == item2.SbsbCK) && (item1.MemeCK == item2.MemeCK) && (item1.BleiCK == item2.BleiCK))));

            DataTable dt = new DataTable();
            dt.Columns.Add("SbsbCK", typeof(int));
            dt.Columns.Add("MemeCK", typeof(int));
            dt.Columns.Add("BleiCK", typeof(int));
            dt.Columns.Add("GrgrCK", typeof(int));
            dt.Columns.Add("CspiID", typeof(string));
            dt.Columns.Add("PdpdID", typeof(string));
            dt.Columns.Add("CscsID", typeof(string));
            dt.Columns.Add("Dck", typeof(int));
            dt.Columns.Add("DckName", typeof(string));
            dt.Columns.Add("Payment", typeof(decimal));
            dt.Columns.Add("DerivedPayment", typeof(decimal));
            dt.Columns.Add("TotalPayment", typeof(decimal));
            dt.Columns.Add("PaidMonthCount", typeof(int));
            dt.Columns.Add("UnpaidMonthCount", typeof(int));
            dt.Columns.Add("RemainingAmount", typeof(decimal));
            dt.Columns.Add("TotalRemainingAmount", typeof(decimal));
            dt.Columns.Add("TotalPaidMonthCount", typeof(int));
            dt.Columns.Add("TotalUnpaidMonthCount", typeof(int));
            dt.Columns.Add("TotalPayment", typeof(decimal));
            dt.Columns.Add("TotalDerivedPayment", typeof(decimal));

            foreach (CKComb ckComb in CKCombList)
            {
                DataRow row = dt.NewRow();
                row["SbsbCK"] = ckComb.SbsbCK;
                row["MemeCK"] = ckComb.MemeCK;
                row["BleiCK"] = ckComb.BleiCK;
                row["GrgrCK"] = GetGrgrCK(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["CspiID"] = GetCspiID(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["PdpdID"] = GetPdpdID(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["CscsID"] = GetCscsID(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["Dck"] = GetDck(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["DckName"] = GetDckName(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["Payment"] = GetPayment(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK, dateIn);
                row["DerivedPayment"] = GetDerivedPayment(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK, dateIn);
                row["TotalPayment"] = GetTotalPayment(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK, dateIn);
                row["PaidMonthCount"] = GetPaidMonthCount(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["UnpaidMonthCount"] = GetUnpaidMonthCount(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["RemainingAmount"] = GetRemainingAmount(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["TotalRemainingAmount"] = GetTotalRemainingAmount(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK, dateIn);
                row["TotalPaidMonthCount"] = GetTotalPaidMonthCount(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["TotalUnpaidMonthCount"] = GetTotalUnpaidMonthCount(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK);
                row["TotalPayment"] = GetTotalPayment(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK, dateIn);
                row["TotalDerivedPayment"] = GetTotalDerivedPayment(ckComb.SbsbCK, ckComb.MemeCK, ckComb.BleiCK, dateIn);
                dt.Rows.Add(row);
            }
            return dt;
        }ons.Columns.Add("Spenddown", typeof(string));
            }
            else
            {
                tblSpenddownCalculations.Columns.Add("Date", typeof(DateTime));
                tblSpenddownCalculations.Columns.Add("ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("Medicaid ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("First Name", typeof(string));
                tblSpenddownCalculations.Columns.Add("Last Name", typeof(string));
                tblSpenddownCalculations.Columns.Add("Full Name", typeof(string));

                tblSpenddownCalculations.Columns.Add("Rate", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Billed", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Adjmnts", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Paid", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Expenses", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Paid Months", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Accumulated Balance", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Eligibility", typeof(string));
                tblSpenddownCalculations.Columns.Add("Spenddown", typeof(string));
            }

            return tblSpenddownCalculations;SpenddownCalculations.Columns.Add("Date", typeof(DateTime));
                tblSpenddownCalculations.Columns.Add("ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("First Name", typeof(string));
                tblSpenddownCalculations.Columns.Add("Last Name", typeof(string));
                tblSpenddownCalculations.Columns.Add("Medicaid ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("Family Link", typeof(string));
                tblSpenddownCalculations.Columns.Add("Calculated amount due", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("DB amount due", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("# of unpaid months from the latest payment", typeof(int));
                tblSpenddownCalculations.Columns.Add("# of paid months", typeof(int));

                tblSpenddownCalculations.Columns.Add("# of unpaid months", typeof(int));
                tblSpenddownCalculations.Columns.Add("CSPI ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("GRGR CK", typeof(string));
                tblSpenddownCalculations.Columns.Add("CSCS ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("Trust Notice", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider Name", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider Effective Date", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider Termination Date", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider GRGR CK", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider NPI", typeof(string));SpenddownCalculations.Columns.Add("# of total months", typeof(int));

                tblSpenddownCalculations.Columns.Add("Total billed", typeof(decimal));

                tblSpenddownCalculations.Columns.Add("Total paid", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("Total expenses", typeof(decimal));
                tblSpenddownCalculations.Columns.Add("CSPI ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("GRGR CK", typeof(string));
                tblSpenddownCalculations.Columns.Add("CSCS ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("Trust Notice", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider Name", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider Effective Date", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider Termination Date", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider GRGR CK", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider ID", typeof(string));
                tblSpenddownCalculations.Columns.Add("Provider NPI", typeof(string));

            }

            foreach (CKComb ckComb in CKCombList)
            {
                if ((_Eligibilities != null) &&(_Rates != null) &&_Eligibilities.Any(elig => elig.Eligible && (elig.SbsbCK == ckComb.SbsbCK) && (elig.MemeCK == ckComb.MemeCK) && (elig.BleiCK == ckComb.BleiCK)) &&
                    _Rates.Any(rate => rate.Amount > 0 && (rate.SbsbCK == ckComb.SbsbCK) && (rate.MemeCK == ckComb.MemeCK) && (rate.BleiCK == ckComb.BleiCK)))
                {
                    DateTime MinDate = this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MinDate;
                    DateTime MaxDate = date;
                    int months = ((MaxDate.Year - MinDate.Year) * 12) + MaxD
                                eligibility.FirstName + " " + eligibility.LastName,
                                    provider.ProviderName,
                                    provider.ProviderId,
                                    provider.ProviderType,
                                    provider.ProviderTypeDesc,
                                    GetProviderRateOnDate(CurrentDate, provider),
                                    GetProviderBillOnDate(CurrentDate, provider),
                                    GetProviderRateOnDate(CurrentDate, provider) - GetProviderBillOnDate(CurrentDate, provider),
                                    GetProviderPaymentOnDate(CurrentDate, provider),
                                    GetProviderDiscretionaryItemOnDate(CurrentDate, provider),
                                    GetProviderDerivedPaymentOnDate(CurrentDate, provider),
                                    ckComb.BleiCK,
                                    ckComb.SbsbCK,
                                    ckComb.MemeCK,
                                    CurrentDate.Month,
                                    CurrentDate.Year,
                                    ckComb.CkId,
                                    _UserId,
                                    _UserName
                                );

                            BleiCKList.Add(ckComb.BleiCK);
                            SbsbCKList.Add(ckComb.SbsbCK);
                            MemeCKList.Add(ckComb.MemeCK);
                        }
                    } else if ((int)TableType == 1)
                    {
                        for (int month = 0; month <= months; month++)
                        {
                            DateTime CurrentDate = new DateTime(MinDate.AddMonths(month).Year, MinDate.AddMonths(month).Month, 1);
                            decimal rate = GetRateOnDate(CurrentDate, ckComb);
                            decimal bill = GetBillOnDate(CurrentDate, ckComb);
                            Provider provider = GetProviderOnDate(CurrentDate);
                            decimal adjustment = bill - rate;
                            tblSpenddownCalculations.Rows.Add(
                                    CurrentDate,
                                    _Id,
                                    eligibility.MedicaidId,
                                    eligibility.FirstName,
                                    eligibility.LastName,
                                    eligibility.FirstName + " " + eligibility.LastName,
                                    rate,
                                    bill,
                                    bill - rate,
                                    GetPaymentOnDate(CurrentDate, ckComb),
                                    GetDiscretionaryItemOnDate(CurrentDate, ckComb),
                                    GetDerivedPaymentOnDate(CurrentDate),
                                    eligibility.FirstName + " " + eligibility.LastName,
                                    provider.ProviderName,
                                    provider.ProviderId,
                                    provider.ProviderType,
                                    provider.ProviderTypeDesc,
                                    GetProviderRateOnDate(CurrentDate, provider),
                                    GetProviderBillOnDate(CurrentDate, provider),
                                    GetProviderRateOnDate(CurrentDate, provider) - GetProviderBillOnDate(CurrentDate, provider),
                                    GetProviderPaymentOnDate(CurrentDate, provider),
                                    GetProviderDiscretionaryItemOnDate(CurrentDate, provider),
                                    GetProviderDerivedPaymentOnDate(CurrentDate, provider),
                                    ckComb.BleiCK,
                                    ckComb.SbsbCK,
                                    ckComb.MemeCK,
                                    CurrentDate.Month,
                                    CurrentDate.Year,
                                    ckComb.CkId,
                                    _UserId,
                                    _UserName
                                );

                            BleiCKList.Add(ckComb.BleiCK);
                            SbsbCKList.Add(ckComb.SbsbCK);
                            MemeCKList.Add(ckComb.MemeCK);
                        }
                    }GetTotalOnDate(CurrentDate, ckComb),
                                    (GetEligibilityOnDate(CurrentDate, ckComb) ? "YES" : "NO"),
                                    eligibility.FamilyLink,
                                    eligibility.CspiID,
                                    eligibility.GrgrCK,
                                    eligibility.CscsID,
                                    _TrustNotice,
                                    ((provider.Name!=null) ? provider.Name : ""),
                                    ((provider.Name != null) ? provider.EffectiveDate.ToString() : ""),
                                    ((provider.Name != null) ? provider.TerminationDate.ToString() : ""),
                                    ((provider.Name != null) ? provider.GrgrCK.ToString() : ""),
                                    ((provider.Name != null) ? provider.ID : ""),
                                    ((provider.Name != null) ? provider.NPI : "")
                                );

                        }

                        if (true)
                        {
                            decimal totalRate = GetTotalRateOnDate(MaxDate, ckComb),
                                totalBilled = GetTotalBillOnDate(MaxDate, ckComb),

                                totalPaid = GetTotalPaymentOnDate(MaxDate, ckComb),
                                totalExpenses = GetTotalDiscretionaryItemOnDate(MaxDate, ckComb),
                            //totalFullyPaidMonths = (Decimal)tblSpenddownCalculations.Compute("SUM([Paid Months])", string.Empty);
                            totalFullyPaidMonths = 0;

                            tblSpenddownCalculations.Rows.Add(null,
                                                            string.Empty,
                                                            string.Empty,
                                                            string.Empty,
                                );"Total:",
string.Empty,

totalRate,
totalBilled,
totalBilled - totalRate,
totalPaid,
totalExpenses,
totalFullyPaidMonths);

tblSpenddownCalculations.Rows.Add(null,
        string.Empty,
        string.Empty,
        string.Empty,
        "Real rate balance: ",
        "[Rate]-([Paid]+[Expenses])",

        totalRate - totalPaid - totalExpenses);
tblSpenddownCalculations.Rows.Add(null,
    string.Empty,
    string.Empty,
    string.Empty,
    "Billed rate balance:",
    "[Billed]-([Paid]+[Expenses])",

    totalBilled - totalPaid - totalExpenses);
tblSpenddownCalculations.Rows.Add(null,
        string.Empty,
        string.Empty,
        string.Empty,
        "Database balance: ",
        string.Empty,

        this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).NetDueAmountDB);
tblSpenddownCalculations.Rows.Add(null,string.Empty,
                                string.Empty,
                                string.Empty,
                                "Not spent amount: ",
                                string.Empty,

                                this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).RemainingAmount);

                            tblSpenddownCalculations.Rows.Add(null,
                                                string.Empty,
                                                string.Empty,
                                                string.Empty,
                                                "Months paid: ",
                                                string.Empty,

                                                this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).PaidMonthCount);
                            tblSpenddownCalculations.Rows.Add(null,
                                    string.Empty,
                                    string.Empty,
                                    string.Empty,
                                    "Months not paid: ",
                                    string.Empty,

                                    this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).UnpaidMonthCount);
                            tblSpenddownCalculations.Rows.Add(null,
                                  string.Empty,
                                  string.Empty,
                                  string.Empty,
                                  "Month unpaid from the last payment: ",
                                  string.Empty,

                                  this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).LastUnpaidMonthCount);
                            tblSpenddownCalculations.Rows.Add(null,
                                                  string.Empty,
                                                  string.Empty,
                                                  string.Empty,
                                                  "Total months: ",
                                                  string.Empty,

                                                  this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK)).MonthCount);
                        }
                    }
                    if ((int)TableType == 1)
                    {



                        if (true)
                        {
                            decimal totalRate = GetTotalRateOnDate(MaxDate, ckComb),
                                totalBilled = GetTotalBillOnDate(MaxDate, ckComb),

                                totalPaid = GetTotalPaymentOnDate(MaxDate, ckComb),
                                totalExpenses = GetTotalDiscretionaryItemOnDate(MaxDate, ckComb),
                            //totalFullyPaidMonths = (Decimal)tblSpenddownCalculations.Compute("SUM([Paid Months])", string.Empty);
                            totalFullyPaidMonths = 0;


                            SubscriberTotals subTotal = this.Totals.First(total => (total.SbsbCK == ckComb.SbsbCK) && (total.MemeCK == ckComb.MemeCK) && (total.BleiCK == ckComb.BleiCK));
                            Provider provider = GetProviderOnDate(date.AddMonths(-1));
                            tblSpenddownCalculations.Rows.Add(MaxDate,
                                                            _Id,
                                                            eligibility.FirstName,
                                                            eligibility.LastName,eligibility.MedicaidId,
                                                            eligibility.FamilyLink,
                                                            totalRate - totalPaid - totalExpenses,
                                                            subTotal.NetDueAmountDB,
                                                            subTotal.LastUnpaidMonthCount,
                                                            subTotal.PaidMonthCount,
                                                            subTotal.UnpaidMonthCount,
                                                            subTotal.MonthCount,
                                                            totalBilled,
                                                            totalPaid,
                                                            totalExpenses,
                                                            eligibility.CspiID,
                                                            eligibility.GrgrCK,
                                                            eligibility.CscsID,
                                                            _TrustNotice,
                                                            ((provider.Name != null) ? provider.Name : ""),
                                                            ((provider.Name != null) ? provider.EffectiveDate.ToString() : ""),
                                                            ((provider.Name != null) ? provider.TerminationDate.ToString() : ""),
                                                            ((provider.Name != null) ? provider.GrgrCK.ToString() : ""),
                                                            ((provider.Name != null) ? provider.ID : ""),
                                                            ((provider.Name != null) ? provider.NPI : ""));

                        }
                    }
                }
            }
```csharp
return tblSpenddownCalculations;
}
}
}
```