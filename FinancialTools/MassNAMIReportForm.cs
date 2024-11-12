        }

        private void btnMassNAMIBuildReport_Click(object sender, EventArgs e)
        {
            DisableControls();

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += BackgroundMassNAMICalculation_DoWork;
            worker.ProgressChanged += BackgroundMassNAMICalculation_ProgressChanged;
            worker.RunWorkerCompleted += BackgroundMassNAMICalculation_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private void BackgroundMassNAMICalculation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableControls();
            MessageBox.Show("Mass NAMI Report generation completed.");
        }

        private void btnMassNAMIShortReportToExcel_Click(object sender, EventArgs e)
        {
            // Code to export short report to Excel
        }

        private void btnMassNAMIShortReportToCSV_Click(object sender, EventArgs e)
        {
            // Code to export short report to CSV
        }
    }
}            // Decrypt username & password and print to the console

            DateTime cutoffDate = dateMassNAMICutOffTimePicker.Value;

            List<string> IDList = new List<string>();
            List<int> GRGRCK = new List<int>();
            GRGRCK.Add(9);
            List<string> CSPIIDList = new List<string>();
            CSPIIDList.Add("NYM00000");
            CSPIIDList.Add("NYM0HARP");
            CSPIIDList.Add("NYMHR000");
            CSPIIDList.Add("NYMMAA00");
            CSPIIDList.Add("NYMN0000");
            CSPIIDList.Add("NYMSSI10");
            CSPIIDList.Add("MMP00000");
            CSPIIDList.Add("MCDA0000");
            CSPIIDList.Add("MCDAF000");
            CSPIIDList.Add("MCDMAP00");
            CSPIIDList.Add("LTCP0000");
            CSPIIDList.Add("LTCPNHC0");
            CSPIIDList.Add("LTCPNNH0");
            CSPIIDList.Add("LTCR0000");
            CSPIIDList.Add("LTCRNHC0");

            GreenplumDB greenplum = new GreenplumDB(FinancialToolsSettings.GreenplumDBUsername, FinancialToolsSettings.GreenplumDBPassword);
            List<Subscriber> subList = greenplum.GetSubscribers(IDList, EligibleOnDate: true, cutoffDate, GRGRCK, CSPIIDList, objProgress: backgroundMassNAMICalculation, PositiveRatesOnly: true, NAMI: 2);

            tblShortMassNAMICalculation.Columns.Add("Date", typeof(DateTime));
            tblShortMassNAMICalculation.Columns.Add("ID", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("First Name", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Last Name", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Medicaid ID", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Family");            Link", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Calculated amount due", typeof(decimal));
            tblShortMassNAMICalculation.Columns.Add("DB amount due", typeof(decimal));
            tblShortMassNAMICalculation.Columns.Add("# of unpaid months from the latest payment", typeof(int));
            tblShortMassNAMICalculation.Columns.Add("# of paid months", typeof(int));
           
            tblShortMassNAMICalculation.Columns.Add("# of unpaid months", typeof(int));
            tblShortMassNAMICalculation.Columns.Add("# of total months", typeof(int));

            tblShortMassNAMICalculation.Columns.Add("Total billed", typeof(decimal));
            
            tblShortMassNAMICalculation.Columns.Add("Total paid", typeof(decimal));
            tblShortMassNAMICalculation.Columns.Add("Total expenses", typeof(decimal));
            tblShortMassNAMICalculation.Columns.Add("CSPI ID", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("GRGR CK", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("CSCS ID", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Trust Notice", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Provider Name", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Provider Effective Date", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Provider Termination Date", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Provider GRGR CK", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Provider ID", typeof(string));
            tblShortMassNAMICalculation.Columns.Add("Provider NPI", typeof(string));
            foreach ( var sub in subList)
            {
                DataTable tblIndividual = sub.GetInfoTable(cutoffDate,TableType: 1);
                //tblIndividual.Rows[0].Delete();
                foreach (DataRow dr in tblIndividual.Row
        }

        private void BackgroundMassNAMICalculation_DoWork(object sender, DoWorkEventArgs e)
        {
            // Perform background calculation here
        }

        private void BackgroundMassNAMICalculation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Handle completion of background calculation
        }

        private void BtnMassNAMISubmit_Click(object sender, EventArgs e)
        {
            // Submit button click event
        }

        private void BtnShortMassNAMIReportExportToExcel_Click(object sender, EventArgs e)
        {
            // Export to Excel button click event
        }```csharp
        }
        private void BtnShortMassNAMIReportExportToCSV_Click(object sender, EventArgs e)
        {
            DisableControls();
            Export.ExportToCSV(tblShortMassNAMICalculation);

            EnableControls();
        }
    }
}
```