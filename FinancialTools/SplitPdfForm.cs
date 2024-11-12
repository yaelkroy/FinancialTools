olderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Show FolderBrowserDialog
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Set selected directory to source directory text box
            if (result == DialogResult.OK)
            {
                FinancialToolsSettings.SplitPDFSourceDirectory = folderBrowserDialog.SelectedPath;
                lblCurrentSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.SplitPDFSourceDirectory;
            }
        }

        private void btnChooseDstDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Show FolderBrowserDialog
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Set selected directory to destination directory text box
            if (result == DialogResult.OK)
            {
                FinancialToolsSettings.SplitPDFDestinationDirectory = folderBrowserDialog.SelectedPath;
                lblCurrentDstDirectory.Text = "Current directory: " + FinancialToolsSettings.SplitPDFDestinationDirectory;
            }
        }

        private void btnSplitPDF_Click(object sender, EventArgs e)
        {
            // Split PDF logic here
        }
    }
}olderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = Settings.SplitPDFSourceDirectory;
            

            // Show the "Make new folder" button
            Fld.ShowNewFolderButton = true;

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                Settings.SplitPDFSourceDirectory = Fld.SelectedPath;
                lblCurrentSrcDirectory.Text = "Current directory: " + Settings.SplitPDFSourceDirectory;

            }
            else
            {
                // Selection canceled
                //MessageBox.Show("Operation canceled.");
            }
        }

        private void btnChooseDstDirectory_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
            Fld.SelectedPath = Settings.SplitPDFDestinationDirectory;
            

            // Show the "Make new folder" button
            Fld.ShowNewFolderButton = true;

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                Settings.SplitPDFDestinationDirectory = Fld.SelectedPath;

                lblCurrentDstDirectory.Text = "Current directory: " + Settings.SplitPDFDestinationDirectory;
            }
            else
            {
                // Selection canceled
                //MessageBox.Show("Operation canceled.");
            }
        }
        //THIS UPDATES GUI.OUR PROGRESSBAR
        private void BackgroundSplitPDF_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            barSplitPDFProgress.Value = e.ProgressPercentage;

        }
        private void BackgroundSplitPDF_DoWork(obobject sender, DoWorkEventArgs e)
        {
            string dataType = "";
            if (cmbbxSplitPDFDocumentType.InvokeRequired)
            {
                cmbbxSplitPDFDocumentType.Invoke(new MethodInvoker(delegate { dataType = cmbbxSplitPDFDocumentType.Text; }));
            }
            PDFHelper.Split(dataType, backgroundSplitPDF);

        }
        private void BackgroundSplitPDF_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            MessageBox.Show("Work completed successfully");
            btnRunSplit.Enabled = true;
            Cursor.Current = Cursors.Default;

        }
        private void btnRunSplit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnRunSplit.Enabled = false;

           backgroundSplitPDF.RunWorkerAsync();
        }
    }
}