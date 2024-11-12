using FinancialTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTools
{
    class Subscriber_old
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Id { get; set; }
        public String MedicaidId { get; set; }
        public Int32 MemeCK { get; set; }
        public Int32 SbsbCK { get; set; }
        public Int32 BleiCK { get; set; }

        public DateTime Birthdate { get; set; }

        public Int32 SSN { get; set; }

        public String FamilyLink { get; set; }

        public Int16 GrgrCK { get; set; } 

        public String CspiID { get; set; }



        public Subscriber_old(String firstName, String lastName, String id, String medicaidId, Int32 SbsbCK = -1, Int32 MemeCK = -1, Int32 BleiCK = -1,
            DateTime Birthdate = default(DateTime), Int32 SSN = 0, String FamilyLink = default(string), Int16 GrgrCK = -1, String CspiID = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.MedicaidId = medicaidId;
            this.SbsbCK = SbsbCK;
            this.MemeCK = MemeCK;
            this.BleiCK = BleiCK;
            this.Birthdate = Birthdate;
            this.FamilyLink = FamilyLink;
            this.GrgrCK = GrgrCK;
            this.CspiID = CspiID;
        }
        public static Tuple<String, DataTable, Decimal> CalculateIndividualSpenddownTable(string id, string username, string password, DateTime cutoffDate)
        {

            var qryResult = GreenplumODBC.GetIndividualSpenddownInfo(username, password, id);
            if (qryResult.Result.Item4.Item1 == null) return new Tuple<String, DataTable, Decimal>
                    (qryResult.Result.Item1, null, 0);
            var netDueAmount = System.Convert.ToDecimal(qryResult.Result.Item1, CultureInfo.InvariantCulture);
var minDate = qryResult.Result.Item2;
var rates = qryResult.Result.Item4.Item1;
var expenses = qryResult.Result.Item4.Item2;
var payments = qryResult.Result.Item4.Item3;
var bills = qryResult.Result.Item4.Item4;
var eligibilities = qryResult.Result.Item4.Item5;

DateTime maxDate = cutoffDate.AddMonths(1);
if (maxDate < new DateTime(minDate.Year, minDate.Month, 1)) maxDate = new DateTime(minDate.Year, minDate.Month, 1);

DateTime eligStartDate = maxDate;
Decimal eligFlag = 0;
foreach (var i in eligibilities)
{
    if (i.Date < eligStartDate) eligStartDate = i.Date;
}

foreach (var i in eligibilities)
{
    if ((i.Date > eligStartDate) && (i.Date < minDate))
    {
        eligFlag = i.Amount;
        eligStartDate = i.Date;
    }
}

int months = ((maxDate.Year - minDate.Year) * 12) + maxDate.Month - minDate.Month;

using (DataTable tblSpenddownCalculations = new DataTable())
{
    tblSpenddownCalculations.Columns.Add("Date", typeof(DateTime));
    tblSpenddownCalculations.Columns.Add("ID", typeof(String));
    tblSpenddownCalculations.Columns.Add("First Name", typeof(String));
    tblSpenddownCalculations.Columns.Add("Last Name", typeof(String));
    tblSpenddownCalculations.Columns.Add("Full Name", typeof(String));
}                        rRate = i.Rate;
                        rBill = i.Billed;
                        rPayment = i.Paid;
                        rExpense = i.Expenses;
                    }
                    rAccumBalance += rBill - rPayment + rExpense;
                    rPaidMonths = rBill / rRate;
                    tblSpenddownCalculations.Rows.Add(rDate, rRate, rBill, rBill - rPayment, rPayment, rExpense, rPaidMonths, rAccumBalance, eligFlag);
                }
rPayment - rRate,
rExpense,
rAccumBalance,
elig
);

This code appears to be calculating various financial values based on different types of transactions (bills, payments, expenses). It then adds these values to calculate an accumulated balance and determines eligibility based on a flag. The sanitized code removes any sensitive information related to paths, passwords, database names, and connection strings.                string.Empty,
                string.Empty,
                "Total Rate:",
                totalRate,
                "Total Billed:",
                totalBilled,
                "Total Adjustments:",
                totalAdjmnts,
                "Total Paid:",
                totalPaid,
                "Total Expenses:",
                totalExpenses,
                "Total Paid Months:",
                totalPaidMonths,
                string.Empty,
                string.Empty,
                "Total Fully Paid Months:",
                totalFullyPaidMonths,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                stringnull,
                                    totalFullyPaidMonths);lt.Item2.Item3;
            DataTable tblSpenddownCalculations = new DataTable();
            tblSpenddownCalculations.Columns.Add("SBSB_CK", typeof(String));
            tblSpenddownCalculations.Columns.Add("MEME_CK", typeof(String));
            tblSpenddownCalculations.Columns.Add("BLEI_CK", typeof(String));
            tblSpenddownCalculations.Columns.Add("Months paid: ", typeof(String));
            tblSpenddownCalculations.Columns.Add("Rate", typeof(String));
            tblSpenddownCalculations.Columns.Add("Amount", typeof(Decimal));
            tblSpenddownCalculations.Columns.Add("Months not paid: ", typeof(String));
            tblSpenddownCalculations.Columns.Add("Total months: ", typeof(String));
            tblSpenddownCalculations.Rows.Add(null,
                                    string.Empty,
                                    string.Empty,
                                    "Months paid: ",
                                    string.Empty,
                                    null,
                                    monthsPaid);
            tblSpenddownCalculations.Rows.Add(null,
                        string.Empty,
                        string.Empty,
                        "Months not paid: ",
                        string.Empty,
                        null,
                        months - monthsPaid);
            tblSpenddownCalculations.Rows.Add(null,
                                  string.Empty,
                                  string.Empty,
                                  "Total months: ",
                                  string.Empty,
                                  null,
                                  months);



            return new Tuple<String, DataTable, DataTable, Decimal>("", tblSpenddownCalculations, tblMassSpenddownBills, netDueAmount);
        }
    }Calculations.Columns.Add("Total expenses", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total paid months", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total accumulated balance", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total eligibility", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total rate", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total billed", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total adjmnts", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total paid", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total expenses", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total paid months", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total accumulated balance", typeof(Decimal));
            tblFullSpenddownCalculations.Columns.Add("Total total eligibility", typeof(Decimal));

            foreach (DataRow row in tblMassSpenddownPayments.Rows)
            {
                DataRow newRow = tblFullSpenddownCalculations.NewRow();
                newRow["Date"] = row["Date"];
                newRow["ID"] = row["ID"];
                newRow["First Name"] = row["First Name"];
                newRow["Last Name"] = row["Last Name"];
                newRow["Full Name"] = row["Full Name"];
                newRow["Effective Date"] = row["Effective Date"];
                newRow["Rate"] = row["Rate"];
                newRow["Billed"] = row["Billed"];
                newRow["Adjmnts"] = row["Adjmnts"];
                newRow["Paid"] = row["Paid"];
                newRow["Expenses"] = row["Expenses"];
                newRow["Paid Months"] = row["Paid Months"];
                newRow["Accumulated Balance"] = row["Accumulated Balance"];
                newRow["Eligibility"] = row["Eligibility"];
                newRow["Total rate"] = row["Total rate"];
                newRow["Total billed"] = row["Total billed"];
                newRow["Total adjmnts"] = row["Total adjmnts"];
                newRow["Total paid"] = row["Total paid"];
                newRow["Total expenses"] = row["Total expenses"];
                newRow["Total paid months"] = row["Total paid months"];
                newRow["Total accumulated balance"] = row["Total accumulated balance"];
                newRow["Total eligibility"] = row["Total eligibility"];
                newRow["Total total rate"] = row["Total total rate"];
                newRow["Total total billed"] = row["Total total billed"];
                newRow["Total total adjmnts"] = row["Total total adjmnts"];
                newRow["Total total paid"] = row["Total total paid"];
                newRow["Total total expenses"] = row["Total total expenses"];
                newRow["Total total paid months"] = row["Total total paid months"];
                newRow["Total total accumulated balance"] = row["Total total accumulated balance"];
                newRow["Total total eligibility"] = row["Total total eligibility"];
                tblFullSpenddownCalculations.Rows.Add(newRow);
            }mns.Add("Family Link", typeof(String));

                    foreach (DataRow row in tblFullSpenddownCalculations.Rows)
                    {
                        DataRow newRow = tblShortSpenddownCalculations.NewRow();
                        newRow["Date"] = DateTime.Now;
                        newRow["ID"] = row["ID"];
                        newRow["First Name"] = row["First Name"];
                        newRow["Last Name"] = row["Last Name"];
                        newRow["Full Name"] = row["Full Name"];
                        newRow["Effective Date"] = row["Effective Date"];
                        newRow["Rate"] = row["Rate"];
                        newRow["Billed"] = row["Billed"];
                        newRow["Adjmnts"] = row["Adjmnts"];
                        newRow["Paid"] = row["Paid"];
                        newRow["Expenses"] = row["Expenses"];
                        newRow["Paid Months"] = row["Paid Months"];
                        newRow["Accumulated Balance"] = row["Accumulated Balance"];
                        newRow["Family Link"] = row["Family Link"];

                        tblShortSpenddownCalculations.Rows.Add(newRow);
                    }
                }mns.Add("Eligibility", typeof(String));
                    tblShortSpenddownCalculations.Columns.Add("Total rate", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total billed", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total adjmnts", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total paid", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total expenses", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("DB amount due", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Calculated amount due", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("# of paid months", typeof(Int32));
                    tblShortSpenddownCalculations.Columns.Add("# of unpaid months", typeof(Int32));
                    tblShortSpenddownCalculations.Columns.Add("# of unpaid months from the latest payment", typeof(Int32));
                    tblShortSpenddownCalculations.Columns.Add("Family link", typeof(String));


                    int prevMonths = 0;
                    for (int countSubs = 0; countSubs < tblMassSpenddownList.Rows.Count; countSubs++)
                    {

                        if (objProgress != null)
                        {
                            int percentage = 8 + countSubs * 92 / (tblMassSpenddownList.Rows.Count - 1);
                            objProgress.ReportProgress(percentage);
                        }
                        DateTime minDate = qryResult.Result.Item3.Item1;
                    }Console.WriteLine("{0} of {1}", countSubs, tblMassSpenddownList.Rows.Count);

DateTime minIndDate = new DateTime(3000, 12, 31);
DateTime maxIndDate = new DateTime(1900, 1, 1);
Subscriber_old subscriber = new Subscriber_old(((String)tblMassSpenddownList.Rows[countSubs][2]).Trim(), ((String)tblMassSpenddownList.Rows[countSubs][1]).Trim(), ((String)tblMassSpenddownList.Rows[countSubs][0]).Trim(), "");
String familyLink = ((String)tblMassSpenddownList.Rows[countSubs][8]).Trim();
Decimal netDueAmount = 0;
int ind = 0;
while ((ind < tblMassSpenddownDueAmount.Rows.Count) && (((String)tblMassSpenddownDueAmount.Rows[ind][0]).Trim() != ((String)tblMassSpenddownList.Rows[countSubs][0]).Trim())) ind++;
if (tblMassSpenddownDueAmount.Rows[ind][0] == tblMassSpenddownList.Rows[countSubs][0]) netDueAmount = (Decimal)tblMassSpenddownDueAmount.Rows[ind][24];

List<Transaction_old> rates = new List<Transaction_old>();
for (int intTbl = 0; intTbl < tblMassSpenddownRates.Rows.Count; intTbl++)
{

    if ((int)tblMassSpenddownRates.Rows[intTbl][0] == (int)tblMassSpenddownList.Rows[countSubs][12])
    {
        if (!decimal.TryParse((string)tblMassSpenddownRates.Rows[intTbl][8], out _)) tblMassSpenddownRates.Rows[intTbl][8] = "0.00";
        Transaction_old transaction = new Transaction_old(System.Convert.ToDecimal((string)tblMassSpenddownRates.Rows[intTbl][8], CultureInfo.InvariantCulture), (DateTime)tblMassSpenddownRates.Rows[intTbl][1], "", "", System.Convert.ToInt32(tblMassSpenddownRates.Rows[intTbl][0], CultureInfo.InvariantCulture), subscriber);
        rates.Add(transaction);                   if ((DateTime)tblMassSpenddownRates.Rows[intTbl][1] < minIndDate) minIndDate = (DateTime)tblMassSpenddownRates.Rows[intTbl][1];
                                if ((DateTime)tblMassSpenddownRates.Rows[intTbl][1] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownRates.Rows[intTbl][1];
                            }
                        }
                        List<Transaction_old> payments = new List<Transaction_old>();
                        for (int intTbl = 0; intTbl < tblMassSpenddownPayments.Rows.Count; intTbl++)
                        {
                            if ((string)tblMassSpenddownPayments.Rows[intTbl][2] == (string)tblMassSpenddownList.Rows[countSubs][0])
                            {
                                Transaction_old transaction = new Transaction_old(System.Convert.ToDecimal(tblMassSpenddownPayments.Rows[intTbl][11], CultureInfo.InvariantCulture), (DateTime)tblMassSpenddownPayments.Rows[intTbl][3], "", "", System.Convert.ToInt32(tblMassSpenddownPayments.Rows[intTbl][2], CultureInfo.InvariantCulture), subscriber);
                                payments.Add(transaction);
                                if ((DateTime)tblMassSpenddownPayments.Rows[intTbl][3] < minIndDate) minIndDate = (DateTime)tblMassSpenddownPayments.Rows[intTbl][3];
                                if ((DateTime)tblMassSpenddownPayments.Rows[intTbl][3] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownPayments.Rows[intTbl][3];
                            }
                        }
                        List<Transaction_old> eligibilities = new List<Transaction_old>();
                        for (int intTbl = 0; intTbl < tblMassSpenddownEligibility.Rows.Count; intTbl++)
                        {
                            if ((int)tblMassSpenddownEligibility.Rows[intTbl][0] == (int)tblMassSpenddownList.Rows[countSubs][16])
                            {
                                Decimal amount = 0;s.Rows[intTbl][2] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownBills.Rows[intTbl][2];
                            }
                        }

                        List<Transaction_old> spenddowns = new List<Transaction_old>();
                        foreach (Transaction_old bill in bills)
                        {
                            foreach (Transaction_old eligibility in eligibilities)
                            {
                                if (bill.Date == eligibility.Date)
                                {
                                    Transaction_old spenddown = new Transaction_old(bill.Amount - eligibility.Amount, bill.Date, "", "", bill.SubscriberID, subscriber);
                                    spenddowns.Add(spenddown);
                                }
                            }
                        }

                        foreach (Transaction_old spenddown in spenddowns)
                        {
                            if (spenddown.Amount < 0)
                            {
                                Transaction_old adjustment = new Transaction_old(spenddown.Amount * -1, spenddown.Date, "", "", spenddown.SubscriberID, subscriber);
                                adjustments.Add(adjustment);
                            }
                        }s.Rows[intTbl][2] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownBills.Rows[intTbl][2];
                            }
                        }
                        List<Transaction_old> expenses = new List<Transaction_old>();
                        for (int intTbl = 0; intTbl < tblMassSpenddownExpenses.Rows.Count; intTbl++)
                        {
                            if ((int)tblMassSpenddownExpenses.Rows[intTbl][8] == (int)tblMassSpenddownList.Rows[countSubs][12])
                            {
                                Transaction_old transaction = new Transaction_old(System.Convert.ToDecimal(tblMassSpenddownExpenses.Rows[intTbl][5], CultureInfo.InvariantCulture), (DateTime)tblMassSpenddownExpenses.Rows[intTbl][0], "", "", System.Convert.ToInt64(tblMassSpenddownExpenses.Rows[intTbl][1], CultureInfo.InvariantCulture), subscriber);
                                expenses.Add(transaction);
                                if ((DateTime)tblMassSpenddownExpenses.Rows[intTbl][0] < minIndDate) minIndDate = (DateTime)tblMassSpenddownExpenses.Rows[intTbl][0];
                                if ((DateTime)tblMassSpenddownExpenses.Rows[intTbl][0] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownExpenses.Rows[intTbl][0];
                            }
                        }



                        DateTime maxDate = cutoffDate.AddMonths(1);
                        if (maxDate < new DateTime(minDate.Year, minDate.Month, 1)) maxDate = new DateTime(minDate.Year, minDate.Month, 1);

                        DateTime eligStartDate = maxDate;
                        Decimal eligFlag = 0;
                        foreach (var i in eligibilities)
                        {

                            if (i.Date < eligStartDate) eligStartDate = i.Date;


                        }
                        foreach (var i in eligibilities)
                        {

                            if ((i.Date > eligStartDate) &&{
    if (minIndDate > maxDate) minIndDate = maxDate;
    int months = ((maxDate.Year - minIndDate.Year) * 12) + maxDate.Month - minIndDate.Month;

    Decimal rRate = 0, rAccumBalance = 0, rPaidMonths = 0;

    Decimal totalRate = 0;
    Decimal totalBilled = 0;
    Decimal totalAdjmnts = 0;
    Decimal totalPaid = 0;
    Decimal totalExpenses = 0;

    for (int j = 0; j < months; j++)
    {
        Decimal rBill = 0, rPayment = 0, rExpense = 0;

        foreach (var i in eligibilities)
        {
            if ((minIndDate.AddMonths(j).Year == i.Date.Year) && (minIndDate.AddMonths(j).Month == i.Date.Month))
            {
                eligFlag = i.Amount;
            }
        }

        foreach (var i in rates)
        {
            if ((minIndDate.AddMonths(j).Year == i.Date.Year) && (minIndDate.AddMonths(j).Month == i.Date.Month))
            {
                rRate = i.Amount;
            }
        }

        foreach (var i in bills)
        {
            // Process bills
        }
    }
}iber.DOB,
                                                             subscriber.SSN,
                                                             elig,
                                                             rRate,
                                                             rBill,
                                                             rPayment,
                                                             rExpense,
                                                             rAccumBalance,
                                                             totalRate,
                                                             totalBilled,
                                                             totalAdjmnts,
                                                             totalPaid,
                                                             totalExpenses,
                                                             totalBalance);iber.FirstName + " " + subscriber.LastName,
                                                             new DateTime(minIndDate.AddMonths(j).Year, minIndDate.AddMonths(j).Month, 1),
                                                             rRate * eligFlag,
                                                             rBill,
                                                             rBill - rRate * eligFlag,
                                                             rPayment,
                                                             rExpense,
                                                             rPaidMonths,
                                                             rAccumBalance,
                                                             elig);
                            if (j == months - 1)
                            {
                                tblShortSpenddownCalculations.Rows.Add(minIndDate.AddMonths(j),
                                     subscriber.Id,
                                     subscriber.FirstName,
                                     subscriber.LastName,
                                     subscriber.FirstName + " " + subscriber.LastName,
                                     new DateTime(minIndDate.AddMonths(j).Year, minIndDate.AddMonths(j).Month, 1),
                                     rRate * eligFlag,
                                     rBill,
                                     rBill - rRate * eligFlag,
                                     rPayment,
                                     rExpense,
                                     rPaidMonths,
                                     rAccumBalance,
                                     elig);
                            }

                        }






                        Decimal totalPaidMonths = totalPaid;

                        int cMonths = 0;
                        int monthsPaid = 0;int lastUnpaidMonths = 0;
while (cMonths < months)
{
    totalPaidMonths += tblFullSpenddownCalculations.Rows[prevMonths + cMonths].Field<Decimal>("Expenses");
    if (totalPaidMonths >= tblFullSpenddownCalculations.Rows[prevMonths + cMonths].Field<Decimal>("Rate"))
    {
        tblFullSpenddownCalculations.Rows[prevMonths + cMonths][11] = tblFullSpenddownCalculations.Rows[prevMonths + cMonths].Field<Decimal>("Rate");
        totalPaidMonths -= (Decimal)tblFullSpenddownCalculations.Rows[prevMonths + cMonths][11];

    }
    lastUnpaidMonths++;
    if ((Decimal)tblFullSpenddownCalculations.Rows[prevMonths + cMonths][11] > 0)
    {
        lastUnpaidMonths = 0;
        monthsPaid++;
    }

    cMonths++;
}


for (int j = 0; j < months; j++)
{
    tblFullSpenddownCalculations.Rows[prevMonths + j][14] = totalRate;
    tblFullSpenddownCalculations.Rows[prevMonths + j][15] = totalBilled;
    tblFullSpenddownCalculations.Rows[prevMonths + j][16] = totalAdjmnts;
    tblFullSpenddownCalculations.Rows[prevMonths + j][17] = totalPaid;
    tblFullSpenddownCalculations.Rows[prevMonths + j][18] = totalExpenses;
    tblFullSpenddownCalculations.Rows[prevMonths + j][19] = netDueAmount;
    tblFullSpenddownCalculations.Rows[prevMonths + j][20] = rAccumBalance;
    tblFullSpenddownCalculations.Rows[prevMonths + j][21] = monthsPaid;public static Tuple<String, DataTable, DataTable, Decimal> CalculateMassNAMIReportTable(DateTime cutoffDate, bool flgOnlyWithnonZeroRates, bool flgOnlyEligibleNow, System.ComponentModel.BackgroundWorker objProgress = null)
{

    var qryResult = GreenplumODBC.GetMassNAMIInfo(cutoffDate, flgOnlyWithnonZeroRates, flgOnlyEligibleNow, objProgress);
            if (qryResult.Result.Item1.Item1.Length > 0) return new Tuple<String, DataTable, DataTable, Decimal>
                      (qryResult.Result.Item1.Item1, null, null, 0);

            DataTable tblMassSpenddownList = qryResult.Result.Item2.Item1;
            DataTable tblMassSpenddownRates = qryResult.Result.Item2.Item2;
            DataTable tblMassSpenddownBills = qryResult.Result.Item2.Item3;
            DataTable tblMassSpenddownPayments = qryResult.Result.Item2.Item4;
            DataTable tblMassSpenddownExpenses = qryResult.Result.Item2.Item5;
            DataTable tblMassSpenddownEligibility = qryResult.Result.Item2.Item6;
            DataTable tblMassSpenddownDueAmount = qryResult.Result.Item2.Item7;

            using (DataTable tblFullSpenddownCalculations = new DataTable())
            {
                tblFullSpenddownCalculations.Columns.Add("Date", typeof(DateTime));
                tblFullSpenddownCalculations.Columns.Add("ID", typeof(String));
                tblFullSpenddownCalculations.Columns.Add("First Name", typeof(String));
                tblFullSpenddownCalculations.Columns.Add("Last Name", typeof(String));
                tblFullSpenddownCalculations.Columns.Add("Full Name", typeof(String));
                tblFullSpenddownCalculations.Columns.Add("Effective Date", typeof(DateTime));
                tblFullSpenddownCalculations.Columns.Add("Rate", typeof(Decimal));
                tblFullSpenddownCalculations.Columns.Add("Billed", typeof(Decimal));
                tblFullSpenddownCalculations.Columns.Add("Adjmnts", typeof(Decimal));
                tblFullSpenddownCalculations.Columns.Add("Paid", typeof(Decimal));
            }ShortSpenddownCalculations.Columns.Add("Total Rate", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total Billed", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total Paid", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total Adjustments", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Total Expenses", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("DB Amount Due", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("Calculated Amount Due", typeof(Decimal));
                    tblShortSpenddownCalculations.Columns.Add("# of Paid Months", typeof(Int32));
                    tblShortSpenddownCalculations.Columns.Add("# of Unpaid Months", typeof(Int32));
                    tblShortSpenddownCalculations.Columns.Add("# of Unpaid Months from the Latest Payment", typeof(Int32));
                    tblShortSpenddownCalculations.Columns.Add("Family Link", typeof(String));
                }lShortSpenddownCalculations.Columns.Add("Effective Date", typeof(DateTime));
tblShortSpenddownCalculations.Columns.Add("Rate", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Billed", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Adjmnts", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Paid", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Expenses", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Paid Months", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Accumulated Balance", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Eligibility", typeof(String));
tblShortSpenddownCalculations.Columns.Add("Total rate", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Total billed", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Total adjmnts", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Total paid", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Total expenses", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("DB amount due", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("Calculated amount due", typeof(Decimal));
tblShortSpenddownCalculations.Columns.Add("# of paid months", typeof(Int32));
tblShortSpenddownCalculations.Columns.Add("# of unpaid months", typeof(Int32));
tblShortSpenddownCalculations.Columns.Add("# of unpaid months from the latest payment", typeof(Int32));
tblShortSpenddownCalculations.Columns.Add("Family link", typeof(String));

int prevMonths = 0;//for (int countSubs = 0; countSubs < 2; countSubs++)

for (int countSubs = 0; countSubs < tblMassSpenddownList.Rows.Count; countSubs++)
{

    if (objProgress != null)
    {
        int percentage = 8 + countSubs * 92 / (tblMassSpenddownList.Rows.Count - 1);
        objProgress.ReportProgress(percentage);
    }
    //MassSpenddownReport.backgroundMassSpenddownCalculation.ReportProgress(23+77/tblMassSpenddownList.Rows.Count*(+1));
    DateTime minDate = qryResult.Result.Item3.Item1;
    //DateTime maxDate = qryResult.Result.Item3.Item2;
    //Console.WriteLine("{0} of {1}", countSubs, tblMassSpenddownList.Rows.Count);

    DateTime minIndDate = new DateTime(3000, 12, 31);
    DateTime maxIndDate = new DateTime(1900, 1, 1);
    Subscriber_old subscriber = new Subscriber_old(((String)tblMassSpenddownList.Rows[countSubs][2]).Trim(), ((String)tblMassSpenddownList.Rows[countSubs][1]).Trim(), ((String)tblMassSpenddownList.Rows[countSubs][0]).Trim(), "");
    String familyLink = ((String)tblMassSpenddownList.Rows[countSubs][8]).Trim();
    Decimal netDueAmount = 0;
    int ind = 0;
    while ((ind < tblMassSpenddownDueAmount.Rows.Count) && (((String)tblMassSpenddownDueAmount.Rows[ind][0]).Trim() != ((String)tblMassSpenddownList.Rows[countSubs][0]).Trim())) ind++;
    if (tblMassSpenddownDueAmount.Rows[ind][0] == tblMassSpenddownList.Rows[countSubs][0]) netDueAmount = (Decimal)tblMassSpenddownDueAmount.Rows[ind][24];

    List<Transaction_old> rates = new List<Transaction_old>();
    for (int intTbl = 0; intTbl < tblMassSpenddownRates.Rows.Count; intTbl++)
                        {

                            if ((int)tblMassSpenddownRates.Rows[intTbl][0] == (int)tblMassSpenddownList.Rows[countSubs][12])
                            {
                                if (!decimal.TryParse((string)tblMassSpenddownRates.Rows[intTbl][8], out _)) tblMassSpenddownRates.Rows[intTbl][8] = "0.00";
                                Transaction_old transaction = new Transaction_old(System.Convert.ToDecimal((string)tblMassSpenddownRates.Rows[intTbl][8], CultureInfo.InvariantCulture), (DateTime)tblMassSpenddownRates.Rows[intTbl][1], "", "", System.Convert.ToInt32(tblMassSpenddownRates.Rows[intTbl][0], CultureInfo.InvariantCulture), subscriber);
                                rates.Add(transaction);
                                if ((DateTime)tblMassSpenddownRates.Rows[intTbl][1] < minIndDate) minIndDate = (DateTime)tblMassSpenddownRates.Rows[intTbl][1];
                                if ((DateTime)tblMassSpenddownRates.Rows[intTbl][1] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownRates.Rows[intTbl][1];
                            }
                        }
                        List<Transaction_old> payments = new List<Transaction_old>();
                        for (int intTbl = 0; intTbl < tblMassSpenddownPayments.Rows.Count; intTbl++)
                        {
                            if ((string)tblMassSpenddownPayments.Rows[intTbl][2] == (string)tblMassSpenddownList.Rows[countSubs][0])
                            {
                                Transaction_old transaction = new Transaction_old(System.Convert.ToDecimal(tblMassSpenddownPayments.Rows[intTbl][11], CultureInfo.InvariantCulture), (DateTime)tblMassSpenddownPayments.Rows[intTbl][3], "", "", System.Convert.ToInt32(tblMassSpenddownPayments.Rows[intTbl][2], CultureInfo.InvariantCulture), subscriber);
                                payments.Add(transaction);
                                if ((DateTime)tblMassSpenddownPayments.Rows[intTbl][3] < minIndDate) minIndDate = (DateTime)tblMassSpenddownPayments.Rows[intTbl][3];
                                if ((DateTime)tblMassSpenddownPayments.Rows[intTbl][3] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownPayments.Rows[intTbl][3];
                            }
                        }
                        List<Transaction_old> eligibilities = new List<Transaction_old>();
                        for (int intTbl = 0; intTbl < tblMassSpenddownEligibility.Rows.Count; intTbl++)
                        {
                            if ((int)tblMassSpenddownEligibility.Rows[intTbl][0] == (int)tblMassSpenddownList.Rows[countSubs][16])
                            {
                                Decimal amount = 0;
                                if (((string)tblMassSpenddownEligibility.Rows[intTbl][10]).Contains("Y")) amount = 1;
                                if (((string)tblMassSpenddownEligibility.Rows[intTbl][10]).Contains("N")) amount = 0;
                                Transaction_old transaction = new Transaction_old(amount, (DateTime)tblMassSpenddownEligibility.Rows[intTbl][2], "", "", System.Convert.ToInt32(tblMassSpenddownEligibility.Rows[intTbl][0], CultureInfo.InvariantCulture), subscriber);
                                if ((amount == 1) && ((DateTime)tblMassSpenddownEligibility.Rows[intTbl][2] < minIndDate)) minIndDate = (DateTime)tblMassSpenddownEligibility.Rows[intTbl][2];
                                if ((amount == 1) && ((DateTime)tblMassSpenddownEligibility.Rows[intTbl][2] > maxIndDate)) maxIndDate = (DateTime)tblMassSpenddownEligibility.Rows[intTbl][2];
                                eligibilities.Add(transaction);

                            }
                        }

                        List<Transaction_old> bills = new List<Transaction_old>();
                        for (int intTbl = 0; intTbl < tblMassSpenddownBills.Rows.Count; intTbl++)
                        {                            if ((int)tblMassSpenddownBills.Rows[intTbl][0] == (int)tblMassSpenddownList.Rows[countSubs][25])
                            {

                                Transaction_old transaction = new Transaction_old(System.Convert.ToDecimal(tblMassSpenddownBills.Rows[intTbl][5], CultureInfo.InvariantCulture), (DateTime)tblMassSpenddownBills.Rows[intTbl][2], "", "", System.Convert.ToInt32(tblMassSpenddownBills.Rows[intTbl][0], CultureInfo.InvariantCulture), subscriber);
                                bills.Add(transaction);
                                if ((DateTime)tblMassSpenddownBills.Rows[intTbl][2] < minIndDate) minIndDate = (DateTime)tblMassSpenddownBills.Rows[intTbl][2];
                                if ((DateTime)tblMassSpenddownBills.Rows[intTbl][2] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownBills.Rows[intTbl][2];
                            }
                        }
                        List<Transaction_old> expenses = new List<Transaction_old>();
                        for (int intTbl = 0; intTbl < tblMassSpenddownExpenses.Rows.Count; intTbl++)
                        {
                            if ((int)tblMassSpenddownExpenses.Rows[intTbl][8] == (int)tblMassSpenddownList.Rows[countSubs][12])
                            {
                                Transaction_old transaction = new Transaction_old(System.Convert.ToDecimal(tblMassSpenddownExpenses.Rows[intTbl][5], CultureInfo.InvariantCulture), (DateTime)tblMassSpenddownExpenses.Rows[intTbl][0], "", "", System.Convert.ToInt64(tblMassSpenddownExpenses.Rows[intTbl][1], CultureInfo.InvariantCulture), subscriber);
                                expenses.Add(transaction);
                                if ((DateTime)tblMassSpenddownExpenses.Rows[intTbl][0] < minIndDate) minIndDate = (DateTime)tblMassSpenddownExpenses.Rows[intTbl][0];
                                if ((DateTime)tblMassSpenddownExpenses.Rows[intTbl][0] > maxIndDate) maxIndDate = (DateTime)tblMassSpenddownExpenses.Rows[intTbl][0];
                            }
                        }ate <= i.Date) && (i.Date <= maxDate))
                                {
                                    rRate += i.Amount;
                                    rAccumBalance += i.Amount;
                                    rPaidMonths++;
                                }
                            }

                            foreach (var i in billings)
                            {

                                if ((minIndDate <= i.Date) && (i.Date <= maxDate))
                                {
                                    rBill += i.Amount;
                                }
                            }

                            foreach (var i in payments)
                            {

                                if ((minIndDate <= i.Date) && (i.Date <= maxDate))
                                {
                                    rPayment += i.Amount;
                                }
                            }

                            foreach (var i in expenses)
                            {

                                if ((minIndDate <= i.Date) && (i.Date <= maxDate))
                                {
                                    rExpense += i.Amount;
                                }
                            }

                            totalRate += rRate;
                            totalBilled += rBill;
                            totalPaid += rPayment;
                            totalExpenses += rExpense;

                            Decimal rBillAdj = rBill;
                            foreach (var i in billAdjustments)
                            {

                                if ((minIndDate <= i.Date) && (i.Date <= maxDate))
                                {
                                    rBillAdj += i.Amount;
                                }
                            }

                            Decimal rPaidAdj = rPayment;
                            foreach (var i in paymentAdjustments)
                            {

                                if ((minIndDate <= i.Date) && (i.Date <= maxDate))
                                {
                                    rPaidAdj += i.Amount;
                                }
                            }

                            Decimal rExpAdj = rExpense;
                            foreach (var i in expenseAdjustments)
                            {

                                if ((minIndDate <= i.Date) && (i.Date <= maxDate))
                                {
                                    rExpAdj += i.Amount;
                                }
                            }

                            totalAdjmnts += rBillAdj + rPaidAdj + rExpAdj;

                            minIndDate = minIndDate.AddMonths(1);
                        }ate.AddMonths(j).Year == i.Date.Year) && (minIndDate.AddMonths(j).Month == i.Date.Month))
                                {

                                    eligFlag = i.Amount;



                                }


                            }
                            foreach (var i in rates)
                            {

                                if ((minIndDate.AddMonths(j).Year == i.Date.Year) && (minIndDate.AddMonths(j).Month == i.Date.Month))
                                {


                                    DateTime rDate = i.Date;
                                    rRate = i.Amount;



                                }


                            }

                            foreach (var i in bills)
                            {

                                if ((minIndDate.AddMonths(j).Year == i.Date.Year) && (minIndDate.AddMonths(j).Month == i.Date.Month))
                                {

                                    rBill += i.Amount;

                                }

                            }


                            foreach (var i in payments)
                            {

                                if ((minIndDate.AddMonths(j).Year == i.Date.Year) && (minIndDate.AddMonths(j).Month == i.Date.Month))
                                {

                                    rPayment += i.Amount;
                                }

                            }
                            foreach (var i in expenses)
                            {

                                if ((minIndDate.AddMonths(j).Year == i.Date.Year) && (minIndDate.AddMonths(j).Month == i.Date.Month))
                                {
                                    rExpense += i.Amount;

                                }

                            }
                            totalRate += rRate * eligFlag;
                            totalBilled += rBill;.LastName,
                                     new DateTime(minIndDate.AddMonths(j).Year, minIndDate.AddMonths(j).Month, 1),
                                     totalAdjmnts,
                                     totalPaid,
                                     totalExpenses,
                                     rAccumBalance);
                            }.LastName,
                                     new DateTime(minIndDate.AddMonths(j).Year, minIndDate.AddMonths(j).Month, 1),
                                     rRate * eligFlag,
                                     rBill,
                                     rBill - rRate * eligFlag,
                                     rPayment,
                                     rExpense,
                                     rPaidMonths,
                                     rAccumBalance,
                                     elig);
                            }

                        }






                        Decimal totalPaidMonths = totalPaid;

                        int cMonths = 0;
                        int monthsPaid = 0;
                        int lastUnpaidMonths = 0;
                        while (cMonths < months)
                        {
                            totalPaidMonths += tblFullSpenddownCalculations.Rows[prevMonths + cMonths].Field<Decimal>("Expenses");
                            if (totalPaidMonths >= tblFullSpenddownCalculations.Rows[prevMonths + cMonths].Field<Decimal>("Rate"))
                            {
                                tblFullSpenddownCalculations.Rows[prevMonths + cMonths][11] = tblFullSpenddownCalculations.Rows[prevMonths + cMonths].Field<Decimal>("Rate");
                                totalPaidMonths -= (Decimal)tblFullSpenddownCalculations.Rows[prevMonths + cMonths][11];

                            }
                            lastUnpaidMonths++;
                            if ((Decimal)tblFullSpenddownCalculations.Rows[prevMonths + cMonths][11] > 0)
                            {
                                lastUnpaidMonths = 0;
                                monthsPaid++;
                            }

                            cMonths++;
                        }


                        for (int j = 0; j < months; j++)
                        {[23] = lastUnpaidMonths;
                        tblShortSpenddownCalculations.Rows[countSubs][24] = familyLink;[23] = lastUnpaidMonths;
tblShortSpenddownCalculations.Rows[countSubs][24] = familyLink;
prevMonths += months;

return new Tuple<String, DataTable, DataTable, Decimal>("", tblShortSpenddownCalculations, tblFullSpenddownCalculations, 0);
}