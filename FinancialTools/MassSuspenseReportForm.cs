        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundMassSuspenseCalculation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableControls();
            progressBar1.Visible = false;

            if (e.Error != null)
            {
                MessageBox.Show("Error occurred: " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Operation was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMassSuspenseBuildReport_Click(object sender, EventArgs e)
        {
            DisableControls();
            progressBar1.Visible = true;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += BackgroundMassSuspenseCalculation_ProgressChanged;
            worker.RunWorkerCompleted += BackgroundMassSuspenseCalculation_RunWorkerCompleted;
            worker.DoWork += (s, ev) =>
            {
                // Code for building the report goes here
            };

            worker.RunWorkerAsync();
        }

        private void btnMassSuspenseShortReportToExcel_Click(object sender, EventArgs e)
        {
            // Code for exporting report to Excel goes here
        }

        private void btnMassSuspenseShortReportToCSV_Click(object sender, EventArgs e)
        {
            // Code for exporting report to CSV goes here
        }
    }
}{
            barMassSuspenseReportProgress.Value = e.ProgressPercentage;
            
        }
        private void BackgroundMassSuspenseCalculation_DoWork(object sender, DoWorkEventArgs e)
        {

       

            GreenplumDB greenplum = new GreenplumDB(FinancialToolsSettings.GreenplumDBUsername, FinancialToolsSettings.GreenplumDBPassword);

            //greenplum.SuspenseBuildFin150Report(backgroundMassSuspenseCalculation);
            tblEPPAllYears = greenplum.SuspenseBuildDBAllYearsTable("EPP", "Y", backgroundMassSuspenseCalculation, 10);
            tblEPPLastActive = greenplum.SuspenseBuildDBLastActiveTable( backgroundMassSuspenseCalculation, 14);
            tblEPPAllYears.Merge( greenplum.SuspenseBuildDBAllYearsTable("EPP", "N", backgroundMassSuspenseCalculation, 15));
            tblEPPLastActive.Merge(greenplum.SuspenseBuildDBLastActiveTable(backgroundMassSuspenseCalculation, 19));
            tblCHPAllYears = greenplum.SuspenseBuildDBAllYearsTable("CHP", "Y", backgroundMassSuspenseCalculation, 20);
            tblCHPLastActive = greenplum.SuspenseBuildDBLastActiveTable(backgroundMassSuspenseCalculation, 24);
            tblCHPAllYears.Merge(greenplum.SuspenseBuildDBAllYearsTable("CHP", "N", backgroundMassSuspenseCalculation, 25));
            tblCHPLastActive.Merge(greenplum.SuspenseBuildDBLastActiveTable(backgroundMassSuspenseCalculation, 29));
            //greenplum.SuspenseAppendAllYears(tblCHPAllYears, "CHP", backgroundMassSuspenseCalculation, 34);
            //greenplum.SuspenseAppendAllYears(tblCHPAllYears, "EPP", backgroundMassSuspenseCalculation, 39);
            tblCHPReportHistorical = greenplum.SuspenseBuildReportHistorical( "CHP", backgroundMassSuspenseCalculation, 44);
            tblEPPReportHistorical = greenplum.SuspenseBuildReportHistorical( "EPP", backgroundMassSuspenseCalculation, 49);
            //Export.ExportSuspenseReportToExcel(tblCHPAllYears, tblCHPLastActive, tblCHPReportHistorical, "CHP"
}, DateTime.Now);
            //Export.ExportSuspenseReportToExcel(tblEPPAllYears, tblEPPLastActive, tblEPPReportHistorical, "EPP", DateTime.Now);
            backgroundMassSuspenseCalculation.ReportProgress(100);


        }
        private void BackgroundMassSuspenseCalculation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //MessageBox.Show("Work completed successfully");
            //dataMassSuspense.DataSource = tblShortMassSuspenseCalculation;

            
            btnMassSuspenseShortReportToExcel.Enabled = true;
            btnMassSuspenseShortReportToCSV.Enabled = true;



            //dataMassSuspense.FirstDisplayedScrollingRowIndex = dataMassSuspense.RowCount - 1;
            
            EnableControls();

        }
        private void BtnMassSuspenseSubmit_Click(object sender, EventArgs e)
        {
            DisableControls();

            backgroundMassSuspenseCalculation.RunWorkerAsync();

            

        }


        private void BtnShortMassSuspenseReportExportToExcel_Click(object sender, EventArgs e)
        {

            DisableControls();
           // _ = Export.ExportMassSuspenseTableToExcel(tblShortMassSuspenseCalculation);

            EnableControls();

        }
        private void BtnShortMassSuspenseReportExportToCSV_Click(object sender, EventArgs e)
        {
            DisableControls();
            //Export.ExportToCSV(tblShortMassSuspenseCalculation);


            EnableControls();

        }


    }
}