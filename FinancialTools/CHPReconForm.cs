                dates.Add(file.CreationTime);
            }

            dates.Sort();
            dates.Reverse();

            if (dates.Count > 0)
            {
                IndexOfSelectedDate = 0;
                LoadData(dates[IndexOfSelectedDate]);
            }
        }

        private void LoadData(DateTime date)
        {
            var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            var path = Path.Combine(dir.FullName, date.ToString("yyyyMMdd") + ".xlsx");
            var dt = ExcelReader.ReadExcel(path);

            tblSummaryMOSPaid = dt.Tables["tblSummaryMOSPaid"];
            tblMaxDateInHistoricDetail = dt.Tables["tblMaxDateInHistoricDetail"];
            tblMaxDateInHistoricDup = dt.Tables["tblMaxDateInHistoricDup"];
            tblAdjSummaryByMos = dt.Tables["tblAdjSummaryByMos"];
            tblRptAdjSummary = dt.Tables["tblRptAdjSummary"];
            tblRptSummaryForCurrentMM = dt.Tables["tblRptSummaryForCurrentMM"];
            tblRptSummaryCur = dt.Tables["tblRptSummaryCur"];
            tblRptMon = dt.Tables["tblRptMon"];
            tblRptMonSummary = dt.Tables["tblRptMonSummary"];
            tblRptSummaryBy6Ms = dt.Tables["tblRptSummaryBy6Ms"];
            tblRptSummaryCurrentMonth = dt.Tables["tblRptSummaryCurrentMonth"];
            tblRptPrepSummarybyMos = dt.Tables["tblRptPrepSummarybyMos"];
            tblRptVoucherSummary = dt.Tables["tblRptVoucherSummary"];
            tblRptUnpaidSummaryByMOS = dt.Tables["tblRptUnpaidSummaryByMOS"];
            tblRptMbrByMOS = dt.Tables["tblRptMbrByMOS"];
            tblRptPytAmtbyMOS = dt.Tables["tblRptPytAmtbyMOS"];
            tblTmpDedupListing = dt.Tables["tblTmpDedupListing"];
            tblTmpDetailVoucherDup = dt.Tables["tblTmpDetailVoucherDup"];

            dataGridView1.DataSource = tblSummaryMOSPaid;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            IndexOfSelectedDate = Math.Min(dates.Count - 1, IndexOfSelectedDate + 1);
            LoadData(dates[IndexOfSelectedDate]);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            IndexOfSelectedDate = Math.Max(0, IndexOfSelectedDate - 1);
            LoadData(dates[IndexOfSelectedDate]);
        }
    }
}file.Delete());
            }
        }
        private void DisableControls()
        {
            Cursor.Current = Cursors.WaitCursor;
            btnCHPReconBuildReports.Enabled = false;
            

        }
        private void EnableControls()
        {
            Cursor.Current = Cursors.Default;
            btnCHPReconBuildReports.Enabled = true;

        }

        private DataTable tblFullCHPReconCalculation = new DataTable();
        private DataTable tblShortCHPReconCalculation = new DataTable();
        private void OnCHPReconReportFormLoad(object sender, EventArgs e)
        {


            int year = (System.DateTime.Now.Year);
            for (int intCount = year; intCount >= 2005; intCount--)
            {
                int MonthCount = 12;
                if (intCount == year) MonthCount = System.DateTime.Now.Month;
                for (int i = MonthCount; i >= 1; i--)
                {
                    dates.Add(new DateTime(year, i, 1));
                    string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i);
                    lstbxCHPReconPickDate.Items.Add(MonthName + " - " + intCount.ToString());
                }
            }

            lstbxCHPReconPickDate.SelectedIndex = 0;


        }

 
        //THIS UPDATES GUI.OUR PROGRESSBAR
        private void BackgroundCHPReconCalculation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            barCHPReconReportProgress.Value = e.ProgressPercentage;
            
        }
        private void BackgroundCHPReconCalculation_DoWork(object sender, DoWorkEventArgs e)
        {
            GreenplumDB Greenplum = new GreenplumDB(FinancialToolsSettings.GreenplumDBUsername, FinancialToolsSettings.GreenplumDBPassword);

            //Greenplum.CHPReconRecreateTables();
            int depth = 0;
            int OneStepScale = 100 / (depth+1);
            int step = 2;
            
            for (i                Greenplum.CHPReconDropTables();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale*(depth - i));
                
                Greenplum.CHPReconСreateTables();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.CHPReconCleanInHistoryIfExists(dates[IndexOfSelectedDate].AddMonths(-i));
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.CHPReconGetVoucherDetails(dates[IndexOfSelectedDate].AddMonths(-i));
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.CHPReconAppendUnpaidSummary(dates[IndexOfSelectedDate].AddMonths(-i));
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.CHPReconGroupingDeduping();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));ulation.ReportProgress(cummProp + OneStepScale * (depth - i));


                tblSummaryMOSPaid = Greenplum.GetMaxDatesInHistory();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblMaxDateInHistoricDetail = Greenplum.GetMaxDateInHistoricDetail();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblMaxDateInHistoricDup = Greenplum.GetMaxDateInHistoricDup();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblAdjSummaryByMos = Greenplum.GetAdjSummaryByMOS();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblRptAdjSummary = Greenplum.GetAdjSummary();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblRptSummaryForCurrentMM = Greenplum.GetSummaryForCurrentMM();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblRptSummaryCur = Greenplum.CHPReconReportSummaryCur();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblRptMon = Greenplum.CHPReconReportMon();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblRptMonSummary = Greenplum.CHPReconReportMonSummary();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));



                Greenplum.CHPReconAppendCurActiveSummary(dates[IndexOfSelectedDate].AddMonths(-i));
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.CHPReconAppendCurAdjSummary();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.CHPReconAppendVchrDettoCummHist();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.CHPReconAppendDupRecToHist();
                cummStep += step;cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

Greenplum.CHPReconReportPaidSummary();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

Greenplum.CHPReconReportPaidMMMOSbyPytMon();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

Greenplum.CHPReconReportUnpaidMMbyMOS();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

Greenplum.CHPReconReportPrepSummarybyMos();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

tblRptPrepSummarybyMos = Greenplum.CHPReconReportSummarybyMos();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

Greenplum.CHPReconAppendCurMonData();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depthGreenplum.CHPReconReportCurMon();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

Greenplum.CHPReconPrepAppendMonList();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

Greenplum.CHPReconRptPrepSummBy6m();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

tblRptSummaryBy6Ms = Greenplum.CHPReconReportSummaryBy6Ms();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

tblRptSummaryCurrentMonth = Greenplum.CHPReconReportSummaryCurrentMonth();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

tblRptVoucherSummary = Greenplum.CHPReconReportVoucherSummary();
cummStep += step;
cummProp = cummStep / (depth + 1);
if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

tblRptUnpaidSummaryByMOS = Greenplum.CHPReconReportUnpaidSummaryByMOS();
cummStep += step;                tblRptMbrByMOS = Greenplum.GetReportMbrByMOS();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblRptPytAmtbyMOS = Greenplum.GetReportPytAmtbyMOS();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblTmpDedupListing = Greenplum.GetReportTmpDedupListing();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                tblTmpDetailVoucherDup = Greenplum.GetReportTmpDetailVoucherDup();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Greenplum.DropTables();
                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));

                Export.ExportReportToExcel(tblRptSummaryCurrentMonth,
                                tblRptPrepSummarybyMos,
                                tblRptVoucherSummary,
                                tblRptUnpaidSummaryByMOS,
                                tblRptMbrByMOS,
                                tblRptPytAmtbyMOS,
                                tblRptSummaryForCurrentMM,
                                tblAdjSummaryByMos,
                                tblRptSummaryBy6Ms,
                                tblTmpDedupListing,
                                tblTmpDetailVoucherDup,
                                dates[IndexOfSelectedDate].AddMonths(-i));

                cummStep += step;
                cummProp = cummStep / (depth + 1);
                if((cummProp + OneStepScale * (depth - i))<=100) backgroundCHPReconCalculation.ReportProgress(cummProp + OneStepScale * (depth - i));
            }
            backgroundCHPReconCalculation.ReportProgress(100);
        }
        private void BackgroundCHPReconCalculation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //MessageBox.Show("Work completed successfully");

            EnableControls();

        }


        private void btnCHPReconBuildReports_Click(object sender, EventArgs e)
        {
            DisableControls();
            IndexOfSelectedDate = lstbxCHPReconPickDate.SelectedIndex;
            backgroundCHPReconCalculation.RunWorkerAsync();
        }
    }
}