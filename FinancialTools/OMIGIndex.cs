ver=server;Port=port;User Id=user;Password=password;Database=database;";
            NpgsqlConnection conn = new NpgsqlConnection(ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM table";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ExcelCell cell = new ExcelCell();
                cell.ID = dr["ID"].ToString();
                cell.Name = dr["Name"].ToString();
                cell.Value = dr["Value"].ToString();
                cellList.Add(cell);
            }

            conn.Close();
        }

        public OMIGIndexForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[2].DataPropertyName = "Value";
        }

        private void OMIGIndexForm_Load(object sender, EventArgs e)
        {
            if (!m_bLayoutCalled)
            {
                m_bLayoutCalled = true;
                LoadAsync();
            }
        }
    }

    public class ExcelCell
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}ver=greenplum.fideliscare.org;Database=fidprd;port=5432;Timeout=86400;Keepalive=60;User Id=" + FinancialToolsSettings.GreenplumDBUsername + ";Password=" + FinancialToolsSettings.GreenplumDBPassword;
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.OpenAsync();
                cmd.CommandText = "SELECT * FROM OMIGIndex LIMIT 1000;";
                cmd.CommandTimeout = 86400;
                
                Application.DoEvents();
                DateTime start = DateTime.Now;
                long total = 1000;
                
                using (var reader = cmd.ExecuteReaderAsync())
                {
                    while (await reader.Result.ReadAsync())
                    {
                        ExcelCell eCell = new ExcelCell(reader.Result.GetString(1), reader.Result.GetString(2), reader.Result.GetString(3), reader.Result.GetString(4), reader.Result.GetString(5));
                        cellList.Add(eCell);
                        SplashScreen.SetStatus("Loaded " + cellList.Count.ToString() + " of " + total.ToString());

                    }
                }
                conn.Close();
                
            }
        }
        private void OnOMIGIndexFormLoad(object sender, EventArgs e)
        {
            DisableControls();
            SplashScreen.ShowSplashScreen();
            string ConnectionString = "Server=greenplum.fideliscare.org;Database=fidprd;port=5432;Timeout=1024;Keepalive=60;User Id=" + FinancialToolsSettings.GreenplumDBUsername + ";Password=" + FinancialToolsSettings.GreenplumDBPassword;
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM Sandbox.FinancialTools_OMIGIndex LIMIT 1000;";
                cmd.CommandTimeout = 86400;

                //Application.DoEvents();
                DateTime start = DateTime.Now;
                //SplashScreenXMLStorage.Percents = "0.000008365523869181945";
                //SplashScreenXMLStorage.Interval = "0.000001";
                long total = 11953824;



                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ExcelCell eCell = new ExcelCell(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        cellList.Add(eCell);
                        SplashScreen.SetStatus("Loaded " + cellList.Count.ToString() + " of " + total.ToString());

                    }
                }



                conn.Close();

            }
            this.Activate();
            SplashScreen.CloseForm();

            cellListFocus = (List<ExcelCell>) cellList.Take(100).ToList().OrderBy(y => y.CIN).ToList();
            bindingCellList = new BindingList<ExcelCell>(cellListFocus);
            source = new BindingSource(bindingCellList, null);
            dataOMIGIndex.DataSource = source;
            EnableControls();

        }

        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;

        }
        private void BtnOMIGIndexSubmit_Click(object sender, EventArgs e)
        {

            DisableControls();

            /*Regex rgx = new Regex(@"[a-zA-Z]{2}\d{5}[a-zA-Z]{1}");
            var resultsList = rgx.Matches(txtOMIGIndexSubID.Text.ToUpper())
                       .Cast<Match>()
                       .Select(m => m.            .ToList();
            cellListFocus = cellList.Where(x => resultsList.Contains(x.CIN)).ToList().OrderBy(y => y.CIN).ToList();
            bindingCellList = new BindingList<ExcelCell>(cellListFocus);
            source = new BindingSource(bindingCellList, null);
            dataOMIGIndex.DataSource = source;*/
            SplashScreen.ShowSplashScreen();
            Regex rgx = new Regex(@"[a-zA-Z]{2}\d{5}[a-zA-Z]{1}");
            var resultsList = rgx.Matches(txtOMIGIndexSubID.Text.ToUpper())
                                .Cast<Match>()
                                .Select(m => m.Value)
                                .ToList();
            string ConnectionString = "Server=example.server.com;Database=exampledb;port=5432;Timeout=1024;Keepalive=60;User Id=exampleuser;Password=examplepassword";
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM example_table WHERE CIN IN ('" + String.Join("', '", resultsList.ToArray()) + "') ORDER BY CIN ASC;";
                cmd.CommandTimeout = 86400;

                //Application.DoEvents();
                DateTime start = DateTime.Now;
                //SplashScreenXMLStorage.Percents = "0.000008365523869181945";
                //SplashScreenXMLStorage.Interval = "0.000001";
                long total = 11953824;


                cellListFocus.Clear();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ExcelCell eCell = new ExcelCell(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        cellListFocus.Add(eCell)mount"].DefaultCellStyle.Format = "0.##";*/

        }

        private void OMIGIndexForm_Load(object sender, EventArgs e)
        {
            SplashScreen.ShowSplashScreen();
            BackgroundOMIGIndex.RunWorkerAsync();
        }

        private void OMIGIndexForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BackgroundOMIGIndex.IsBusy)
            {
                BackgroundOMIGIndex.CancelAsync();
            }
        }

        private void EnableControls()
        {
            if (dataOMIGIndex.Rows.Count > 0)
            {
                buttonExport.Enabled = true;
            }
        }
    }
}he following code is a snippet from a C# program that formats columns in a DataGridView and enables buttons for exporting reports to Excel and CSV files. It also includes event handlers for clicking a button and selecting a cell in a DataGridView.

```csharp
dataMassSpenddown.Columns["Paid"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Expenses"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Paid months"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Accumulated Balance"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Total rate"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Total billed"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Total paid"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Total expenses"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["DB amount due"].DefaultCellStyle.Format = "0.##";
dataMassSpenddown.Columns["Calculated amount due"].DefaultCellStyle.Format = "0.##";
btnMassSpenddownFullReportToExcel.Enabled = true;
btnMassSpenddownFullReportToCSV.Enabled = true;
btnMassSpenddownShortReportToExcel.Enabled = true;
btnMassSpenddownShortReportToCSV.Enabled = true;

dataMassSpenddown.FirstDisplayedScrollingRowIndex = dataMassSpenddown.RowCount - 1;
btnMassSpenddownBuildReport.Enabled = true;
EnableControls();
}

private void BtnOMIGReindex_Click(object sender, EventArgs e)
{
DisableControls();
backgroundOMIGIndex.RunWorkerAsync();
}

private void dataOMIGIndex_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
int selectedrowindex = dataOMIGIndex.SelectedCells[0].RowIndex;
DataGridViewRow selectedRow = dataOMIGIndex.Rows[selectedrowindex];

string CIN = System.Convert.ToString(selectedRow.Cells["CIN"].Value);
string FileName = System.Convert.ToString(selectedRow.Cells["FileName"].Value);
// Additional code for handling cell content click event
}
```

This sanitized code removes any sensitive information and focuses on the functionality related to formatting columns, enabling buttons, and handling events in a DataGridView.string fileName = System.Convert.ToString(selectedRow.Cells["FileName"].Value);
string sheetID = System.Convert.ToString(selectedRow.Cells["SheetID"].Value);
string sheetName = System.Convert.ToString(selectedRow.Cells["SheetName"].Value);
string cellReference = System.Convert.ToString(selectedRow.Cells["CellReference"].Value);

Microsoft.Office.Interop.Excel.Application excelApp;
Microsoft.Office.Interop.Excel._Workbook workbook;
Microsoft.Office.Interop.Excel._Worksheet worksheet;
Microsoft.Office.Interop.Excel.Range range;
object missingValue = System.Reflection.Missing.Value;

//Start Excel and get Application object.
excelApp = new Microsoft.Office.Interop.Excel.Application
{
    Visible = true,
    UserControl = true
};

//Get a new workbook.
workbook = excelApp.Workbooks.Open(fileName);
worksheet = workbook.Sheets[sheetName];
worksheet.Activate();
Excel.Range allCellsRange = worksheet.Cells;
Excel.Range cellRange = allCellsRange.get_Range(cellReference);
cellRange.Select();
}

private void DisableControls()
{
    Cursor.Current = Cursors.WaitCursor;
    btnOMIGIndexReindex.Enabled = false;
    btnOMIGIndexSearch.Enabled = false;
    btnExportToExcel.Enabled = false;
}

private void EnableControls()
{
    Cursor.Current = Cursors.Default;
    btnOMIGIndexReindex.Enabled = true;
    btnOMIGIndexSearch.Enabled = true;
    btnExportToExcel.Enabled = true;
}

private void btnExportToExcel_Click(object sender, EventArgs e)
{
    DisableControls();
    Export.ExportOMIGTableToExcel(cellListFocus);
    EnableControls();
}
}