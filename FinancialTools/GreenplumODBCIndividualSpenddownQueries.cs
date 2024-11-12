FinancialTools
{
    partial class GreenplumODBC
    {
        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        /****************************************************** INDIVIDUAL SPENDDOWN ********************************************************/
        /************************************************************************************************************************************/
        /************************************************************************************************************************************/

        private const string sqlIndividualSpenddownEligibility1 = @"SELECT *
            FROM ODS_FACETS.cmc_mepe_prcs_elig eligibility
            JOIN ODS_FACETS.cmc_meme_member link
            ON link.meme_ck= eligibility.meme_ck
            JOIN ODS_FACETS.CMC_SBSB_SUBSC subscriber
            ON link.sbsb_ck= subscriber.sbsb_ck
            WHERE eligibility.grgr_ck = 9  AND subscriber.sbsb_id= '";
        private const string sqlIndividualSpenddownEligibility2 = @"';";

        private const string sqlIndividualSpenddownNetDue1 = @"SELECT * FROM cmc_blei_enty_info WHERE blei_ck IN 
                        (SELECT DISTINCT blei_ck FROM cmc_blei_enty_info WHERE blei_bill_level_ck IN
                        (SELECT DISTINCT sbsb_ck FROM ODS_FACETS.CMC_SBSB_SUBSC WHERE sbsb_id='";
        private const string sqlIndividualSpenddownNetDue2 = @"')) ORDER BY blei_lst_bl_due_dt DESC LIMIT 1;";

        private const string sqlIndividualSpenddownRates1 = @"SELECT * FROM cmc_sbrt_rate_data x 
                    JOIN  ODS_sqlIndividualSpenddownRates2 = @"';";

private const string sqlIndividualSpenddownExpenses1 = @"SELECT expense.blbl_due_dt,expense.bldi_seq_no,expense.bldi_desc,expense.bldi_fee_disc_amt,
                    expense.usus_id,subscriber.sbsb_id,subscriber.sbsb_first_name,subscriber.sbsb_last_name FROM cmc_bldi_discretn expense 
                    JOIN cmc_blei_enty_info blei
                     ON expense.blei_ck=blei.blei_ck 
                    JOIN CMC_SBSB_SUBSC subscriber 
                    ON blei.blei_bill_level_ck = subscriber.sbsb_ck
                    WHERE  subscriber.sbsb_id=';";

private const string sqlIndividualSpenddownExpenses2 = @"' AND expense .bldi_seq_no IN
                    (SELECT DISTINCT bldi_seq_no FROM cds_indi_discretn WHERE bliv_id IN
                    (SELECT DISTINCT bliv_id FROM cds_insb_sb_detail WHERE sbsb_ck IN
                    (SELECT DISTINCT sbsb_ck FROM CMC_SBSB_SUBSC WHERE sbsb_id='";
private const string sqlIndividualSpenddownExpenses3 = @"')));";

private const string sqlIndividualSpenddownBills1 = @"SELECT
                        ss.sbsb_id,ss.sbsb_first_name,ss.sbsb_last_name,ss.sbsb_ck,bill.blei_ck,bill.blbl_due_dt,bill.blbl_end_dt,bill.blbl_create_dtm,bill.blbl_dlnq_dt,
                        bill.blbl_billed_amt,bill.blbl_rcvd_amt,bill.blbl_paid_sts,blei.blei_net_due,bill.ods_last_updated
                        FROM CMC_BLBL_BILL_SUMM bill
                        JOIN cmc_blei_enty_info blei
                        ON bill.blei_ck = blei.blei_ck
                        JOIN CMC_SBSB_SUBSC ss
                        ON blei.blei_bill_level_ck = ss.sbsb_ck
                        WHERE blbl_due_dt >= '01/01/2005' AND bill.blbl_billed_amt<>0  AND ss.sbsb_id='";sqlIndividualSpenddownBills2 = @"';";

        private const string sqlIndividualSpenddownPayments1 = @"SELECT
                        row_number() over (PARTITION BY r.rcpt_input_sbsb_id,r.rcpt_input_grgr_id
                        ORDER BY r.rcpt_input_sbsb_id,r.rcpt_input_grgr_id, rcpt_rcvd_dt ASC)AS pos,
                        rcpt_id, r.rcpt_input_sbsb_id AS sbsb_id,
                        rcpt_rcvd_dt, rcpt_check_no, rcpt_mctr_rsn,r.rcpt_input_grgr_id AS grgr_id,
                        CASE WHEN rcpt_check_no LIKE 'EPIC%' THEN 'EPIC'
                        WHEN rcpt_check_no LIKE 'SSA%' THEN 'SSA'
                        WHEN rcpt_check_no LIKE 'H%' THEN 'HKF' ELSE 'OTHER' END AS Type,
                        to_date(CASE WHEN rcpt_check_no LIKE 'EPI%' THEN substring(rcpt_check_no from 7 for 2)||'0120' || substring(rcpt_check_no from 5 for 2)
                        WHEN rcpt_check_no LIKE 'SSA%' THEN substring(rcpt_check_no from 6 for 2)||'0120' || substring(rcpt_check_no from 4 for 2)
                        ELSE '01012199' END , 'mmddyyyy') AS DT, CASE WHEN rcpt_rcpt_cd = 'R' THEN -1 
                        WHEN rcpt_rcpt_cd = 'N' THEN -1
                        WHEN rcpt_rcpt_cd = 'S' THEN -1
                        WHEN rcpt_rcpt_cd = 'F' THEN -1
                        WHEN rcpt_rcpt_cd = 'W' THEN 1
                        WHEN rcpt_rcpt_cd = 'V' THEN 0
                        WHEN rcpt_rcpt_cd = 'X' THEN -1
                        ELSE 1 END AS selection, rcpt_amt, 
                        CASE WHEN rcpt_rcpt_cd = 'R' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'N' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'S' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'F' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'W' THEN rcpt_amt
                        WHEN rcpt_rcpt_cd = 'V' THEN 0
                        WHEN rcpt_rcpt_cd = 'X' THEN -1 * rcpt_amt
                        ELSE rcpt_amt END AS applied_amt, rcpt_sts
                        FROM  [REMOVED].CMC_RCPT_RECEIPTS R
                        WHERE rcpt_check_no <> 'T' AND rcpt_sts <> '97'
                        AND rcpt_rcvd_dt >= '1/1/2005'	   
                        AND rcpt_check_no NOT LIKE 'EPI%'  
                        AND rcpt_check_no NOT LIKE 'SSA%'  
                        AND rcpt_input_grgr_id IN ('FCNY0001','DUAL0001','LTCF0001')
                        AND rcpt_amt  <>0 
                        AND r.rcpt_input_sbsb_id='";
        private const string sqlIndividualSpenddownPayments2 = @"';";

        /*public static async Task RunSerialAsync(string username, string password, string id)
        {
            string connectionString = GetConnectionString(username, password);
            using (var awConnection =
                new NpgsqlConnection(connectionString))
            {
                awConnection.Open();
                var multiple = await GetNetDueAmount(awConnection, id);
                var single = await GetRates(awConnection, id);
                Console.WriteLine("Multiple Price Entity Count: {0}", multiple);
                Console.WriteLine("Single Price Entity Count: {0}", single);
                awConnection.Close();
            }
        }*/
        
    }
}