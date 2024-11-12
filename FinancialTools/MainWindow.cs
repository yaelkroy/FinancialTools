

                // FinancialToolsSettings.Disenrol = key.GetValue("Disenrol").ToString();
                FinancialToolsSettings.Disenrol = @"T:\DataSets_Private\Finance\Disenrolment\";

                key.Close();
            }
            else
            {
                MessageBox.Show("Registry key not found", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSplitPDF_Click(object sender, EventArgs e)
        {
            SplitPDF splitPDF = new SplitPDF();
            splitPDF.ShowDialog();
        }

        private void BtnBulkPDFSearch_Click(object sender, EventArgs e)
        {
            BulkPDFSearch bulkPDFSearch = new BulkPDFSearch();
            bulkPDFSearch.ShowDialog();
        }

        private void BtnDisenrol_Click(object sender, EventArgs e)
        {
            Disenrol disenrol = new Disenrol();
            disenrol.ShowDialog();
        }
    }
}lmentPackagesDisFormSourceDirectory = key.GetValue("DisenrollmentPackagesDisFormSourceDirectory").ToString();
                    FinancialToolsSettings.DisenrollmentPackagesDisLetSourceDirectory = key.GetValue("DisenrollmentPackagesDisLetSourceDirectory").ToString();
                    FinancialToolsSettings.DisenrollmentPackagesInvoiceSourceDirectory = key.GetValue("DisenrollmentPackagesInvoiceSourceDirectory").ToString();
                    FinancialToolsSettings.DisenrollmentPackagesNotASourceDirectory = key.GetValue("DisenrollmentPackagesNotASourceDirectory").ToString();
                    FinancialToolsSettings.DisenrollmentPackagesNotBSourceDirectory = key.GetValue("DisenrollmentPackagesNotBSourceDirectory").ToString();
                    FinancialToolsSettings.DisenrollmentPackagesNotCSourceDirectory = key.GetValue("DisenrollmentPackagesNotCSourceDirectory").ToString();
                    FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory = key.GetValue("DisenrollmentPackagesDestinationDirectory").ToString();
                    key.Close();
        }
                else
                {
                    key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\FinancialTools");
                    key.SetValue("SplitPDFSourceDirectory", "ddd");
                    key.Close();
                    FinancialToolsSettings.SplitPDFSourceDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\SplitPDF\Input\";
                    FinancialToolsSettings.SplitPDFDestinationDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\SplitPDF\Output\";
                    FinancialToolsSettings.BulkPDFSearchSourceDirectory = @"T:\DataSets_Private\Finance\Spenddown\All Paperless Invoices by subscriber\";
                    FinancialToolsSettings.BulkPDFSearchDestinationDirectory = @"T:\DataSets_Private\Finance\Spenddown\BulkSearch\";
                    FinancialToolsSettings.TempDirectory= Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\FinancialTools\Temp\";
                    FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\SplitPDF\Output\Disenrollment Forms\";
                    FinancialToolsSettings.DisenrollmentPackagesDisLetSourceDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\SplitPDF\Output\Disenrollment Letters\";
                    FinancialToolsSettings.DisenrollmentPackagesInvoiceSourceDirectory = @"T:\DataSets_Private\Finance\Spenddown\All Paperless Invoices by subscriber\";
                    FinancialToolsSettings.DisenrollmentPackagesNotASourceDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\SplitPDF\Output\Notification Letters - A Category\";
                    FinancialToolsSettings.DisenrollmentPackagesNotBSourceDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\SplitPDF\Output\Notification Letters - B Category\";
                    FinancialToolsSettings.DisenrollmentPackagesNotCSourceDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\SplitPDF\Output\Notification Letters - C Category\";
                    FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory = KnownFolders.GetPath(KnownFolder.Documents) + @"\FinancialTools\DisenrollmentPackages\Output\";


            }


            LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.SplitPDFSourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.SplitPDFDestinationDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.BulkPDFSearchSourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.BulkPDFSearchDestinationDirectory));
    LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.TempDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.DisenrollmentPackagesDisLetSourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.DisenrollmentPackagesInvoiceSourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.DisenrollmentPackagesNotASourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.DisenrollmentPackagesNotBSourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.DisenrollmentPackagesNotCSourceDirectory));
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory));
                FinancialToolsSettings.GreenplumDBUsername = "username";
                FinancialToolsSettings.GreenplumDBPassword = "password";
                //GreenplumDB GreenplumDB = new GreenplumDB("username", "password");
                //GreenplumDB.Initialization();

            // SplashScreen.ShowSplashScreen();
            Application.DoEvents();
                //SplashScreenXMLStorage.Percents = "";
                //SplashScreenXMLStorage.Interval = ".015";

/*                SplashScreen.SetStatus("Loading module 1");
                System.Threading.Thread.Sleep(500);
                SplashScreen.SetStatus("Loading module 2");
                System.Threading.Thread.Sleep(300);
                SplashScreen.SetStatus("Loading module 3");
                System.Threading.Thread.Sleep(900);
                SpSplashScreen.SetStatus("Loading module 4");
System.Threading.Thread.Sleep(100);
SplashScreen.SetStatus("Loading module 5");
System.Threading.Thread.Sleep(400);
SplashScreen.SetStatus("Loading module 6");
System.Threading.Thread.Sleep(50);
SplashScreen.SetStatus("Loading module 7");
System.Threading.Thread.Sleep(240);
SplashScreen.SetStatus("Loading module 8");
System.Threading.Thread.Sleep(900);
SplashScreen.SetStatus("Loading module 9");
System.Threading.Thread.Sleep(240);
SplashScreen.SetStatus("Loading module 10");
System.Threading.Thread.Sleep(90);
SplashScreen.SetStatus("Loading module 11");
System.Threading.Thread.Sleep(1000);
SplashScreen.SetStatus("Loading module 12");
System.Threading.Thread.Sleep(100);
SplashScreen.SetStatus("Loading module 13");
System.Threading.Thread.Sleep(500);
SplashScreen.SetStatus("Loading module 14", false);
System.Threading.Thread.Sleep(1000);
SplashScreen.SetStatus("Loading module 14a", false);
System.Threading.Thread.Sleep(1000);
SplashScreen.SetStatus("Loading module 14b", false);
System.Threading.Thread.Sleep(1000);
SplashScreen.SetStatus("Loading module 14c", false);
System.Threading.Thread.Sleep(1000);
SplashScreen.SetStatus("Loading module 15");
System.Threading.Thread.Sleep(20);
SplashScreen.SetStatus("Loading module 16");
System.Threading.Thread.Sleep(450);
SplashScreen.SetStatus("Loading module 17");
System.Threading.Thread.Sleep(240);urge_Click(object sender, EventArgs e)
        {
            var BulkUpdateForm = new BulkUpdateForm();
            BulkUpdateForm.ShowDialog();
        }

        private void btnUpdateCHP_Click(object sender, EventArgs e)
        {
            var UpdateCHPForm = new UpdateCHPForm();
            UpdateCHPForm.ShowDialog();
        }

        private void btnUpdateCHPStatus_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusForm = new UpdateCHPStatusForm();
            UpdateCHPStatusForm.ShowDialog();
        }

        private void btnUpdateCHPStatusIndividual_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusIndividualForm = new UpdateCHPStatusIndividualForm();
            UpdateCHPStatusIndividualForm.ShowDialog();
        }

        private void btnUpdateCHPStatusMass_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMassForm = new UpdateCHPStatusMassForm();
            UpdateCHPStatusMassForm.ShowDialog();
        }

        private void btnUpdateCHPStatusMass2_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass2Form = new UpdateCHPStatusMass2Form();
            UpdateCHPStatusMass2Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass3_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass3Form = new UpdateCHPStatusMass3Form();
            UpdateCHPStatusMass3Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass4_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass4Form = new UpdateCHPStatusMass4Form();
            UpdateCHPStatusMass4Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass5_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass5Form = new UpdateCHPStatusMass5Form();
            UpdateCHPStatusMass5Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass6_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass6Form = new UpdateCHPStatusMass6Form();
            UpdateCHPStatusMass6Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass7_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass7Form = new UpdateCHPStatusMass7Form();
            UpdateCHPStatusMass7Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass8_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass8Form = new UpdateCHPStatusMass8Form();
            UpdateCHPStatusMass8Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass9_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass9Form = new UpdateCHPStatusMass9Form();
            UpdateCHPStatusMass9Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass10_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass10Form = new UpdateCHPStatusMass10Form();
            UpdateCHPStatusMass10Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass11_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass11Form = new UpdateCHPStatusMass11Form();
            UpdateCHPStatusMass11Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass12_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass12Form = new UpdateCHPStatusMass12Form();
            UpdateCHPStatusMass12Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass13_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass13Form = new UpdateCHPStatusMass13Form();
            UpdateCHPStatusMass13Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass14_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass14Form = new UpdateCHPStatusMass14Form();
            UpdateCHPStatusMass14Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass15_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass15Form = new UpdateCHPStatusMass15Form();
            UpdateCHPStatusMass15Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass16_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass16Form = new UpdateCHPStatusMass16Form();
            UpdateCHPStatusMass16Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass17_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass17Form = new UpdateCHPStatusMass17Form();
            UpdateCHPStatusMass17Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass18_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass18Form = new UpdateCHPStatusMass18Form();
            UpdateCHPStatusMass18Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass19_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass19Form = new UpdateCHPStatusMass19Form();
            UpdateCHPStatusMass19Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass20_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass20Form = new UpdateCHPStatusMass20Form();
            UpdateCHPStatusMass20Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass21_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass21Form = new UpdateCHPStatusMass21Form();
            UpdateCHPStatusMass21Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass22_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass22Form = new UpdateCHPStatusMass22Form();
            UpdateCHPStatusMass22Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass23_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass23Form = new UpdateCHPStatusMass23Form();
            UpdateCHPStatusMass23Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass24_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass24Form = new UpdateCHPStatusMass24Form();
            UpdateCHPStatusMass24Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass25_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass25Form = new UpdateCHPStatusMass25Form();
            UpdateCHPStatusMass25Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass26_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass26Form = new UpdateCHPStatusMass26Form();
            UpdateCHPStatusMass26Form.ShowDialog();
        }

        private void btnUpdateCHPStatusMass27_Click(object sender, EventArgs e)
        {
            var UpdateCHPStatusMass27Form = new UpdateCHPStatusMass27Form();
            UpdateCHPStatusMass27Form.ShowDialog();
       DFSearch_Click(object sender, EventArgs e)
        {
            var BulkPDFSearch = new BulkPDFSearchForm();
            BulkPDFSearch.ShowDialog();
        }

        private void btnRefunds_Click(object sender, EventArgs e)
        {
            var MassRefundReport = new MassSuspenseReportForm();
            MassRefundReport.ShowDialog();
        }

        private void btnMedicareUpload_Click(object sender, EventArgs e)
        {
            var AddMedicareFiles = new AddMedicareFilesForm();
            AddMedicareFiles.ShowDialog();

        }
    }
}