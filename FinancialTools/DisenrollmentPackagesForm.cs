using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTools
{
    public partial class DissenrollmentPackagesForm : Form
    {
        public DissenrollmentPackagesForm()
        {
            InitializeComponent();
        }
        private void OnDisenrollmentPackagesFormLoad(object sender, EventArgs e)
        {
            lblCurrentDisFormSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory;
            lblCurrentDisLetSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesDisLetSourceDirectory;
            lblCurrentInvSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesInvoiceSourceDirectory;
            lblCurrentNotASrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesNotASourceDirectory;
            lblCurrentNotBSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesNotBSourceDirectory;
            lblCurrentNotCSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesNotCSourceDirectory;
            lblCurrentDstDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory;

            /*            using (var cred = new Credential())
                        {
                            cred.Target = "FinancialToolsGreenPlum";
                            cred.Load();
                            // Decrypt username & password and print to the console

                            if (!(string.IsNullOrEmpty(cred.Username)) && !(string.IsNullOrEmpty(cred.Password)))
                            {

                                txtMassSpenddownUsername.Text = Cryptography.DecrypFolder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormSrcDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormDestDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesDisFormDestinationDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormDestDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormTempDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesTempDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormTempDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormLogDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesLogDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormLogDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormMergeDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesMergeDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormMergeDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnRunMerge_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnRunMerge.Enabled = false;

            backgroundDisenrollmentPackages.RunWorkerAsync();
        }

        private void btnChooseDisFormSrcDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormSrcDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormDestDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesDisFormDestinationDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormDestDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormTempDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesTempDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormTempDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormLogDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesLogDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormLogDirectory.Text = Fld.SelectedPath;
            }
        }

        private void btnChooseDisFormMergeDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = FinancialToolsSettings.DisenrollmentPackagesMergeDirectory;


            // Show the "Make new Folder" button
            Fld.ShowNewFolderButton = true;

            // Show the dialog and process the result
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                txtDisFormMergeDirectory.Text = Fld.SelectedPath;
            }
        }            Fld.ShowNewFolderButton = true;

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                FinancialToolsSettings.DisenrollmentPackagesInvoiceSourceDirectory = Fld.SelectedPath;
                lblCurrentInvoiceSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesInvoiceSourceDirectory;

            }
            else
            {
                // Selection canceled
                //MessageBox.Show("Operation canceled.");
            }
        }owDialog() == DialogResult.OK)
            {
                // Select successful
                FinancialToolsSettings.DisenrollmentPackagesNotBSourceDirectory = Fld.SelectedPath;
                lblCurrentNotBSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesNotBSourceDirectory;

            }
            else
            {
                // Selection canceled
                //MessageBox.Show("Operation canceled.");
            }
        }                FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory = Fld.SelectedPath;
                lblCurrentDstDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory;

            }
            else
            {
                // Selection canceled
                //MessageBox.Show("Operation canceled.");
            }
        }FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory = Fld.SelectedPath;

lblCurrentDstDirectory.Text = "Current directory: " + FinancialToolsSettings.DisenrollmentPackagesDestinationDirectory;
}
else
{
// Selection canceled
//MessageBox.Show("Operation canceled.");
}
}
}
}