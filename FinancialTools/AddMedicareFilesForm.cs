using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTools
{
    public partial class AddMedicareFilesForm : Form
    {
        private List<string> QueryList= new List<string>();
        private string[] fileNames;
        private DataTable csvData = new DataTable();
        public AddMedicareFilesForm()
        {
            InitializeComponent();
        }
        private void DisableControls()
        {
            Cursor.Current = Cursors.WaitCursor;

            btnAddMedicareFilesChooseFiles.Enabled = false;
            btnAddMedicareFilesRunSplit.Enabled = false;
        }
        private void EnableControls()
        {

            btnAddMedicareFilesChooseFiles.Enabled = true;
            btnAddMedicareFilesRunSplit.Enabled = true;
            Cursor.Current = Cursors.Default;
        }
        private void OnAddMedicareFilesFormLoad(object sender, EventArgs e)
        {
            // Code removed for sanitization
        }
    }
}mns.Add("Risk Adj C", typeof(string));
            csvData.Columns.Add("Risk Adj D", typeof(string));
            csvData.Columns.Add("Risk Adj E", typeof(string));
            csvData.Columns.Add("Risk Adj F", typeof(string));
            csvData.Columns.Add("Risk Adj G", typeof(string));
            csvData.Columns.Add("Risk Adj H", typeof(string));
            csvData.Columns.Add("Risk Adj I", typeof(string));
            csvData.Columns.Add("Risk Adj J", typeof(string));
            csvData.Columns.Add("Risk Adj K", typeof(string));
            csvData.Columns.Add("Risk Adj L", typeof(string));
            csvData.Columns.Add("Risk Adj M", typeof(string));
            csvData.Columns.Add("Risk Adj N", typeof(string));
            csvData.Columns.Add("Risk Adj O", typeof(string));
            csvData.Columns.Add("Risk Adj P", typeof(string));
            csvData.Columns.Add("Risk Adj Q", typeof(string));
            csvData.Columns.Add("Risk Adj R", typeof(string));
            csvData.Columns.Add("Risk Adj S", typeof(string));
            csvData.Columns.Add("Risk Adj T", typeof(string));
            csvData.Columns.Add("Risk Adj U", typeof(string));
            csvData.Columns.Add("Risk Adj V", typeof(string));
            csvData.Columns.Add("Risk Adj W", typeof(string));
            csvData.Columns.Add("Risk Adj X", typeof(string));
            csvData.Columns.Add("Risk Adj Y", typeof(string));
            csvData.Columns.Add("Risk Adj Z", typeof(string));
            csvData.Columns.Add("Risk Adj AA", typeof(string));
            csvData.Columns.Add("Risk Adj AB", typeof(string));
            csvData.Columns.Add("Risk Adj AC", typeof(string));
            csvData.Columns.Add("Risk Adj AD", typeof(string));
            csvData.Columns.Add("Risk Adj AE", typeof(string));
            csvData.Columns.Add("Risk Adj AF", typeof(string));
            csvData.Columns.Add("Risk Adj AG", typeof(string));
            csvData.Columns.Add("Risk Adj AH", typeof(string));
            csvData.Columns.Add("Risk Adj AI", typeof(string));
            csvData.Columns.Add("Risk Adj AJ", typeof(string));
            csvData.Columns.Add("Risk Adj AK", typeof(string));
            csvData.Columns.Add("Risk Adj AL", typeof(string));
            csvData.Columns.Add("Risk Adj AM", typeof(string));
            csvData.Columns.Add("Risk Adj AN", typeof(string));
            csvData.Columns.Add("Risk Adj AO", typeof(string));
            csvData.Columns.Add("Risk Adj AP", typeof(string));
            csvData.Columns.Add("Risk Adj AQ", typeof(string));
            csvData.Columns.Add("Risk Adj AR", typeof(string));
            csvData.Columns.Add("Risk Adj AS", typeof(string));
            csvData.Columns.Add("Risk Adj AT", typeof(string));
            csvData.Columns.Add("Risk Adj AU", typeof(string));
            csvData.Columns.Add("Risk Adj AV", typeof(string));
            csvData.Columns.Add("Risk Adj AW", typeof(string));
            csvData.Columns.Add("Risk Adj AX", typeof(string));
            csvData.Columns.Add("Risk Adj AY", typeof(string));
            csvData.Columns.Add("Risk Adj AZ", typeof(string));
            csvData.Columns.Add("Risk Adj BA", typeof(string));
            csvData.Columns.Add("Risk Adj BB", typeof(string));
            csvData.Columns.Add("Risk Adj BC", typeof(string));
            csvData.Columns.Add("Risk Adj BD", typeof(string));
            csvData.Columns.Add("Risk Adj BE", typeof(string));
            csvData.Columns.Add("Risk Adj BF", typeof(string));
            csvData.Columns.Add("Risk Adj BG", typeof(string));
            csvData.Columns.Add("Risk Adj BH", typeof(string));
            csvData.Columns.Add("Risk Adj BI", typeof(string));
            csvData.Columns.Add("Risk Adj BJ", typeof(string));
            csvData.Columns.Add("Risk Adj BK", typeof(string));
            csvData.Columns.Add("Risk Adj BL", typeof(string));
            csvData.Columns.Add("Risk Adj BM", typeof(string));
            csvData.Columns.Add("Risk Adj BN", typeof(string));
            csvData.Columns.Add("Risk Adj BO", typeof(string));
            csvData.Columns.Add("Risk Adj BP", typeof(string));
            csvData.Columns.Add("Risk Adj BQ", typeof(string));
            csvData.Columns.Add("Risk Adj BR", typeof(string));
            csvData.Columns.Add("Risk Adj BS", typeof(string));
            csvData.Columns.Add("Risk Adj BT", typeof(string));
            csvData.Columns.Add("Risk Adj BU", typeof(string));
            csvData.Columns.Add("Risk Adj BV", typeof(string));
            csvData.Columns.Add("Risk Adj BW", typeof(string));
            csvData.Columns.Add("Risk Adj BX", typeof(string));
            csvData.Columns.Add("Risk Adj BY", typeof(string));
            csvData.Columns.Add("Risk Adj BZ", typeof(string));
            csvData.Columns.Add("Risk Adj CA", typeof(string));
            csvData.Columns.Add("Risk Adj CB", typeof(string));
            csvData.Columns.Add("Risk Adj CC", typeof(string));
            csvData.Columns.Add("Risk Adj CD", typeof(string));
            csvData.Columns.Add("Risk Adj CE", typeof(string));
            csvData.Columns.Add("Risk Adj CF", typeof(string));
            csvData.Columns.Add("Risk Adj CG", typeof(string));
            csvData.Columns.Add("Risk Adj CH", typeof(string));
            csvData.Columns.Add("Risk Adj CI", typeof(string));
            csvData.Columns.Add("Risk Adj CJ", typeof(string));
            csvData.Columns.Add("Risk Adj CK", typeof(string));
            csvData.Columns.Add("Risk Adj CL", typeof(string));
            csvData.Columns.Add("Risk Adj CM", typeof(string));
            csvData.Columns.Add("Risk Adj CN", typeof(string));
            csvData.Columns.Add("Risk Adj CO", typeof(string));
            csvData.Columns.Add("Risk Adj CP", typeof(string));
            csvData.Columns.Add("Risk Adj CQ", typeof(string));
            csvData.Columns.Add("Risk Adj CR", typeof(string));
            csvData.Columns.Add("Risk Adj CS", typeof(string));
            csvData.Columns.Add("Risk Adj CT", typeof(string));
            csvData.Columns.Add("Risk Adj CU", typeof(string));
            csvData.Columns.Add("Risk Adj CV", typeof(string));
            csvData.Columns.Add("Risk Adj CW", typeof(string));
            csvData.Columns.Add("Risk Adj CX", typeof(string));
            csvData.Columns.Add("Risk Adj CY", typeof(string));
            csvData.Columns.Add("Risk Adj CZ", typeof(string));
            csvData.Columns.Add("Risk Adj DA", typeof(string));
            csvData.Columns.Add("Risk Adj DB", typeof(string));
            csvData.Columns.Add("Risk Adj DC", typeof(string));
            csvData.Columns.Add("Risk Adj DD", typeof(string));
            csvData.Columns.Add("Risk Adj DE", typeof(string));
            csvData.Columns.Add("Risk Adj DF", typeof(string));
            csvData.Columns.Add("Risk Adj DG", typeof(string));
            csvData.Columns.Add("Risk Adj DH", typeof(string));
            csvData.Columns.Add("Risk Adj DI", typeof(string));
            csvData.Columns.Add("Risk Adj DJ", typeof(string));
            csvData.Columns.Add("Risk Adj DK", typeof(string));
            csvData.Columns.Add("Risk Adj DL", typeof(string));
            csvData.Columns.Add("Risk Adj DM", typeof(string));
            csvDataThe code has been sanitized to remove sensitive information:

```csharp
mns.Add("Nbr Paymt A", typeof(string));
csvData.Columns.Add("Nbr Paymt B", typeof(string));
csvData.Columns.Add("Adj Code", typeof(string));
csvData.Columns.Add("Paymt Start", typeof(string));
csvData.Columns.Add("Paymt End", typeof(string));
csvData.Columns.Add("Demo Paymt A", typeof(string));
csvData.Columns.Add("Demo Paymt B", typeof(string));
csvData.Columns.Add("Risk Paymt A", typeof(string));
csvData.Columns.Add("Risk Paymt B", typeof(string));
csvData.Columns.Add("LIS Amt", typeof(string));
csvData.Columns.Add("ESRD MSP", typeof(string));
csvData.Columns.Add("UnknownMoney1", typeof(string));
csvData.Columns.Add("UnknownFlag1", typeof(string));
csvData.Columns.Add("RAAG", typeof(string));
csvData.Columns.Add("PRDIP", typeof(string));
csvData.Columns.Add("Plan Benefit", typeof(string));
csvData.Columns.Add("Race Code", typeof(string));
csvData.Columns.Add("RA Code", typeof(string));
csvData.Columns.Add("Frailty Ind", typeof(string));
csvData.Columns.Add("Prev Ind", typeof(string));
csvData.Columns.Add("Lag Ind", typeof(string));
csvData.Columns.Add("Seg ID", typeof(string));
csvData.Columns.Add("Enroll Source", typeof(string));
csvData.Columns.Add("EGHP", typeof(string));
csvData.Columns.Add("Part C Premium A", typeof(string));
csvData.Columns.Add("Part C Premium B", typeof(string));
csvData.Columns.Add("Rebate A", typeof(string));
csvData.Columns.Add("Rebate B", typeof(string));
csvData.Columns.Add("Rebate A Supp", typeof(string));
csvData.Columns.Add("Rebate B Supp", typeof(string));
csvData.Columns.Add("Rebate A Reduction", typeof(string));
```            csvData.Columns.Add("Rebate B Reduction", typeof(string));
            csvData.Columns.Add("Rebate Part D Supp A", typeof(string));
            csvData.Columns.Add("Rebate Part D Supp B", typeof(string));
            csvData.Columns.Add("Total Part A", typeof(string));
            csvData.Columns.Add("Total Part B", typeof(string));
            csvData.Columns.Add("Total MA", typeof(string));
            csvData.Columns.Add("Part D RA", typeof(string));
            csvData.Columns.Add("Part D Low Income Ind", typeof(string));
            csvData.Columns.Add("Part D Low Income Mult", typeof(string));
            csvData.Columns.Add("Part D Long Term Ind", typeof(string));
            csvData.Columns.Add("Part D Long Term Mult", typeof(string));
            csvData.Columns.Add("Rebate Part D Premium Red", typeof(string));
            csvData.Columns.Add("Part D Premium Amt", typeof(string));
            csvData.Columns.Add("Part D Subsidy Paymt", typeof(string));
            csvData.Columns.Add("Resinsurance Subsidy Amt", typeof(string));
            csvData.Columns.Add("Low Income Subsidy Cost", typeof(string));
            csvData.Columns.Add("Total Part D", typeof(string));
            csvData.Columns.Add("Nbr Paymt D", typeof(string));
            csvData.Columns.Add("PACE Premium Add-On", typeof(string));
            csvData.Columns.Add("PACE Cost Add-on", typeof(string));
            csvData.Columns.Add("UnknownIndicator1", typeof(string));
            csvData.Columns.Add("UnknownIndicator2", typeof(string));
            csvData.Columns.Add("UnknownAmount1", typeof(string));
            csvData.Columns.Add("UnknownAmount2", typeof(string));
            csvData.Columns.Add("UnknownIndicator3", typeof(string));
            csvData.Columns.Add("UnknownIndicator4", typeof(string));
            csvData.Columns.Add("UnknownIndicator5", typeof(string));
            csvData.Columns.Add("UnknownIndicator6", typeof(string));8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 10, 10, 10, 11, 2, 10, 10, 7, 7, 10, 10, 2, 8, 2, 1, 9, 9, 9, 10};

csvReader.HasFieldsEnclosedInQuotes = false;

while (!csvReader.EndOfData)
{

    string[] fieldData = csvReader.ReadFields();
    
    for (int i = 0; i < fieldData.Length; i++)
    {
        if (fieldData[i] == "")
        {
            fieldData[i] = null;
        }
    }
    
    Array.Resize(ref fieldData, fieldData.Length + 1);
    fieldData[fieldData.Length - 1] = Path.GetFileName(csv_file_path);
    csvData.Rows.Add(fieldData);
}

IndexHelper.MedicareUpload(csvData);
csvData.Clear();
double percentage = (k * 100) / dlgMedicareFilesToUpload.FileNames.Length;
backgroundAddMedicareFiles.ReportProgress(Convert.ToInt32(Math.Truncate(percentage)));

}
catch (SecurityException ex)
{
    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
        "Error message: " + ex.Message + "\n\n" +
        "Details (send to Support):\n\n" + ex.StackTrace
    );
}
catch (Exception ex)
{
    // Could not load the image - probably related to Windows file system permissions.MessageBox.Show("Error reading file: " + csv_file_path.Substring(csv_file_path.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }


        }
        private void BackgroundAddMedicareFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            MessageBox.Show("Work completed successfully");
            EnableControls();

        }
        private void btnRunUpload_Click(object sender, EventArgs e)
        {
           DisableControls();

            backgroundAddMedicareFiles.RunWorkerAsync();
        }
    }
}