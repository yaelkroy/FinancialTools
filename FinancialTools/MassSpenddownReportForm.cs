sender, DoWorkEventArgs e)
        {
            DisableControls();

            BackgroundWorker worker = sender as BackgroundWorker;

            //CODE TO CALCULATE MASS SPENDDOWN REPORT

            EnableControls();
        }

        private void OnMassSpenddownShortReportToExcelClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                //CODE TO EXPORT SHORT MASS SPENDDOWN CALCULATION TO EXCEL
            }
        }

        private void OnMassSpenddownShortReportToCSVClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                //CODE TO EXPORT SHORT MASS SPENDDOWN CALCULATION TO CSV
            }
        }
    }
}
            tblShortMassSpenddownCalculation.Columns.Add("Date", typeof(DateTime));
            tblShortMassSpenddownCalculation.Columns.Add("ID", typeof(string));
            tblShortMassSpenddownCalculation.Columns.Add("First Name", typeof(string));
            tblShortMassSpenddownCalculation.Columns.Add("Last Name", typeof(string));

            foreach (Subscriber sub in subList)
            {
                DataRow row = tblShortMassSpenddownCalculation.NewRow();
                row["Date"] = sub.Date;
                row["ID"] = sub.ID;
                row["First Name"] = sub.FirstName;
                row["Last Name"] = sub.LastName;
                tblShortMassSpenddownCalculation.Rows.Add(row);
            }

            dgvShortMassSpenddownCalculation.DataSource = tblShortMassSpenddownCalculation;

            // Encrypt username & password and save to the database

            //string encryptedUsername = EncryptString(FinancialToolsSettings.GreenplumDBUsername, "encryptionKey");
            //string encryptedPassword = EncryptString(FinancialToolsSettings.GreenplumDBPassword, "encryptionKey");

            //greenplum.SaveEncryptedCredentials(encryptedUsername, encryptedPassword);
        }) {
                DataRow row = tblShortMassSpenddownCalculation.NewRow();
                row["Medicaid ID"] = sub.MedicaidID;
                row["Family Link"] = sub.FamilyLink;
                row["Calculated amount due"] = sub.CalculatedAmountDue;
                row["DB amount due"] = sub.DBAmountDue;
                row["# of unpaid months from the latest payment"] = sub.UnpaidMonthsLatestPayment;
                row["# of paid months"] = sub.PaidMonths;
                row["# of unpaid months"] = sub.UnpaidMonths;
                row["# of total months"] = sub.TotalMonths;
                row["Total billed"] = sub.TotalBilled;
                row["Total paid"] = sub.TotalPaid;
                row["Total expenses"] = sub.TotalExpenses;
                row["CSPI ID"] = sub.CSPIID;
                row["GRGR CK"] = sub.GRGRCK;
                row["CSCS ID"] = sub.CSCSID;
                row["Trust Notice"] = sub.TrustNotice;
                row["Provider Name"] = sub.ProviderName;
                row["Provider Effective Date"] = sub.ProviderEffectiveDate;
                row["Provider Termination Date"] = sub.ProviderTerminationDate;
                row["Provider GRGR CK"] = sub.ProviderGRGRCK;
                row["Provider ID"] = sub.ProviderID;
                row["Provider NPI"] = sub.ProviderNPI;
                tblShortMassSpenddownCalculation.Rows.Add(row);
            }lation.RunWorkerAsync();
        }public partial class MainForm : Form
{

    public MainForm()
    {
        InitializeComponent();
        bgwCalculation.RunWorkerAsync();
    }

    private void BtnShortMassSpenddownReportExportToExcel_Click(object sender, EventArgs e)
    {
        DisableControls();
        _ = Export.ExportMassSpenddownTableToExcel(tblShortMassSpenddownCalculation);
        EnableControls();
    }

    private void BtnShortMassSpenddownReportExportToCSV_Click(object sender, EventArgs e)
    {
        DisableControls();
        Export.ExportToCSV(tblShortMassSpenddownCalculation);
        EnableControls();
    }

}
```