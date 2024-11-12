using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTools
{
    public partial class BulkPDFSearchForm : Form
    {
        private List<string> QueryList= new List<string>();
        public BulkPDFSearchForm()
        {
            InitializeComponent();
        }
        private void DisableControls()
        {
            Cursor.Current = Cursors.WaitCursor;
            btnBulkPDFSearchChooseDstDirectory.Enabled = false;
            btnBulkPDFSearchChooseSrcDirectory.Enabled = false;
            btnBulkPDFSearchRunSplit.Enabled = false;
        }
        private void EnableControls()
        {
            btnBulkPDFSearchChooseDstDirectory.Enabled = true;
            btnBulkPDFSearchChooseSrcDirectory.Enabled = true;
            btnBulkPDFSearchRunSplit.Enabled = true;
            Cursor.Current = Cursors.Default;
        }
        private void OnBulkPDFSearchFormLoad(object sender, EventArgs e)
        {
            lblBulkPDFSearchCurrentSrcDirectory.Text = "Current directory: " + FinancialToolsSettings.BulkPDFSearchSourceDirectory;
            lblBulkPDFSearchCurrentDstDirectory.Text = "Current directory: " + FinancialToolsSettings.BulkPDFSearchDestinationDirectory;
        }
    }
}t.OK)
            {
                // Select successful
                FinancialToolsSettings.BulkPDFSearchDestinationDirectory = Fld.SelectedPath;
                lblBulkPDFSearchCurrentDstDirectory.Text = "Current directory: " + FinancialToolsSettings.BulkPDFSearchDestinationDirectory;
            }
            else
            {
                // Selection canceled
                //MessageBox.Show("Operation canceled.");
            }
        }gex.Matches(txtbxBulkPDFSearchCriteriaList.Text.ToUpper())
                                .Cast<Match>()
                                .Select(m => m.Value)
                                .ToList();

            if (resultsMedicaidList.Count > 0 && resultsCINList.Count > 0 && QueryList.Count > 0)
            {
                if (backgroundBulkPDFSearch.IsBusy != true)
                {
                    backgroundBulkPDFSearch.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Invalid search criteria entered. Please enter valid search criteria.");
                EnableControls();
            }
        }
        private void EnableControls()
        {
            btnBulkPDFSearchSourceDirectory.Enabled = true;
            btnBulkPDFSearchDestinationDirectory.Enabled = true;
            txtbxBulkPDFSearchCriteriaList.Enabled = true;
            btnRunSplit.Enabled = true;
        }
        private void DisableControls()
        {
            btnBulkPDFSearchSourceDirectory.Enabled = false;
            btnBulkPDFSearchDestinationDirectory.Enabled = false;
            txtbxBulkPDFSearchCriteriaList.Enabled = false;
            btnRunSplit.Enabled = false;
        }resultsCINList.Concat(resultsMedicaidList).Distinct().ToList();
backgroundBulkPDFSearch.RunWorkerAsync();
}