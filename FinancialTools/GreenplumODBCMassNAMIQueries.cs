using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

using FinancialTools;
using FinancialTools;
using System.Globalization;

namespace FinancialTools
{
    partial class GreenplumODBC
    {


        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        /*********************************************************** MASS NAMI **************************************************************/
        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        private const string sqlMassNAMICurrentEligibilityList1 = @"SELECT DISTINCT  sbsb_ck, mepe_eff_dt, mepe_elig_ind
            FROM ODS_FACETS.cmc_mepe_prcs_elig eligibility 
            LEFT JOIN ODS_FACETS.cmc_meme_member member_ck
            ON member_ck.meme_ck = eligibility.meme_ck  
            WHERE eligibility.mepe_term_dt>NOW()
            AND eligibility.GRGR_CK IN ('9')
            AND eligibility.cspi_id IN ('NYM00000','NYM0HARP','NYMHR000','NYMMAA00','NYMN0000','NYMSSI10','MMP00000',                            
	            'MCDA0000','MCDAF000','MCDMAP00',
	            'LTCP0000','LTCPNHC0','LTCPNNH0','LTCR0000','LTCRNHC0')
            AND member_ck.meme_ck  IN (	SELECT meme_ck FROM 
					(SELECT DISTINCT ON (meme_ck) meme_ck,grgr_ck,wmds_seq_no,mewm_eff_dt AS eff_dt,mewm_term_dt,
					CASE WHEN  (lead(mewm_eff_dt- INTERVAL '1 day') over(PARTITION BY meme_ck,grgr_ck ORDER BY meme_ck,grgr_ck,wmds_seq_no,mewm_eff_dt )) IS NULL 
					THEN  mewm_term_dt 
					ELSconst string sqlMassNAMICurrentEligibilityList2 = @"' BETWEEN eff_dt AND new_term_dt))

            GROUP BY sbsb_ck, mepe_eff_dt, mepe_elig_ind
            ORDER BY sbsb_ck, mepe_eff_dt ASC ";
        const string sqlMassNAMINonZeroRatesList = @"SELECT DISTINCT sbsb_ck  FROM cmc_sbrt_rate_data WHERE GRGR_CK IN ('1','8','9','13')";
        const string sqlMassNAMIListFull = @"
            SELECT DISTINCT  ON (subscriber.sbsb_id)
					            subscriber.sbsb_id,
					            member_ck.meme_last_name,
					            member_ck.meme_first_name,
					            member_ck.meme_ssn,
					            member_ck.meme_sex,
					            member_ck.meme_birth_dt,
					            member_ck.meme_mctr_lang,
					            member_ck.meme_record_no,
					            member_ck.meme_fam_link_id, 
					            cscs_id,
					            cspi_id
				 	            pdpd_id,
				 	            excd_id,
					            subscriber.sbsb_ck,
					            member_ck.grgr_ck,
					            sgsg_ck,
					            member_ck.meme_mctr_sts,
					            member_ck.meme_ck,
				 	            cspd_cat,
				 	            mepe_elig_ind,
				 	            mepe_mctr_rsn,
				 	            mepe_sys_inel_cd,
				 	            mepe_fi,
				 	            mepe_source,
					            meme_rel,
					            sbsb_sig_dt

            FROM ODS_FACETS.cmc_mepe_prcs_elig plans
            LEFT JOIN ODS_FACETS.cmc_meme_member member_ck
            ON member_ck.meme_ck = plans.meme_ck AND member_ck.grgr_ck = plans.grgr_ck
            LEFT JOIN ODS_FACETS.cmc_sbsb_subsc subscriber
            ON member_ck.sbsb_ck = subscriber.sbsb_ck AND member_.MEPE_TERM_DT >= '01/01/2005' 
            AND plans.cspi_id IN ('NYM00000','NYM0HARP','NYMHR000','NYMMAA00','NYMN0000','NYMSSI10','MMP00000',                            
	            'MCDA0000','MCDAF000','MCDMAP00',
	            'LTCP0000','LTCPNHC0','LTCPNNH0','LTCR0000','LTCRNHC0');";
        private const string sqlMassNAMIListShort1 = @"
            SELECT DISTINCT  ON (subscriber.sbsb_id)
					            subscriber.sbsb_id,
					            member_ck.meme_last_name,
					            member_ck.meme_first_name,
					            member_ck.meme_ssn,
					            member_ck.meme_sex,
					            member_ck.meme_birth_dt,
					            member_ck.meme_mctr_lang,
					            member_ck.meme_record_no,
					            member_ck.meme_fam_link_id, 
					            cscs_id,
					            cspi_id
				 	            pdpd_id,
				 	            excd_id,
					            subscriber.sbsb_ck,
					            member_ck.grgr_ck,
					            sgsg_ck,
					            member_ck.meme_mctr_sts,
					            member_ck.meme_ck,
				 	            cspd_cat,
				 	            mepe_elig_ind,
				 	            mepe_mctr_rsn,
				 	            mepe_sys_inel_cd,
				 	            mepe_fi,
				 	            mepe_source,
					            meme_rel,
					            sbsb_sig_dt

            FROM ODS_FACETS.cmc_mepe_prcs_elig plans
            LEFT JOIN ODS_FACETS.cmc_meme_member member_ck
            ON member_ck.meme_ck = plans.meme_ck AND member_ck.grgr_ck = plans.grgr_ck
            LEFT JOIN ODS_FACETS.cmc_sbsb_subsc subscriber
            ON member_ck.sbsb_ck = subscriber.sbsb_ck AND member_ck.grgr_ck = subscriber.grgr_ck
            where subscriber.sbsb_ck IN (";
        private const string sqlMassNAMIListShort2 = @")
            AND plans.GRGR_CK IN ('9')
            AND plans.MEPE_TERM_DT >= '01/01/2005' 
            AND plans.cspi_id IN ('NYM00000','NYM0HARP','NYMHR000','NYMMAA00','NYMN0000','NYMSSI10','MMP00000',                            
	            'MCDA0000','MCDAF000','MCDMAP00',
	            'LTCP0000','LTCPNHC0','LTCPNNH0','LTCR0000','LTCRNHC0');";
        private const string sqlMassNAMIEligibility1 = @"SELECT *
            FROM ODS_FACETS.cmc_mepe_prcs_elig 
            WHERE meme_ck IN (";
        private const string sqlMassNAMINetDue1 = @"SELECT * FROM cmc_blei_enty_info WHERE blei_bill_level_ck IN (";
        private const string sqlMassNAMINetDue2 = @") ORDER BY blei_lst_bl_due_dt DESC;";

        private const string sqlMassNAMIRates = @"SELECT * FROM cmc_sbrt_rate_data;";
        private const string sqlMassNAMIRatesFromList1 = @"SELECT * FROM cmc_sbrt_rate_data WHERE sbsb_ck IN (";
        private const string sqlMassNAMIRatesFromList2 = @");";


        private const string sqlMassNAMIExpenses1 = @"SELECT DISTINCT ON (bldi_seq_no) blsb_cov_due_dt,expenses.bliv_id, bldi_seq_no, bldi_desc, pmfa_desc, bldi_fee_disc_amt,usus_id,usus_desc,sbsb_ck
                        FROM cds_indi_discretn expenses
                        JOIN cds_insb_sb_detail bills
                        ON bills.bliv_id = expenses.bliv_id
                        WHERE bills.sbsb_ck IN (";
        private const string sqlMassNAMIExpenses2 = @");";

        private const string sqlMassNAMIBills1 = @"SELECT  blei_ck,blbl_due_dt,blbl_end_dt,blbl_create_dtm,blbl_dlnq_dt,
                        blbl_billed_amt,blbl_rcvd_amt,blbl_paid_sts,ods_last_updated
                        FROM ODS_FACETS.CMC_BLBL_BILL_SUMM 
                        WHERE blbl_due_dt >= '01/01/2005' AND blbl_billed_amt<>0 AND blei_ck IN (";
        private const string sqlMassNAMIBills2 = @");";

        private const string sqlMassNAMIPayments1 = @"SELECT
                        row_number() over (PARTITION BY r.rcpt_input_sbsb_id, r.rcpt_input_grgr_id
                        ORDER BY r.rcpt_input_sbsb_id, r.rcpt_input_grgr_id, rcpt_rcvd_dt ASC) AS pos,
                        rcpt_id, r.rcpt_input_sbsb_id AS sbsb_id,
                        rcpt_rcvd_dt, rcpt_check_no, rcpt_mctr_rsn, r.rcpt_input_grgr_id AS grgr_id,
                        CASE WHEN rcpt_check_no LIKE 'EPIC%' THEN 'EPIC'
                        WHEN rcpt_check_no LIKE 'SSA%' THEN 'SSA'
                        WHEN rcpt_check_no LIKE 'H%' THEN 'HKF' ELSE 'OTHER' END AS Type,
                        to_date(CASE WHEN rcpt_check_no LIKE 'EPI%' THEN substring(rcpt_check_no from 7 for 2)||'0120' || substring(rcpt_check_no from 5 for 2)
                        WHEN rcpt_check_no LIKE 'SSA%' THEN substring(rcpt_check_no from 6 for 2)||'0120' || substring(rcpt_check_no from 4 for 2)
                        ELSE '01012199' END , 'mmddyyyy') AS DT, CASE WHEN rcpt_rcpt_cd = 'R' THEN -1 
                        WHEN rcpt_rcpt_cd = 'N' THEN -1
                        WHEN rcpt_rcpt_cd = 'S' THEN -1
                        WHEN rcpt_rcpt_cd = 'F' THEN -1
                        WHEN rcpt_rcpt_cd = 'W' THEN 1  -- write off
                        WHEN rcpt_rcpt_cd = 'V' THEN 0
                        WHEN rcpt_rcpt_cd = 'X' THEN -1 -- write off reveral
                        ELSE 1 END AS selection, rcpt_amt, 
                        CASE WHEN rcpt_rcpt_cd = 'R' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'N' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'S' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'F' THEN -1 * rcpt_amt
                        WHEN rcpt_rcpt_cd = 'W' THEN rcpt_amt
                        WHEN rcpt_rcpt_cd = 'V' THEN 0
                        WHEN rcpt_rcpt_cd = 'X' THEN -1 * rcpt_amt
                        ELSE rcpt_amt END AS applied_amt, rcpt_sts
                        FROM  ODS_FACETS.CMC_RCPT_RECEIPTS RWHERE rcpt_check_no <> 'T' AND rcpt_sts <> '97'
                        AND rcpt_rcvd_dt >= '1/1/2005'	   
                        AND rcpt_check_no NOT LIKE 'EPI%'  
                        AND rcpt_check_no NOT LIKE 'SSA%'  
                        AND rcpt_input_grgr_id IN ('FCNY0001','DUAL0001','LTCF0001')
                        AND rcpt_amt  <>0 
                        AND r.rcpt_input_sbsb_id IN (";
        private const string sqlMassNAMIPayments2 = @");";