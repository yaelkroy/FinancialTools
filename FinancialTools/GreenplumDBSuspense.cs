The code provided contains database names, table names, and connection strings that should not be made public. It is recommended to avoid sharing such information online for security reasons. If you need help with specific parts of the code or have any questions, feel free to ask.char(35)     NULL ,
                            MEME_MID_NAME           char(15)     NULL ,
                            SBSB_MID_NAME           char(15)     NULL ,
                            MEME_DOB                date    NULL ,
                            SBSB_DOB                date    NULL ,
                            MEME_GENDER             char(1)      NULL ,
                            SBSB_GENDER             char(1)      NULL ,
                            MEME_SSN                char(9)      NULL ,
                            MEME_ADDR1              char(30)     NULL ,
                            MEME_ADDR2              char(30)     NULL ,
                            MEME_CITY               char(20)     NULL ,
                            MEME_STATE              char(2)      NULL ,
                            MEME_ZIP                char(10)     NULL ,
                            MEME_COUNTRY            char(3)      NULL ,
                            SBSB_ADDR1              char(30)     NULL ,
                            SBSB_ADDR2              char(30)     NULL ,
                            SBSB_CITY               char(20)     NULL ,
                            SBSB_STATE              char(2)      NULL ,
                            SBSB_ZIP                char(10)     NULL ,
                            SBSB_COUNTRY            char(3)      NULL ,
                            SBSB_PHONE              char(10)     NULL ,
                            SBSB_EMAIL              char(30)     NULL ,
                            MEME_PHONE              char(10)     NULL ,
                            MEME_EMAIL              char(30)     NULL ,
                            MEME_DECEASED_IND       char(1)      NULL ,
                            MEME_DECEASED_DT        date    NULL ,
                            SBSB_DECEASED_IND       char(1)      NULL ,
                            SBSB_DECEASED_DT        date    NULL ,
                            MEME_ALT_ADDR1          char(30)     NULL ,
                            MEME_ALT_ADDR2          char(30)     NULL ,
                            MEME_ALT_CITY           char(20)     NULL ,
                            MEME_ALT_STATE          char(2)      NULL ,
                            MEME_ALT_ZIP            char(10)     NULL ,
                            MEME_ALT_COUNTRY        char(3)      NULL ,
                            MEME_ALT_PHONE          char(10)     NULL ,
                            MEME_ALT_EMAIL          char(30)     NULL ,
                            MEME_ALT_CNTCT_REL      char(30)     NULL ,
                            SBSB_ALT_ADDR1          char(30)     NULL ,
                            SBSB_ALT_ADDR2          char(30)     NULL ,
                            SBSB_ALT_CITY           char(20)     NULL ,
                            SBSB_ALT_STATE          char(2)      NULL ,
                            SBSB_ALT_ZIP            char(10)     NULL ,
                            SBSB_ALT_COUNTRY        char(3)      NULL ,
                            SBSB_ALT_PHONE          char(10)     NULL ,
                            SBSB_ALT_EMAIL          char(30)     NULL ,
                            SBSB_ALT_CNTCT_REL      char(30)     NULL ,
                            MEME_ALT_CNTCT_REL      char(30)     NULLchar(35)     NULL ,
                            MCRP_ADDR1              char(40)     NULL ,
                            MCRP_ADDR2              char(40)     NULL ,
                            MCRP_ADDR3              char(40)     NULL ,
                            MCRP_CITY               char(19)     NULL ,
                            MCRP_STATE              char(2)      NULL ,
                            MCRP_ZIP                char(11)     NULL ,
                            CSPI_ID_RCPT            char(8)      NULL,
                            ATXR_SOURCE_ID          timestamp ,
                            HBX_AC_Policy_Number    char(255) 
    
                        )distributed by (BLEI_CK );
                        --Version 1.4 changes begin
                        CREATE TABLE Sandbox.FinancialTools_temp_MAX_MERP_DATE AS
                        SELECT 
                                        MEME_CK,
                                        MAX(MERP_EFF_DT) AS MAX_MERP_EFF_DT
                        FROM 
                                        ODS_FACETS.CMC_MERP_RELATION
                        GROUP BY 
                                        MEME_CK;
                        --Version 1.4 changes end
                        /*************************************************************************************/
                        INSERT INTO Sandbox.FinancialTools_temp_TMP_FIN150
                        (
                            RCPT_RCVD_DT            ,
                            RCPT_MCTR_RSN           ,
                            RCPT_RCPT_CD            ,
                            RCPT_ID                 ,
                            BLEI_NET_DUE            ,
                            BLBL_BILLED_AMT         ,
                            BLEI_CK                 ,
                            MEPE_TERM_DT            , 
                             MEPE_ELIG_IND          ,
                            BLEI_LST_BL_DUE_DT,
                            Household_Amt_due_IND,
                            GRGR_ID,
                            GRGR_CK,
                            MCRP_ID,
                            MEME_FAM_LINK_ID,
                            MEME_CK,
                            SBSB_ID,
                            CSPI_ID,
                            BLEI_PCS_STS,
                            BLEI_NET_ALLOC_SUSP,
                            SBSB_FIRST_NAME,
                            SBSB_LAST_NAME,
                            CSCS_ID,
                            MEME_FIRST_NAME,
                            MEME_LAST_NAME,
                            MCRP_FIRST_NAME,
                            MCRP_LAST_NAME,
                            MCRP_ADDR1,
                            MCRP_ADDR2,
                            MCRP_ADDR3,
                            MCRP_CITY,
                            MCRP_STATE,
                            MCRP_ZIP,
                            ATXR_SOURCE_ID
                        )

                        SELECT DISTINCT
                        RCPT.RCPT_RCVD_DT,
                        RCPT.RCPT_MCTR_RSN,
                        RCPT_RCPT_CD,
                        RCPT_ID,
                        BLEI.BLEI_NET_DUE,
                        BLBL_BILLED_AMT,
                        BLEI.BLEI_CK,
                        MEPE.MEPE_TERM_DT,MEPE_ELIG_IND,
                          BLEI_LST_BL_DUE_DT,
                            'N' AS Household_Amt_due_IND,
                            GRGR.GRGR_ID,
                            MEME.GRGR_CK,
                           MCRP.MCRP_ID,
                            MEME_FAM_LINK_ID,
                            MEME.MEME_CK,
                            SBSB_ID,
                            CSPI_ID,
                            BLEI_PCS_STS,
                            BLEI_NET_ALLOC_SUSP,
                            RTRIM(SBSB_FIRST_NAME),
                            RTRIM(SBSB_LAST_NAME),
                            MEPE.CSCS_ID,
                            MEME_FIRST_NAME,
                            MEME_LAST_NAME,  
                            MCRP.MCRP_FIRST_NAME,
                            MCRP.MCRP_LAST_NAME,
                            MCRP_ADDR1,
                           MCRP_ADDR2,
                           MCRP_ADDR3,
                           MCRP_CITY,
                           MCRP_STATE,
                            MCRP_ZIP,
                            SBSB.ATXR_SOURCE_ID

                        From 
                            ODS_FACETS.CMC_BLEI_ENTY_INFO                   BLEI   INNER JOIN
                             ODS_FACETS.CMC_SBSB_SUBSC                      SBSB
                             ON   BLEI.BLEI_BILL_LEVEL_CK = SBSB.SBSB_CK
                             AND BLEI_BILL_LEVEL = 'I'
                             AND BLEI_NET_DUE <> BLEI_NET_ALLOC_SUSP
                             AND BLEI.BLEI_NET_ALLOC_SUSP > 0
                        INNER JOIN
                             ODS_FACETS.CMC_MEME_MEMBER                     MEME
                             ON  SBSB.SBSB_CK = MEME.SBSB_CK
                             AND SBSB.GRGR_CK = MEME.GRGR_CK
                             AND MEME_SFX = 0    
                        LEFT JOIN
                             ODS_FACETS.CMC_MEPE_PRCS_ELIG                  MEPE
                             ON  MEPE.MEME_CK = MEME.MEME_CK
                             AND MEPE.GRGR_CK = MEME.GRGR_CK
                             AND CURRENT_TIMESTAMP BETWEEN MEPE.MEPE_EFF_DT AND MEPE.MEPE_TERM_DT 
         
                        INNER JOIN
                             ODS_FACETS.CMC_GRGR_GROUP GRGR
                             ON  MEME.GRGR_CK = GRGR.GRGR_CK
                             AND GRGR_ID NOT LIKE 'PEND%'

                        LEFT JOIN
                        --Version 1.4 changes begin 
                                        (SELECT MERP1.MEME_CK,MERP1.GRGR_CK,MERP1.MCRP_ID FROM 
                                       ODS_FACETS.CMC_MERP_RELATION MERP1                  
                             INNER JOIN
                                                        Sandbox.FinancialTools_temp_MAX_MERP_DATE MAX_MERP
                                        ON 
                                                        MAX_MERP.MEME_CK = MERP1.MEME_CK
                                        AND 
                                                        MAX_MERP.MAX_MERP_EFF_DT = MERP1.MERP_EFF_DT)           MERP
                        --     ODS_FACETS.CMC_MERP_RELATION MERP
--Version 1.4 changes end

ON MEME.MEME_CK = MERP.MEME_CK
AND MEME.GRGR_CK = MERP.GRGR_CK
LEFT JOIN
ODS_FACETS.CMC_MCRP_RELAT_PER MCRP
ON MERP.MCRP_ID = MCRP.MCRP_ID

LEFT JOIN
ODS_FACETS.CMC_BLBL_BILL_SUMM BLBL
ON BLEI.BLEI_CK = BLBL.BLEI_CK
AND BLBL.BLBL_DUE_DT = BLEI.BLEI_LST_BL_DUE_DT

INNER JOIN
ODS_FACETS.CMC_RCPT_RECEIPTS RCPT
ON BLEI.BLEI_CK = RCPT.BLEI_CK
AND RCPT.RCPT_INPUT_SBSB_ID = SBSB.SBSB_ID
AND RCPT_RCVD_DT = (SELECT MAX(RCPT3.RCPT_RCVD_DT)
FROM ODS_FACETS.CMC_RCPT_RECEIPTS RCPT3
WHERE RCPT.BLEI_CK = RCPT3.BLEI_CK
AND RCPT.RCPT_INPUT_SBSB_ID = RCPT3.RCPT_INPUT_SBSB_ID );

----checked

DROP TABLE IF EXISTS Sandbox.FinancialTools_temp_TMP_FIN150_MAX_EFF_DT;
CREATE TABLE Sandbox.FinancialTools_temp_TMP_FIN150_MAX_EFF_DT AS
select
SBSB.SBSB_ID,
max(MEPE.MEPE_EFF_DT) AS MEPE_EFF_DT,
max(SBSB.SBSB_ORIG_EFF_DT) AS SBSB_ORIG_EFF_DT

FROM
Sandbox.FinancialTools_temp_TMP_FIN150 TMP
INNER JOIN
ODS_FACETS.CMC_SBSB_SUBSC SBSBON TMP.SBSB_ID = SBSB.SBSB_ID       
                        INNER JOIN
                             ODS_FACETS.CMC_MEME_MEMBER         MEME
                             ON  SBSB.SBSB_CK = MEME.SBSB_CK
                             AND SBSB.GRGR_CK = MEME.GRGR_CK
                             AND MEME_SFX = 0    
                        INNER JOIN
                             ODS_FACETS.CMC_MEPE_PRCS_ELIG             MEPE
                             ON  MEPE.MEME_CK = MEME.MEME_CK
                             AND MEPE.GRGR_CK = MEME.GRGR_CK
                             AND MEPE.MEPE_TERM_DT=
                                  (SELECT MAX(MEPE2.MEPE_TERM_DT) 
                                    FROM ODS_FACETS.CMC_MEPE_PRCS_ELIG  MEPE2
                                         WHERE MEPE.MEME_CK = MEPE2.MEME_CK
                                           AND MEPE.GRGR_CK = MEPE2.GRGR_CK      
                                   )     
                            GROUP BY SBSB.SBSB_ID; 


                        UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                            SET
                                MCRP_ID            = SBSB.SBSB_ID,      
                                MCRP_FIRST_NAME              = SBSB.SBSB_FIRST_NAME,
                                MCRP_LAST_NAME  = SBSB.SBSB_LAST_NAME,
                                MCRP_ADDR1       = TRIM(SBAD.SBAD_ADDR1) ,
                                MCRP_ADDR2       = TRIM(SBAD.SBAD_ADDR2) ,
                                MCRP_ADDR3       = TRIM(SBAD.SBAD_ADDR3) ,
                                MCRP_CITY        = TRIM(SBAD.SBAD_CITY)  ,
                                MCRP_STATE       = SBAD.SBAD_STATE       ,
                                MCRP_ZIP         = SBAD.SBAD_ZIP
                                                                                


                        from
                            ODS_FACETS.CMC_SBSB_SUBSC           SBSB  --- ON TMP.SBSB_ID = SBSB.SBSB_ID
INNER JOIN ODS_FACETS.CMC_SBAD_ADDR SBAD
ON SBSB.GRGR_CK = SBAD.GRGR_CK
AND SBSB.SBSB_CK = SBAD.SBSB_CK
AND SBSB.SBAD_TYPE_MAIL = SBAD.SBAD_TYPE
INNER JOIN Sandbox.FinancialTools_temp_TMP_FIN150_MAX_EFF_DT MAX
ON MAX.SBSB_ID = SBSB.SBSB_ID
AND MAX.SBSB_ORIG_EFF_DT= SBSB.SBSB_ORIG_EFF_DT
WHERE TMP.SBSB_ID = SBSB.SBSB_ID
AND MCRP_ID IS NULL ;

UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
SET
CSPI_ID_RCPT = MEPE.CSPI_ID
FROM ODS_FACETS.CMC_MEPE_PRCS_ELIG MEPE
where TMP.MEME_CK = MEPE.MEME_CK
AND TMP.RCPT_RCVD_DT BETWEEN MEPE.MEPE_EFF_DT AND MEPE.MEPE_TERM_DT ;

DROP table IF EXISTS Sandbox.FinancialTools_temp_TMP_BILLED ;
CREATE TABLE Sandbox.FinancialTools_temp_TMP_BILLED AS
SELECT
SBSB_ID,
SUM(BLBL.BLBL_BILLED_AMT) AS Total_Billed_Amount
FROM
Sandbox.FinancialTools_temp_TMP_FIN150 TMP
INNER JOIN ODS_FACETS.CMC_BLBL_BILL_SUMM BLBL
ON TMP.BLEI_CK = BLBL.BLEI_CK
GROUP BY
SBSB_ID;

UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
SETTotal_Billed_Amount = BILLED.Total_Billed_Amount
                        FROM
                            Sandbox.FinancialTools_temp_TMP_BILLED       BILLED
                           WHERE  TMP.SBSB_ID = BILLED.SBSB_ID   ;

                         DROP TABLE IF EXISTS  Sandbox.FinancialTools_temp_TMP_PMT;
                        CREATE TABLE  Sandbox.FinancialTools_temp_TMP_PMT AS 
    
                          SELECT
                            RCPT.BLEI_CK,
                            RCPT.RCPT_MCTR_RSN,
                            SUM(BLRC.BLRC_AMT) AS Payment

                        FROM
                             Sandbox.FinancialTools_temp_TMP_FIN150                    TMP    
                        INNER JOIN
                            ODS_FACETS.CMC_RCPT_RECEIPTS    RCPT
                            ON RCPT.RCPT_INPUT_SBSB_ID = TMP.SBSB_ID
                            AND  TMP.BLEI_CK = RCPT.BLEI_CK
                        INNER JOIN
                            ODS_FACETS.CMC_BLRC_BILL_RCPT   BLRC
                            ON TMP.BLEI_CK = BLRC.BLEI_CK
                             AND RCPT.RCPT_ID = BLRC.RCPT_ID
                        GROUP BY
                            RCPT.BLEI_CK,
                            RCPT.RCPT_MCTR_RSN;
                        --- checked
                        UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                            SET    
                                TOT_HKF = Payment 
                        FROM
                        Sandbox.FinancialTools_temp_TMP_PMT       PMT
                        where TMP.BLEI_CK = PMT.BLEI_CK
                            AND PMT.RCPT_MCTR_RSN = 'HKF' ;

                         UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                            SET    
                                TOT_SSA = Payment 
                        FROM 
                             Sandbox.FinancialTools_temp_TMP_PMT       PMT
                        WHERE TMP.BLEI_CK = PMT.BLEI_CK
                            AND PMT.RCPT_MCTR_RSN = 'SSA' ;
                        -----------------------------------------------
                        UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                            SET    
                                TOT_EPIC = Payment 
                        FROM
                        Sandbox.FinancialTools_temp_TMP_PMT       PMT
                        WHERE  TMP.BLEI_CK = PMT.BLEI_CK
                            AND PMT.RCPT_MCTR_RSN = 'EPIC' ;
  
                         DROP TABLE IF EXISTS Sandbox.FinancialTools_temp_TMP_OTHER_RCPT; 
                          CREATE TABLE Sandbox.FinancialTools_temp_TMP_OTHER_RCPT as
                        SELECT 
                            SUM(Payment) AS OTHER_RCPT,
                            PMT.BLEI_CK

                        FROM 
                            Sandbox.FinancialTools_temp_TMP_FIN150            TMP
                        INNER JOIN 
                            Sandbox.FinancialTools_temp_TMP_PMT         PMT
                            ON TMP.BLEI_CK = PMT.BLEI_CK
                            AND PMT.RCPT_MCTR_RSN NOT IN ('EPIC','HKF','SSA')
                        GROUP BY 
                            PMT.BLEI_CK ;


                        UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                            SET    
                                OTHER_RCPT = RCPT.OTHER_RCPT
                        FROM 
                        Sandbox.FinancialTools_temp_TMP_OTHER_RCPT        RCPT
                        where TMP.BLEI_CK = RCPT.BLEI_CK   ;

                        DROP TABLE IF EXISTS Sandbox.FinancialTools_temp_TMP_AMT_DUE;
                        CREATE TABLE Sandbox.FinancialTools_temp_TMP_AMT_DUE as
                        SELECT
                            MCRP_ID,
                            SUM(BLEI.BLEI_NET_DUE) AS Household_Amt_due                            MCRP_ID                                 ,
                            BLEI.BLEI_CK                            ,
                            BLEI.BLEI_ID                            ,
                            TMP.ATXR_SOURCE_ID                      ,
                            TMP.HBX_AC_Policy_Number                ,
                            TMP.Household_Amt_due                   ,
                            TMP.Household_Amt_due_IND
                        FROM
                            Sandbox.FinancialTools_temp_TMP_FIN150     TMP 
                        INNER JOIN
                             ODS_FACETS.CMC_BLEI_ENTY_INFO   BLEI   
                             ON TMP.BLEI_CK = BLEI.BLEI_CK 
    
                        GROUP BY
                            MCRP_ID  ;             
            
                        UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                            SET
                                Household_Amt_due = AMT.Household_Amt_due
                        FROM
                            Sandbox.FinancialTools_temp_TMP_AMT_DUE    AMT
                            WHERE TMP.MCRP_ID = AMT.MCRP_ID   ;
  
  
                        UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                            SET
                                Household_Amt_due_IND = 'Y'
                        WHERE Household_Amt_due > 0    ;

                        UPDATE Sandbox.FinancialTools_temp_TMP_FIN150 TMP
                        SET HBX_AC_Policy_Number  = ATXR_DESC 
                        FROM ODS_FACETS.CER_ATXR_ATTACH_U ATXR
                        WHERE ATXR.ATXR_SOURCE_ID = TMP.ATXR_SOURCE_ID 
                        AND ATXR.ATSY_ID ='HPOL';

                        DROP TABLE IF EXISTS sandbox.FinancialTools_fda_vh_fin150;

                        CREATE TABLE sandbox.FinancialTools_fda_vh_fin150 as
                        SELECT DISTINCT
                            GRGR_ID                                 ,
                            MCRP_ID                                 ,
                            BLEI.BLEI_CK                            ,
                            BLEI.BLEI_ID                            ,
                            TMP.ATXR_SOURCE_ID                      ,
                            TMP.HBX_AC_Policy_Number                ,
                            TMP.Household_Amt_due                   ,
                            TMP.Household_Amt_due_IND;MCRP_ID,
MEME_FAM_LINK_ID,
SBSB_ID,
CSPI_ID,
BLEI_PCS_STS,
MEPE_ELIG_IND AS Eligibility_Indicator,
CSPI_ID_RCPT,
Total_Billed_Amount,
TOT_HKF AS Total_HKF_Payment,
TOT_SSA AS Total_SSA_Payment,
TOT_EPIC AS Total_EPIC_Payment,
OTHER_RCPT AS Other_Receipt_Activity,
BLEI_NET_DUE AS Total_Net_Due,
RCPT_RCVD_DT AS Last_Receipt_Date,
RCPT_MCTR_RSN AS Last_Receipt_Reason,
RCPT_RCPT_CD AS Last_Payment_Type,
Household_Amt_due_IND,
Household_Amt_due,
BLEI_NET_ALLOC_SUSP,
SBSB_FIRST_NAME,
SBSB_LAST_NAME,
CSCS_ID,
MEME_FIRST_NAME,
MEME_LAST_NAME,
MCRP_FIRST_NAME,
MCRP_LAST_NAME,
MCRP_ADDR1,
MCRP_ADDR2.          MCRP_ADDR3                              ,
                            MCRP_CITY                               ,
                            MCRP_STATE                              ,
                            MCRP_ZIP    ,
                            HBX_AC_Policy_Number         
                        FROM 
                            Sandbox.FinancialTools_temp_TMP_FIN150 
						
                        ORDER BY  
                            GRGR_ID             , 
                            MCRP_ID             , 
                            SBSB_ID;



                          ALTER TABLE sandbox.FinancialTools_fda_vh_fin150  ADD COLUMN id INTEGER;
                          CREATE SEQUENCE sandbox.test_id_seq OWNED BY sandbox.FinancialTools_fda_vh_fin150.id;
                          ALTER TABLE sandbox.FinancialTools_fda_vh_fin150 ALTER COLUMN id SET DEFAULT nextval('sandbox.test_id_seq');
                          UPDATE sandbox.FinancialTools_fda_vh_fin150  SET id = nextval('sandbox.test_id_seq');
  
                        drop table if exists  Sandbox.FinancialTools_temp_TMP_FIN150 ;
                        drop table if exists  Sandbox.FinancialTools_temp_TMP_BILLED ;
                        drop table if exists Sandbox.FinancialTools_temp_TMP_PMT ;
                        drop table if exists Sandbox.FinancialTools_temp_TMP_OTHER_RCPT ;
                        drop table if exists  Sandbox.FinancialTools_temp_TMP_AMT_DUE ; 
                        DROP TABLE IF EXISTS Sandbox.FinancialTools_temp_MAX_MERP_DATE;    --Version 1.4 changes

						delete from sandbox.fda_vh_fin150_10102018;
						INSERT INTO sandbox.fda_vh_fin150_10102018  
						(SELECT id,
						grgr_id,
						mcrp_id,
						meme_fam_link_id,
						sbsb_id,
						cspi_id,
						blei_pcs_sts,
						eligibility_indicator,
						cspi_id_rcpt,
						total_billed_amount,
						total_hkf_payment,
						total_ssa_payment,
						total_epic_payment,
			if (objProgress != null) objProgress.ReportProgress(srcPercentage + 1);

			DataTable tblAllYears = new DataTable();
			tblAllYears.Columns.Add("Report_date", typeof(DateTime));
			tblAllYears.Columns.Add("comment", typeof(string));
			tblAllYears.Columns.Add("action", typeof(string));
			tblAllYears.Columns.Add("year_", typeof(int));
			tblAllYears.Columns.Add("detail", typeof(string));
			tblAllYears.Columns.Add("other_receipt_activity", typeof(string));
			tblAllYears.Columns.Add("total_net_due", typeof(decimal));
			tblAllYears.Columns.Add("last_receipt_date", typeof(DateTime));
			tblAllYears.Columns.Add("last_receipt_reason", typeof(string));
			tblAllYears.Columns.Add("last_payment_type", typeof(string));
			tblAllYears.Columns.Add("household_amt_due_ind", typeof(string));
			tblAllYears.Columns.Add("household_amt_due", typeof(decimal));
			tblAllYears.Columns.Add("blei_net_alloc_susp", typeof(decimal));
			tblAllYears.Columns.Add("sbsb_first_name", typeof(string));
			tblAllYears.Columns.Add("sbsb_last_name", typeof(string));
			tblAllYears.Columns.Add("cscs_id", typeof(int));
			tblAllYears.Columns.Add("hbx_ac_policy_number", typeof(string));
			tblAllYears.Columns.Add("meme_first_name", typeof(string));
			tblAllYears.Columns.Add("meme_last_name", typeof(string));
			tblAllYears.Columns.Add("mcrp_first_name", typeof(string));
			tblAllYears.Columns.Add("mcrp_last_name", typeof(string));

			string query = @"
SELECT Report_date,
						comment,
						action,
						year_,
						detail,
						other_receipt_activity,
						total_net_due,
						last_receipt_date,
						last_receipt_reason,
						last_payment_type,
						household_amt_due_ind,
						household_amt_due,
						blei_net_alloc_susp,
						sbsb_first_name,
						sbsb_last_name,
						cscs_id,
						hbx_ac_policy_number,
						meme_first_name,
						meme_last_name,
						mcrp_first_name,
						mcrp_last_name FROM sandbox.FinancialTools_fda_vh_fin150) ;
                        ";

  
            NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection)
                {
                    CommandTimeout = 0
                };
                
                command.ExecuteNonQuery();
                

                connection.Close();
                if (objProgress != null) objProgress.ReportProgress(10);

            }
            catch (NpgsqlException e)
            {
                if (connection != null)
                    connection.Close();
                throw new NpgsqlException(@"Greenplum database error: " + e.ToString(), e);
                
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            
        }tblAllYears.Columns.Add("unmatch_t_trxs", typeof(string));
			tblAllYears.Columns.Add("has_match_t_trxs", typeof(string));
			tblAllYears.Columns.Add("grgr_id", typeof(string));
			tblAllYears.Columns.Add("sbsb_id", typeof(string));
			tblAllYears.Columns.Add("cspi_id", typeof(string));
			tblAllYears.Columns.Add("has_2_accts_in_suspence", typeof(string));
			tblAllYears.Columns.Add("last_receipt_date", typeof(DateTime));
			tblAllYears.Columns.Add("last_receipt_reason", typeof(string));
			tblAllYears.Columns.Add("last_payment_type", typeof(string));
			tblAllYears.Columns.Add("suspence_fin", typeof(decimal));
			tblAllYears.Columns.Add("suspence_cspi_id", typeof(string));
			tblAllYears.Columns.Add("suspence_eff_start_date", typeof(string));
			tblAllYears.Columns.Add("suspence_eff_end_date", typeof(string));
			tblAllYears.Columns.Add("elig_suspence_cspi_id", typeof(string));
			tblAllYears.Columns.Add("elig_suspence_term_code", typeof(string));
			tblAllYears.Columns.Add("elig_suspence_term_descp", typeof(string));
			tblAllYears.Columns.Add("elig_suspence_eff_dt", typeof(string));
			tblAllYears.Columns.Add("other_policy_grgr", typeof(string));
			tblAllYears.Columns.Add("other_policy_cspi", typeof(string));
			tblAllYears.Columns.Add("other_policy_eff_dt", typeof(string));
			tblAllYears.Columns.Add("other_policy_end_dt", typeof(string));
			tblAllYears.Columns.Add("other_policy_descr", typeof(string));
			tblAllYears.Columns.Add("due_grgr_ids", typeof(string));
			tblAllYears.Columns.Add("due_cspi_id", typeof(string));
			tblAllYears.Columns.Add("due_eff_start_date", typeof(string));
			tblAllYears.Columns.Add("due_eff_end_date", typeof(string));
			tblAllYears.Columns.Add("current_suspence", typeof(decimal));
			tblAllYears.Columns.Add("amt_due", typeof(decimal));
			tblAllYears.Columns.Add("difference", typeof(decimal));
			tblAllYears.Columns.Add("family_link", typeof(string));
			tblAllYears.Columns.Add("family_t");tblAllYears.Columns.Add("tl_due", typeof(string));
			tblAllYears.Columns.Add("grgr_1", typeof(string));
			tblAllYears.Columns.Add("cspi_id_1", typeof(string));
			tblAllYears.Columns.Add("eff_start_dt_1", typeof(string));
			tblAllYears.Columns.Add("eff_end_dt_1", typeof(string));
			tblAllYears.Columns.Add("last_active_grgr_id", typeof(string));
			tblAllYears.Columns.Add("last_active_cspi_id", typeof(string));
			tblAllYears.Columns.Add("last_active_start_dt", typeof(string));
			tblAllYears.Columns.Add("last_active_end_dt", typeof(string));
			string partQuery = "";
			if(LOB == "EPP") partQuery = "LEFT(grgr_id,3) = 'EPP'";
			if (LOB == "CHP") partQuery = "LEFT(cspi_id, 3) = 'CHP'";
			DateTime curDay = DateTime.Now;
			DateTime curDay50 = new DateTime(DateTime.Now.AddDays(-50).Year, DateTime.Now.AddDays(-50).Month, DateTime.Now.AddDays(-50).Day);


			string query = @"
						/********************************************************************************************************************************************
						creates a temp table that will hold all of the data 
						********************************************************************************************************************************************/
						DROP TABLE IF EXISTS Sandbox.FinancialTools_SuspenseAllYears;
						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspensewellcare;
						CREATE TABLE Sandbox.FinancialTools_SuspenseAllYears 
						(
							comment 					varchar(100),
							Action						VARCHAR(100),
							year_						VARCHAR(100),
							detail						VARCHAR(250),
							unmatch_t_trxs				VARCHAR(10),
							has_match_t_trxs			VARCHAR(10),						
							grgr_id 					varchar(20),
							sbsb_id 					varchar(20),
							cspi_id 					varchar(20),
							has_2_accts_in_suspence		VARCHAR(20),
							last_receipt_date 			timestamp,
							last_receipt_reason 		varchar(500),
   							last_payment_type  			varchar(20),
							suspence_fin 		  			decimal,
							suspence_cspi_id varchar(20),
suspence_eff_start_date VARCHAR(50),
suspence_eff_end_date VARCHAR(50), 
-------------------------------------------
elig_suspence_cspi_id VARCHAR(20),
elig_suspence_term_code VARCHAR(20),
elig_suspence_term_descp varchar(250),
elig_suspence_eff_dt TIMESTAMP,
-------------------------------------------
other_policy_grgr VARCHAR(20),
other_policy_cspi VARCHAR(20),
other_policy_eff_dt VARCHAR(20),
other_policy_end_dt VARCHAR(20),
other_policy_descr VARCHAR(250),
-------------------------------------------
due_grgr_ids varchar(20),
due_cspi_id varchar(20),
due_eff_start_date timestamp,
due_eff_end_date timestamp,
-------------------------------------------
current_suspence decimal,
amt_due decimal,
difference decimal,
family_link VARCHAR(20),
family_ttl_due decimal,
-------------------------------------------
grgr_1 varchar(20),
cspi_id_1 varchar(20),
eff_start_dt_1 timestamp,
eff_end_dt_1 timestamp
);

/********************************************************************************************************************************************
populates the table with the required criteria

-- select * from Sandbox.FinancialTools_SuspenseAllYears

select * from sandbox.FinancialTools_fda_vh_fin150

delete from sandbox.FinancialTools_fda_vh_fin150

********************************************************************************************************************************************/

INSERT INTO Sandbox.FinancialTools_SuspenseAllYears
( grgr_id, sbsb_id, cspi_id, last_receipt_date, last_receipt_reason, last_payment_type, suspence_fin,family_link,year_ )
SELECT grgr_id, sbsb_id, cspi_id, last_receipt_date,
						string_agg(last_receipt_reason, ', ') AS last_receipt_reason
						,CASE WHEN last_payment_type = 'W' THEN 'W' ELSE '' END AS last_payment_type
						, blei_net_alloc_susp,meme_fam_link_id, extract(YEAR FROM last_receipt_date) AS year_
						FROM sandbox.FinancialTools_fda_vh_fin150

						WHERE  sbsb_id NOT IN ('744626074') and	eligibility_indicator = '" + elig + @"'
							 AND "+ partQuery+ @"
						GROUP  BY grgr_id, sbsb_id, cspi_id, last_receipt_date, blei_net_alloc_susp,meme_fam_link_id, CASE WHEN last_payment_type = 'W' THEN 'W' ELSE '' END 
						;

						--SELECT * FROM  Sandbox.FinancialTools_SuspenseAllYears --sandbox.FinancialTools_fda_vh_fin150 WHERE sbsb_id = '742870012'




						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspensewellcare;
						CREATE TABLE Sandbox.FinancialTools_Suspensewellcare as
						SELECT  DISTINCT rcpt_input_sbsb_id AS sbsb_id,                              
										 rcpt_input_grgr_id AS grgr_id 
	 
						FROM  (SELECT DISTINCT sbsb_id, grgr_id FROM Sandbox.FinancialTools_SuspenseAllYears ) a 
								LEFT JOIN ODS_FACETS.CMC_RCPT_RECEIPTS R   ON a.sbsb_id = R.rcpt_input_sbsb_id 
																		   AND a.grgr_id = r.rcpt_input_grgr_id
								WHERE rcpt_sts <> '97'
										AND r.rcpt_rcvd_dt >= '1/1/2020'
										AND rcpt_check_no = 'WC_BAL';

						-- select * from Sandbox.FinancialTools_Suspensewellcare where sbsb_id='740928444' --LEFT(grgr_id,3) = 'FCN'  LEFT(cspi_id,3) = 'CHP' 
						-- select distinct a.sbsb_id from Sandbox.FinancialTools_Suspensewellcare a     left join Sandbox.FinancialTools_SuspenseAllYears b on a.sbsb_id=b.sbsb_id where b.sbsb_id is null ; 

----------------  T transactions
DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_t_trxs;
CREATE TABLE Sandbox.FinancialTools_Suspense_t_trxs as
SELECT sbsb_id, grgr_id, sum(applied_amt) AS ttl
FROM (
SELECT  rcpt_id, r.rcpt_input_sbsb_id AS sbsb_id
,rcpt_rcvd_dt, rcpt_check_no, rcpt_mctr_rsn
,r.rcpt_input_grgr_id AS grgr_id 
,CASE 
WHEN rcpt_rcpt_cd = 'W' THEN 1 -- write off
WHEN rcpt_rcpt_cd = 'V' THEN 0
WHEN rcpt_rcpt_cd IN ('1','2','3','N','R','S','F','X') THEN -1 -- write off reveral
ELSE 1 END AS selection
,rcpt_amt
,CASE WHEN rcpt_rcpt_cd = 'W' THEN rcpt_amt
WHEN rcpt_rcpt_cd = 'V' THEN 0
WHEN rcpt_rcpt_cd IN ('1','2','3','N','R','S','F','X')  THEN -1 * rcpt_amt
ELSE rcpt_amt END AS applied_amt
,rcpt_sts
FROM  ODS_FACETS.CMC_RCPT_RECEIPTS R
INNER JOIN (SELECT DISTINCT sbsb_id, grgr_id FROM Sandbox.FinancialTools_SuspenseAllYears a ) 
b ON R.rcpt_input_sbsb_id = b.sbsb_id
AND R.rcpt_input_grgr_id =  b.grgr_id
WHERE rcpt_check_no = 'T' AND rcpt_sts <> '97'
) a
GROUP BY sbsb_id, grgr_id ; 

UPDATE Sandbox.FinancialTools_SuspenseAllYears a
SET unmatch_t_trxs = 'Y'
,comment = 'Un-match t transaction'
,action = 'Review'
FROM Sandbox.FinancialTools_Suspense_t_trxs b
WHERE a.sbsb_id = b.sbsb_id
AND a.grgr_id =  b.grgr_id
							 AND b.ttl <> 0
						;


						UPDATE Sandbox.FinancialTools_SuspenseAllYears a
						SET		has_match_t_trxs = 'Y'
						FROM 	Sandbox.FinancialTools_Suspense_t_trxs b
						WHERE a.sbsb_id = b.sbsb_id
							 AND a.grgr_id =  b.grgr_id
							 AND b.ttl = 0
						;


						-- select * from Sandbox.FinancialTools_SuspenseAllYears

						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_famlink;
						CREATE TABLE Sandbox.FinancialTools_Suspense_famlink AS 
						SELECT 	sbsb.sbsb_id, s.family_link
						FROM (SELECT 	DISTINCT family_link FROM 	Sandbox.FinancialTools_SuspenseAllYears ) AS  s
	 							INNER JOIN ods_facets.cmc_meme_member		meme	ON s.family_link = meme_fam_link_id
								INNER JOIN ods_facets.cmc_sbsb_subsc 		sbsb	ON 	meme.sbsb_ck = sbsb.sbsb_ck
																					AND meme.grgr_ck = sbsb.grgr_ck;
		
						--	SELECT * FROM Sandbox.FinancialTools_Suspense_famlink WHERE family_link = '744216323'

						/********************************************************************************************************************************************
						populates the table with the required criteria

						-- select * from Sandbox.FinancialTools_SuspenseAllYears WHERE sbsb_id = '744216323'
						********************************************************************************************************************************************/




						---  creates a temp table for suspence information
						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_suspe_current;
						CREATE TABLE Sandbox.FinancialTools_Suspense_suspe_current AS 
						SELECT	SS.SBSB_CK, SS.GRGR_CK
								,SS.SBSB_ID
								,grgr.grgr_id
								,BEI.blei_net_alloc_susp AS suspence
								,blei_net_due AS net_due, BEI.*
						FROM ODS_FACETS.CMC_BLEI_ENTY_INFO AS BEI
							INNER  JOIN ODS_FACETS.CMC_SBSB_SUBSC AS SS 	ON SS.SBSB_CK = BEI.BLEI_BILL_LEVEL_CK 
							INNER JOIN ods_facets.cmc_grgr_group grgr		ON SS.grgr_ck	=grgr.grgr_ck
							INNER JOIN (SELECT DISTINCT sbsb_id	FROM Sandbox.FinancialTools_SuspenseAllYears
										) m1 	ON SS.SBSB_ID = m1.sbsb_id;
	
	
						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_net_due_fam;
						CREATE TABLE Sandbox.FinancialTools_Suspense_net_due_fam AS 
						SELECT	family_link, SS.SBSB_CK, SS.GRGR_CK
								,SS.SBSB_ID
								,grgr.grgr_id
								,blei_net_due AS net_due
						FROM ODS_FACETS.CMC_BLEI_ENTY_INFO AS BEI
							INNER  JOIN ODS_FACETS.CMC_SBSB_SUBSC AS SS 	ON SS.SBSB_CK = BEI.BLEI_BILL_LEVEL_CK 
							INNER JOIN ods_facets.cmc_grgr_group grgr		ON SS.grgr_ck	= grgr.grgr_ck
							INNER JOIN (SELECT DISTINCT sbsb_id, family_link FROM Sandbox.FinancialTools_Suspense_famlink	) m1 	ON SS.SBSB_ID = m1.sbsb_id
						WHERE 	 blei_net_due >  0	;		
				


						UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
						SET		amt_due = b.net_due
						FROM 	Sandbox.FinancialTools_Suspense_suspe_current b
						WHERE 	a.grgr_id = b.grgr_id
								AND a.sbsb_id = b.sbsb_id;
				
   
						UPDATE Sandbox.FinancialTools_SuspenseAllYears a
						SET		family_ttl_due = b.ttl_due_family
								,detail = family_sbsb_ids
						FROM 	(
									SELECT 	family_link
											,string_agg(sbsb_id, ', ') AS family_sbsb_ids
											,sum(net_due) AS ttl_due_family
									FROM 	Sandbox.FinancialTools_Suspense_net_due_fam
									GROUP BY family_link
			
								) b
						WHERE a.family_link = b.family_link
							 AND a.amt_due <> b.ttl_due_family
						;



						--  adds new suspence amount and reports if this account in no longer in suspence
						UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
						SET		current_suspence = b.suspence
								,comment = CASE WHEN b.suspence = 0 THEN 'No Longer in Suspence' ELSE NULL END
								,Action = CASE WHEN b.suspence = 0 THEN 'N/A' ELSE NULL END
						FROM 	Sandbox.FinancialTools_Suspense_suspe_current b
						WHERE 	a.grgr_id = b.grgr_id
			AND a.sbsb_id = b.sbsb_id;

-- identifies if there are more than 2 accunts in suspence
UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
SET		has_2_accts_in_suspence = CASE WHEN b.sbsb_id IS NULL THEN null ELSE 'Y' END 
FROM 	(	SELECT sbsb_id, count(*) 
			FROM Sandbox.FinancialTools_Suspense_suspe_current
			WHERE  coalesce(suspence) + coalesce(net_due) <> 0
			GROUP BY sbsb_id
			HAVING count(*) > 1
		) b
WHERE 	a.sbsb_id = b.sbsb_id;

-- adds the amount of net due.  it adds the amt due in case there are multiple accounts in suspence
UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
SET		amt_due 			= b.net_due
		,due_grgr_ids		= b.grgr_id
		,due_cspi_id		= b.cspi_id
		,due_eff_start_date	= b.mepe_eff_dt
		,due_eff_end_date	= b.mepe_term_dt
FROM 	(

			SELECT a.*, c.cspi_id
					,c.mepe_eff_dt, c.mepe_term_dt
			FROM  	(SELECT sbsb_id, grgr_id, net_due FROM Sandbox.FinancialTools_Suspense_suspe_current WHERE net_due > 0) A
				LEFT JOIN (	SELECT *
							FROM (
									SELECT 	S.grgr_id, s.sbsb_id, cspi_id
											,mepe.mepe_eff_dt 
											,mepe.mepe_term_dt 
											,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
											,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id, cspi_id ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
											FROM (SELECT sbsb_id, grgr_id, net_due FROM Sandbox.FinancialTools_Suspense_suspe_current WHERE net_due > 0 ) s
												INNER JOIN ods_facets.cmc_sbsb_subsc 	sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
												INNER JOIN ods_facets.cmc_meme_member	meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																			AND sbsb.grgr_ck
								nt_type = 'Write Off' AND comment IS NULL			
								) b
						WHERE 	a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;nt_type = 'W'
								) b
						WHERE 	a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;


						/************************************************************************************************************************
						Select information from Eligibility (Sandbox.FinancialTools_Suspense_sbel)
						will update suspence termination here.  Will go back to use this table later.

						select * from Sandbox.FinancialTools_SuspenseAllYears
						SELECT * FROM Sandbox.FinancialTools_SuspenseAllYears WHERE sbsb_id = '744313386'
						************************************************************************************************************************/

						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_sbel;
						CREATE TABLE Sandbox.FinancialTools_Suspense_sbel AS 
						SELECT *
						FROM (
						SELECT sbsb.sbsb_id, grgr.grgr_id,  sbel.cspi_id
								,CASE 	WHEN sbel_elig_type = 'RI' THEN 'Reinstate' 
										WHEN sbel_elig_type = 'CH' THEN 'Change' 
										WHEN sbel_elig_type = 'TM' THEN 'Terminate' 
										WHEN sbel_elig_type = 'SL' THEN 'Select' 
									ELSE sbel_elig_type END AS type 
								,sbel_mctr_rsn, mctr_desc, sbel_eff_dt
								, row_number() over (PARTITION BY  sbsb.sbsb_id, grgr.grgr_id ORDER BY sbel_eff_dt desc, sbel_insq_dt DESC) AS position
								, row_number() over (PARTITION BY  sbsb.sbsb_id  ORDER BY sbel_eff_dt desc, sbel_insq_dt DESC) AS position_mem
						FROM ods_facets.CMC_SBEL_ELIG_ENT  sbel	
							INNER JOIN ods_facets.cmc_sbsb_subsc sbsb 	ON 	sbel.sbsb_ck = sbsb.sbsb_ck
															AND sbel.grgr_ck = sbsb.grgr_ck
							INNER JOIN ( select DISTINCT sbsb_id FROM sandbox.FinancialTools_fda_vh_fin150) a ON sbsb.sbsb_id = a.sbsb_id
							INNER JOIN ods_facets.cmc_grgr_group grgr 	ON  sbel.grgr_ck = grgr.grgr_ck
															AND sbsb.grgr_ck = grgr.grgr_ck
							LEFT JOIN (
											SELECT DISTINCT mctr_value, mctr_desc
											FROM ods_facets.cmc_mctr_cd_tran
```sql
WHERE mctr_type = 'RSN' and mctr_entity IN ('SBEL','MEEL')
) sbel_c ON sbel_mctr_rsn = sbel_c.mctr_value

WHERE sbel.sbel_void_ind = 'N' AND grgr.grgr_id NOT LIKE 'PEND%' 
) a 
WHERE position = 1 ;

-- SELECT * FROM Sandbox.FinancialTools_SuspenseAllYears WHERE sbsb_id = '744313386'

UPDATE Sandbox.FinancialTools_SuspenseAllYears a
SET elig_suspence_term_code = sbel_mctr_rsn
,elig_suspence_term_descp = mctr_desc
,elig_suspence_eff_dt = sbel_eff_dt
,elig_suspence_cspi_id = b.cspi_id
FROM (
SELECT sbsb_id, grgr_id, cspi_id, type, sbel_mctr_rsn
,CASE WHEN type = 'Reinstate' THEN type
ELSE mctr_desc END AS mctr_desc, sbel_eff_dt, position, position_mem
FROM Sandbox.FinancialTools_Suspense_sbel
WHERE type IN ('Reinstate','Terminate', 'Select')

) b
WHERE a.sbsb_id = b.sbsb_id
AND a.grgr_id = b.grgr_id;

DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_elig1;
CREATE TABLE Sandbox.FinancialTools_Suspense_elig1 AS
SELECT GRGR.GRGR_ID, S.SBSB_ID 
,MEME.MEME_CK, GRGR.GRGR_CK
,SBEL.CSPI_ID AS SBEL_CSPI_ID
,SBSB.SBSB_CK
,SBEL.SBEL_MCTR_RSN
,SBEL.SBEL_EFF_DT, SBEL.SBEL_VOID_IND, SBEL.SBEL_UPDATE_DTM, SBEL.SBEL_INSQ_DT, b.has_premium
FROM (SELECT DISTINCT sbsb_id FROM Sandbox.FinancialTools_SuspenseAllYears ) S
INNER JOIN ods_facets.cmc_sbsb_subsc SBSB ON S.SBSB_ID = SBSB.SBSB_ID
```--INNER JOIN #fid F ON SBSB.SBSB_ID = F.fidelis_id
								INNER JOIN ods_facets.CMC_MEME_MEMBER MEME	ON SBSB.SBSB_CK = MEME.SBSB_CK
																					AND SBSB.GRGR_CK = MEME.GRGR_CK
								INNER JOIN ods_facets.CMC_GRGR_GROUP GRGR	ON MEME.GRGR_CK = GRGR.GRGR_CK  
											   										AND LEFT(GRGR.GRGR_ID, 4) <> 'PEND'
																		--AND GRGR.GRGR_ID IN ('EPP00001') 
								INNER JOIN ods_facets.CMC_SBEL_ELIG_ENT SBEL	ON SBSB.SBSB_CK = SBEL.SBSB_CK
																					AND SBSB.GRGR_CK = SBEL.GRGR_CK
																					AND SBEL.SBEL_EFF_DT >=  (EXTRACT(MONTH FROM CURRENT_TIMESTAMP )::VARCHAR || '/1/' || EXTRACT( YEAR FROM CURRENT_TIMESTAMP)):: DATE
								INNER JOIN sandbox.cspi_id_billing2 b		  ON   SBEL.cspi_id = b.cspi_id											
						WHERE SBEL.SBEL_MCTR_RSN IN ('X001');
	 		   
								 --SBEL.SBEL_MCTR_RSN IN ('X002','E002','C020','X024','X020','E001')		THEN -1
		


						-- SELECT * FROM Sandbox.FinancialTools_Suspense_elig1 WHERE GRGR_ID IN ('EPP00001') 
						-- select * from sandbox.cspi_id_billing2


						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_ELIG2;
						CREATE TABLE Sandbox.FinancialTools_Suspense_ELIG2 AS
						SELECT E.*
						FROM Sandbox.FinancialTools_Suspense_elig1 E
								LEFT JOIN CMC_MEPE_PRCS_ELIG	MEPE	ON E.MEME_CK = mepe.MEME_CK	
																		AND e.GRGR_CK =  mepe.GRGR_CK  	 
																		AND MEPE.MEPE_ELIG_IND = 'Y'
																		--AND F.elig = MEPE.MEPE_EFF_DT*/
																		AND e.SBEL_EFF_DT = MEPE.MEPE_EFF_DT
						WHERE MEPE.meme_ck IS NULL;

						-- SELECT * FROM Sandbox.FinancialTools_Suspense_ELIG2 
						-- select * from Sandbox.FinancialTools_SuspenseAllYears


						UPDATE Sandbox.FinancialTools_SuspenseAllYears a 
						SET comment = CASE WHEN e.grgr_id = a.grgr_id THEN 'New policy is waiting to effectuate'
													WHEN e.grgr_id <> a.grgr_id THEN 'New policy is waiting to effectuate - different lob' 
													ELSE '' END 
								,action		= CASE 	WHEN e.grgr_id = a.grgr_id THEN 'N/A'
													WHEN e.grgr_id <> a.grgr_id AND e.has_premium='Y' THEN 'Move'
													WHEN e.grgr_id <> a.grgr_id AND e.has_premium='N' THEN 'N/A'
													ELSE '' END

						FROM   Sandbox.FinancialTools_Suspense_ELIG2 e
						WHERE a.sbsb_id = e.sbsb_id
							  --AND a.grgr_id = e.grgr_id	 

						;

						-- SELECT * FROM Sandbox.FinancialTools_SuspenseAllYears;

						/***************************************************************************************************************************
						END new section for New policy waiting to effectuate 
						***************************************************************************************************************************/



     
						/******************************************************************************************************************************************************************************     
						gets all of the eligibilty from this members

						table will be called eligbility inquiry as this is the name in facets
						******************************************************************************************************************************************************************************/    
     
						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_elig_inquiry;
						CREATE TABLE Sandbox.FinancialTools_Suspense_elig_inquiry AS 					
						SELECT 	grgr.grgr_id, s.sbsb_id, mepe.cspi_id, sbsb.sbsb_ck,mepe.mepe_eff_dt, mepe.mepe_term_dt
								,mepe.MEPE_MCTR_RSN
								,row_number() over (PARTITION BY s.sbsb_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
								,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
								,mepe.mepe_elig_ind, b.has_premium
						FROM (SELECT DISTINCT sbsb_id   FROM Sandbox.FinancialTools_SuspenseAllYears ) s
							INNER JOIN ods_facets.cmc_sbsb_subsc 		sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
							INNER JOIN ods_facets.cmc_meme_member		meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																				AND sbsb.grgr_ck = meme.grgr_ck
																				AND meme_sfx = 0										
							INNER JOIN ods_facets.cmc_grgr_group 		grgr	ON meme.grgr_ck	= grgr.grgr_ck  
																				AND LEFT(grgr.grgr_id, 4) <> 'PEND'
							INNER JOIN ods_facets.cmc_mepe_prcs_elig	mepe	ON meme.meme_ck = mepe.meme_ck	
																				AND grgr.grgr_ck =  mepe.grgr_ck  
																				AND mepe.mepe_elig_ind = 'Y'											   	
							LEFT JOIN sandbox.cspi_id_billing2			b		ON mepe.cspi_id = b.cspi_id;




						UPDATE	 Sandbox.FinancialTools_SuspenseAllYears a 
						SET		comment		= 'Conflicting Active Policies'
								,action		= 'Review'
	 							,detail		=  'More than one policy starting ' ||  to_char(mepe_eff_dt, 'MM/DD/YYYY')
						FROM   (		
	   								SELECT 	DISTINCT a.sbsb_id, r.grgr_id, r.cspi_id, b.mepe_eff_dt
									FROM 	Sandbox.FinancialTools_Suspense_elig_inquiry a
									INNER JOIN (
													SELECT sbsb_id, mepe_eff_dt,  count(*)
													FROM Sandbox.FinancialTools_Suspense_elig_inquiry e
													GROUP BY sbsb_id, mepe_eff_dt
													HAVING count(*)> 1
												) b ON 	a.sbsb_id = b.sbsb_id
													AND a.mepe_eff_dt = b.mepe_eff_dt
									INNER JOIN Sandbox.FinancialTools_SuspenseAllYears r ON a.sbsb_id = r.sbsb_id
													AND r.last_receipt_date > b.mepe_eff_dt 
													AND r.comment IS NULL
							) b
						WHERE a.sbsb_id = b.sbsb_id
							  AND a.grgr_id = b.grgr_id	 
							  ;
						-- SELECT * FROM Sandbox.FinancialTools_Suspense_elig_inquiry where sbsb_id in ('743841041'),'742999836','743742774')
						-- select * from Sandbox.FinancialTools_SuspenseAllYears 	where sbsb_id in ('743841041','742999836','743742774')
						/***************************************************************************************************************************
						new section for conflicting policies
						***************************************************************************************************************************/




						DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_elig_inquiry2;
						CREATE  TABLE Sandbox.FinancialTools_Suspense_elig_inquiry2 AS 
						SELECT 	 sbsb_id,grgr_id, last_receipt_date, count(*) AS counter
						FROM (	
								SELECT 	 s.sbsb_id,last_receipt_date, grgr.grgr_id, mepe.cspi_id, sbsb.sbsb_ck,mepe.mepe_eff_dt, mepe.mepe_term_dt
										,mepe.MEPE_MCTR_RSN
										,row_number() over (PARTITION BY s.sbsb_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
										,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
										,mepe.mepe_elig_ind, b.has_premium
								FROM (SELECT DISTINCT sbsb_id, last_receipt_date   FROM Sandbox.FinancialTools_SuspenseAllYears ) s
									INNER JOIN ods_facets.cmc_sbsb_subsc 		sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
									INNER JOIN ods_facets.cmc_meme_member		meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																						AND sbsb.grgr_ck = meme.grgr_ck
																						AND meme_sfx = 0										
									INNER JOIN ods_facets.cmc_grgr_group 		grgr	ON meme.grgr_ck	= grgr.grgr_ck  
																						AND LEFT(grgr.grgr_id, 4) <> 'PEND'
									INNER JOIN ods_facets.cmc_mepe_prcs_elig	mepe	ON meme.meme_ck = mepe.meme_ck	
																						AND grgr.grgr_ck =  mepe.grgr_ck  
																						AND mepe.mepe_elig_ind = 'Y' 
																						AND last_receipt_date BETWEEN mepe.mepe_eff_dt AND mepe.mepe_term_dt 											   	
									LEFT JOIN sandbox.cspi_id_billing2			b		ON mepe.cspi_id = b.cspi_id
								) b
						GROUP BY sbsb_id, grgr_id, last_receipt_date
						HAVING count(*)  > 1
						;



						UPDATE	 Sandbox.FinancialTools_SuspenseAllYears a 
						SET		comment		= 'Conflicting Active Po.UPDATE Sandbox.FinancialTools_SuspenseAllYears a
SET 	comment		= CASE WHEN b.has_premium = 'Y' THEN 'Active in premium suspence policy'
				WHEN b.has_premium = 'N' THEN 'Active in non premium suspence policy' ELSE '' end
		,action		= CASE WHEN b.has_premium = 'Y' THEN 'N/A'
				WHEN  b.has_premium = 'N' THEN 'Suspense' ELSE '' END 
		--,detail		=  'More than one policy starting ' ||  to_char(mepe_eff_dt, 'MM/DD/YYYY')
		,suspence_cspi_id		= b.cspi_id
		,suspence_eff_start_date	= mepe_eff_dt
		,suspence_eff_end_date		= mepe_term_dt
FROM (
			SELECT e.*
			FROM Sandbox.FinancialTools_Suspense_elig_inquiry e
				INNER JOIN Sandbox.FinancialTools_SuspenseAllYears r  ON e.sbsb_id = r.sbsb_id 
									AND r.comment IS NULL
								   --	AND e.has_premium = 'Y'
									AND e.grgr_id = r.grgr_id
			WHERE position_mem = 1 AND e.mepe_term_dt >= CURRENT_TIMESTAMP
	) b

WHERE 	   a.sbsb_id = b.sbsb_id
			AND a.grgr_id = b.grgr_id	;E '' end

								,action		= CASE WHEN b.has_premium = 'Y' THEN 'Move'
													WHEN  b.has_premium = 'N' THEN 'Suspense' ELSE '' END 
	 							--,detail		=  'More than one policy starting ' ||  to_char(mepe_eff_dt, 'MM/DD/YYYY')
	 							,suspence_cspi_id		= b.cspi_id
	 							,suspence_eff_start_date	= mepe_eff_dt
	 							,suspence_eff_end_date		= mepe_term_dt
						FROM (
									SELECT e.*
									FROM Sandbox.FinancialTools_Suspense_elig_inquiry e
										INNER JOIN Sandbox.FinancialTools_SuspenseAllYears r  ON e.sbsb_id = r.sbsb_id 
															AND r.comment IS NULL
														   --	AND e.has_premium = 'Y'
															AND e.grgr_id <> r.grgr_id
									WHERE position_mem = 1 AND e.mepe_term_dt >= CURRENT_TIMESTAMP
							) b
						WHERE 	   a.sbsb_id = b.sbsb_id
	  								AND a.grgr_id <> b.grgr_id	;
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
						--***************************************************************************************************************************************************************************
						/*


								SELECT sbsb_id, grgr_id, cspi_id, type, sbel_mctr_rsn
										,CASE WHEN type = 'Reinstate' THEN type
											ELSE mctr_desc END AS mctr_desc, sbel_eff_dt, position, position_mem
								FROM sbel
								WHERE type IN ('Reinstate','Terminate', 'Select')
									and sbsb_id = '744313386'

						select * from Sandbox.FinancialTools_Suspense_sbel where sbsb_id = '742049820'

						SELECT * FROM Sandbox.FinancialTools_SuspenseAllYears where comment is null

						*/
   
						UPDATE	 Sandbox.FinancialTools_SuspenseAllYears a 
						SET		other_policy_descr		= mctr_desc		
								,other_policy_grgr		= other_grgr_id		   
								,other_policy_eff_dt	= sbel_eff_dt
								,other_policy_cspi		= b.cspi_id	 	
						FROM   (		

								SELECT r.sbsb_id, r.grgr_id, s.grgr_id  AS other_grgr_id, s.cspi_id, s.type, s.sbel_mctr_rsn
										,CASE WHEN s.type = 'Reinstate' THEN s.type
											ELSE s.mctr_desc END AS mctr_desc, s.sbel_eff_dt
								FROM (SELECT DISTINCT sbsb_id , grgr_id FROM Sandbox.FinancialTools_SuspenseAllYears) r
										LEFT JOIN Sandbox.FinancialTools_Suspense_sbel s ON s.sbsb_id = r.sbsb_id
								WHERE s.type IN ('Reinstate','Select')
									AND r.grgr_id <> s.grgr_id
								   --	AND r.sbsb_id = '744313386'
							) b
						WHERE a.sbsb_id = b.sbsb_id
							  AND a.grgr_id = b.grgr_id
							  AND a.grgr_id <> b.other_grgr_id
							  AND b.sbel_eff_dt >  current_timestamp
							  ;
  
						--SELECT * FROM Sandbox.FinancialTools_Suspense_sbel WHERE sbsb_id = '741549505'

						/*

						SELECT b.* , a.*
						FROM   	Sandbox.FinancialTools_SuspenseAllYears a
						INNER JOIN		(		
								SELECT r.sbsb_id, r.grgr_id, s.grgr_id AS other_grgr_id, s.cspi_id, s.type, s.sbel_mctr_rsn
										,CASE WHEN s.type = 'Reinstate' THEN s.type
											ELSE s.mctr_desc END AS mctr_desc, s.sbel_eff_dt
										,position, position_mem
								FROM (SELECT DISTINCT sbsb_id , grgr_id FROM Sandbox.FinancialTools_SuspenseAllYears WHERE comment IS null) r
										LEFT JOIN Sandbox.FinancialTools_Suspense_sbel s ON s.sbsb_id = r.sbsb_id
	  							WHERE s.position_mem = 1
	  								AND s.type IN ('Reinstate','Select')
									AND r.grgr_id <> s.grgr_id
								   --	AND r.sbsb_id = '744313386'
							) b on
						  a.sbsb_id = b.sbsb_id
							  AND a.grgr_id = b.grgr_id
							  AND a.grgr_id <> b.other_grgr_id
							--  AND b.sbel_eff_dt >  current_timestamp
						AND a.sbsb_id = '741549505'

						*/









	
						/********************************************************************************************************************************************
						 updates amount due information
											WHEN elig_suspence_cspi_id LIKE ('%IND')		THEN 'Reinstatement - move to billable individual account'
											ELSE 'check'
										END AS Comment
									,CASE 	WHEN elig_suspence_cspi_id LIKE ('%FRE')		THEN 'Move'
											WHEN elig_suspence_cspi_id LIKE ('%IND')		THEN 'Move'
											ELSE 'check'
										END AS Action
								FROM Sandbox.FinancialTools_SuspenseAllYears r
									LEFT JOIN  sandbox.cspi_id_billing2 AS b ON r.elig_suspence_cspi_id = b.cspi_id
								WHERE r.comment IS NULL 
								AND elig_suspence_cspi_id IS NOT NULL
							 ) b
						WHERE 	a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;


						-- select * from Sandbox.FinancialTools_SuspenseAllYears where comment is null

						********************************************************************************************************************************************/WHEN b.has_premium = 'Y' THEN 'Reinstatement in same group - premiun'
WHEN b.has_premium = 'N' THEN 'Reinstatement in same group - non premiun'
ELSE 'check'
END AS Comment
,CASE WHEN elig_suspence_cspi_id LIKE ('%FRE') THEN 'Move'
WHEN b.has_premium = 'Y' THEN 'N/A'
WHEN b.has_premium = 'N' THEN 'Suspense'
ELSE 'check'
END AS Action
FROM (SELECT * FROM FinancialTools_SuspenseAllYears WHERE comment IS NULL) r
LEFT JOIN cspi_id_billing2 AS b ON r.elig_suspence_cspi_id = b.cspi_id
WHERE r.comment IS NULL
AND r.elig_suspence_eff_dt > current_timestamp
) b
WHERE a.sbsb_id = b.sbsb_id
AND a.grgr_id = b.grgr_id;

-- select * from FinancialTools_SuspenseAllYears where comment is null
-- select * from FinancialTools_SuspenseAllYears where sbsb_id = '744313386'

--- updates suspence termination date

DROP TABLE IF EXISTS FinancialTools_Suspense_eff;
CREATE TABLE FinancialTools_Suspense_eff AS
SELECT a.grgr_id, a.sbsb_id, a.cspi_id,sbsb_ck, MEPE_MCTR_RSN, sbel_MCTR_Rsn
, to_char(mepe_eff_dt, 'MM/DD/YYYY') AS eff_start_dt
, to_char(mepe_term_dt , 'MM/DD/YYYY') AS eff_end_dt
,position_mem, position_plan, mepe_elig_ind, dt, b.has_premium
FROM (

SELECT grgr.grgr_id, s.sbsb_id, mepe.cspi_id, sbsb.sbsb_ck
, mepe.mepe_eff_dt 
, mepe.mepe_term_dt
,mepe.MEPE_MCTR_RSN
,sbel.sbel_MCTR_Rsn
,row_number() over (PARTITION BY s.sbsb_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
,dt, mepe.mepe_elig_ind

FROM (SELECT DISTINCT sbsb_id, grgr_id, last_receipt_date AS dt FROM Sandbox.FinancialTools_SuspenseAllYears WHERE comment IS null) s
INNER JOIN ods_facets.cmc_sbsb_subsc 	sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
INNER JOIN ods_facets.cmc_meme_member	meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
												AND sbsb.grgr_ck = meme.grgr_ck
										
INNER JOIN ods_facets.cmc_grgr_group 	grgr	ON meme.grgr_ck	= grgr.grgr_ck  AND LEFT(grgr.grgr_id, 4) <> 'PEND'
												AND s.grgr_id = grgr.grgr_id
INNER JOIN ods_facets.cmc_mepe_prcs_elig mepe	ON meme.meme_ck = mepe.meme_ck	
												AND grgr.grgr_ck =  mepe.grgr_ck  AND mepe.mepe_elig_ind = 'Y'
										   							AND s.dt BETWEEN (mepe_eff_dt - INTERVAL '30 days' ) AND mepe_term_dt --(mepe_term_dt + INTERVAL '30 days')
										   	
										   							AND CURRENT_TIMESTAMP < mepe_eff_dt
inner JOIN ods_facets.CMC_SBEL_ELIG_ENT	sbel	ON 	sbsb.sbsb_ck = sbel.sbsb_ck
												AND sbsb.grgr_ck = sbel.grgr_ck
		  
) a
LEFT JOIN sandbox.cspi_id_billing2 b ON a.cspi_id = b.cspi_id
 WHERE position_plan = 1;


--  select * from Sandbox.FinancialTools_Suspense_eff where sbsb_id = '744313386'

UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
SET		suspence_eff_end_date 		= b.eff_end_dt
		,suspence_eff_start_date 	= b.eff_start_dt
		,suspence_cspi_id 			= b.cspi_id						FROM Sandbox.FinancialTools_Suspense_eff b
						WHERE a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id
								;
		
						--    stop at 10/21 at 12:42
						/********************************************************************************************************************************************
						 select * from Sandbox.FinancialTools_SuspenseAllYears where comment is null
						********************************************************************************************************************************************/
 

						/********************************************************************************************************************************************
						 select * from Sandbox.FinancialTools_SuspenseAllYears where comment is null
						********************************************************************************************************************************************/



						UPDATE Sandbox.FinancialTools_SuspenseAllYears a
						SET suspence_eff_end_date = b.eff_end_dt
								,suspence_eff_start_date = b.eff_start_dt
								,suspence_cspi_id = b.cspi_id	
						FROM (
									SELECT grgr_id, sbsb_id, cspi_id,sbsb_ck, MEPE_MCTR_RSN, sbel_MCTR_Rsn
											, to_char(mepe_eff_dt, 'MM/DD/YYYY') AS eff_start_dt
											, to_char(mepe_term_dt , 'MM/DD/YYYY') AS  eff_end_dt
											,position_mem, position_plan, mepe_elig_ind, dt
									FROM (
					
											SELECT grgr.grgr_id, s.sbsb_id, mepe.cspi_id, sbsb.sbsb_ck
													, mepe.mepe_eff_dt 
													, mepe.mepe_term_dt
													,mepe.MEPE_MCTR_RSN
													,sbel.sbel_MCTR_Rsn
												,row_number() over (PARTITION BY s.sbsb_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
												,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
												,dt, mepe.mepe_elig_ind
						
											FROM (SELECT DISTINCT sbsb_id, grgr_id, last_receipt_date AS dt FROM FinancialTools_SuspenseAllYears WHERE comment IS NULL) s
												INNER JOIN ods_facets.cmc_sbsb_subsc 	sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
												INNER JOIN ods_facets.cmc_meme_member	meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																								AND sbsb.grgr_ck = meme.grgr_ck
																		
												INNER JOIN ods_facets.cmc_grgr_group 	grgr	ON meme.grgr_ck	= grgr.grgr_ck  AND LEFT(grgr.grgr_id, 4) <> 'PEND'
																								AND s.grgr_id = grgr.grgr_id
												INNER JOIN ods_facets.cmc_mepe_prcs_elig mepe	ON meme.meme_ck = mepe.meme_ck	
																								AND grgr.grgr_ck =  mepe.grgr_ck  AND mepe.mepe_elig_ind = 'Y'
																	   							AND s.dt BETWEEN mepe_eff_dt  AND mepe_term_dt --(mepe_term_dt + INTERVAL '30 days')
																	   							AND CURRENT_TIMESTAMP > mepe_term_dt
												inner JOIN ods_facets.CMC_SBEL_ELIG_ENT	sbel	ON 	sbsb.sbsb_ck = sbel.sbsb_ck
																								AND sbsb.grgr_ck = sbel.grgr_ck
				   
										) a
									 WHERE position_plan = 1 -- AND sbsb_id = '744313386'
								) b
						WHERE a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;
	   







						UPDATE 	FinancialTools_SuspenseAllYears	a
						SET		eff_start_dt_1				= b.eff_end_dt
								,eff_end_dt_1			 	= b.eff_start_dt
								,grgr_1			 			= b.grgr_id	
								,cspi_id_1					= b.cspi_id
						FROM (
									SELECT grgr_id, sbsb_id, cspi_id,sbsb_ck, MEPE_MCTR_RSN, sbel_MCTR_Rsn
											, mepe_eff_dt AS eff_start_dt
											, mepe_term_dt AS  eff_end_dt
											,position_mem, position_plan, mepe_elig_ind, dt
									FROM (
					
											SELECT grgr.grgr_id, s.sbsb_id, mepe.cspi_id, sbsb.sbsb_ck
													, mepe.mepe_eff_dt 
													, mepe.mepe_term_dt
													,mepe.MEPE_MCTR_RSN
													,sbel.sbel_MCTR_Rsn
												,row_number() over (PARTITION BY s.sbsb_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
												,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
												,dt, mepe.mepe_elig_ind
						
											FROM (SELECT DISTINCT sbsb_id, grgr_id, last_receipt_date AS dt FROM FinancialTools_SuspenseAllYears WHERE comment IS NULL ) s
												INNER JOIN ods_facets.cmc_sbsb_subsc 	sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
												INNER JOIN ods_facets.cmc_meme_member	meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																								AND sbsb.grgr_ck = meme.grgr_ck
																		
												INNER JOIN ods_facets.cmc_grgr_group 	grgr	ON meme.grgr_ck	= grgr.grgr_ck  AND LEFT(grgr.grgr_id, 4) <> 'PEND'
																								AND s.grgr_id <> grgr.grgr_id
												INNER JOIN ods_facets.cmc_mepe_prcs_elig mepe	ON meme.meme_ck = mepe.meme_ck	
																								AND grgr.grgr_ck =  mepe.grgr_ck  AND mepe.mepe_elig_ind = 'Y'
																							   --AND s.dt BETWEEN mepe_eff_dt  AND mepe_term_dt --(mepe_term_dt + INTERVAL '30 days')
																	   							AND CURRENT_TIMESTAMP < mepe_term_dt
												inner JOIN ods_facets.CMC_SBEL_ELIG_ENT	sbel	ON 	sbsb.sbsb_ck = sbel.sbsb_ck
																								AND sbsb.grgr_ck = sbel.grgr_ck
				  
										) a
									 WHERE position_plan = 1  --AND  sbsb_id = '744313386'
								) b
						WHERE a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;
	   


						/********************************************************************************************************************************************
						 select * from Financial
								FROM Sandbox.FinancialTools_Suspense_last_active_policy ) p
								ON s.sbsb_id = p.sbsb_id
								INNER JOIN ( SELECT DISTINCT grgr_id, cspi_id FROM Sandbox.FinancialTools_Suspense_last_active_policy ) a
								ON a.grgr_id = s.grgr_id
							) b
						WHERE a.sbsb_id = a.sbsb_id
						AND a.grgr_id = b.suspence_grgr_id
						AND a.position_mem = 1;FROM  Sandbox.FinancialTools_Suspense_last_active_policy p
														WHERE mepe_term_dt > CURRENT_TIMESTAMP
													) p ON s.sbsb_id = p.sbsb_id
									INNER JOIN 	 sandbox.cspi_id_billing2 AS b ON p.cspi_id = b.cspi_id	  AND has_premium = 'Y'		
  							) b
						WHERE 	a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.suspence_grgr_id
						; 	

						UPDATE Sandbox.FinancialTools_SuspenseAllYears a
						SET other_policy_grgr	= b.grgr_id
							,other_policy_cspi	= b.cspi_id
							,other_policy_eff_dt	= b.mepe_eff_dt
							,comment				= 'Active Non premium policy'
							,Action					= 'Suspense'
						FROM (
								SELECT s.grgr_id AS suspence_grgr_id, p.*, has_premium
								FROM ( SELECT DISTINCT sbsb_id, grgr_id  FROM Sandbox.FinancialTools_SuspenseAllYears WHERE comment IS NULL  ) s
										INNER JOIN (	SELECT *
														FROM  Sandbox.FinancialTools_Suspense_last_active_policy p
														WHERE mepe_term_dt > CURRENT_TIMESTAMP
													) p ON s.sbsb_id = p.sbsb_id
									INNER JOIN 	 sandbox.cspi_id_billing2 AS b ON p.cspi_id = b.cspi_id	  AND has_premium = 'N'		
  							) b
						WHERE 	a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.suspence_grgr_id
						; 	


						--  select * from Sandbox.FinancialTools_SuspenseAllYears where sbsb_id = '744313386'
						-------------------------------------------------------------------------------------------------


						UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
						SET		comment = 'No other active policies'
							,Action = 'Suspense'
						FROM (
								SELECT 	l.*
								FROM 	(SELECT DISTINCT sbsb_id, grgr_id  FROM Sandbox.FinancialTools_SuspenseAllYears WHERE comment IS NULL AND amt_due IS NULL AND suspence_eff_start_date IS NOT NULL ) s
										INNER JOIN Sandbox.FinancialTools_Suspense_last_active_policy l ON s.sbsb_id = l.sbsb_id
																		AND s.grgr_id = l.grgr_id
							) b
						WHERE 	a.sbsb_id = b.sbsb_id
AND a.grgr_id = b.grgr_id;

/********************************************************************************************************************************************
select * FROM Sandbox.FinancialTools_SuspenseAllYears WHERE comment IS NULL 
********************************************************************************************************************************************/

UPDATE Sandbox.FinancialTools_SuspenseAllYears a
SET comment = 'No other active policies'
,Action = 'Suspense'
FROM (
select * 
FROM Sandbox.FinancialTools_SuspenseAllYears 
WHERE comment IS NULL 
AND suspence_eff_start_date IS NOT NULL
) b
WHERE a.sbsb_id = b.sbsb_id
AND a.grgr_id = b.grgr_id;

/********************************************************************************************************************************************
select * FROM Sandbox.FinancialTools_SuspenseAllYears WHERE comment IS NULL and suspence_eff_start_date is not null
********************************************************************************************************************************************/

DROP TABLE IF EXISTS Sandbox.FinancialTools_Suspense_last_pol;
CREATE TABLE Sandbox.FinancialTools_Suspense_last_pol as
SELECT grgr_id, sbsb_id, cspi_id,sbsb_ck, MEPE_MCTR_RSN, sbel_MCTR_Rsn
, to_char(mepe_eff_dt, 'MM/DD/YYYY') AS eff_start_dt
, to_char(mepe_term_dt , 'MM/DD/YYYY') AS eff_end_dt
,position_mem, position_plan, mepe_elig_ind, dt
FROM (

SELECT grgr.grgr_id, s.sbsb_id, mepe.cspi_id, sbsb.sbsb_ck
, mepe.mepe_eff_dt 
, mepe.mepe_term_dt
,mepe.MEPE_MCTR_RSN
,sbel.sbel_MCTR_Rsn
,row_number() over (PARTITION BY s.sbsb_id ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
												,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
												,dt, mepe.mepe_elig_ind
						
											FROM (SELECT DISTINCT sbsb_id, grgr_id, last_receipt_date AS dt FROM FinancialTools_SuspenseAllYears WHERE comment IS NULL) s
												INNER JOIN cmc_sbsb_subsc 	sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
												INNER JOIN cmc_meme_member	meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																								AND sbsb.grgr_ck = meme.grgr_ck
																		
												INNER JOIN cmc_grgr_group 	grgr	ON meme.grgr_ck	= grgr.grgr_ck  AND LEFT(grgr.grgr_id, 4) <> 'PEND'
																								AND s.grgr_id = grgr.grgr_id
												INNER JOIN cmc_mepe_prcs_elig mepe	ON meme.meme_ck = mepe.meme_ck	
																								AND grgr.grgr_ck =  mepe.grgr_ck  AND mepe.mepe_elig_ind = 'Y'
																	   							
												inner JOIN CM_SBEL_ELIG_ENT	sbel	ON 	sbsb.sbsb_ck = sbel.sbsb_ck
																								AND sbsb.grgr_ck = sbel.grgr_ck
												) a
									 WHERE position_plan = 1;




						UPDATE 	FinancialTools_SuspenseAllYears	a
						SET		comment = 'Policy never effectuated'
								,Action = 'Suspense'
						FROM (
		 


								SELECT 	a.*
								FROM 	(	SELECT 	*  FROM   	FinancialTools_SuspenseAllYears r WHERE comment IS NULL ) a
									LEFT JOIN  ( SELECT DISTINCT sbsb_id, grgr_id  FROM FinancialTools_Suspense_sbel  		) s	ON a.sbsb_id = s.sbsb_id 
									LEFT JOIN  ( SELECT DISTINCT sbsb_id, grgr_id  FROM FinancialTools_Suspense_last_pol 	) p ON a.sbsb_id = p.sbsb_id 
								WHERE s.sbsb_id IS NULL AND p.sbsb_id IS NULl


						) b	WHERE 	a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;


						UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
						SET		comment = 'No active policies'
								,Action = 'Suspense'
						FROM (
									SELECT a.*
									FROM (			
												SELECT *
												FROM Sandbox.FinancialTools_SuspenseAllYears
												WHERE 
												comment IS null
												AND elig_suspence_term_descp IN (
												'Voluntary disenroll during yr',
												'Termed - failed to pay premium',
												'SDOH Special Recert',
												'Presumpt term-miss documentn',
												'Cancellation via 834',
												'SDOH-Disenrl - dual CHP/Medicd',
												'Voluntary disenroll at recert',
												'HBX NonAPTC Term MonthlyPrem',
												'HBX APTC Term Monthly Premium',
												'Passive Renewal',
												'HBX NonAPTC Term Monthly Prem',
												'Voluntary disenroll during yr'

													)
							
											) a
											LEFT JOIN  ( SELECT sbsb_id, grgr_id FROM Sandbox.FinancialTools_Suspense_sbel  	WHERE sbel_eff_dt::TIMESTAMP >  current_timestamp	) s	ON a.sbsb_id = s.sbsb_id --AND a.grgr_id = s.grgr_id
											LEFT JOIN  ( SELECT sbsb_id, grgr_id  FROM Sandbox.FinancialTools_Suspense_last_pol WHERE eff_start_dt:: TIMESTAMP > current_timestamp	) p ON a.sbsb_id = p.sbsb_id --AND a.grgr_id = p.grgr_id	
									WHERE s.sbsb_id IS NULL AND p.sbsb_id IS NULl
								) b
		
						 WHERE 	a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;				



						--SELECT * FROM Sandbox.FinancialTools_Suspense_sbel  	WHERE sbsb_id = '743458080'
						--sbel_eff_dt::TIMESTAMP >  current_timestamp



						UPDATE 	Sandbox.FinancialTools_SuspenseAllYears	a
						SET		suspence_eff_end_date 		= b.eff_end_dt
								,suspence_eff_start_date 	= b.eff_start_dt
								,suspence_cspi_id 			= b.cspi_id	
						FROM (
									SELECT grgr_id, sbsb_id, cspi_id,sbsb_ck, MEPE_MCTR_RSN, sbel_MCTR_Rsn
											, to_char(mepe_eff_dt, 'MM/DD/YYYY') AS eff_start_dt
											, to_char(mepe_term_dt , 'MM/DD/YYYY') AS  eff_end_dt
											,position_mem, position_plan, mepe_elig_ind, dt
									FROM (
					
											SELECT grgr.grgr_id, s.sbsb_id, mepe.cspi_id, sbsb.sbsb_ck
													, mepe.mepe_eff_dt 
													, mepe.mepe_term_dt
													,mepe.MEPE_MCTR_RSN
													,sbel.sbel_MCTR_Rsn
												,row_number() over (PARTITION BY s.sbsb_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
												,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
												,dt, mepe.mepe_elig_ind
						
											FROM (SELECT DISTINCT sbsb_id, grgr_id, last_receipt_date AS dt FROM Sandbox.FinancialTools_SuspenseAllYears WHERE comment IS NULL) s
												INNER JOIN ods_facets.cmc_sbsb_subsc 	sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
												INNER JOIN ods_facets.cmc_meme_member	meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																								AND sbsb.grgr_ck = meme.grgr_ck
																		
												INNER JOIN ods_facets.cmc_grgr_group 	grgr	ON meme.grgr_ck	= grgr.grgr_ck  AND LEFT(grgr.grgr_id, 4) <> 'PEND'
																								AND s.grgr_id = grgr.grgr_id
												INNER JOIN ods_facets.cmc_mepe_prcs_elig mepe	ON meme.meme_ck = mepe.meme_ck	
																								AND grgr.grgr_ck =  mepe.grgr_ck  AND mepe.mepe_elig_ind = 'Y'
																	   							--AND s.dt BETWEEN mepe_eff_dt  AND mepe_term_dt --(mepe_term_dt + INTERVAL '30 days')
																	   							--AND CURRENT_TIMESTAMP > mepe_term_dt
												inner JOIN ods_facets.CMC_SBEL_ELIG_ENT	sbel	ON 	sbsb.sbsb_ck = sbel.sbsb_ck
																								AND sbsb.grgr_ck = sbel.grgr_ck
				  
										) a
									 WHERE position_plan = 1
								) b
						WHERE a.sbsb_id = b.sbsb_id
								AND a.grgr_id = b.grgr_id;
						-- SELECT * FROM Sandbox.FinancialTools_SuspenseAllYears where comment AS last_active_mnt
							,a.sbsb_id AS last_active_sbsb_id
							,a.suspence_eff_start_date AS last_active_suspence_eff_start_date
						FROM Sandbox.FinancialTools_SuspenseAllYears r
							LEFT JOIN Sandbox.FinancialTools_Suspense_last_pol a ON r.sbsb_id = a.sbsb_id AND r.grgr_id = a.grgr_id
						WHERE r.comment = 'Received Wellcare Payment';epe_eff_dt AS last_active_start_dt
							,a.mepe_term_dt AS last_active_end_dt
						FROM Sandbox.FinancialTools_SuspenseAllYears r
							-- connect to last active policy
							LEFT JOIN  (	
								SELECT *
								FROM (
										SELECT 	 s.sbsb_id,grgr.grgr_id, cspi_id
												,mepe.mepe_eff_dt 
												,mepe.mepe_term_dt 
												,row_number() over (PARTITION BY s.sbsb_id  ORDER BY mepe.mepe_term_dt DESC ) AS position_mem
												,row_number() over (PARTITION BY s.sbsb_id, grgr.grgr_id, cspi_id ORDER BY mepe.mepe_term_dt DESC ) AS position_plan
										FROM (sELECT DISTINCT sbsb_id FROM Sandbox.FinancialTools_Suspense_suspe_current  ) s
											INNER JOIN ods_facets.cmc_sbsb_subsc 	sbsb	ON 	s.sbsb_id = sbsb.sbsb_id
											INNER JOIN ods_facets.cmc_meme_member	meme	ON 	sbsb.sbsb_ck = meme.sbsb_ck
																							 AND meme_sfx = 0
											INNER JOIN ods_facets.cmc_grgr_group 	grgr	ON meme.grgr_ck	= grgr.grgr_ck  
																							--AND s.grgr_id = grgr.grgr_id 
																							AND LEFT(grgr_id, 4) <> 'PEND'
											INNER JOIN ods_facets.cmc_mepe_prcs_elig mepe	ON meme.meme_ck = mepe.meme_ck	 AND mepe.mepe_elig_ind = 'Y'
																							AND grgr.grgr_ck =  mepe.grgr_ck
									) B
									WHERE position_mem = 1 	 
									) a ON r.sbsb_id = a.sbsb_id
									WHERE last_receipt_date <'" + curDay50.ToString()+ @"';
			

						-- 742870012




						--- Last Policy within in the same group
                            ";


			NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);



			try
			{
				connection.Open();
				NpgsqlCommand command = new NpgsqlCommand(query, connection)
				{
					CommandTimeout = 0
				};

				NpgsqlDataReader thisReader = command.ExecuteReader();
				
				while (thisReader.Read())
				{
					/*					string[] str = new string[43];
										str[0] = curDay= System.Convert.ToString(thisReader.GetValue(28)); = System.Convert.ToString(thisReader.GetValue(28));
str[29] = System.Convert.ToString(thisReader.GetValue(29));
str[30] = System.Convert.ToString(thisReader.GetValue(30));
str[31] = System.Convert.ToString(thisReader.GetValue(31));
str[32] = System.Convert.ToString(thisReader.GetValue(32));
str[33] = System.Convert.ToString(thisReader.GetValue(33));
str[34] = System.Convert.ToString(thisReader.GetValue(34));
str[35] = System.Convert.ToString(thisReader.GetValue(35));
str[36] = System.Convert.ToString(thisReader.GetValue(36));
str[37] = System.Convert.ToString(thisReader.GetValue(37));
str[38] = System.Convert.ToString(thisReader.GetValue(38));
str[39] = System.Convert.ToString(thisReader.GetValue(39));
str[40] = System.Convert.ToString(thisReader.GetValue(40));
str[41] = System.Convert.ToString(thisReader.GetValue(41));
str[42] = System.Convert.ToString(thisReader.GetValue(42)); */

DateTime lastRecieptDate = System.Convert.ToDateTime(thisReader.GetValue(10));

tblAllYears.Rows.Add(
    curDay,
    System.Convert.ToString(thisReader.GetValue(0)),
    System.Convert.ToString(thisReader.GetValue(1)),
    System.Convert.ToInt32(thisReader.GetValue(2)),
    System.Convert.ToString(thisReader.GetValue(3)),
    System.Convert.ToString(thisReader.GetValue(4)),
    System.Convert.ToString(thisReader.GetValue(5)),
    System.Convert.ToString(thisReader.GetValue(6)),
    System.Convert.ToString(thisReader.GetValue(7)),
    System.Convert.ToString(thisReader.GetValue(8)),
    System.Convert.ToString(thisReader.GetValue(9)),
    lastRecieptDate,
    System.Convert.ToString(thisReader.GetValue(11)),
    System.Convert.ToString(thisReader.GetValue(12)),
    System.Convert.ToDecimal(thisReader.GetValue(13)),
    System.Convert.ToString(thisReader.GetValue(14)),
							System.Convert.ToString(thisReader.GetValue(15)),
							System.Convert.ToString(thisReader.GetValue(16)),
							System.Convert.ToString(thisReader.GetValue(17)),
							System.Convert.ToString(thisReader.GetValue(18)),
							System.Convert.ToString(thisReader.GetValue(19)),
							System.Convert.ToString(thisReader.GetValue(20)),
							System.Convert.ToString(thisReader.GetValue(21)),
							System.Convert.ToString(thisReader.GetValue(22)),
							System.Convert.ToString(thisReader.GetValue(23)),
							System.Convert.ToString(thisReader.GetValue(24)),
							System.Convert.ToString(thisReader.GetValue(25)),
							System.Convert.ToString(thisReader.GetValue(26)),
							System.Convert.ToString(thisReader.GetValue(27)),
							System.Convert.ToString(thisReader.GetValue(28)),
							System.Convert.ToString(thisReader.GetValue(29)),
							System.Convert.ToDecimal(thisReader.GetValue(30)),
							System.Convert.ToDecimal(thisReader.GetValue(31)),
							System.Convert.ToDecimal(thisReader.GetValue(30)) - System.Convert.ToDecimal(thisReader.GetValue(31)),
							System.Convert.ToString(thisReader.GetValue(33)),
							System.Convert.ToString(thisReader.GetValue(34)),
							System.Convert.ToString(thisReader.GetValue(35)),
							System.Convert.ToString(thisReader.GetValue(36)),
							System.Convert.ToString(thisReader.GetValue(37)),
							System.Convert.ToString(thisReader.GetValue(38)),
							System.Convert.ToString(thisReader.GetValue(39)),
							System.Convert.ToString(thisReader.GetValue(40)),
							System.Convert.ToString(thisReader.GetValue(41)),
							System.Convert.ToString(thisReader.GetValue(42))

	
						);


				}
				connection.Close();
				if (objProgress != null) objProgress.ReportProgress(srcPercentage + 2);



			}
			catch (NpgsqlException e)
			{
				if (connection != null)
					connection.Close();
				throw new NpgsqlException(@"Greenplum database error: " + e.ToString(), e);pgsqlCommand(query, connection);
				NpgsqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					DataRow row = tblLastActive.NewRow();
					row["sbsb_id"] = reader["sbsb_id"];
					row["grgr_id"] = reader["grgr_id"];
					row["cspi_id"] = reader["cspi_id"];
					row["mepe_eff_dt"] = reader["mepe_eff_dt"];
					row["mepe_term_dt"] = reader["mepe_term_dt"];
					tblLastActive.Rows.Add(row);
				}
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
			return tblLastActive;
		}
	}
}ctionString);

			connection.Open();

			NpgsqlCommand command = new NpgsqlCommand(query, connection)
			{
				CommandTimeout = 0
			};

			foreach (DataRow row in tblAllYears.Rows)
			{
				command.CommandText += "(";
				for (int i = 0; i < row.ItemArray.Length; i++)
				{
					if (row[i] is DateTime)
					{
						command.CommandText += "'" + ((DateTime)row[i]).ToString("yyyy-MM-dd") + "'";
					}
					else
					{
						command.CommandText += "'" + row[i].ToString() + "'";
					}

					if (i < row.ItemArray.Length - 1)
					{
						command.CommandText += ", ";
					}
				}
				command.CommandText += "),\r\n";
			}

			command.CommandText = command.CommandText.TrimEnd(',', '\r', '\n');

			try
			{
				command.ExecuteNonQuery();
				connection.Close();
				if (objProgress != null) objProgress.ReportProgress(srcPercentage + 1);
			}
			catch (NpgsqlException e)
			{
				if (connection != null)
					connection.Close();
				throw new NpgsqlException(@"Greenplum database error: " + e.ToString(), e);
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
		}ng(row[23]) + "', " +        //24
							"'" + System.Convert.ToString(row[24]) + "', " +        //25
							(row[25].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[25]).ToString() + "'") + ", " +      //26
							(row[26].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[26]).ToString() + "'") + ", " +      //27
							(row[27].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[27]).ToString() + "'") + ", " +      //28
							"'" + System.Convert.ToString(row[28]) + "', " +        //29
							"'" + System.Convert.ToString(row[29]) + "', " +        //30
							"'" + System.Convert.ToString(row[30]) + "', " +        //31
							"'" + System.Convert.ToString(row[31]) + "', " +        //32
							"'" + System.Convert.ToString(row[32]) + "', " +        //33
							"'" + System.Convert.ToString(row[33]) + "', " +        //34
							"'" + System.Convert.ToString(row[34]) + "', " +        //35
							"'" + System.Convert.ToString(row[35]) + "', " +        //36
							"'" + System.Convert.ToString(row[36]) + "', " +        //37
							"'" + System.Convert.ToString(row[37]) + "', " +        //38
							"'" + System.Convert.ToString(row[38]) + "', " +        //39
							"'" + System.Convert.ToString(row[39]) + "', " +        //40
							"'" + System.Convert.ToString(row[40]) + "', " +        //41
							"'" + System.Convert.ToString(row[41]) + "', " +        //42
							"'" + System.Convert.ToString(row[42]) + "', " +        //43
							"'" + System.Convert.ToString(row[43]) + "', " +        //44
							"'" + System.Convert.ToString(row[44]) + "', " +        //45
							"'" + System.Convert.ToString(row[45]) + "', " +        //46
							"'" + System.Convert.ToString(row[46]) + "', " +        //47
							"'" + System.Convert.ToString(row[47]) + "', " +        //48
							"'" + System.Convert.ToString(row[48]) + "', " +        //49
							"'" + System.Convert.ToString(row[49]) + "', " +        //50
							"'" + System.Convert.ToString(row[50]) + "', " +        //51
							"'" + System.Convert.ToString(row[51]) + "', " +        //52
							"'" + System.Convert.ToString(row[52]) + "', " +        //53
							"'" + System.Convert.ToString(row[53]) + "', " +        //54
							"'" + System.Convert.ToString(row[54]) + "', " +        //55
							"'" + System.Convert.ToString(row[55]) + "', " +        //56
							"'" + System.Convert.ToString(row[56]) + "', " +        //57
							"'" + System.Convert.ToString(row[57]) + "', " +        //58
							"'" + System.Convert.ToString(row[58]) + "', " +        //59
							"'" + System.Convert.ToString(row[59]) + "', " +        //60
							"'" + System.Convert.ToString(row[60]) + "', " +        //61
							"'" + System.Convert.ToString(row[61]) + "', " +        //62
							"'" + System.Convert.ToString(row[62]) + "', " +        //63
							"'" + System.Convert.ToString(row[63]) + "', " +        //64
							"'" + System.Convert.ToString(row[64]) + "', " +        //65
							"'" + System.Convert.ToString(row[65]) + "', " +        //66
							"'" + System.Convert.ToString(row[66]) + "', " +        //67
							"'" + System.Convert.ToString(row[67]) + "', " +        //68
							"'" + System.Convert.ToString(row[68]) + "', " +        //69
							"'" + System.Convert.ToString(row[69]) + "', " +        //70
							"'" + System.Convert.ToString(row[70]) + "', " +        //71
							"'" + System.Convert.ToString(row[71]) + "', " +        //72
							"'" + System.Convert.ToString(row[72]) + "', " +        //73
							"'" + System.Convert.ToString(row[73]) + "', " +        //74
							"'" + System.Convert.ToString(row[74]) + "', " +        //75
							"'" + System.Convert.ToString(row[75]) + "', " +        //76
							"'" + System.Convert.ToString(row[76]) + "', " +        //77
							"'" + System.Convert.ToString(row[77]) + "', " +        //78
							"'" + System.Convert.ToString(row[78]) + "', " +        //79
							"'" + System.Convert.ToString(row[79]) + "', " +        //80
							"'" + System.Convert.ToString(row[80]) + "', " +        //81
							"'" + System.Convert.ToString(row[81]) + "', " +        //82
							"'" + System.Convert.ToString(row[82]) + "', " +        //83
							"'" + System.Convert.ToString(row[83]) + "', " +        //84
							"'" + System.Convert.ToString(row[84]) + "', " +        //85
							"'" + System.Convert.ToString(row[85]) + "', " +        //86
							"'" + System.Convert.ToString(row[86]) + "', " +        //87
							"'" + System.Convert.ToString(row[87]) + "', " +        //88
							"'" + System.Convert.ToString(row[88]) + "', " +        //89
							"'" + System.Convert.ToString(row[89]) + "', " +        //90
							"'" + System.Convert.ToString(row[90]) + "', " +        //91
							"'" + System.Convert.ToString(row[91]) + "', " +        //92
							"'" + System.Convert.ToString(row[92]) + "', " +        //93
							"'" + System.Convert.ToString(row[93]) + "', " +        //94
							"'" + System.Convert.ToString(row[94]) + "', " +        //95
							"'" + System.Convert.ToString(row[95]) + "', " +        //96ng(row[23]) + "', " + //24
(row[24].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[24]).ToString() + "'") + ", " + //25
(row[25].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[25]).ToString() + "'") + ", " + //26
"'" + System.Convert.ToString(row[26]) + "', " + //27
"'" + System.Convert.ToString(row[27]) + "', " + //28
"'" + System.Convert.ToString(row[28]) + "', " + //29
(row[29].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[29]).ToString() + "'") + ", " + //30
(row[30].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[30]).ToString() + "'") + ", " + //31
"'" + System.Convert.ToDecimal(row[31]) + "', " + //32
"'" + System.Convert.ToDecimal(row[32]) + "', " + //33
"'" + System.Convert.ToDecimal(row[33]) + "', " + //34
"'" + System.Convert.ToString(row[34]) + "', " + //35
"'" + System.Convert.ToString(row[35]) + "', " + //36
"'" + System.Convert.ToString(row[36]) + "', " + //37
"'" + System.Convert.ToString(row[37]) + "', " + //38
"'" + System.Convert.ToString(row[38]) + "', " + //39
"'" + System.Convert.ToString(row[39]) + "', " + //40
"'" + System.Convert.ToString(row[40]) + "', " + //41
"'" + System.Convert.ToString(row[41]) + "', " + //42
(row[42].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[42]).ToString("") + "'") + ", " + //43
(row[43].ToString()=="" ? "NULL" : "'" + System.Convert.ToDateTime(row[43]).ToString("") + "'") //44
"),
";
}
query = query.Substring(0, query.Length - 3);


connection.Open();
NpgsqlCommand command = new NpgsqlCommand(query, connection)
{
CommandTimeout = 0
};

command.ExecuteNonQuery();
connection.Close();
				if (objProgress != null) objProgress.ReportProgress(srcPercentage + 1);



			}
			catch (NpgsqlException e)
			{
				if (connection != null)
					connection.Close();
				throw new NpgsqlException(@"Greenplum database error: " + e.ToString(), e);

			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
			

		}
		public DataTable SuspenseBuildReportHistorical(string LOB, System.ComponentModel.BackgroundWorker objProgress, int srcPercentage)
		{







			string query = @"DROP TABLE IF EXISTS sandbox.financialtools_refund_last_report;
						CREATE TABLE sandbox.financialtools_refund_last_report AS
						SELECT DISTINCT Max(Report_date) AS MaxOfReport_date
						FROM sandbox.financialtools_refund_" + LOB + @"_suspense;


						DROP TABLE IF EXISTS sandbox.financialtools_refund_last_report_details;
						CREATE TABLE sandbox.financialtools_refund_last_report_details as
						SELECT 
						Report_date, 
						comment, 
						action, 
						year_, 
						detail, 
						unmatch_t_trxs, 
						has_match_t_trxs, 
						grgr_id, 
						sbsb_id, 
						cspi_id, 
						has_2_accts_in_suspence, 
						last_receipt_date, 
						last_receipt_reason, 
						last_payment_type, 
						suspence_fin, 
						suspence_cspi_id, 
						suspence_eff_start_date, 
						suspence_eff_end_date, 
						elig_suspence_cspi_id, 
						elig_suspence_term_code, 
						elig_suspence_term_descp, 
						elig_suspence_eff_dt, 
						other_policy_grgr, 
						other_policy_cspi, 
						other_policy_eff_dt, 
						other_policy_end_dt, 
						other_policy_descr, 
						due_grgr_ids, 
						due_cspi_id, 
						due_eff_start_date, 
						due_eff_end_date, 
						current_suspence, 
						amt_due, 
						difference, 
						family_link, 
						family_ttl_due, 
						grgr_1, 
						cspi_id_1,
						eff_start_dt_1, 
						eff_end_dt_1, 
						last_active_grgr_id, 
						last_active_cspi_id, 
						last_active_start_dt, 
						last_active_end_dt
						FROM sandbox.financialtools_refund_" + LOB + @"_suspense
						INNER JOIN sandbox.financialtools_refund_last_report lr
						ON Report_date = lr.MaxOfReport_date;


						DROP TABLE IF EXISTS sandbox.financialtools_refund_first_reported;
						CREATE TABLE sandbox.financialtools_refund_first_reported AS 
						SELECT 
						Min(main.Report_date) AS first_reported, 
						main.sbsb_id, main.comment, 
						main.action, main.difference, 
						main.last_receipt_date, 
						main.current_suspence
						FROM sandbox.financialtools_refund_" + LOB + @"_suspense main 
						LEFT JOIN sandbox.financialtools_refund_last_report lr 
						ON main.Report_date = lr.MaxOfReport_date
						GROUP BY main.sbsb_id, main.comment, main.action, main.difference, main.last_receipt_date, main.current_suspence, lr.MaxOfReport_date
						HAVING (((lr.MaxOfReport_date) Is Null);


						SELECT 
						lrd.current_suspence AS current_susp, 
						fr.current_suspence AS reported_suspence, 
						fr.first_reported, lrd.Report_date, 
						lrd.comment, 
						lrd.action, 
						lrd.year_, 
						lrd.detail, 
						lrd.unmatch_t_trxs, 
						lrd.has_match_t_trxs, 
						lrd.grgr_id, 
						lrd.sbsb_id, 
						lrd.cspi_id, 
						lrd.has_2_accts_in_suspence, 
						lrd.last_receipt_date, 
						lrd.last_receipt_reason, 
						lrd.last_payment_type, 
						lrd.suspence_fin, 
						lrd.suspence_cspi_id, 
						lrd.suspence_eff_start_date, 
						lrd.suspence_eff_end_date, 
						lrd.elig_suspence_cspi_id, 
						lrd.elig_suspence_term_code, 
						lrd.elig_suspence_term_descp, 
						lrd.elig_suspence_eff_dt, 
						lrd.other_policy_grgr, 
						lrd.other_policy_cspi, 
						lrd.other_policy_eff_dt, 
						lrd.other_policy_end_dt, 
						lrd.other_policy_descr, 
						lrd.due_grgr_ids, 
						lrd.due_cspi_id, 
						lrd.due_eff_start_date, 
						lrd.due_eff_end_date, 
						lrd.current_suspen						lrd.amt_due, 
						lrd.difference, 
						lrd.family_link, 
						lrd.family_ttl_due, 
						lrd.grgr_1, 
						lrd.cspi_id_1, 
						lrd.eff_start_dt_1, 
						lrd.eff_end_dt_1, 
						lrd.last_active_grgr_id, 
						lrd.last_active_cspi_id, 
						lrd.last_active_start_dt, 
						lrd.last_active_end_dt
						FROM financialtools_refund_last_report_details lrd
						LEFT JOIN financialtools_refund_first_reported fr
						ON lrd.sbsb_id = fr.sbsb_id;";
			DataTable tblHistorical = new DataTable();
			DataTable tbltempHistorical = new DataTable();
			tbltempHistorical.Columns.Add("Reported", typeof(string));
			tbltempHistorical.Columns.Add("current_susp", typeof(decimal));
			tbltempHistorical.Columns.Add("reported_suspence", typeof(decimal));
			tbltempHistorical.Columns.Add("first_reported", typeof(DateTime));
			tbltempHistorical.Columns.Add("report_date", typeof(string));
			tbltempHistorical.Columns.Add("comment", typeof(string));
			tbltempHistorical.Columns.Add("action", typeof(string));
			tbltempHistorical.Columns.Add("year_", typeof(string));
			tbltempHistorical.Columns.Add("detail", typeof(string));
			tbltempHistorical.Columns.Add("unmatch_t_trxs", typeof(string));
			tbltempHistorical.Columns.Add("has_match_t_trxs", typeof(string));
			tbltempHistorical.Columns.Add("grgr_id", typeof(string));
			tbltempHistorical.Columns.Add("sbsb_id", typeof(string));
			tbltempHistorical.Columns.Add("cspi_id", typeof(string));
			tbltempHistorical.Columns.Add("has_2_accts_in_suspence", typeof(string));
			tbltempHistorical.Columns.Add("last_receipt_date", typeof(string));
			tbltempHistorical.Columns.Add("last_receipt_reason", typeof(string));
			tbltempHistorical.Columns.Add("last_payment_type", typeof(string));
			tbltempHistorical.Columns.Add("suspence_fin", typeof(string));
			tbltempHistorical.Columns.Add("suspence_cspi_id", typeof(string));
			tbltempHistorical.Columns.Add("suspence_eff_start_date");tbltempHistorical.Columns.Add("suspence_eff_start_date", typeof(string));
			tbltempHistorical.Columns.Add("suspence_eff_end_date", typeof(string));
			tbltempHistorical.Columns.Add("elig_suspence_cspi_id", typeof(string));
			tbltempHistorical.Columns.Add("elig_suspence_term_code", typeof(string));
			tbltempHistorical.Columns.Add("elig_suspence_term_descp", typeof(string));
			tbltempHistorical.Columns.Add("elig_suspence_eff_dt", typeof(string));
			tbltempHistorical.Columns.Add("other_policy_grgr", typeof(string));
			tbltempHistorical.Columns.Add("other_policy_cspi", typeof(string));
			tbltempHistorical.Columns.Add("other_policy_eff_dt", typeof(string));
			tbltempHistorical.Columns.Add("other_policy_end_dt", typeof(string));
			tbltempHistorical.Columns.Add("other_policy_descr", typeof(string));
			tbltempHistorical.Columns.Add("due_grgr_ids", typeof(string));
			tbltempHistorical.Columns.Add("due_cspi_id", typeof(string));
			tbltempHistorical.Columns.Add("due_eff_start_date", typeof(string));
			tbltempHistorical.Columns.Add("due_eff_end_date", typeof(string));
			tbltempHistorical.Columns.Add("current_suspence", typeof(string));
			tbltempHistorical.Columns.Add("amt_due", typeof(string));
			tbltempHistorical.Columns.Add("difference", typeof(string));
			tbltempHistorical.Columns.Add("family_link", typeof(string));
			tbltempHistorical.Columns.Add("family_ttl_due", typeof(string));
			tbltempHistorical.Columns.Add("grgr_1", typeof(string));
			tbltempHistorical.Columns.Add("cspi_id_1", typeof(string));
			tbltempHistorical.Columns.Add("eff_start_dt_1", typeof(string));
			tbltempHistorical.Columns.Add("eff_end_dt_1", typeof(string));
			tbltempHistorical.Columns.Add("last_active_grgr_id", typeof(string));
			tbltempHistorical.Columns.Add("last_active_cspi_id", typeof(string));
			tbltempHistorical.Columns.Add("last_active_start_dt", typeof(string));
			tbltempHistorical.Columns.Add("last_active_end_dt", typeof(string));
			tbltempHistorical.Columns.Add("sbsb_id_int", typeof(int));NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);

try
{
    connection.Open();
    NpgsqlCommand command = new NpgsqlCommand(query, connection)
    {
        CommandTimeout = 0
    };

    NpgsqlDataReader thisReader = command.ExecuteReader();

    while (thisReader.Read())
    {
        decimal current_susp = (string.IsNullOrEmpty(thisReader.GetValue(0).ToString().Trim())) ? 0 : System.Convert.ToDecimal(thisReader.GetValue(0));
        decimal reported_suspence = (string.IsNullOrEmpty(thisReader.GetValue(1).ToString().Trim())) ? 0 : System.Convert.ToDecimal(thisReader.GetValue(1));
        string Reported = "";
        string strfirst_reported = System.Convert.ToString(thisReader.GetValue(2));
        DateTime first_reported = new DateTime();
        if (DateTime.TryParse(strfirst_reported, out first_reported))
        {
            if (reported_suspence != current_susp) Reported = "Previously Reported with different amount";
            if (reported_suspence == current_susp) Reported = "Reported on " + first_reported.ToShortDateString();
        }
        else Reported = "Newly reported";

        tbltempHistorical.Rows.Add(
            Reported,
            current_susp,
            reported_suspence,
            first_reported,
            System.Convert.ToString(thisReader.GetValue(3)),
            System.Convert.ToString(thisReader.GetValue(4)),
            System.Convert.ToString(thisReader.GetValue(5)),
            System.Convert.ToString(thisReader.GetValue(6)),
            System.Convert.ToString(thisReader.GetValue(7)),
            System.Convert.ToString(thisReader.GetValue(8)),
            System.Convert.ToString(thisReader.GetValue(9)),
            System.Convert.ToString(thisReader.GetValue(10)),
            System.Convert.ToString(thisReader.GetValue(11)),
            System.Convert.ToString(thisReader.GetValue(12)),
            System.Convert.ToString(thisReader.GetValue(13)),
            System.Convert.ToString(thisReader.GetValue(14)),
            System.Convert.ToString(thisReader.GetValue(15)),
            System.Convert.ToString(thisReader.GetValue(16))
        );
    }
}
catch (Exception ex)
{
    // Handle exception
}
finally
{
    connection.Close();
}vert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToString(),
						System.Convert.ToInt32(thisReader.GetValue(11));

				}
				connection.Close();
				if (objProgress != null) objProgress.ReportProgress(srcPercentage + 1);

				tblHistorical = tbltempHistorical.AsEnumerable()
					  .Ord.OrderBy(r => r.Field<int>("sbsb_id_int"))
					  .ThenBy(r => r.Field<DateTime>("first_reported"))
					  .CopyToDataTable();

			}
			catch (NpgsqlException e)
			{
				if (connection != null)
					connection.Close();
				throw new NpgsqlException(@"Greenplum database error: " + e.ToString(), e);

			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
			tblHistorical = tblHistorical.AsEnumerable().GroupBy(r => new { sbsb_id = r.Field<string>("sbsb_id"), grgr_id = r.Field<string>("grgr_id"), cspi_id = r.Field<string>("cspi_id"), family_link = r.Field<string>("family_link") }).Select(g => g.First()).CopyToDataTable();
			tblHistorical.Columns.Remove("sbsb_id_int");
			return tblHistorical;

		}
	}

}