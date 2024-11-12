using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

using FinancialTools;
using FinancialTools;
using System.Globalization;
using Npgsql;

namespace FinancialTools
{
    partial class GreenplumODBC
    {

        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        /*********************************************************** MASS SPENDDOWN *********************************************************/
        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        public static async 
        Task<Tuple<Tuple<String, String, String, String, String>, Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable>, Tuple<DateTime, DateTime>>> GetMassSpenddownInfo(string username, string password, DateTime dateCutOff, bool flgOnlyWithnonZeroRates, bool flgOnlyEligibleNow, System.ComponentModel.BackgroundWorker objProgress = null)
            {
                string connectionString = GetMassSpenddownConnectionString(username, password);
                using (var awConnection = new NpgsqlConnection(connectionString))
                {

                    try
                    {
                        awConnection.Open();
                        String sbsb_ckList = "";
                        DateTime minDate = new DateTime(3000, 1, 1), maxDate = new DateTime(1000, 1, 1);

                        var resGetMassSpenddownRates = GetMassSpenddownRates(awConnection, dateCutOff, flgOnlyWithnonZeroRates,rogress(3);

                        var resGetMassSpenddownNetDueAmountSummary = GetMassSpenddownNetDueAmountSummary(awConnection, tblMassSpenddownDueAmount, blei_ckList);
                        DataTable tblMassSpenddownDueAmountSummary = resGetMassSpenddownNetDueAmountSummary.Result.Item1;
                        var blck_ckList = resGetMassSpenddownNetDueAmountSummary.Result.Item2;
                        //if (minDate > resGetMassSpenddownNetDueAmountSummary.Result.Item3) minDate = resGetMassSpenddownNetDueAmountSummary.Result.Item3;
                        //if (maxDate < resGetMassSpenddownNetDueAmountSummary.Result.Item4) maxDate = resGetMassSpenddownNetDueAmountSummary.Result.Item4;
                        if (objProgress != null) objProgress.ReportProgress(4);

                        var resGetMassSpenddownNetDueAmountSummaryDetail = GetMassSpenddownNetDueAmountSummaryDetail(awConnection, tblMassSpenddownDueAmountSummary, blck_ckList);
                        DataTable tblMassSpenddownDueAmountSummaryDetail = resGetMassSpenddownNetDueAmountSummaryDetail.Result.Item1;
                        //if (minDate > resGetMassSpenddownNetDueAmountSummaryDetail.Result.Item2) minDate = resGetMassSpenddownNetDueAmountSummaryDetail.Result.Item2;
                        //if (maxDate < resGetMassSpenddownNetDueAmountSummaryDetail.Result.Item3) maxDate = resGetMassSpenddownNetDueAmountSummaryDetail.Result.Item3;
                        if (objProgress != null) objProgress.ReportProgress(5);

                        var resGetMassSpenddownNetDueAmountSummaryDetailStats = GetMassSpenddownNetDueAmountSummaryDetailStats(awConnection, tblMassSpenddownDueAmountSummaryDetail);
                        DataTable tblMassSpenddownDueAmountSummaryDetailStats = resGetMassSpenddownNetDueAmountSummaryDetailStats.Result.Item1;
                        //if (minDate > resGetMassSpenddownNetDueAmountSummaryDetailStats.Result.Item2) minDate = resGetMassSpenddownNetDueAmountSummaryDetailStats.Result.Item2;
                        //if (maxDate < resGetMassSpenddownNetDueAmountSummaryDetailStats.Result.Item3) maxDate = resGetMassSpenddownNetDueAmountSummaryDetailStats.Result.Item3;
                        if (objProgress != null) objProgress.ReportProgress(6);

                        var resGetMassSpenddownNetDueAmountSummaryDetailStatsSummary = GetMassSpenddownNetDueAmountSummaryDetailStatsSummary(awConnection, tblMassSpenddownDueAmountSummaryDetailStats);
                        DataTable tblMassSpenddownDueAmountSummaryDetailStatsSummary = resGetMassSpenddownNetDueAmountSummaryDetailStatsSummary.Result.Item1;
                        //if (minDate > resGetMassSpenddownNetDueAmountSummaryDetailStatsSummary.Result.Item2) minDate = resGetMassSpenddownNetDueAmountSummaryDetailStatsSummary.Result.Item2;
                        //if (maxDate < resGetMassSpenddownNetDueAmountSummaryDetailStatsSummary.Result.Item3) maxDate = resGetMassSpenddownNetDueAmountSummaryDetailStatsSummary.Result.Item3;
                        if (objProgress != null) objProgress.ReportProgress(7);

                        return new Tuple<DataTable, DateTime, DateTime>(tblMassSpenddownDueAmountSummaryDetailStatsSummary, minDate, maxDate);
                    }

                    private Tuple<DataTable, List<long>> GetMassSpenddownList(AwConnection awConnection, List<long> sbsb_ckList)
                    {
                        DataTable tblMassSpenddownList = new DataTable();
                        List<long> idList = new List<long>();
                        List<long> sbsb_ckListOut = new List<long>();
                        List<long> meme_ckList = new List<long>();

                        if (sbsb_ckList.Count == 0) return new Tuple<DataTable, List<long>, List<long>, List<long>>(tblMassSpenddownList, idList, sbsb_ckListOut, meme_ckList);

                        string query = "SELECT * FROM ...";

                        using (SqlCommand command = new SqlCommand(query, awConnection.GetConnection()))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(tblMassSpenddownList);
                            }
                        }

                        foreach (DataRow row in tblMassSpenddownList.Rows)
                        {
                            idList.Add(Convert.ToInt64(row["..."]));
                            sbsb_ckListOut.Add(Convert.ToInt64(row["..."]));
                            meme_ckList.Add(Convert.ToInt64(row["..."]));
                        }

                        return new Tuple<DataTable, List<long>, List<long>, List<long>>(tblMassSpenddownList, idList, sbsb_ckListOut, meme_ckList);
                    }

                    private Tuple<DataTable, List<long>> GetMassSpenddownNetDueAmount(AwConnection awConnection, DataTable tblMassSpenddownList, List<long> sbsb_ckList)
                    {
                        DataTable tblMassSpenddownNetDueAmount = new DataTable();
                        List<long> blei_ckList = new List<long>();

                        if (sbsb_ckList.Count == 0) return new Tuple<DataTable, List<long>>(tblMassSpenddownNetDueAmount, blei_ckList);

                        string query = "SELECT * FROM ...";

                        using (SqlCommand command = new SqlCommand(query, awConnection.GetConnection()))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(tblMassSpenddownNetDueAmount);
                            }
                        }

                        foreach (DataRow row in tblMassSpenddownNetDueAmount.Rows)
                        {
                            blei_ckList.Add(Convert.ToInt64(row["..."]));
                        }

                        return new Tuple<DataTable, List<long>>(tblMassSpenddownNetDueAmount, blei_ckList);
                    }

                    // Other methods have similar structures and are omitted for brevity.= resGetMassSpenddownEligibility.Result.Item2;
                        if (maxDate < resGetMassSpenddownEligibility.Result.Item3) maxDate = resGetMassSpenddownEligibility.Result.Item3;
                        if (objProgress != null) objProgress.ReportProgress(8);

                        var resGetMassSpenddownNotes = GetMassSpenddownNotes(awConnection, blei_ckList);
                        DataTable tblMassSpenddownNotes = resGetMassSpenddownNotes.Result.Item1;
                        if (minDate > resGetMassSpenddownNotes.Result.Item2) minDate = resGetMassSpenddownNotes.Result.Item2;
                        if (maxDate < resGetMassSpenddownNotes.Result.Item3) maxDate = resGetMassSpenddownNotes.Result.Item3;
                        if (objProgress != null) objProgress.ReportProgress(9);

                        var resGetMassSpenddownStatus = GetMassSpenddownStatus(awConnection, blei_ckList);
                        DataTable tblMassSpenddownStatus = resGetMassSpenddownStatus.Result.Item1;
                        if (minDate > resGetMassSpenddownStatus.Result.Item2) minDate = resGetMassSpenddownStatus.Result.Item2;
                        if (maxDate < resGetMassSpenddownStatus.Result.Item3) maxDate = resGetMassSpenddownStatus.Result.Item3;
                        if (objProgress != null) objProgress.ReportProgress(10);

                        if (objProgress != null) objProgress.ReportProgress(11);= resGetMassSpenddownEligibility.Result.Item2;
                        if (maxDate < resGetMassSpenddownEligibility.Result.Item3) maxDate = resGetMassSpenddownEligibility.Result.Item3;
                        if (objProgress != null) objProgress.ReportProgress(8);

                        var result1 = new Tuple<String, String, String, String, String>
                                ("", idList, sbsb_ckList, meme_ckList, blei_ckList);
                        var result2 = new Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable> 
                                (tblMassSpenddownList, tblMassSpenddownRates, tblMassSpenddownBills, tblMassSpenddownPayments, tblMassSpenddownExpenses, tblMassSpenddownEligibility, tblMassSpenddownDueAmount);
                        var result3 = new Tuple<DateTime, DateTime>(minDate, maxDate);
                        return new Tuple<Tuple<String, String, String, String, String>, Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable>, Tuple<DateTime, DateTime>>(result1, result2, result3);
                    }

                    catch (NpgsqlException e)
                    {
                        string errorMessages = e.ToString();

                        var result1 = new Tuple<String, String, String, String, String>
                                ("Failed to connect to database!\n\r" + errorMessages, "", "", "", "");
                        var result2 = new Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable>();private static async Task<Tuple<DataTable, String, String, String, DateTime, DateTime>> GetMassSpenddownList(NpgsqlConnection connection, String sbsb_ckList)

{
    var tblMassSpenddownList = new DataTable();
    tblMassSpenddownList.Columns.Add("ID", typeof(String));
    tblMassSpenddownList.Columns.Add("Last Name", typeof(String));
    tblMassSpenddownList.Columns.Add("First Name", typeof(String));
    tblMassSpenddownList.Columns.Add("SSN", typeof(String));
    tblMassSpenddownList.Columns.Add("Sex", typeof(String));
    tblMassSpenddownList.Columns.Add("Date of birth", typeof(String));
    tblMassSpenddownList.Columns.Add("Language", typeof(String));
    tblMassSpenddownList.Columns.Add("Record #", typeof(String));
    tblMassSpenddownList.Columns.Add("Family Link", typeof(String));
    tblMassSpenddownList.Columns.Add("cscs_id", typeof(String));
    tblMassSpenddownList.Columns.Add("pdpd_id", typeof(String));
    tblMassSpenddownList.Columns.Add("excd_id", typeof(String));
    tblMassSpenddownList.Columns.Add("sbsb_ck", typeof(Int32));
    tblMassSpenddownList.Columns.Add("grgr_ck", typeof(String));
    tblMassSpenddownList.Columns.Add("sgsg_ck", typeof(String));
    tblMassSpenddownList.Columns.Add("meme_mctr_sts", typeof(String));

    var result1 = new DataTable();
    var result2 = new DataTable();
    var result3 = new Tuple<DateTime, DateTime>(DateTime.Now, DateTime.Now);

    return new Tuple<DataTable, String, String, String, DateTime, DateTime>(tblMassSpenddownList, "", "", "", DateTime.Now, DateTime.Now);
}                tblMassSpenddownList.Columns.Add("meme_ck", typeof(Int32));
                tblMassSpenddownList.Columns.Add("cspd_cat", typeof(String));
                tblMassSpenddownList.Columns.Add("mepe_elig_ind", typeof(String));
                tblMassSpenddownList.Columns.Add("mepe_mctr_rsn", typeof(String));
                tblMassSpenddownList.Columns.Add("mepe_sys_inel_cd", typeof(String));
                tblMassSpenddownList.Columns.Add("mepe_fi", typeof(String));
                tblMassSpenddownList.Columns.Add("mepe_source", typeof(String));
                tblMassSpenddownList.Columns.Add("meme_rel", typeof(String));
                tblMassSpenddownList.Columns.Add("Net Amount Due", typeof(Decimal));
                tblMassSpenddownList.Columns.Add("blei_ck", typeof(Int32));
                tblMassSpenddownList.Columns.Add("Signature Date", typeof(DateTime));
                //Console.WriteLine("rates start {0}", DateTime.Now.ToLongTimeString().ToString());

                using (NpgsqlCommand command = string.IsNullOrEmpty(sbsb_ckList)
                    ? new NpgsqlCommand(sqlMassSpenddownListFull, connection)
                    : new NpgsqlCommand(sqlMassSpenddownListShort1 + sbsb_ckList + sqlMassSpenddownListShort2, connection))
                {
                    command.CommandTimeout = 86400;
                   command.ExecuteNonQuery();
                    NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
                    DateTime minDate = new DateTime(3000, 1, 1), maxDate = new DateTime(1000, 1, 1);

                    String idList = "", meme_ckList = "";
                    sbsb_ckList = "";

                    while (thisReader.Read())
                    {
                    DateTime date = System.Convert.ToDateTime(thisReader.GetValue(24), CultureInfo.InvariantCulture);
                        tblMassSpenddownList.Rows.Add(((string)thisReader.GetValue(0)).ToString(CultureInfo.InvariantCulture),
                            thisReader.GetValue(1),
                            thisReader.GetValue(2),
                            thisReader.GetValue(3),
                            thisReader.GetValue(4),
                            thisReader.GetValue(5),
                            thisReader.GetValue(6),
                            thisReader.GetValue(7),
                            thisReader.GetValue(8),
                            thisReader.GetValue(9),
                            thisReader.GetValue(10),
                            thisReader.GetValue(11),
                            System.Convert.ToInt32(thisReader.GetValue(12), CultureInfo.InvariantCulture),
                            thisReader.GetValue(13),
                            thisReader.GetValue(14),
                            thisReader.GetValue(15),
                            System.Convert.ToInt32(thisReader.GetValue(16), CultureInfo.InvariantCulture),
                            thisReader.GetValue(17),
                            thisReader.GetValue(18),
                            thisReader.GetValue(19),
                            thisReader.GetValue(20),
                            thisReader.GetValue(21),
                            thisReader.GetValue(22),
                            thisReader.GetValue(23),
                            0,
                            0,
                            thisReader.GetValue(24));
                        if (minDate > date) minDate = date;
                        if (maxDate < date) maxDate = date;

                        idList += "'" + thisReader.GetValue(0) + "',";
                        sbsb_ckList += "'" + thisReader.GetValue(12) + "',";
                        meme_ckList += "'" + thisReader.GetValue(16) + "',";

                    }
                    //Console.WriteLine("rates stop {0}", DateTime.Now.ToLongTimeString().ToString());idList = idList.Substring(0, idList.Length - 1);
sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);
meme_ckList = meme_ckList.Substring(0, meme_ckList.Length - 1);
return new Tuple<DataTable, String, String, String, DateTime, DateTime>(tblMassSpenddownList, idList, sbsb_ckList, meme_ckList, minDate, maxDate);
}

public static async Task<Tuple<DataTable, string, DateTime, DateTime>> GetMassSpenddownNetDueAmount(NpgsqlConnection connection, DataTable tblMassSpenddownList, string sbsb_ckList)
{
//Console.WriteLine("due amount start {0}", DateTime.Now.ToLongTimeString().ToString());

NpgsqlCommand command = new NpgsqlCommand(sqlMassSpenddownNetDue1 + sbsb_ckList + sqlMassSpenddownNetDue2, connection)
{
CommandTimeout = 86400
};
command.ExecuteNonQuery();
NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
DataTable data = new DataTable();
data.Columns.Add("blei_ck", typeof(Int32));
data.Columns.Add("blei_bill_level", typeof(String));
data.Columns.Add("blei_bill_level_ck", typeof(Int32));
data.Columns.Add("blei_net_due", typeof(Decimal));
data.Columns.Add("blei_net_alloc_susp", typeof(Decimal));
data.Columns.Add("blei_lst_bl_due_dt", typeof(DateTime));
data.Columns.Add("blei_lst_bl_end_dt", typeof(DateTime));
data.Columns.Add("blei_lst_aprv_dt", typeof(DateTime));
data.Columns.Add("blei_lst_pd_due_dt", typeof(DateTime));
data.Columns.Add("blei_lst_tl_due_dt", typeof(DateTime));
data.Columns.Add("blei_lst_rc_due_dt", typeof(DateTime));
data.Columns.Add("blei_last_bill_dtm);}                typeof(DateTime));
                data.Columns.Add("blei_mult_bl_due", typeof(DateTime));
                data.Columns.Add("blei_mult_bl_end", typeof(DateTime));
                data.Columns.Add("blei_bill_bat_sts", typeof(String));
                data.Columns.Add("blei_man_to_due_dt", typeof(DateTime));
                data.Columns.Add("blei_pcs_sts", typeof(String));
                data.Columns.Add("blei_suspnd_bl_ind", typeof(String));
                data.Columns.Add("blei_lst_arch_dt", typeof(DateTime));
                data.Columns.Add("blei_recon_ind", typeof(String));
                data.Columns.Add("blei_elig_upd_ind", typeof(String));
                data.Columns.Add("blei_sbsr_ind", typeof(String));
                data.Columns.Add("blei_tol_meth", typeof(String));
                data.Columns.Add("blei_remit_tol_amt", typeof(Decimal));
                data.Columns.Add("blei_remit_tol_pct", typeof(Int32));
                data.Columns.Add("blei_autorecon_ind", typeof(String));
                data.Columns.Add("blei_lock_token", typeof(Int32));
                data.Columns.Add("atxr_source_id", typeof(DateTime));
                data.Columns.Add("sys_last_upd_dtm", typeof(DateTime));
                data.Columns.Add("sys_usus_id", typeof(String));
                data.Columns.Add("sys_dbuser_id", typeof(String));
                data.Columns.Add("blei_aptc_grace_dt_nvl", typeof(DateTime));
                data.Columns.Add("ods_last_updated", typeof(DateTime));
                DateTime minDate = new DateTime(3000, 12, 31);
                DateTime maxDate = new DateTime(1900, 1, 1);
                while (thisReader.Read())
                {
                DateTime date = System.Convert.ToDateTime(thisReader.GetValue(5), CultureInfo.InvariantCulture);
                    data.Rows.Add(thisReader.GetValue(0),
                        thisReader.GetValue(1),
                        thisReader.GetValue(2),
                        thisReader.GetValue(3),
                        thisReader.GetValue(4),
                        thisReader.GetValue(5),
                        thisReader.GetValue(6),
                        thisReader.GetValue(7),
                        thisReader.GetValue(8),
                        thisReader.GetValue(9),
                        thisReader.GetValue(10),
                        thisReader.GetValue(11),
                        thisReader.GetValue(12),
                        thisReader.GetValue(13),
                        thisReader.GetValue(14),
                        thisReader.GetValue(15),
                        thisReader.GetValue(16),
                        thisReader.GetValue(17),
                        thisReader.GetValue(18),
                        thisReader.GetValue(19),
                        thisReader.GetValue(20),
                        thisReader.GetValue(21),
                        thisReader.GetValue(22),
                        thisReader.GetValue(23),
                        thisReader.GetValue(24),
                        thisReader.GetValue(25),
                        thisReader.GetValue(26),
                        thisReader.GetValue(27),
                        thisReader.GetValue(28),
                        thisReader.GetValue(29),
                        thisReader.GetValue(30),
                        thisReader.GetValue(31),
                        thisReader.GetValue(32),
                        thisReader.GetValue(33),
                        thisReader.GetValue(34),
                        thisReader.GetValue(35),
                        thisReader.GetValue(36),
                        thisReader.GetValue(37),
                        thisReader.GetValue(38),
                        thisReader.GetValue(39),
                        thisReader.GetValue(40),
                        thisReader.GetValue(41),
                        thisReader.GetValue(42),
                        thisReader.GetValue(43),
                        thisReader.GetValue(44),
                        thisReader.GetValue(45),
                        thisReader.GetValue(46),
                        thisReader.GetValue(47),
                        thisReader.GetValue(48),
                        thisReader.GetValue(49),
                        thisReader.GetValue(50),
                        thisReader.GetValue(51),
                        thisReader.GetValue(52),
                        thisReader.GetValue(53),
                        thisReader.GetValue(54),
                        thisReader.GetValue(55),
                        thisReader.GetValue(56),
                        thisReader.GetValue(57),
                        thisReader.GetValue(58),
                        thisReader.GetValue(59),
                        thisReader.GetValue(60),
                        thisReader.GetValue(61),
                        thisReader.GetValue(62),
                        thisReader.GetValue(63),
                        thisReader.GetValue(64),
                        thisReader.GetValue(65),
                        thisReader.GetValue(66),
                        thisReader.GetValue(67),
                        thisReader.GetValue(68),
                        thisReader.GetValue(69),
                        thisReader.GetValue(70),
                        thisReader.GetValue(71),
                        thisReader.GetValue(72),
                        thisReader.GetValue(73),
                        thisReader.GetValue(74),
                        thisReader.GetValue(75),
                        thisReader.GetValue(76),
                        thisReader.GetValue(77),
                        thisReader.GetValue(78),
                        thisReader.GetValue(79),
                        thisReader.GetValue(80),
                        thisReader.GetValue(81),
                        thisReader.GetValue(82),
                        thisReader.GetValue(83),
                        thisReader.GetValue(84),
                        thisReader.GetValue(85),
                        thisReader.GetValue(86),
                        thisReader.GetValue(87),
                        thisReader.GetValue(88),
                        thisReader.GetValue(89),
                        thisReader.GetValue(90),
                        thisReader.GetValue(91),
                        thisReader.GetValue(92),
                        thisReader.GetValue(93),
                        thisReader.GetValue(94),
                        thisReader.GetValue(95),
                        thisReader.GetValue(96),
                        thisReader.GetValue(97),
                        thisReader.GetValue(98),
                        thisReader.GetValue(99),
                        thisReader.GetValue(100),
                        thisReader.GetValue(101),
                        thisReader.GetValue(102),
                        thisReader.GetValue(103),
                        thisReader.GetValue(104),
                        thisReader.GetValue(105),
                        thisReader.GetValue(106),
                        thisReader.GetValue(107),
                        thisReader.GetValue(108),
                        thisReader.GetValue(109),
                        thisReader.GetValue(110),
                        thisReader.GetValue(111),
                        thisReader.GetValue(112),
                        thisReader.GetValue(113),
                        thisReader.GetValue(114),
                        thisReader.GetValue(115),
                        thisReader.GetValue(116),
                        thisReader.GetValue(117),
                        thisReader.GetValue(118),
                        thisReader.GetValue(119),
                        thisReader.GetValue(120),
                        thisReader.GetValue(121),
                        thisReader.GetValue(122),
                        thisReader.GetValue(123),
                        thisReader.GetValue(124),
                        thisReader.GetValue(125),
                        thisReader.GetValue(126),
                        thisReader.GetValue(127),
                        thisReader.GetValue(128),
                        thisReader.GetValue(129),
                        thisReader.GetValue(130),
                        thisReader.GetValue(131),
                        thisReader.GetValue(132),
                        thisReader.GetValue(133),
                        thisReader.GetValue(134),
                        thisReader.GetValue(135),
                        thisReader.GetValue(136),
                        thisReader.GetValue(137),
                        thisReader.GetValue(138),
                        thisReader.GetValue(139),
                        thisReader.GetValue(140),
                        thisReader.GetValue(141),
                        thisReader.GetValue(142),
                        thisReader.GetValue(143),
                        thisReader.GetValue(144),
                        thisReader.GetValue(145),
                        thisReader.GetValue(146),
                        thisReader.GetValue(147),
                        thisReader.GetValue(148),
                        thisReader.GetValue(149),
                        thisReader.GetValue(150),
                        thisReader.GetValue(151),
                        thisReader.GetValue(152),
                        thisReader.GetValue(153),
                        thisReader.GetValue(154),
                        thisReader.GetValue(155),
                        thisReader.GetValue(156),
                        thisReader.GetValue(157),
                        thisReader.GetValue(158),
                        thisReader.GetValue(159),
                        thisReader.GetValue(160),
thisReader.GetValue(3),
                        thisReader.GetValue(4),
                        thisReader.GetValue(5),
                        thisReader.GetValue(6),
                        thisReader.GetValue(7),
                        thisReader.GetValue(8),
                        thisReader.GetValue(9),
                        thisReader.GetValue(10),
                        thisReader.GetValue(11),
                        thisReader.GetValue(12),
                        thisReader.GetValue(13),
                        thisReader.GetValue(14),
                        thisReader.GetValue(15),
                        thisReader.GetValue(16),
                        thisReader.GetValue(17),
                        thisReader.GetValue(18),
                        thisReader.GetValue(19),
                        thisReader.GetValue(20),
                        thisReader.GetValue(21),
                        thisReader.GetValue(22),
                        thisReader.GetValue(23));
                    if (minDate > date) minDate = date;
                    if (maxDate < date) maxDate = date;

                }

                String  blei_ckList = "";
                for (int i = 0; i < tblMassSpenddownList.Rows.Count; i++)
                {
                    int j = 0;
                    while ((data.Rows.Count> j) && (System.Convert.ToInt32(tblMassSpenddownList.Rows[i][12], CultureInfo.InvariantCulture) != System.Convert.ToInt32(data.Rows[j][2], CultureInfo.InvariantCulture))) j++;

                if ((data.Rows.Count > j) && (System.Convert.ToInt32(tblMassSpenddownList.Rows[i][12], CultureInfo.InvariantCulture) != System.Convert.ToInt32(data.Rows[j][2], CultureInfo.InvariantCulture)))
                {

                        tblMassSpenddownList.Rows[i][24] = data.Rows[j][3];
                        tblMassSpenddownList.Rows[i][25] = data.Rows[j][0];
                        blei_ckList +=  data.Rows[j][0] + "{
    String sbsb_ckList = "";
    List<long> lstSbsb_ck1 = new List<long>();
    if (flgOnlyEligibleNow)
    {
        NpgsqlCommand commandAlt = new NpgsqlCommand(sqlMassSpenddownCurrentEligibilityList1 + dateCutOff.ToString() + sqlMassSpenddownCurrentEligibilityList2, connection)
        {
            CommandTimeout = 86400
        };
        await commandAlt.ExecuteNonQueryAsync();
        NpgsqlDataReader thisReaderAlt = (NpgsqlDataReader)await commandAlt.ExecuteReaderAsync();
        DateTime date = new DateTime(1900, 1, 1);
        long sbsb_ckId = 0;
        bool flag = false;
        while (thisReaderAlt.Read())
        {

            if (((flag) && (sbsb_ckId != System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture))) ||
                ((date < dateCutOff) && (dateCutOff < System.Convert.ToDateTime(thisReaderAlt.GetValue(1), CultureInfo.InvariantCulture)) && (flag) && (sbsb_ckId == System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture))))
            {
                sbsb_ckList += sbsb_ckId + ",";
                lstSbsb_ck1.Add(sbsb_ckId);
            }

            if (date < System.Convert.ToDateTime(thisReaderAlt.GetValue(1), CultureInfo.InvariantCulture))
            {
                date = System.Convert.ToDateTime(thisReaderAlt.GetValue(1), CultureInfo.InvariantCulture);
            }
            sbsb_ckId = System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture);
            flag = true;
        }
        thisReaderAlt.Close();
        commandAlt.Dispose();
    }

    String blei_ckList = "";
    DataTable tblMassSpenddownList = new DataTable();
    NpgsqlCommand command = new NpgsqlCommand(sqlMassSpenddownRates, connection)
    {
        CommandTimeout = 86400
    };
    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
    adapter.Fill(tblMassSpenddownList);
    command.Dispose();

    DateTime minDate = DateTime.MaxValue;
    DateTime maxDate = DateTime.MinValue;
    foreach (DataRow row in tblMassSpenddownList.Rows)
    {
        if (minDate > System.Convert.ToDateTime(row["eff_date"], CultureInfo.InvariantCulture))
        {
            minDate = System.Convert.ToDateTime(row["eff_date"], CultureInfo.InvariantCulture);
        }
        if (maxDate < System.Convert.ToDateTime(row["eff_date"], CultureInfo.InvariantCulture))
        {
            maxDate = System.Convert.ToDateTime(row["eff_date"], CultureInfo.InvariantCulture);
        }

    }

    blei_ckList = blei_ckList.Substring(0, blei_ckList.Length - 1);
    return new Tuple<DataTable, String, DateTime, DateTime>(tblMassSpenddownList, blei_ckList, minDate, maxDate);
}lstSbsb_ck1.Add(System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture));
date = System.Convert.ToDateTime(thisReaderAlt.GetValue(1), CultureInfo.InvariantCulture);
sbsb_ckId = System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture);
if (((string)thisReaderAlt.GetValue(2)).Trim() == "Y") flag = true;
else flag = false;

List<long> lstSbsb_ck2 = new List<long>();
if (flgOnlyWithnonZeroRates)
{
    NpgsqlCommand commandAlt = new NpgsqlCommand(sqlMassSpenddownNonZeroRatesList, connection)
    {
        CommandTimeout = 86400
    };
    await commandAlt.ExecuteNonQueryAsync();
    NpgsqlDataReader thisReaderAlt = (NpgsqlDataReader)await commandAlt.ExecuteReaderAsync();
    while (thisReaderAlt.Read())
    {
        lstSbsb_ck2.Add(System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture));
    }
}

if ((lstSbsb_ck2.Count > 0) && (lstSbsb_ck1.Count > 0))
{
    IEnumerable<long> res = lstSbsb_ck1.AsQueryable().Intersect(lstSbsb_ck2);
    foreach (long a in res) sbsb_ckList += a.ToString(CultureInfo.InvariantCulture) + ",";
    sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);
}
else if (((lstSbsb_ck2.Count == 0) && (lstSbsb_ck1.Count > 0)))
{
    foreach (long a in lstSbsb_ck1) sbsb_ckList += a.ToString(CultureInfo.InvariantCulture) + ",";
    sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);
}else if (((lstSbsb_ck2.Count > 0) && (lstSbsb_ck1.Count == 0)))
{
    foreach (long a in lstSbsb_ck2) sbsb_ckList +=  a.ToString(CultureInfo.InvariantCulture) + ",";
    sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);
}

DateTime minDate = new DateTime(3000, 12, 31);
DateTime maxDate = new DateTime(1900, 1, 1);
DataTable data = new DataTable();
data.Columns.Add("sbsb_ck", typeof(Int32));
data.Columns.Add("sbrt_eff_dt", typeof(DateTime));
data.Columns.Add("sbrt_term_dt", typeof(DateTime));
data.Columns.Add("grgr_ck", typeof(Int32));
data.Columns.Add("sbrt_sb_bill_ind", typeof(String));
data.Columns.Add("sbrt_smoker_ind", typeof(String));
data.Columns.Add("sbrt_rt_st", typeof(String));
data.Columns.Add("sbrt_rt_cnty", typeof(String));
data.Columns.Add("sbrt_rt_area", typeof(String));
data.Columns.Add("sbrt_rt_sic", typeof(String));
data.Columns.Add("sbrt_lock_token", typeof(Int32));
data.Columns.Add("atxr_source_id", typeof(DateTime));
data.Columns.Add("ods_last_updated", typeof(DateTime));
if (string.IsNullOrEmpty(sbsb_ckList))
{
    NpgsqlCommand command = new NpgsqlCommand(sqlMassSpenddownRates, connection)
    {
        CommandTimeout = 86400
    };
    command.ExecuteNonQuery();
    NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
    while (thisReader.Read())
    {
        DateTime date = System.Convert.ToDateTime(thisReader.GetValue(1), CultureInfo.InvariantCulture);
        datader.GetValue(5),
                            thisReader.GetValue(6),
                            thisReader.GetValue(7),
                            thisReader.GetValue(8),
                            thisReader.GetValue(9),
                            thisReader.GetValue(10),
                            thisReader.GetValue(11),
                            thisReader.GetValue(12));
                        if (minDate > date) minDate = date;
                        if (maxDate < date) maxDate = date;
                    }
                }                        thisReader.GetValue(5),
                            thisReader.GetValue(6),
                            thisReader.GetValue(7),
                            thisReader.GetValue(8),
                            thisReader.GetValue(9),
                            thisReader.GetValue(10),
                            thisReader.GetValue(11),
                            thisReader.GetValue(12));

                        if (minDate > date) minDate = date;
                        if (maxDate < date) maxDate = date;
                    }
                }

                return new Tuple<DataTable, String, DateTime, DateTime>(data, sbsb_ckList, minDate, maxDate);
            }

            public static async Task<Tuple<DataTable, DateTime, DateTime>> GetMassSpenddownExpenses(NpgsqlConnection connection, String sbsb_ckList)
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlMassSpenddownExpenses1 + sbsb_ckList + sqlMassSpenddownExpenses2, connection)
                {
                    CommandTimeout = 86400
                };
               command.ExecuteNonQuery();
                NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
                DataTable data = new DataTable();
                data.Columns.Add("blsb_cov_due_dt", typeof(DateTime));
                data.Columns.Add("bliv_id", typeof(String));
                data.Columns.Add("bldi_seq_no", typeof(Int32));
                data.Columns.Add("bldi_desc", typeof(String));
                data.Columns.Add("pmfa_desc", typeof(String));
                data.Columns.Add("bldi_fee_disc_amt", typeof(Decimal));
                data.Columns.Add("usus_id", typeof(String));
                thisReader.GetValue(5),
                            thisReader.GetValue(6),
                            thisReader.GetValue(7),
                            thisReader.GetValue(8),
                            thisReader.GetValue(9),
                            thisReader.GetValue(10),
                            thisReader.GetValue(11),
                            thisReader.GetValue(12));

                        if (minDate > date) minDate = date;
                        if (maxDate < date) maxDate = date;
                    }
                }

                return new Tuple<DataTable, String, DateTime, DateTime>(data, sbsb_ckList, minDate, maxDate);
            }data.Columns.Add("blei_ck", typeof(Int32));
                data.Columns.Add("blbl_due_dt", typeof(DateTime));
                data.Columns.Add("blbl_amt", typeof(Decimal));
                data.Columns.Add("blbl_pend_amt", typeof(Decimal));
                data.Columns.Add("blbl_pend_dt", typeof(DateTime));
                data.Columns.Add("blbl_pend_desc", typeof(String));
                data.Columns.Add("blbl_pend_ck", typeof(Int32));
                data.Columns.Add("blbl_pend_pend_ck", typeof(Int32));
                data.Columns.Add("blbl_pend_pend_dt", typeof(DateTime));

                DateTime minDate = new DateTime(3000, 12, 31);
                DateTime maxDate = new DateTime(1900, 1, 1);

                while (thisReader.Read())
                {
                    DateTime date = System.Convert.ToDateTime(thisReader.GetValue(1), CultureInfo.InvariantCulture);
                    data.Rows.Add(thisReader.GetValue(0),
                            thisReader.GetValue(1),
                            thisReader.GetValue(2),
                            thisReader.GetValue(3),
                            thisReader.GetValue(4),
                            thisReader.GetValue(5),
                            thisReader.GetValue(6),
                            thisReader.GetValue(7),
                            thisReader.GetValue(8)
                    );
                    if (minDate > date) minDate = date;
                    if (maxDate < date) maxDate = date;
                }
                return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
            }
            public static async Task<Tuple<DataTable, DateTime, DateTime>> GetMassSpenddownBills(NpgsqlConnection connection, String blei_ckList)
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlMassSpenddownBills1 + blei_ckList + sqlMassSpenddownBills2, connection)
                {
                    CommandTimeout = 86400
                };
                command.ExecuteNonQuery();
                NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
                DataTable data = new DataTable();
                data.Columns.Add("blei_ck", typeof(Int32));
                data.Columns.Add("blbl_due_dt", typeof(DateTime));
                data.Columns.Add("blbl_amt", typeof(Decimal));
                data.Columns.Add("blbl_pend_amt", typeof(Decimal));
                data.Columns.Add("blbl_pend_dt", typeof(DateTime));
                data.Columns.Add("blbl_pend_desc", typeof(String));
                data.Columns.Add("blbl_pend_ck", typeof(Int32));
                data.Columns.Add("blbl_pend_pend_ck", typeof(Int32));
                data.Columns.Add("blbl_pend_pend_dt", typeof(DateTime));

                DateTime minDate = new DateTime(3000, 12, 31);
                DateTime maxDate = new DateTime(1900, 1, 1);

                while (thisReader.Read())
                {
                    DateTime date = System.Convert.ToDateTime(thisReader.GetValue(1), CultureInfo.InvariantCulture);
                    data.Rows.Add(thisReader.GetValue(0),
                            thisReader.GetValue(1),
                            thisReader.GetValue(2),
                            thisReader.GetValue(3),
                            thisReader.GetValue(4),
                            thisReader.GetValue(5),
                            thisReader.GetValue(6),
                            thisReader.GetValue(7),
                            thisReader.GetValue(8)
                    );
                    if (minDate > date) minDate = date;
                    if (maxDate < date) maxDate = date;
                }
                return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
            }                data.Columns.Add("end_dt", typeof(DateTime));
                data.Columns.Add("create_dtm", typeof(DateTime));
                data.Columns.Add("dlnq_dt", typeof(DateTime));
                data.Columns.Add("billed_amt", typeof(Decimal));
                data.Columns.Add("rcvd_amt", typeof(Decimal));
                data.Columns.Add("paid_sts", typeof(String));
                data.Columns.Add("last_updated", typeof(DateTime));
                DateTime minDate = new DateTime(3000, 12, 31);
                DateTime maxDate = new DateTime(1900, 1, 1);


                while (thisReader.Read())
                {
                    DateTime date = System.Convert.ToDateTime(thisReader.GetValue(1), CultureInfo.InvariantCulture);
                    data.Rows.Add(thisReader.GetValue(0),
                            thisReader.GetValue(1),
                            thisReader.GetValue(2),
                            thisReader.GetValue(3),
                            thisReader.GetValue(4),
                            thisReader.GetValue(5),
                            thisReader.GetValue(6),
                            thisReader.GetValue(7),
                            thisReader.GetValue(8)
                    );
                    if (minDate > date) minDate = date;
                    if (maxDate < date) maxDate = date;

                }
                return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
            }

            public static async Task<Tuple<DataTable, DateTime, DateTime>> GetMassSpenddownPayments(NpgsqlConnection connection, String idList)
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlMassSpenddownPayments1 + idList + sqlMassSpenddownPayments2, connection)
                {
                    CommandTimeout = 86400
                };
      e(12));

                    if (date < minDate)
                    {
                        minDate = date;
                    }
                    if (date > maxDate)
                    {
                        maxDate = date;
                    }
                }

                thisReader.Close();
                return data;));
                DateTime minDate = DateTime.MaxValue;
                DateTime maxDate = DateTime.MinValue;
                while (thisReader.Read())
                {
                    int meme_ck = thisReader.GetInt32(0);
                    string cspd_cat = thisReader.GetString(1);
                    DateTime mepe_eff_dt = thisReader.GetDateTime(2);
                    DateTime mepe_term_dt = thisReader.GetDateTime(3);
                    DateTime mepe_create_dtm = thisReader.GetDateTime(4);
                    string cscs_id = thisReader.GetString(5);
                    int grgr_ck = thisReader.GetInt32(6);
                    int sgsg_ck = thisReader.GetInt32(7);
                    string cspi_id = thisReader.GetString(8);
                    string pdpd_id = thisReader.GetString(9);
                    string mepe_elig_ind = thisReader.GetString(10);
                    string excd_id = thisReader.GetString(11);
                    string mepe_mctr_rsn = thisReader.GetString(12);
                    string mepe_sys_inel_cd = thisReader.GetString(13);
                    string mepe_fi = thisReader.GetString(14);
                    string mepe_elig_ovr_ind = thisReader.GetString(15);

                    data.Rows.Add(meme_ck, cspd_cat, mepe_eff_dt, mepe_term_dt, mepe_create_dtm, cscs_id, grgr_ck, sgsg_ck, cspi_id, pdpd_id, mepe_elig_ind, excd_id, mepe_mctr_rsn, mepe_sys_inel_cd, mepe_fi, mepe_elig_ovr_ind);

                    DateTime date = mepe_create_dtm;
                    if (minDate > date) minDate = date;
                    if (maxDate < date) maxDate = date;

                }
                return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
            }                            thisReader.GetValue(22),
                            thisReader.GetValue(23),
                            thisReader.GetValue(24),
                            thisReader.GetValue(25),
                            thisReader.GetValue(26),
                            thisReader.GetValue(27),
                            thisReader.GetValue(28),
                            thisReader.GetValue(29),
                            thisReader.GetValue(30),
                            thisReader.GetValue(31),
                            thisReader.GetValue(32),
                            thisReader.GetValue(33),
                            thisReader.GetValue(34),
                            thisReader.GetValue(35),
                            thisReader.GetValue(36),
                            thisReader.GetValue(37),
                            thisReader.GetValue(38),
                            thisReader.GetValue(39),
                            thisReader.GetValue(40),
                            thisReader.GetValue(41),
                            thisReader.GetValue(42),
                            thisReader.GetValue(43),
                            thisReader.GetValue(44),
                            thisReader.GetValue(45),
                            thisReader.GetValue(46),
                            thisReader.GetValue(47),
                            thisReader.GetValue(48),
                            thisReader.GetValue(49),
                            thisReader.GetValue(50),
                            thisReader.GetValue(51),
                            thisReader.GetValue(52),
                            thisReader.GetValue(53),
                            thisReader.GetValue(54),
                            thisReader.GetValue(55),
                            thisReader.GetValue(56),
                            thisReader.GetValue(57),
                            thisReader.GetValue(58),
                            thisReader.GetValue(59),
                            thisReader.GetValue(60),
                            thisReader.GetValue(61),
                            thisReader.GetValue(62),
                            thisReader.GetValue(63),
                            thisReader.GetValue(64),
                            thisReader.GetValue(65),
                            thisReader.GetValue(66),
                            thisReader.GetValue(67),
                            thisReader.GetValue(68),
                            thisReader.GetValue(69),
                            thisReader.GetValue(70),
                            thisReader.GetValue(71),
                            thisReader.GetValue(72),
                            thisReader.GetValue(73),
                            thisReader.GetValue(74),
                            thisReader.GetValue(75),
                            thisReader.GetValue(76),
                            thisReader.GetValue(77),
                            thisReader.GetValue(78),
                            thisReader.GetValue(79),
                            thisReader.GetValue(80),
                            thisReader.GetValue(81),
                            thisReader.GetValue(82),
                            thisReader.GetValue(83),
                            thisReader.GetValue(84),
                            thisReader.GetValue(85),
                            thisReader.GetValue(86),
                            thisReader.GetValue(87),
                            thisReader.GetValue(88),
                            thisReader.GetValue(89),
                            thisReader.GetValue(90),
                            thisReader.GetValue(91),
                            thisReader.GetValue(92),
                            thisReader.GetValue(93),
                            thisReader.GetValue(94),
                            thisReader.GetValue(95),
                            thisReader.GetValue(96),
                            thisReader.GetValue(97),
                            thisReader.GetValue(98),
                            thisReader.GetValue(99),
                            thisReader.GetValue(100),
                            thisReader.GetValue(101),
                            thisReader.GetValue(102),
                            thisReader.GetValue(103),
                            thisReader.GetValue(104),
                            thisReader.GetValue(105),
                            thisReader.GetValue(106),
                            thisReader.GetValue(107),
                            thisReader.GetValue(108),
                            thisReader.GetValue(109),
                            thisReader.GetValue(110),
                            thisReader.GetValue(111),
                            thisReader.GetValue(112),
                            thisReader.GetValue(113),
                            thisReader.GetValue(114),
                            thisReader.GetValue(115),
                            thisReader.GetValue(116),
                            thisReader.GetValue(117),
                            thisReader.GetValue(118),
                            thisReader.GetValue(119),
                            thisReader.GetValue(120),
                            thisReader.GetValue(121),
                            thisReader.GetValue(122),
                            thisReader.GetValue(123),
                            thisReader.GetValue(124),
                            thisReader.GetValue(125),
                            thisReader.GetValue(126),
                            thisReader.GetValue(127),
                            thisReader.GetValue(128),
                            thisReader.GetValue(129),
                            thisReader.GetValue(130),
                            thisReader.GetValue(131),
                            thisReader.GetValue(132),
                            thisReader.GetValue(133),
                            thisReader.GetValue(134),
                            thisReader.GetValue(135),
                            thisReader.GetValue(136),
                            thisReader.GetValue(137),
                            thisReader.GetValue(138),
                            thisReader.GetValue(139),
                            thisReader.GetValue(140),
                            thisReader.GetValue(141),
                            thisReader.GetValue(142),
                            thisReader.GetValue(143),
                            thisReader.GetValue(144),
                            thisReader.GetValue(145),
                            thisReader.GetValue(146),
                            thisReader.GetValue(147),
                            thisReader.GetValue(148),
                            thisReader.GetValue(149),
                            thisReader.GetValue(150),
                            thisReader.GetValue(151),
                            thisReader.GetValue(152),
                            thisReader.GetValue(153),
                            thisReader.GetValue(154),
                            thisReader.GetValue(155),
                            thisReader.GetValue(156),
                            thisReader.GetValue(157),
                            thisReader.GetValue(158),
                            thisReader.GetValue(159),
                            thisReader.GetValue(160),
                            thisReader.GetValue(161),
                            thisReader.GetValue(162),
                            thisReader.GetValue(163),
                            thisReader.GetValue(164),
                            thisReader.GetValue(165),
                            thisReader.GetValue(166),
                            thisReader.GetValue(167),
                            thisReader.GetValue(168),
                            thisReader.GetValue(169),
                            thisReader.GetValue(170),
                            thisReader.GetValue(171),
                            thisReader.GetValue(172),
                            thisReader.GetValue(173),
                            thisReader.GetValue(174),
                            thisReader.GetValue(175),
                            thisReader.GetValue(176),
                            thisReader.GetValue(177),
                            thisReader.GetValue(178),
                            thisReader.GetValue(179),
                            thisReader.GetValue(180),
                            thisReader.GetValue(181),
                            thisReader.GetValue(182),
                            thisReader.GetValue(183),
                            thisReader.GetValue(184),
                            thisReader.GetValue(185),
                            thisReader.GetValue(186),
                            thisReader.GetValue(187),
                            thisReader.GetValue(188),
                            thisReader.GetValue(189),
                            thisReader.GetValue(190),
                            thisReader.GetValue(191),
                            thisReader.GetValue(192),
                            thisReader.GetValue(193),
                            thisReader.GetValue(194),
                            thisReader.GetValue(195),
                            thisReader.GetValue(196),
                            thisReader.GetValue(197),
                            thisReader.GetValue(198),
                            thisReader.GetValue(199),
                            thisReader.GetValue(200),
                            thisReader.GetValue(201),
                            thisReader.GetValue(202),
                            thisReader.GetValue(203),
                            thisReader.GetValue(204),
                            thisReader.GetValue(205),
                            thisReader.GetValue(206),
                            thisReader.GetValue(207),
                            thisReader.GetValue(208),
                            thisReader.GetValue(209),
                            thisReader.GetValue(210),
                            thisReader.GetValue(211),
                            thisReader.GetValue(212),
                            thisReader.GetValue(213),
                            thisReader.GetValue(214),
                            thisReader.GetValue(215),
                            thisReader.GetValue(216),
                            thisReader.GetValue(217),
                            thisReader.GetValue(218),
                            thisReader.GetValue(219),
                            thisReader.GetValue(220),
                            thisReader.GetValue(221),
                            thisReader.GetValue(222),
                            thisReader.GetValue(223),
                            thisReader.GetValue(224),
                            thisReader.GetValue(225),
                            thisReader.GetValue(226),
                            thisReader.GetValue(227),
                            thisReader.GetValue(228),
                            thisReader.GetValue(229),
                            thisReader.GetValue(230),
                            thisReader.GetValue(231),
                            thisReader.GetValue(232),
                            thisReader.GetValue(233),
                            thisReader.GetValue(234),
                            thisReader.GetValue(235),
                            this
thisReader.GetValue(22)
);
if (minDate > date) minDate = date;
if (maxDate < date) maxDate = date;

}
return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
}
private static string GetMassSpenddownConnectionString(string username, string password)
{
// You will need to modify this connection string to match your SQL Server Configuration
return "Server=greenplum.fideliscare.org;Database=fidprd;port=5432;User Id=" + username + ";Password=" + password;
}

}
}