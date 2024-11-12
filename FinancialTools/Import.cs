using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinancialTools
{
    class Import
    {
        public static string getCHPReconGetCHPPremExcelFileQuery(DateTime date)
        {
            string query = default;
            DateTime Date = new DateTime(date.Year, date.Month, 1);
            string strDate = Date.ToString("MM/dd/yyyy");
            string filename = @"T:\DataSets_Private\Finance\Financial Tools\Tasks\CHPRecon\CHPosPrem\" + date.ToString("yyyyMM") + ".xlsx";
            //Create COM Objects. Create a COM object for everything that is referenced
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filename);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets["Summary_All_Months"];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = 2;
            int i = 3;
            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            //Regex rgx = new Regex(@"\d\d\/\d\d\/\d{4}");
            //var CreateDateMatch = rgx.Matches(xlRange.Cells[2, 1].Value2);
            //string strCreateDate = CreateDateMatch[0].Value;
            //DateTime CreateDate = DateTime.Parse(strCreateDate);
            string strCreateDate = date.ToString();
            DateTime CreateDate = date;

            GreenplumDB Greenplum = new GreenplumDB(FinancialToolsSettings.GreenplumDBUsername, FinancialToolsSettings.GreenplumDBPassword);
            string voucherfilename = Greenplum.CHPReconGetFileName(date);

            query += "INSERT INTO SandBox.Financia";lTools_CHPRecon_List_Rpt_Mon ( PytMon, RunDate, TimeStamp) VALUES ('" + new DateTime(CreateDate.Year, CreateDate.Month, 1).ToString("MM/dd/yyyy") + "', '" + strCreateDate + "', '" + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "'); ";
            while ((i< rowCount)&&(!xlRange.Cells[i, 1].Value2.ToString().Contains("otal")))
            {
                query += "INSERT INTO financialtools_CHPRecon_List_Unpaid_Summary ( PytMon, CreateDate, MOS, MbrCnt, TimeStamp, voucher_file_name) values ('" + new DateTime( CreateDate.Year, CreateDate.Month, 1).ToString("MM/dd/yyyy") +"','" + strCreateDate + "', '" + DateTime.FromOADate(xlRange.Cells[i, 1].Value2).ToString("MM/dd/yyyy") + "', " + xlRange.Cells[i, 2].Value2.ToString() + ", '" + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "', '" + voucherfilename + "'); ";
                i++;
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            // never use two dots, all COM objects must be referenced and released individually
            // ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            return query;
        }
    }
}