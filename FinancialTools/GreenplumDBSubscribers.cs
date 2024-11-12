CK FROM ODS_FACETS.CMC_SBSB_SRVC WHERE sbsb_stat_ck = '1';";
            NpgsqlCommand command = new NpgsqlCommand(query, connection)
            {
                CommandTimeout = 0
            };

            NpgsqlDataReader thisReader = command.ExecuteReader();
            while (thisReader.Read())
            {
                SbsbCKList.Add(Convert.ToInt32(thisReader.GetValue(0)));
            }
            connection.Close();
            return SbsbCKList;
        }
    }
}
            NpgsqlCommand command = new NpgsqlCommand(query, connection)
            {
                CommandTimeout = 0
            };

            NpgsqlDataReader thisReader = command.ExecuteReader();
            while (thisReader.Read())
            {
                Subscriber subscriber = new Subscriber
                {
                    SbsbID = thisReader.GetValue(0).ToString()
                };
                Subscribers.Add(subscriber);
            }
            connection.Close();
            return Subscribers;
        }" + ", NAMISbsbId.ToArray()) + "'" + ") \n\r";
                AddAnd = true;
            }
            if (AddAnd) query += " AND ";
            query += " eligibility.mepe_eff_dt <= '" + ((DateTime)TrustTime).ToString("MM/dd/yyyy") + "' \n\r";
            query += "AND eligibility.mepe_term_dt > '" + ((DateTime)TrustTime).ToString("MM/dd/yyyy") + "' \n\r";
            return query;, NAMI, CutOffDate, TrustTime, AddAnd, query, Limit, SubscriberList, SBSBIDList, objProgress, member_ck, ssn, sbsbId, meme_ck, meme_last_name, meme_first_name, meme_mid_init, meme_ssn, meme_sex,
                        member_ck.meme_birth_dt,
                        member_ck.meme_record_no,
                        member_ck.meme_hicn,
                        member_ck.meme_medcd_no,
                        member_ck.meme_fam_link_id,
                        member_ck.meme_hist_link_id,
                        member.sbsb_id,
                        member.sbsb_ck,
                        eligibility.meme_ck,
                        eligibility.cscs_id,
                        eligibility.grgr_ck,
                        eligibility.sgsg_ck,
                        eligibility.cspi_id,
                        eligibility.pdpd_id,
                        eligibility.mepe_term_dt,
                        eligibility.mepe_eff_dt,
                        eligibility.mepe_elig_ind,
                        blei.blei_ck
                        FROM ODS_FACETS.cmc_mepe_prcs_elig eligibility
                        LEFT JOIN ODS_FACETS.cmc_meme_member member_ck
                        ON member_ck.meme_ck = eligibility.meme_ck
                        LEFT JOIN ODS_FACETS.CMC_SBSB_SUBSC member
                        ON member_ck.sbsb_ck = member.sbsb_ck
                        LEFT JOIN ODS_FACETS.cmc_blei_enty_info blei
                        ON blei.blei_bill_level_ck = member.sbsb_ck
                        where  member.sbsb_id IN ('" + String.Join("', '", SBSBIDList.ToArray()) + "') ";
                if (GRGRCKList.Count > 0)
                {
                    query += " AND ";
                    string GRGRCKs = String.Join(", ", GRGRCKList.ToArray());
                    query += " eligibility.GRGR_CK IN  (" + GRGRCKs + ") \n\r";
                }
                if (CSPIIDList.Count > 0)
                {
                    query += " AND ";
                    string CSPIIDs = "'" + String.Join("', '", CSPIIDList.ToArray()) + "'";
                    query += " eligibility.cspi_id IN (" + CSPIIDs + ") \n\r";
                    AddAnd = true;
                }
                query += @" ORDER BY member.sbsb_id, eligibility.grgr_ck, eligibility.mepe_eff_dt, eligibility.mepe_term_dt;";
                connection.Open();
                command = new NpgsqlCommand(query, connection)
                 {
                    CommandTimeout = 0
                };

                thisReader = command.ExecuteReader();
                SubscriberList = new List<Subscriber>();
                List<CKComb> CKCombList = new List<CKComb>();
                List<int> SbsbCKList = new List<int>();
                List<int> MemeCKList = new List<int>();
                List<int> BleiCKList = new List<int>();
                SBSBIDList = new List<string>();


                while (thisReader.Read())
                {

                    string LastName = System.Convert.ToString(thisReader.GetValue(0)).Trim();
                    string FirstName = System.Convert.ToString(thisReader.GetValue(1)).Trim();
                    string MiddleInitial = System.Convert.ToString(thisReader.GetValue(2));
                    string SSN = System.Convert.ToString(thisReader.GetValue(3)).Trim();
                    string Sex = System.Convert.ToString(thisReader.GetValue(4)).Trim();
                    DateTime Birthdate = System.Convert.ToDateTime(thisReader.GetValue(5), CultureInfo.InvariantCulture);
                    string RecordNo = System.Convert.ToString(thisReader.GetValue(6)).Trim();
                    string Hicn = System.Convert.ToString(thisReader.GetValue(7)).Trim();
                    string MedicaidId = System.Convert.ToString(thisReader.GetValue(8)).Trim();
                    string FamilyLink = System.Convert.ToString(thisReader.GetValue(9)).Trim();
                    string HistoryLink = System.Convert.ToString(thisReader.GetValue(10)).Trim();
                    int SbsbCK = System.Convert.ToInt32(thisReader.GetValue(12), CultureInfo.InvariantCulture);              TerminationDate,
                        EffectiveDate,
                        BleiCK
                    );

                    eligibilities.Add(eligibility);
                }

                thisReader.Close();
            }

            if (eligibilities.Count > 0)
            {
                foreach (Eligibility eligibility in eligibilities)
                {
                    // Process eligibility data
                }
            }

            return eligibilities;
        }TerminationDate,
                        EffectiveDate,
                        BleiCK);
                    CKComb CKComb = new CKComb(SbsbCK, MemeCK, BleiCK);
                    CKCombList.Add(CKComb);
                    if (!SbsbCKList.Contains(SbsbCK)) SbsbCKList.Add(SbsbCK);
                    if (!MemeCKList.Contains(MemeCK)) MemeCKList.Add(MemeCK);
                    if ((!BleiCKList.Contains(BleiCK))&&(BleiCK!=-1)) BleiCKList.Add(BleiCK);
                    if (!SBSBIDList.Contains(System.Convert.ToString(thisReader.GetValue(11)))) SBSBIDList.Add(System.Convert.ToString(thisReader.GetValue(11)));
                    var existed = SubscriberList.Find(s => s.Id == System.Convert.ToString(thisReader.GetValue(11)));
                    string TrustNotice = null;

                    if (existed != null)
                    {
                        var existedTotal = existed.Totals.Any(total => (total.SbsbCK == eligibility.SbsbCK) && (total.MemeCK == eligibility.MemeCK) && (total.BleiCK == eligibility.BleiCK));
                        if (TrustNotice != null) existed.TrustNotice = TrustNotice;
                        if (!existed.Totals.Any(total => (total.SbsbCK == eligibility.SbsbCK) && (total.MemeCK == eligibility.MemeCK) && (total.BleiCK == eligibility.BleiCK))
 )
                        {
                            existed.Totals.Add(new SubscriberTotals(eligibility.SbsbCK, eligibility.MemeCK, eligibility.BleiCK));
                        }
                        existed.AddEligibility(eligibility);
                        existed.Eligibilities = existed.Eligibilities.OrderBy(elig => elig.EffectiveDate).ToList();

                    }
                    else
                    {
                        Subscriber subscriber = new Subscriber(System.Convert.ToString(thisReader.GetValue(11)));
                        if (TrustNotice != null) subscriber.TrustNotice = TrustNotice;
                        subscriber.Totals = new List<SubscriberTotals>();
                        subscriber.Totals.Add(new SubscriberTotals(eligibility.SbsbCK, eligibility.MemeCK, eligibility.BleiCK));
                        subscriber.AddEligibility(eligibility);
                        SubscriberList.Add(subscriber);
                    }

                }
                string SbsbCKQuery = String.Join(", ", SbsbCKList.ToArray());
                string MemeCKQuery = String.Join(", ", MemeCKList.ToArray());
                string BleiCKQuery = String.Join(", ", BleiCKList.ToArray());
                string SbsbIDQuery = String.Join("', '", SBSBIDList.ToArray());
                connection.Close();
                if (objProgress != null) objProgress.ReportProgress(35);

                connection = new NpgsqlConnection(ConnectionString);

                connection.Open();
                query = @"SELECT DISTINCT
                        --es.mepe_elig_ind AS elig_current,
                        bl.sbsb_id,bl.bein_blei_addr2
                        FROM CDS_BEIN_BL_INDIC bl -- LIMIT 10
                        LEFT JOIN ODS_FACETS.cmc_meme_member mbr
                        ON bl.sbsb_ck = mbr.sbsb_ck
                        AND bl.grgr_ck = mbr.grgr_ck
                        LEFT JOIN (SELECT DISTINCT 
                        row_number() over (PARTITION BY cin, date_trunc('month',file_date) 
                        ORDER BY cin, date_trunc('month',file_date),file_date  DESC) AS pos,
                        cin,ex_cd AS n_code,nami_amount*0.01 AS nami_Roster,file_date,
                        (date_trunc('month', file_date::date) + interval '1 month' - interval '1 day')::DATE AS MOS
                        FROM ods_ext.nami_supplemental) AS  nr
                        ON mbr.meme_medcd_no = nr.cin
                        AND nr.mos = '" + TrustTime.ToString() + " " +
                            @"'-- LEFT JOIN spnd sr
                        --ON mbr.meme_medcd_no = sr.cin
                        --AND sr.mos = '02/28/2019' 
                         LEFT JOIN cmc_sbrt_rate_data AS RATE   
                        ON RATE.sbsb_ck = bl.sbsb_ck 
                        AND RATE.grgr_ck = bl.grgr_ck 
                        --AND RATE.sbrt_eff_dt <= '05/31/2019' AND RATE.sbrt_term_dt >= '05/31/2019'
                        --LEFT JOIN elig_status2 es
                        --ON mbr.meme_ck = es.meme_ck
                        WHERE bl.grgr_ck = '9' 
                        AND bl.sbsb_id IN ('" +  SbsbIDQuery + "') "+
                        @"AND ((LOWER(bein_blei_addr1) ilike ('%finance%') OR LOWER(bein_blei_addr1) ilike ('%trust%') 
                        OR LOWER(bein_blei_addr1) ilike ('%nysarc%') OR LOWER(bein_blei_addr1) ilike ('%dac%')
                        OR LOWER(bein_blei_addr1) ilike ('%spouse%') OR LOWER(bein_blei_addr1) ilike ('%join%'))
                        OR (LOWER(bein_blei_addr2) ilike ('%finance%') OR LOWER(bein_blei_addr2) ilike ('%trust%') 
                        OR LOWER(bein_blei_addr2) ilike ('%nysarc%') OR LOWER(bein_blei_addr2) ilike ('%dac%')
                        OR LOWER(bein_blei_addr2) ilike ('%spouse%') OR LOWER(bein_blei_addr2) ilike ('%join%'))
                        OR (LOWER(bein_blei_addr3) ilike ('%finance%') OR LOWER(bein_blei_addr3) ilike ('%trust%') 
                        OR LOWER(bein_blei_addr3) ilike ('%nysarc%') OR LOWER(bein_blei_addr3) ilike ('%dac%')
                        OR LOWER(bein_blei_addr3) ilike ('%spouse%') OR LOWER(bein_blei_addr3) ilike ('%join%')));";
                command = new NpgsqlCommand(query, connection)
                {
                    CommandTimeout = 0
                };

                thisReader = command.ExecuteReader();
                while (thisReader.Read())
                {
                    if(SubscriberList.Any(s => s.Id == System.Convert.ToString(thisReader.GetValue(0))))SubscriberList.Find(s => s.Id == System.Convert.ToString(thisReader.GetValue(0))).TrustNotice = thisReader.GetValue(1).ToString();

                }
                connection.Close();

                connection = new NpgsqlConnection(ConnectionString);
                connection.Open();
                query = @"
                        SELECT *,
                        lead(date_trunc('month',eff_dt)-INTERVAL '1 day')over(PARTITION BY sbsb_id ORDER BY sbsb_id,grgr_ck, eff_dt ) AS term
                        FROM 
                        (
                        SELECT DISTINCT 
                        row_number() over (PARTITION BY sbsb_id,grgr_ck,date_trunc('month',clcl_input_dt)  
                        ORDER BY sbsb_id,grgr_ck,date_trunc('month',clcl_input_dt),clcl_id DESC) AS pos,
                        sbsb_id,grgr_ck,date_trunc('month',clcl_input_dt) AS eff_dt ,
                        date_trunc('month',clcl_input_dt)+INTERVAL '3 month'-INTERVAL '1 day' AS term1 ,
                        prpr_id,prpr_npi,prpr_name 
                        FROM [REDACTED]
                        WHERE grgr_ck IN ('1','8','9','13')
                        and bpcl_pr_type_desc = 'SNF'
                        and sbsb_id IN ('" + SbsbIDQuery + "') " +
                        @"GROUP BY sbsb_id,grgr_ck,clcl_input_dt,prpr_id,prpr_npi,prpr_name,clcl_id

                        ) AS bpcl1 
                        WHERE pos = '1';";
                command = new NpgsqlCommand(query, connection)
                {
                    CommandTimeout = 0
                };

                thisReader = command.ExecuteReader();
                while (thisReader.Read())
                {
                    Provider provider = new Provider();
                    
                    provider.Name = thisReader.GetValue(7).ToString();
                    provider.ID = thisReader.GetValue(5).ToString();provider.NPI = thisReader.GetValue(6).ToString();
                    provider.GrgrCK = Convert.ToInt32(thisReader.GetValue(2));
                    provider.EffectiveDate = DateTime.Parse(thisReader.GetValue(3).ToString(), CultureInfo.InvariantCulture);
                    DateTime TerminationDate = new DateTime();
                    if (!DateTime.TryParse(thisReader.GetValue(8).ToString(),out TerminationDate))
                        TerminationDate = DateTime.Parse(thisReader.GetValue(4).ToString(), CultureInfo.InvariantCulture);
                    provider.TerminationDate = TerminationDate;
                    if (SubscriberList.Any(s => s.Id == System.Convert.ToString(thisReader.GetValue(1))))
                    {
                        var existed = SubscriberList.Find(s => s.Id == System.Convert.ToString(thisReader.GetValue(1)));
                        if (existed.Providers == default) existed.Providers = new List<Provider>();
                        existed.Providers.Add(provider);
                        existed.Providers = existed.Providers.OrderBy(x => x.TerminationDate).ToList();
                    }
                }
                connection.Close();
                if (BleiCKQuery.Length > 1)
                {


                    connection.Open();
                    query = @"SELECT DISTINCT ON (blei_ck) blei_ck, MAX(blei_net_due)                        FROM cmc_blei_enty_info WHERE blei_ck IN (" +
                            BleiCKQuery +
                            ")   GROUP BY blei_ck, blei_net_due, blei_lst_bl_due_dt ORDER BY blei_ck, blei_lst_bl_due_dt;";
                    command = new NpgsqlCommand(query, connection)
                    {
                        CommandTimeout = 0
                    };

                    thisReader = command.ExecuteReader();
                    while (thisReader.Read())
                    {
                        int BleiCK = System.Convert.ToInt32(thisReader.GetValue(0));```csharp
eader.GetValue(0));

Subscriber subscriber = SubscriberList.First(sub => sub.Eligibilities.Any(elig => elig.BleiCK == BleiCK));

subscriber.Totals.First(total => total.BleiCK == BleiCK).NetDueAmountDB = System.Convert.ToDecimal(thisReader.GetValue(1).ToString().Replace("$", "")); ;

}
connection.Close();

if (objProgress != null) objProgress.ReportProgress(35);
connection.Open();
query = @"SELECT  blei_ck,
blbl_billed_amt,
blbl_due_dt,
blbl_bliv_id_last
FROM ODS_FACETS.CMC_BLBL_BILL_SUMM
WHERE blbl_due_dt >= '01/01/2005' AND blbl_billed_amt<>0 AND blei_ck IN (" +
BleiCKQuery +
") ORDER BY blei_ck, blbl_create_dtm;";
command = new NpgsqlCommand(query, connection)
{
CommandTimeout = 0
};

thisReader = command.ExecuteReader();
while (thisReader.Read())
{
int BleiCK = System.Convert.ToInt32(thisReader.GetValue(0));
CKComb CKComb = CKCombList.First(o => o.BleiCK == BleiCK);
Transaction transaction = new Transaction(
System.Convert.ToDecimal(thisReader.GetValue(1).ToString().Replace("$", "")),
System.Convert.ToDateTime(thisReader.GetValue(2), CultureInfo.InvariantCulture),
default,
CKComb.SbsbCK,
CKComb.MemeCK,
CKComb.BleiCK,
System.Convert.ToString(thisReader.GetValue(3)).Trim(),
```
       default,
                                    default,
                                    default,
                                    default,
                                    true);

                        Subscriber subscriber = SubscriberList.First(sub => sub.Eligibilities.Any(elig => elig.BleiCK == BleiCK));

                        subscriber.AddBill(transaction);
                        subscriber.Bills = subscriber.Bills.OrderBy(bill => bill.EffectiveDate).ToList();
                    }
                    connection.Close();

                    if (objProgress != null) objProgress.ReportProgress(50);
                    connection.Open();
                    query = @"SELECT DISTINCT ON (sequence.bldi_seq_no) sequence.blei_ck, sequence.bldi_fee_disc_amt, sequence.blbl_due_dt,
                        expenses.bliv_id,
                        expenses.cspi_id,
                        expenses.plds_desc,
                        expenses.pdpd_id,
                        expenses.pdbl_id 

                    FROM cmc_bldi_discretn sequence
                    LEFT JOIN cds_indi_discretn expenses
                    ON sequence.bldi_seq_no = expenses.bldi_seq_no

                    WHERE sequence.blei_ck IN ( " + BleiCKQuery + " ) ORDER BY sequence.bldi_seq_no, sequence.blei_ck,  sequence.blbl_due_dt;  ";
                    command = new NpgsqlCommand(query, connection)
                    {
                        CommandTimeout = 0
                    };

                    thisReader = command.ExecuteReader();
                    while (thisReader.Read())
                    {
                        int BleiCK = System.Convert.ToInt32(thisReader.GetValue(0));
                        CKComb CKComb = CKCombList.First(o => o.BleiCK == BleiCK);
                        Transaction transaction = new Transaction(
                                                       System.Convert.ToDecimal(thisReader.GetValue(0)));
                    }.ToString().Replace("$", "")),
                                                       System.Convert.ToDateTime(thisReader.GetValue(2), CultureInfo.InvariantCulture),
                                                       default,
                                                       CKComb.SbsbCK,
                                                       CKComb.MemeCK,
                                                       CKComb.BleiCK,
                                                       System.Convert.ToString(thisReader.GetValue(3)).Trim(),
                                                       default,
                                                       default,
                                                       default,
                                                       default,
                                                       false);

                        Subscriber subscriber = SubscriberList.First(sub => sub.Eligibilities.Any(elig => elig.BleiCK == System.Convert.ToInt32(thisReader.GetValue(0))));
                        if (transaction.ID.Length>0) transaction.Committed = true;
                        subscriber.AddDiscretionaryItem(transaction);
                        subscriber.DiscretionaryItems = subscriber.DiscretionaryItems.OrderBy(dbi => dbi.EffectiveDate).ToList();
                    }
                    connection.Close();

                    if (objProgress != null) objProgress.ReportProgress(65);
                    connection.Open();
                    query = @"SELECT
                        row_number() over (PARTITION BY r.rcpt_input_sbsb_id,r.rcpt_input_grgr_id
                        ORDER BY r.rcpt_input_sbsb_id,r.rcpt_input_grgr_id, rcpt_rcvd_dt ASC)AS pos,
                        rcpt_id, r.rcpt_input_sbsb_id AS sbsb_id,r.blei_ck,
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
                        FROM  ODS_FACETS.CMC_RCPT_RECEIPTS R
                        WHERE rcpt_check_no <> 'T' AND rcpt_sts <> '97'
                        AND rcpt_rcvd_dt >= '1/1/2005'	   
                        AND rcpt_check_no NOT LIKE 'EPI%'  
                        AND rcpt_check_no NOT LIKE 'SSA%'  
                        AND rcpt_amt  <>0 
                        AND r.blei_ck IN ("
                             + BleiCKQuery +
                             ");";
                    command = new NpgsqlCommand(query, connection)
                    {
                        CommandTimeout = 0
                    };

                    thisReader = command.ExecuteReader();
                    while (thisReader.Read())
                    {
                        int BleiCK = System.Convert.ToInt32(thisReader.GetValue(3));
                        CKComb CKComb = CKCombList.First(o => o.BleiCK == BleiCK);
                        Transaction transaction = new Transaction(
                                                       System.Convert.ToDecimal(thisReader.GetValue(12).ToString().Replace("$", "")),
                                                       System.Convert.ToDateTime(thisReader.GetValue(4), CultureInfo.InvariantCulture),
                                                       default,
                                                       CKComb.SbsbCK,
                                                       CKComb.MemeCK,
                                                       CKComb.BleiCK,
                                                       System.Convert.ToString(thisReader.GetValue(1)).Trim(),
                                                       default,
                                                       default,
                                                       default,
                                                       default,
                                                       true);
                        Subscriber subscriber = SubscriberList.First(sub => sub.Eligibilities.Any(elig => elig.BleiCK == BleiCK));
                        subscriber.AddPayment(transaction);
                        subscriber.Payments = subscriber.Payments.OrderBy(payment => payment.EffectiveDate).ToList();
                    }
                    connection.Close();
                }
                if (objProgress != null) objPProgress.ReportProgress(80);
                if (SbsbCKQuery.Length > 1)
                {
                    connection.Open();
                    query = @"SELECT sbsb_ck, sbrt_eff_dt, sbrt_term_dt, sbrt_rt_area FROM rate_data WHERE sbsb_ck IN ("
                             + SbsbCKQuery +
                             ") ORDER BY sbsb_ck, sbrt_eff_dt,  sbrt_term_dt;";
                    command = new NpgsqlCommand(query, connection)
                    {
                        CommandTimeout = 0
                    };

                    thisReader = command.ExecuteReader();
                    while (thisReader.Read())
                    {
                        int SbsbCK = System.Convert.ToInt32(thisReader.GetValue(0));
                        CKComb CKComb = CKCombList.First(o => o.SbsbCK == SbsbCK);
                        Transaction transaction = new Transaction(
                                                       System.Convert.ToDecimal(thisReader.GetValue(3).ToString().Replace("$", "")),
                                                       System.Convert.ToDateTime(thisReader.GetValue(1), CultureInfo.InvariantCulture),
                                                       System.Convert.ToDateTime(thisReader.GetValue(2), CultureInfo.InvariantCulture),
                                                       CKComb.SbsbCK,
                                                       CKComb.MemeCK,
                                                       CKComb.BleiCK,
                                                       default,
                                                       default,
                                                       default,
                                                       default,
                                                       default,
                                                       true);
                        Subscriber subscriber = SubscriberList.First(sub=> sub.Eligibilities.Any(elig => elig.SbsbCK == SbsbCK));
                        subscriber.AddRate(transaction);
                        subscriber.Rates = subscriber.Rates.OrderBy(rate => rate.EffectiveDate).ToList();
                    }
                    connection.Close();
                }
                if (objProgress != null) objProgress.ReportProgress(90);

            }
            catch (NpgsqlException e)
            {
                if (connection != null)
                    connection.Close();
                throw new NpgsqlException(@"Greenplum database error: " + e.ToString(), e);
                return null;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return SubscriberList;
        }
    }
}