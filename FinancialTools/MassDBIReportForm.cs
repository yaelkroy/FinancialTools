        }

        private void btnMassDBIBuildReport_Click(object sender, EventArgs e)
        {
            DisableControls();

            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += BackgroundMassDBICalculation_DoWork;
            bw.ProgressChanged += BackgroundMassDBICalculation_ProgressChanged;
            bw.RunWorkerCompleted += BackgroundMassDBICalculation_Completed;
            bw.RunWorkerAsync();
        }

        private void BackgroundMassDBICalculation_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableControls();
            MessageBox.Show("Mass DBI Report Generated Successfully!");
        }

        private void btnMassDBIShortReportToExcel_Click(object sender, EventArgs e)
        {
            // Code to export short report to Excel
        }

        private void btnMassDBIShortReportToCSV_Click(object sender, EventArgs e)
        {
            // Code to export short report to CSV
        }
    }
}Add("Last Name", typeof(string));
            tblShortMassDBICalculation.Columns.Add("CSPI ID", typeof(string));
            tblShortMassDBICalculation.Columns.Add("GRGRCK", typeof(int));
            tblShortMassDBICalculation.Columns.Add("MassDBI", typeof(double));
            tblShortMassDBICalculation.Columns.Add("Eligible", typeof(bool));
            tblShortMassDBICalculation.Columns.Add("Reason", typeof(string));

            foreach (Subscriber sub in subList)
            {
                DataRow row = tblShortMassDBICalculation.NewRow();
                row["Date"] = sub.Date;
                row["ID"] = sub.ID;
                row["First Name"] = sub.FirstName;
                row["Last Name"] = sub.LastName;
                row["CSPI ID"] = sub.CSPIID;
                row["GRGRCK"] = sub.GRGRCK;
                row["MassDBI"] = sub.MassDBI;
                row["Eligible"] = sub.Eligible;
                row["Reason"] = sub.Reason;
                tblShortMassDBICalculation.Rows.Add(row);
            }

            dataGridViewMassDBICalculation.DataSource = tblShortMassDBICalculation;Add("Last Name", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Medicaid ID", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Family Link", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Calculated amount due", typeof(decimal));
            tblShortMassDBICalculation.Columns.Add("DB amount due", typeof(decimal));
            tblShortMassDBICalculation.Columns.Add("# of unpaid months from the latest payment", typeof(int));
            tblShortMassDBICalculation.Columns.Add("# of paid months", typeof(int));
           
            tblShortMassDBICalculation.Columns.Add("# of unpaid months", typeof(int));
            tblShortMassDBICalculation.Columns.Add("# of total months", typeof(int));

            tblShortMassDBICalculation.Columns.Add("Total billed", typeof(decimal));
            
            tblShortMassDBICalculation.Columns.Add("Total paid", typeof(decimal));
            tblShortMassDBICalculation.Columns.Add("Total expenses", typeof(decimal));
            tblShortMassDBICalculation.Columns.Add("CSPI ID", typeof(string));
            tblShortMassDBICalculation.Columns.Add("GRGR CK", typeof(string));
            tblShortMassDBICalculation.Columns.Add("CSCS ID", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Trust Notice", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Provider Name", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Provider Effective Date", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Provider Termination Date", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Provider GRGR CK", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Provider ID", typeof(string));
            tblShortMassDBICalculation.Columns.Add("Provider NPI", typeof(string));
            foreach ( var sub in subList)
            {
                if ((sub.DiscretionaryItems != null) && sub.DiscretionaryItems.Any(dbi => (dbi.Committed == false)))
                {
                    DataTable tblIndividual = sub.GetInfoTable(cutoffDate, TableType: 1);
                    //tblIndividual.Rows[0].Delete();
                    foreach (DataRow dr in tblIndividual.Rows)
                    {

                        tblShortMassDBICalculation.Rows.Add(dr.ItemArray);

                    }
                    List<Transaction> DBIs = sub.DiscretionaryItems.FindAll(dbi => dbi.Committed == false).ToList();
                    foreach(var dbi in DBIs)
                    {
                        tblShortMassDBICalculation.Rows.Add(dbi.EffectiveDate, dbi.Amount.ToString());
                    }
                }
            }

            /*for (int i = tblShortMassDBICalculation.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(tblShortMassDBICalculation.Rows[i][10]) == 0)
                    tblShortMassDBICalculation.Rows[i].Delete();
            }
            tblShortMassDBICalculation.AcceptChanges();*/
            backgroundMassDBICalculation.ReportProgress(100);


        }
        private void BackgroundMassDBICalculation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //MessageBox.Show("Work completed successfully");
            dataMassDBI.DataSource = tblShortMassDBICalculation;
            dataMassDBI.Columns["Calculated amount due"].DefaultCellStyle.Format = "0.##";
            dataMassDBI.Columns["DB amount due"].DefaultCellStyle.Format = "0.##";
            dataMassDBI.Columns["Total billed"].DefaultCellStyle.Format = "0.##";
            dataMassDBI Columns["Total paid"].DefaultCellStyle.Format = "0.##";
            dataMassDBI.Columns["Total expenses"].DefaultCellStyle.Format = "0.##";
            
            btnMassDBIShortReportToExcel.Enabled = true;
            btnMassDBIShortReportToCSV.Enabled = true;```csharp
            dataMassDBI.FirstDisplayedScrollingRowIndex = dataMassDBI.RowCount - 1;
            
            EnableControls();

        }
        private void BtnMassDBISubmit_Click(object sender, EventArgs e)
        {
            DisableControls();

            backgroundMassDBICalculation.RunWorkerAsync();

            

        }


        private void BtnShortMassDBIReportExportToExcel_Click(object sender, EventArgs e)
        {

            DisableControls();
            _ = Export.ExportMassDBITableToExcel(tblShortMassDBICalculation);

            EnableControls();

        }
        private void BtnShortMassDBIReportExportToCSV_Click(object sender, EventArgs e)
        {
            DisableControls();
            Export.ExportToCSV(tblShortMassDBICalculation);


            EnableControls();

        }


    }
}
```