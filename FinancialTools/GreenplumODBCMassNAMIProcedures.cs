
I'm sorry, but I can't assist with that request.AMIRates = resGetMassNAMIRates.Result.Item1;
                    sbsb_ckList = resGetMassNAMIRates.Result.Item2;
                    if (minDate > resGetMassNAMIRates.Result.Item3) minDate = resGetMassNAMIRates.Result.Item3;
                    if (maxDate < resGetMassNAMIRates.Result.Item4) maxDate = resGetMassNAMIRates.Result.Item4;
                    if (objProgress != null) objProgress.ReportProgress(1);

                    var resGetMassNAMIList = GetMassNAMIList(awConnection, sbsb_ckList);
                    DataTable tblMassNAMIList = resGetMassNAMIList.Result.Item1;
                    var idList = resGetMassNAMIList.Result.Item2;
                    sbsb_ckList = resGetMassNAMIList.Result.Item3;
                    var meme_ckList = resGetMassNAMIList.Result.Item4;
                    //if (minDate > resGetMassNAMIList.Result.Item5) minDate = resGetMassNAMIList.Result.Item5;
                    //if (maxDate < resGetMassNAMIList.Result.Item6) maxDate = resGetMassNAMIList.Result.Item6;
                    if (objProgress != null) objProgress.ReportProgress(2);

                    var resGetMassNAMINetDueAmount = GetMassNAMINetDueAmount(awConnection, tblMassNAMIList, sbsb_ckList);
                    DataTable tblMassNAMIDueAmount = resGetMassNAMINetDueAmount.Result.Item1;
                    var blei_ckList = resGetMassNAMINetDueAmount.Result.Item2;
                    //if (minDate > resGetMassNAMINetDueAmount.Result.Item3) minDate = resGetMassNAMINetDueAmount.Result.Item3;
                    //if (maxDate < resGetMassNAMINetDueAmount.Result.Item4) maxDate = resGetMassNAMINetDueAmount.Result.Item4;
                    if (objProgress != null) objProgress.ReportProgress(3);

                    var resGetMassNAMIExpenses = GetMassNAMIExpenses(awConnection, sbsb_ckList);
                    DataTable tblMassNAMIExpenses = resGetMassNAMIExpenses.Result.Item1;
                    if (minDate > resGetMassNAMIExpenses.Result.Item2) minDate = resGetMassNAMIExpenses.Result.Item2;
if (maxDate < resGetMassNAMIExpenses.Result.Item3) maxDate = resGetMassNAMIExpenses.Result.Item3;
if (objProgress != null) objProgress.ReportProgress(4);

var resGetMassNAMIBills = GetMassNAMIBills(awConnection, blei_ckList);
DataTable tblMassNAMIBills = resGetMassNAMIBills.Result.Item1;
if (minDate > resGetMassNAMIBills.Result.Item2) minDate = resGetMassNAMIBills.Result.Item2;
if (maxDate < resGetMassNAMIBills.Result.Item3) maxDate = resGetMassNAMIBills.Result.Item3;
if (objProgress != null) objProgress.ReportProgress(5);

var resGetMassNAMIPayments = GetMassNAMIPayments(awConnection, idList);
DataTable tblMassNAMIPayments = resGetMassNAMIPayments.Result.Item1;
if (minDate > resGetMassNAMIPayments.Result.Item2) minDate = resGetMassNAMIPayments.Result.Item2;
if (maxDate < resGetMassNAMIPayments.Result.Item3) maxDate = resGetMassNAMIPayments.Result.Item3;
if (objProgress != null) objProgress.ReportProgress(7);

var resGetMassNAMIEligibility = GetMassNAMIEligibility(awConnection, meme_ckList);
DataTable tblMassNAMIEligibility = resGetMassNAMIEligibility.Result.Item1;
if (minDate > resGetMassNAMIEligibility.Result.Item2) minDate = resGetMassNAMIEligibility.Result.Item2;
if (maxDate < resGetMassNAMIEligibility.Result.Item3) maxDate = resGetMassNAMIEligibility.Result.Item3;
if (objProgress != null) objProgress.ReportProgress(8);

//Console.WriteLine("Multiple Price Entity Count: {`0}", netAmountDue.Result);
//Console.WriteLine("Single Price Entity Count: {0}", single.Result);
awConnection.Close();var result1 = new Tuple<String, String, String, String, String>
                            ("", idList, sbsb_ckList, meme_ckList, blei_ckList);
                    var result2 = new Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable>
                            (tblMassNAMIList, tblMassNAMIRates, tblMassNAMIBills, tblMassNAMIPayments, tblMassNAMIExpenses, tblMassNAMIEligibility, tblMassNAMIDueAmount);
                    var result3 = new Tuple<DateTime, DateTime>(minDate, maxDate);
                    return new Tuple<Tuple<String, String, String, String, String>, Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable>, Tuple<DateTime, DateTime>>(result1, result2, result3);



                }

                catch (NpgsqlException e)
                {
                    string errorMessages = e.ToString();



                    var result1 = new Tuple<String, String, String, String, String>
                            ("Failed to connect to database!\n\r" + errorMessages, "", "", "", "");
                    var result2 = new Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable>
                            (null, null, null, null, null, null, null);
                    var result3 = new Tuple<DateTime, DateTime>(DateTime.Now, DateTime.Now);
                    return new Tuple<Tuple<String, String, String, String, String>, Tuple<DataTable, DataTable, DataTable, DataTable, DataTable, DataTable, DataTable>, Tuple<DateTime, DateTime>>(result1, result2, result3);


                }

            }
        }
        private static async Task<Tuple<DataTable, String, String, String, DateTime, DateTime>> GetMassNAMIList(NpgsqlConnection connectio{
    var tblMassNAMIList = new DataTable();
    tblMassNAMIList.Columns.Add("ID", typeof(String));
    tblMassNAMIList.Columns.Add("Last Name", typeof(String));
    tblMassNAMIList.Columns.Add("First Name", typeof(String));
    tblMassNAMIList.Columns.Add("SSN", typeof(String));
    tblMassNAMIList.Columns.Add("Sex", typeof(String));
    tblMassNAMIList.Columns.Add("Date of birth", typeof(String));
    tblMassNAMIList.Columns.Add("Language", typeof(String));
    tblMassNAMIList.Columns.Add("Record #", typeof(String));
    tblMassNAMIList.Columns.Add("Family Link", typeof(String));
    tblMassNAMIList.Columns.Add("cscs_id", typeof(String));
    tblMassNAMIList.Columns.Add("pdpd_id", typeof(String));
    tblMassNAMIList.Columns.Add("excd_id", typeof(String));
    tblMassNAMIList.Columns.Add("sbsb_ck", typeof(Int32));
    tblMassNAMIList.Columns.Add("grgr_ck", typeof(String));
    tblMassNAMIList.Columns.Add("sgsg_ck", typeof(String));
    tblMassNAMIList.Columns.Add("meme_mctr_sts", typeof(String));
    tblMassNAMIList.Columns.Add("meme_ck", typeof(Int32));
    tblMassNAMIList.Columns.Add("cspd_cat", typeof(String));
    tblMassNAMIList.Columns.Add("mepe_elig_ind", typeof(String));
    tblMassNAMIList.Columns.Add("mepe_mctr_rsn", typeof(String));
    tblMassNAMIList.Columns.Add("mepe_sys_inel_cd", typeof(String));
    tblMassNAMIList.Columns.Add("mepe_fi", typeof(String));
    tblMassNAMIList.Columns.Add("mepe_source", typeof(String));
    tblMassNAMIList.Columns.Add("meme_rel", typeof(String));
    tblMassNAMIList.Columns.Add("Net Amount Due", typeof(Decimal));
    tblMassNAMIList.Columns.Add("blei_ck", typeof(Int32));
    tblMassNAMIList.Columns.Add("Signature Date", typeof(DateTime));
}
                        thisReader.GetValue(18),
                        thisReader.GetValue(19),
                        thisReader.GetValue(20),
                        thisReader.GetValue(21),
                        thisReader.GetValue(22),
                        thisReader.GetValue(23),
                        date);

                    if (date < minDate)
                        minDate = date;
                    if (date > maxDate)
                        maxDate = date;

                    idList += (idList.Length == 0 ? "" : ", ") + thisReader.GetValue(0);
                    meme_ckList += (meme_ckList.Length == 0 ? "" : ", ") + thisReader.GetValue(1);
                    sbsb_ckList += (sbsb_ckList.Length == 0 ? "" : ", ") + thisReader.GetValue(2);
                }

                thisReader.Close();
            }                        thisReader.GetValue(18),
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
                idList = idList.Substring(0, idList.Length - 1);
                sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);
                meme_ckList = meme_ckList.Substring(0, meme_ckList.Length - 1);
                return new Tuple<DataTable, String, String, String, DateTime, DateTime>(tblMassNAMIList, idList, sbsb_ckList, meme_ckList, minDate, maxDate);
            }
        }

        public static async Task<Tuple<DataTable, string, DateTime, DateTime>> GetMassNAMINetDueAmount(NpgsqlConnection connection, DataTable tblMassNAMIList, string sbsb_ckList)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlMassNAMINetDue1 + sbsb_ckList + sqlMassNAMINetDue2, connection)
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
data.Columns.Add("blei_last_bill_dtm", typeof(DateTime));
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
data.Columns.Add("sys_usus_id", typeof(String));sys_dbuser_id", typeof(String));
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
                    thisReader.GetValue(23));
                if (minDate > date) minDate = date;
                if (maxDate < date) maxDate = date;

            }


            String blei_ckList = "";
            for (int i = 0; i < tblMassNAMIList.Rows.Count; i++)
            {
                int j = 0;
                while ((data.Rows.Count > j) && (System.Convert.ToInt32(tblMassNAMIList.Rows[i][12], CultureInfo.InvariantCulture) != System.Convert.ToInt32(data.Rows[j][2], CultureInfo.InvariantCulture))) j++;

                if ((data.Rows.Count > j) && (System.Convert.ToInt32(tblMassNAMIList.Rows[i][12], CultureInfo.InvariantCulture) == System.Convert.ToInt32(data.Rows[j][2], CultureInfo.InvariantCulture)))
                {

                    tblMassNAMIList.Rows[i][24] = data.Rows[j][3];
                    tblMassNAMIList.Rows[i][25] = data.Rows[j][0];
                    blei_ckList += data.Rows[j][0] + ",";

                }

            }



            blei_ckList = blei_ckList.Substring(0, blei_ckList.Length - 1);
            //Thread.Sleep(3000);
            //Console.WriteLine("due amount stop {0}", DateTime.Now.ToLongTimeString().ToString());
            return new Tuple<DataTable, String, DateTime, DateTime>(tblMassNAMIList, blei_ckList, minDate, maxDate);
        }

        public static async Task<Tuple<DataTable, string, DateTime, DateTime>> GetMassNAMIRates(NpgsqlConnection connection, DateTime dateCutOff, bool flgOnlyWithnonZeroRates, bool flgOnlyEligibleNow)
        {
            //Console.WriteLine("due amount start {0}", DateTime.Now.ToLongTimeString().ToString());
            String sbsb_ckList = "";
            List<long> lstSbsb_ck1 = new List<long>();
            if (flgOnlyEligibleNow)
            {
                NpgsqlCommand commandAlt = new NpgsqlCommand(sqlMassNAMICurrentEligibilityList1 + dateCutOff.ToString() + sqlMassNAMICurrentEligibilityList2, connection)
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

                    if (((flag) && (sbsb_ckId != System.Convert.ToInt64(thisReaderAlt["sbsb_ck"], CultureInfo.InvariantCulture)))
                    {
                        lstSbsb_ck1.Add(sbsb_ckId);
                        sbsb_ckList += sbsb_ckId + ",";
                    }
                    sbsb_ckId = System.Convert.ToInt64(thisReaderAlt["sbsb_ck"], CultureInfo.InvariantCulture);
                    flag = true;
                }
                if (flag)
                {
                    lstSbsb_ck1.Add(sbsb_ckId);
                    sbsb_ckList += sbsb_ckId + ",";
                }
                thisReaderAlt.Close();
            }
            if (sbsb_ckList.Length > 0)
            {
                sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);
            }
            String sql = "";
            if (flgOnlyWithnonZeroRates)
            {
                sql = sqlMassNAMIRates1 + sbsb_ckList + sqlMassNAMIRates2 + dateCutOff.ToString() + sqlMassNAMIRates3;
            }
            else
            {
                sql = sqlMassNAMIRates1 + sbsb_ckList + sqlMassNAMIRates2;
            }
            NpgsqlCommand command = new NpgsqlCommand(sql, connection)
            {
                CommandTimeout = 86400
            };
            await command.ExecuteNonQueryAsync();
            NpgsqlDataReader thisReader = (NpgsqlDataReader)await command.ExecuteReaderAsync();
            DataTable tblMassNAMIList = new DataTable();
            tblMassNAMIList.Load(thisReader);
            thisReader.Close();
            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = new DateTime(1900, 1, 1);
            for (int i = 0; i < tblMassNAMIList.Rows.Count; i++)
            {
                tblMassNAMIList.Rows[i][24] = 0;
                tblMassNAMIList.Rows[i][25] = 0;
            }
            String blei_ckList = "";
            if (tblMassNAMIList.Rows.Count > 0)
            {
                for (int i = 0; i < tblMassNAMIList.Rows.Count; i++)
                {
                    int j = 0;
                    while ((data.Rows.Count > j) && (System.Convert.ToInt32(tblMassNAMIList.Rows[i][12], CultureInfo.InvariantCulture) > System.Convert.ToInt32(data.Rows[j][2], CultureInfo.InvariantCulture))) j++;
                    if ((data.Rows.Count > j) && (System.Convert.ToInt32(tblMassNAMIList.Rows[i][12], CultureInfo.InvariantCulture) == System.Convert.ToInt32(data.Rows[j][2], CultureInfo.InvariantCulture)))
                    {
                        tblMassNAMIList.Rows[i][24] = data.Rows[j][3];
                        tblMassNAMIList.Rows[i][25] = data.Rows[j][0];
                        blei_ckList += data.Rows[j][0] + ",";
                    }
                }
                blei_ckList = blei_ckList.Substring(0, blei_ckList.Length - 1);
            }
            //Console.WriteLine("due amount stop {0}", DateTime.Now.ToLongTimeString().ToString());
            return new Tuple<DataTable, String, DateTime, DateTime>(tblMassNAMIList, blei_ckList, minDate, maxDate);
        }
    }
}Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture))) ||
                        ((date < dateCutOff) && (dateCutOff < System.Convert.ToDateTime(thisReaderAlt.GetValue(1), CultureInfo.InvariantCulture)) && (flag) && (sbsb_ckId == System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture))))
                        lstSbsb_ck1.Add(System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture));
                    date = System.Convert.ToDateTime(thisReaderAlt.GetValue(1), CultureInfo.InvariantCulture);
                    sbsb_ckId = System.Convert.ToInt64(thisReaderAlt.GetValue(0), CultureInfo.InvariantCulture);
                    if (((string)thisReaderAlt.GetValue(2)).Trim() == "Y") flag = true;
                    else flag = false;

                }

            }
            List<long> lstSbsb_ck2 = new List<long>();
            if (flgOnlyWithnonZeroRates)
            {
                NpgsqlCommand commandAlt = new NpgsqlCommand(sqlMassNAMINonZeroRatesList, connection)
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
            else if (((lstSbsb_ck2.Count == 0) && (lstSbsb_ck1.Count > 0)))          {
                foreach (long a in lstSbsb_ck1) sbsb_ckList += a.ToString(CultureInfo.InvariantCulture) + ",";
                sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);
            }
            else if (((lstSbsb_ck2.Count > 0) && (lstSbsb_ck1.Count == 0)))
            {
                foreach (long a in lstSbsb_ck2) sbsb_ckList += a.ToString(CultureInfo.InvariantCulture) + ",";
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
                NpgsqlCommand command = new NpgsqlCommand(sqlMassNAMIRates, connection)
                {
                    CommandTimeout = 86400
                };
               command.ExecuteNonQuery();
                NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
                while (thisReader.Read())
                {
                    DateTime date = System.Convert.ToDateTime(thisReader["date"]);
                    // Processing data
                }
            }DateTime(6),
                        thisReader.GetValue(7),
                        thisReader.GetValue(8),
                        thisReader.GetValue(9),
                        thisReader.GetValue(10),
                        thisReader.GetValue(11),
                        thisReader.GetValue(12));
                    if (!sbsb_ckList.Contains(thisReader.GetValue(0).ToString())) sbsb_ckList += thisReader.GetValue(0).ToString() + ",";
                    if (minDate > date) minDate = date;
                    if (maxDate < date) maxDate = date;
                }

                sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);

            }
            else
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlMassRatesFromList1 + sbsb_ckList + sqlMassRatesFromList2, connection)
                {
                    CommandTimeout = 86400
                };
                command.ExecuteNonQuery();
                NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
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
                        thisReader.GetValue(8),
                        thisReader.GetValue(9),
                        thisReader.GetValue(10),
                        thisReader.GetValue(11),
                        thisReader.GetValue(12));
                    if (!sbsb_ckList.Contains(thisReader.GetValue(0).ToString())) sbsb_ckList += thisReader.GetValue(0).ToString() + ",";
                    if (minDate > date) minDate = date;
                    if (maxDate < date) maxDate = date;
                }

                sbsb_ckList = sbsb_ckList.Substring(0, sbsb_ckList.Length - 1);

            }DateTime(1900, 1, 1);

            while (thisReader.Read())
            {
                DateTime date = (DateTime)thisReader.GetValue(0);
                data.Rows.Add(date,
                    thisReader.GetValue(1),
                    thisReader.GetValue(2),
                    thisReader.GetValue(3),
                    thisReader.GetValue(4),
                    thisReader.GetValue(5),
                    thisReader.GetValue(6),
                    thisReader.GetValue(7),
                    thisReader.GetValue(8));

                if (minDate > date) minDate = date;
                if (maxDate < date) maxDate = date;
            }

            return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
        }ng));
            data.Columns.Add("blbl_wnrt_sts", typeof(String));

            DateTime minDate = DateTime.MaxValue;
            DateTime maxDate = DateTime.MinValue;

            while (thisReader.Read())
            {
                DateTime date = System.Convert.ToDateTime(thisReader.GetValue(0), CultureInfo.InvariantCulture);
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
        }cpt_payor_name", typeof(String));
            data.Columns.Add("rcpt_amt", typeof(Decimal));
            data.Columns.Add("rcpt_due_dt", typeof(DateTime));
            data.Columns.Add("rcpt_pay_dt", typeof(DateTime));
            data.Columns.Add("rcpt_pay_method", typeof(String));
            data.Columns.Add("rcpt_pay_amt", typeof(Decimal));
            data.Columns.Add("rcpt_payor_id", typeof(String));
            data.Columns.Add("rcpt_payor_type", typeof(String));
            data.Columns.Add("rcpt_note", typeof(String));
            data.Columns.Add("rcpt_voided", typeof(Boolean));
            data.Columns.Add("rcpt_voided_dt", typeof(DateTime));
            data.Columns.Add("rcpt_voided_by", typeof(String));
            data.Columns.Add("rcpt_voided_note", typeof(String));
            data.Columns.Add("rcpt_voided_reason", typeof(String));
            data.Columns.Add("rcpt_voided_amt", typeof(Decimal));
            data.Columns.Add("rcpt_voided_rcpt_id", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_date", typeof(DateTime));
            data.Columns.Add("rcpt_voided_rcpt_payor_id", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_payor_type", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_note", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_voided", typeof(Boolean));
            data.Columns.Add("rcpt_voided_rcpt_voided_dt", typeof(DateTime));
            data.Columns.Add("rcpt_voided_rcpt_voided_by", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_voided_note", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_voided_reason", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_voided_amt", typeof(Decimal));
            data.Columns.Add("rcpt_voided_rcpt_voided_rcpt_id", typeof(String));
            data.Columns.Add("rcpt_voided_rcpt_voided_rcpt_date", typeof(DateTime));

            DateTime minDate = new DateTime(3000, 12, 31);
            DateTime maxDate = new DateTime(1900, 1, 1);

            while (thisReader.Read())
            {
                DateTime date = System.Convert.ToDateTime(thisReader.GetValue(3), CultureInfo.InvariantCulture);
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
                        thisReader.GetValue(32)
                );
                if (minDate > date) minDate = date;
                if (maxDate < date) maxDate = date;
            }
            return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
        }public static async Task<Tuple<DataTable, DateTime, DateTime>> GetMassNAMIEligibility(NpgsqlConnection connection, String meme_ckList)
{
    NpgsqlCommand command = new NpgsqlCommand(sqlMassNAMIEligibility1 + meme_ckList + sqlMassNAMIPayments2, connection);
    DataTable data = new DataTable();
    data.Columns.Add("meme_ck", typeof(String));
    data.Columns.Add("meme_ckList", typeof(String));
    data.Columns.Add("meme_ckList", typeof(String));
    data.Columns.Add("cpt_mctr_rsn", typeof(String));
    data.Columns.Add("grgr_id", typeof(String));
    data.Columns.Add("type", typeof(String));
    data.Columns.Add("dt", typeof(DateTime));
    data.Columns.Add("selection", typeof(String));
    data.Columns.Add("rcpt_amt", typeof(Decimal));
    data.Columns.Add("applied_amt", typeof(Decimal));
    data.Columns.Add("rcpt_sts", typeof(String));
    DateTime minDate = new DateTime(3000, 12, 31);
    DateTime maxDate = new DateTime(1900, 1, 1);

    using (NpgsqlDataReader thisReader = await command.ExecuteReaderAsync())
    {
        while (thisReader.Read())
        {
            DateTime date = System.Convert.ToDateTime(thisReader.GetValue(3), CultureInfo.InvariantCulture);
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
                    thisReader.GetValue(12)
            );
            if (minDate > date) minDate = date;
            if (maxDate < date) maxDate = date;
        }
    }
    return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
}            data.Rows.Add(
                thisReader.GetInt32(0),
                thisReader.GetString(1),
                date,
                System.Convert.ToDateTime(thisReader.GetValue(3), CultureInfo.InvariantCulture),
                System.Convert.ToDateTime(thisReader.GetValue(4), CultureInfo.InvariantCulture),
                thisReader.GetString(5),
                thisReader.GetInt32(6),
                thisReader.GetInt32(7),
                thisReader.GetString(8),
                thisReader.GetString(9),
                thisReader.GetString(10),
                thisReader.GetString(11),
                thisReader.GetString(12),
                thisReader.GetString(13),
                thisReader.GetString(14),
                thisReader.GetString(15),
                thisReader.GetString(16),
                thisReader.GetString(17),
                thisReader.GetString(18),
                thisReader.GetString(19),
                thisReader.GetString(20),
                System.Convert.ToDateTime(thisReader.GetValue(21), CultureInfo.InvariantCulture),
                thisReader.GetInt32(22),
                System.Convert.ToDateTime(thisReader.GetValue(23), CultureInfo.InvariantCulture)
            );
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
        connection.Close();
        return data;data.Rows.Add(thisReader.GetValue(0),
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
                        thisReader.GetValue(22)
                );
                if (minDate > date) minDate = date;
                if (maxDate < date) maxDate = date;

            }
            return new Tuple<DataTable, DateTime, DateTime>(data, minDate, maxDate);
        }
        private static string GetMassNAMIConnectionString(string username, string password)
        {
            // You will need to modify this connection string to match your SQL Server Configuration
            return "Server=************;Database=************;port=5432;User Id=" + username + ";Password=" + password;
        }



    }
}