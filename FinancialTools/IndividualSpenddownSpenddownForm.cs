            // Decrypt username & password and print to the console

            DateTime cutoffDate = dateIndividualSpenddownCutOffTimePicker.Value;

        }ownSpenddown.Columns["Amount"].DefaultCellStyle.Format = "c";
            dataIndividualSpenddownSpenddown.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }ownSpenddown.Columns["Billed"].DefaultCellStyle.Format = "0.##";
            dataIndividualSpenddownSpenddown.Columns["Adjmnts"].DefaultCellStyle.Format = "0.##";
            dataIndividualSpenddownSpenddown.Columns["Paid"].DefaultCellStyle.Format = "0.##";
            dataIndividualSpenddownSpenddown.Columns["Expenses"].DefaultCellStyle.Format = "0.##";
            dataIndividualSpenddownSpenddown.Columns["Paid months"].DefaultCellStyle.Format = "0.##";

            if (dataIndividualSpenddownSpenddown.RowCount > 0) dataIndividualSpenddownSpenddown.FirstDisplayedScrollingRowIndex = dataIndividualSpenddownSpenddown.RowCount - 1;

            EnableControls();

        }

        private void BtnIndividualSpenddownSubmit_Click(object sender, EventArgs e)
        {
            string strSubscriberId = txtSubID.Text.Trim();
            if (strSubscriberId.Length < 8)
            {
                MessageBox.Show("The subscriber id is too short");
                return;
            }
            if (!LanguageUtils.IsDigitsOnly(strSubscriberId))
            {
                MessageBox.Show("The subscriber id is in incorrect format");
                return;
            }
            DisableControls();
            backgroundIndividualSpenddownCalculation.RunWorkerAsync();
        }

        public IndividualSpenddownForm()
        {
            InitializeComponent();

            var dir = new DirectoryInfo(Directory.GetCurrentDirectory());

            foreach (var file in dir.EnumerateFiles("*.xlsx"))
            {
                //LanguageUtils.IgnoreErrors(() => file.Delete());
            }
        }

        private void BtnIndividualSpenddownToExcelWithFormulas_Click(object sender, EventArgs e)
        {
            DisableControls();

            _ = Export.ExportSpenddownTableToExcelWithFormulas(tblSubscriberSpenddownCalculation);
            EnableControls();

        }

        private void BtnIndividualSpenddownToExcelWithoutFormulas_Click(object sender, EventArgs e)
        {
            DisableControls();
            _ = Export.ExportSpenddownTableToExcelWithoutFormulas(tblSubscriberSpenddownCalculation);

            EnableControls();
        }
    }

}