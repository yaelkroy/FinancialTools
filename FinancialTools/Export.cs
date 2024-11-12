            // Format the cells in the header row to be bold and centered vertically
            oSheet.get_Range("A1", "Y1").Font.Bold = true;
            oSheet.get_Range("A1", "Y1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /*************************************/
            // AutoFit columns A to Y
            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            // Release the objects
            oRng = null;
            oSheet = null;
            oWB = null;
            oXL = null;

            // Clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();

            return oXL;
        }
    }
}"_{0:HHmmss}.xlsx", DateTime.Now);
            string path = Path.Combine(outputDir, filename);

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;

            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = false;
            oWB = oXL.Workbooks.Add();
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            for (int i = 1; i < tblNAMICalculations.Columns.Count + 1; i++)
            {
                oSheet.Cells[1, i] = tblNAMICalculations.Columns[i - 1].ColumnName;
            }

            for (int i = 0; i < tblNAMICalculations.Rows.Count; i++)
            {
                for (int j = 0; j < tblNAMICalculations.Columns.Count; j++)
                {
                    oSheet.Cells[i + 2, j + 1] = tblNAMICalculations.Rows[i][j];
                }
            }


            string endRange = "U" + (months + 6).ToString(CultureInfo.InvariantCulture);

            oRng = oSheet.get_Range("G2", endRange);
            oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            oXL.Visible = true;
            oXL.UserControl = true;
            return oXL;
        }e("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            oRng = oSheet.get_Range("E2", "E" + (months + 6).ToString(CultureInfo.InvariantCulture));
            oRng.NumberFormat = "#,##0.00";
            /************************************************************************************/
            /* Save the workbook                                                               */
            /************************************************************************************/
            oWB.Save();
            oWB.Close();
            oXL.Quit();

            //Release objects.
            ReleaseObject(oRng);
            ReleaseObject(oSheet);
            ReleaseObject(oWB);
            ReleaseObject(oXL);
            wb.Dispose();r (int j = 0; j < tblSpenddownCalculations.Rows.Count; j++)
            {
                for (int k = 0; k < tblSpenddownCalculations.Columns.Count; k++)
                {
                    oSheet.Cells[j + 2, k + 1] = tblSpenddownCalculations.Rows[j][k].ToString();
                }
            }

            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            oXL.Visible = true;
            oXL.UserControl = true;

            return oXL;
        }(int j = 0; j < tblSpenddownCalculations.Rows.Count; j++)
            {
                for (int k = 0; k < tblSpenddownCalculations.Columns.Count; k++)
                {
                    oSheet.Cells[j + 2, k + 1] = tblSpenddownCalculations.Rows[j].ItemArray[k].ToString();
                }
            }


            oSheet.get_Range("A1", "N1").Font.Bold = true;
            oSheet.get_Range("A1", "N1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /************************************************************************************/
            /* Calculate the size of cell range                                                 */
            /************************************************************************************/
            string endRange = "N" + (months + 5).ToString(CultureInfo.InvariantCulture);
            //oSheet.get_Range("A2", endRange).Value2 = saData;

            /************************************************************************************/
            /* format cells                                                                     */
            /************************************************************************************/



            oRng = oSheet.get_Range("G2", endRange);
            oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

            oRng = oSheet.get_Range("A1", "N1");
            oRng.EntireColumn.AutoFit();

            /************************************************************************************/
            /* Write and close excel file                                                          */
            /************************************************************************************/
            oSheet.get_Range("A" + (months + 1).ToString(CultureInfo.InvariantCulture), "N" + (months + 10).ToString(CultureInfo.InvariantCulture)).Font.Bold = true;ion object.
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;

            //Get a new workbook.
            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            //Add column headers
            for (int i = 0; i < tblSpenddownCalculations.Columns.Count; i++)
            {
                oSheet.Cells[1, i + 1] = tblSpenddownCalculations.Columns[i].ColumnName;
            }

            //Add data
            for (int i = 0; i < tblSpenddownCalculations.Rows.Count; i++)
            {
                for (int j = 0; j < tblSpenddownCalculations.Columns.Count; j++)
                {
                    oSheet.Cells[i + 2, j + 1] = tblSpenddownCalculations.Rows[i][j].ToString();
                }
            }

            //AutoFit columns
            oRng = oSheet.UsedRange;
            oRng.EntireColumn.AutoFit();

            //Save the workbook
            oWB.SaveAs(Path.Combine(outputDir, filename), Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault,
                Type.Missing, Type.Missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //Cleanup
            oXL.Visible = true;
            oXL.UserControl = true;
            //oWB.Close();
            //oXL.Quit();

            return oXL;
        }```csharp
ion object.
            oXL = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                UserControl = false
            };

            //Get a new workbook.
            oWB = oXL.Workbooks.Open(Path.Combine(outputDir, filename));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;



            oSheet.get_Range("A1", "Y1").Font.Bold = true;
            oSheet.get_Range("A1", "Y1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /************************************************************************************/
            /* Calculate the size of cell range                                                 */
            /************************************************************************************/
            string endRange = "U" + (months + 6).ToString(CultureInfo.InvariantCulture);
            //oSheet.get_Range("A2", endRange).Value2 = saData;

            /************************************************************************************/
            /* format cells                                                                     */
            /************************************************************************************/



            oRng = oSheet.get_Range("G2", endRange);
            oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            /************************************************************************************/
            /* Write and close excel file                                                          */
            /************************************************************************************/
            //oSheet.get_Range("A" + (months + 2).ToString(), "Y" + (months + 10).ToString()).Font.Bold = true;
```oSheet.get_Range("A1", "Y1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;        /************************************************************************************/
        string endRange = "U" + (months + 6).ToString(CultureInfo.InvariantCulture);
        //oSheet.get_Range("A2", endRange).Value2 = saData;

        /************************************************************************************/
        /* format cells                                                                     */
        /************************************************************************************/



        oRng = oSheet.get_Range("G2", endRange);
        oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

        oRng = oSheet.get_Range("A1", "Y1");
        oRng.EntireColumn.AutoFit();

        /************************************************************************************/
        /* Write and close excel file                                                          */
        /************************************************************************************/
        //oSheet.get_Range("A" + (months + 2).ToString(), "Y" + (months + 10).ToString()).Font.Bold = true;


        //oWB.Save();
        oXL.Visible = true;
        oXL.UserControl = true;
        //oWB.Close();
        //oXL.Quit();
        return oXL;
    }

    /******************************************************************************************/
    /******************************************************************************************/
    /******************************************************************************************/
    /******************************************************************************************/
    public static Microsoft.Office.Interop.Excel.Application ExportSpenddownTableToExcelWithFormulas(DataTable tblSpendd = false
            };

            //Get a new workbook.
            oWB = oXL.Workbooks.Add("");
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            //Add table headers going cell by cell.
            oSheet.Cells[1, 1] = "Rate";
            oSheet.Cells[1, 2] = "Billed";
            oSheet.Cells[1, 3] = "Adjmnts";
            oSheet.Cells[1, 4] = "Paid";
            oSheet.Cells[1, 5] = "Expenses";
            oSheet.Cells[1, 6] = "Amount Due";

            //Format A1:D1 as bold, vertical alignment = center.
            oSheet.get_Range("A1", "F1").Font.Bold = true;
            oSheet.get_Range("A1", "F1").VerticalAlignment =
                Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            // Create an array to multiple values at once.
            string[,] arr = new string[months, 6];

            for (int i = 0; i < months; i++)
            {
                arr[i, 0] = tblSpenddownCalculations.Rows[i].Field<Decimal>("Rate").ToString();
                arr[i, 1] = tblSpenddownCalculations.Rows[i].Field<Decimal>("Billed").ToString();
                arr[i, 2] = tblSpenddownCalculations.Rows[i].Field<Decimal>("Adjmnts").ToString();
                arr[i, 3] = tblSpenddownCalculations.Rows[i].Field<Decimal>("Paid").ToString();
                arr[i, 4] = tblSpenddownCalculations.Rows[i].Field<Decimal>("Expenses").ToString();
                arr[i, 5] = strAmountDue;
            }

            //Set the range value to the array.
            oSheet.get_Range("A2", "F" + (months + 1).ToString()).Value = arr;

            //AutoFit columns A:G.
            oRng = oSheet.get_Range("A1", "F1");
            oRng.EntireColumn.AutoFit();

            //Save the workbook.
            oWB.SaveAs("SpenddownCalculations.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //Clean up.
            oWB.Close();
            oXL.Quit();

            Marshal.ReleaseComObject(oRng);
            Marshal.ReleaseComObject(oSheet);
            Marshal.ReleaseComObject(oWB);
            Marshal.ReleaseComObject(oXL);

            //End Excel process.
            Process[] AllProcesses = Process.GetProcesses();
            foreach (Process ExcelProcess in AllProcesses)
            {
                if (ExcelProcess.ProcessName == "EXCEL")
                {
                    ExcelProcess.Kill();
                }
            }
        }
    }
}= false
            };

            //Get a new workbook.
            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            //Add table headers going cell by cell.
            //Add table headers going cell by cell.
            oSheet.Cells[1, 1] = "Date";
            oSheet.Cells[1, 2] = "ID";
            oSheet.Cells[1, 3] = "Medicaid ID";
            oSheet.Cells[1, 4] = "First Name";
            oSheet.Cells[1, 5] = "Last Name";
            oSheet.Cells[1, 6] = "Full Name";
            oSheet.Cells[1, 7] = "Rate";
            oSheet.Cells[1, 8] = "Billed";
            oSheet.Cells[1, 9] = "Adjmnts";
            oSheet.Cells[1, 10] = "Paid";
            oSheet.Cells[1, 11] = "Expenses";
            oSheet.Cells[1, 12] = "Paid months";
            oSheet.Cells[1, 13] = "Accum. balance";
            oSheet.Cells[1, 14] = "Eligibility";
            oSheet.Cells[1, 15] = "CSPI ID";
            oSheet.Cells[1, 16] = "GRGR CK";
            oSheet.Cells[1, 17] = "CSCS ID";
            oSheet.Cells[1, 18] = "Trust Notice";
            oSheet.Cells[1, 19] = "Provider Name";
            oSheet.Cells[1, 20] = "Provider Effective Date";
            oSheet.Cells[1, 21] = "Provider Termination Date";
            oSheet.Cells[1, 22] = "Provider GRGR CK";
            oSheet.Cells[1, 23] = "Provider ID";
            oSheet.Cells[1, 24] = "Provider NPI";
            //Format A1:D1 as bold, vertical alignment = center.
            oSheet.get_Range("A1", "Y1").Font.Bold = true;
            oSheet.get_Range("A1", "Y1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /************************************************************************************/
            /* Calculate the size of cell range                                                 */
            /*********************"=J" + (counter + 1).ToString(CultureInfo.InvariantCulture) + "-K" + (counter + 1).ToString(CultureInfo.InvariantCulture);
                oSheet.Cells[counter + 1, 14].Formula = "=L" + (counter + 1).ToString(CultureInfo.InvariantCulture) + "*M" + (counter + 1).ToString(CultureInfo.InvariantCulture);
                oSheet.Cells[counter + 1, 15].Formula = "=M" + (counter + 1).ToString(CultureInfo.InvariantCulture) + "+N" + (counter + 1).ToString(CultureInfo.InvariantCulture);
            }

            oSheet.Cells[months + 1, 1] = "Total";
            oSheet.Cells[months + 1, 7].Formula = "=SUM(G2:G" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";
            oSheet.Cells[months + 1, 8].Formula = "=SUM(H2:H" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";
            oSheet.Cells[months + 1, 10].Formula = "=SUM(J2:J" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";
            oSheet.Cells[months + 1, 11].Formula = "=SUM(K2:K" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";
            oSheet.Cells[months + 1, 12].Formula = "=SUM(L2:L" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";
            oSheet.Cells[months + 1, 13].Formula = "=SUM(M2:M" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";
            oSheet.Cells[months + 1, 14].Formula = "=SUM(N2:N" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";
            oSheet.Cells[months + 1, 15].Formula = "=SUM(O2:O" + (months + 1).ToString(CultureInfo.InvariantCulture) + ")";

            oSheet.get_Range("A1", endRange).Columns.AutoFit();
            oXL.Visible = true;
            oXL.UserControl = true;
            oXL = null;
            oSheet = null;"+K" + (counter + 1).ToString(CultureInfo.InvariantCulture) + "-G" + (counter + 1).ToString(CultureInfo.InvariantCulture);
            else
                oSheet.Cells[counter + 1, 13].Formula = "=J" + (counter + 1).ToString(CultureInfo.InvariantCulture) +
                    "+K" + (counter + 1).ToString(CultureInfo.InvariantCulture) + "+M" + (counter).ToString(CultureInfo.InvariantCulture) + "-G" + (counter + 1).ToString(CultureInfo.InvariantCulture);
            oSheet.Cells[counter + 1, 14] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Eligibility");
            oSheet.Cells[counter + 1, 15] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("CSPI ID");
            oSheet.Cells[counter + 1, 16] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("GRGR CK");
            oSheet.Cells[counter + 1, 17] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("CSCS ID");
            oSheet.Cells[counter + 1, 18] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Trust Notice");
            oSheet.Cells[counter + 1, 19] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Provider Name");
            oSheet.Cells[counter + 1, 20] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Provider Effective Date");
            oSheet.Cells[counter + 1, 21] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Provider Termination Date");
            oSheet.Cells[counter + 1, 22] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Provider GRGR CK");
            oSheet.Cells[counter + 1, 23] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Provider ID");
            oSheet.Cells[counter + 1, 24] = tblSpenddownCalculations.Rows[counter - 1].Field<String>("Provider NPI");

        }
        
        /************************************************************************************//* format cells */
/************************************************************************************/
oSheet.Cells[months + 2, 7].Formula = "=SUM(G2:G" + (months + 1).ToString(CultureInfo.InvariantCulture);
oSheet.Cells[months + 2, 8].Formula = "=SUM(H2:H" + (months + 1).ToString(CultureInfo.InvariantCulture);
oSheet.Cells[months + 2, 9].Formula = "=SUM(I2:I" + (months + 1).ToString(CultureInfo.InvariantCulture);
oSheet.Cells[months + 2, 10].Formula = "=SUM(J2:J" + (months + 1).ToString(CultureInfo.InvariantCulture);
oSheet.Cells[months + 2, 11].Formula = "=SUM(K2:K" + (months + 1).ToString(CultureInfo.InvariantCulture);
oSheet.Cells[months + 2, 12].Formula = "=SUM(L2:L" + (months + 1).ToString(CultureInfo.InvariantCulture);
oSheet.Cells[months + 4, 11].Formula = "=CONCATENATE(\"Amount due calculated with real rates is: $\"," + "G" + (months + 2) + "-(J" + (months + 2).ToString(CultureInfo.InvariantCulture) +
"+K" + (months + 2).ToString(CultureInfo.InvariantCulture) + ")" + ")";


oRng = oSheet.get_Range("G2", endRange);
oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

oRng = oSheet.get_Range("A1", "Y1");
oRng.EntireColumn.AutoFit();
oSheet.Cells[months + 5, 11].Formula = "=CONCATENATE(\"Amount due calculated with billed rates is: $\"," + "H" + (months + 2) + "-(J" + (months + 2).ToString(CultureInfo.InvariantCulture) +
"+K" + (months + 2).ToString(CultureInfo.InvariantCulture) + ")" + ")";
oSheet.Cells[months + 6, 11].Formula = "=CONCATENATE(\"Amount due in the database is: \",\"" + Math.Round(Convert.ToDecimal(tblSpenddownCalculations.Rows[months + 3][6]), 2).ToStringring("MMddyyyy") + ".csv";
            StreamWriter sw = new StreamWriter(Path.Combine(outputDir, filename), false);
            foreach (DataColumn col in dtDataTable.Columns)
            {
                sw.Write(col.ColumnName + ",");
            }
            sw.WriteLine();
            foreach (DataRow row in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(row[i]))
                    {
                        sw.Write(row[i].ToString());
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}ring("yyyyMMdd", CultureInfo.InvariantCulture) +
                string.Format(CultureInfo.InvariantCulture, @"_{0}.csv", Guid.NewGuid());

            
            string strFilePath = Path.Combine(outputDir, filename);
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!System.Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = string.Format(CultureInfo.InvariantCulture, "\"{0}\"", value, CultureInfo.InvariantCulture);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;

            //Start Excel and get Application object.
            oXL = new Mic            foreach (var property in info)
            {
                header += property.Name + ",";
            }
            header = header.Remove(header.Length - 1, 1);
            sb.AppendLine(header);

            foreach (var obj in genericList)
            {
                var line = "";
                foreach (var property in info)
                {
                    line += property.GetValue(obj, null) + ",";
                }
                line = line.Remove(line.Length - 1, 1);
                sb.AppendLine(line);
            }

            File.WriteAllText(finalPath, sb.ToString());
        }
    }
}ng);
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            excelSheet.Name = "Sheet1";

            // storing header part in Excel

            for (int i = 1; i < dataTable.Columns.Count + 1; i++)
            {
                excel.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
            }

            // storing Each row and column value to excel sheet

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                }
            }

            excel.Visible = true;
            excel.DisplayAlerts = true;
        }
    }
}            // Workk sheet

            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;

            excelSheet.Name = "OMIG";
 
            // now we resize the columns
            excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[dataTable.Rows.Count+1, dataTable.Columns.Count]];
            int i = 0;
            int j = 0;
            //Header
            for (i = 0; i < dataTable.Columns.Count; i++)
            {
                excelCellrange.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                FormattingExcelCells(excelCellrange, "#154360", System.Drawing.Color.White, false);

            }
            //Datas
            for (i = 0; i < dataTable.Rows.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range rowRange = excelSheet.Range[excelSheet.Cells[i + 2, 1], excelSheet.Cells[i + 2, dataTable.Columns.Count]];
                for (j = 0; j < dataTable.Columns.Count; j++)
                {
                    excelCellrange.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                }
                if (i % 2 == 0)
                {
                    FormattingExcelCells(rowRange, "white", System.Drawing.Color.Black, false);
                }
                else
                { 
                    FormattingExcelCells(rowRange, "#2E86C1", System.Drawing.Color.White, false); 
                }
            }
            excelCellrange.EntireColumn.AutoFit();


            Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;
            

            excel.Visible = true;

            excel.DisplayAlerts = true;
        }

        public static void FormattingExcelCells(Microsoft.Office.Interop.Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor,            wb.Worksheets.Add(tblRptAdjSummary, "Rpt_003_AdjSummary");
            wb.Worksheets.Add(tblRptSummaryBy6Ms, "Rpt_004_Summary_by_6Ms");
            wb.Worksheets.Add(tblTmpDedupListing, "Tmp_Dedup_Listing");
            wb.Worksheets.Add(tblTmpDetailVoucherDup, "Tmp_Detail_Voucher_Dup");

            wb.SaveAs(outputDir + filename);

        }wb.Worksheets.Add(tblRptAdjSummary, "Rpt_007_Rpt_Adj_Summary_by_MOS");
            wb.Worksheets.Add(tblRptSummaryBy6Ms, "Rpt_Summary_By_6Ms_aka_5_rows");
            wb.SaveAs(Path.Combine(outputDir, filename));

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;

            //Start Excel and get Application object.
            oXL = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                UserControl = false
            };

            //Get a new workbook.
            oWB = oXL.Workbooks.Open(Path.Combine(outputDir, filename));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;



            oSheet.get_Range("A1", "Y1").Font.Bold = true;
            oSheet.get_Range("A1", "Y1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /************************************************************************************/
            /* Calculate the size of cell range                                                 */
            /************************************************************************************/
            string endRange = "U" + (1 + 6).ToString(CultureInfo.InvariantCulture);
            //oSheet.get_Range("A2", endRange).Value2 = saData;

            /************************************************************************************/
            /* format cells                                                                     */
            /************************************************************************************/



            oRng = oSheet.get_Range("G2", endRange);
            oRng.NumberFormat = "_-$* #,";.Excel.Worksheet)oWB.ActiveSheet;

            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            oWB.Save();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(oRng);
            Marshal.FinalReleaseComObject(oSheet);

            oWB.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(oWB);

            oXL.Quit();
            Marshal.FinalReleaseComObject(oXL);

            filename = "CHP_VchDup_for_" + date.ToString("yyyyMM", CultureInfo.InvariantCulture) + "_on_" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) +
     string.Format(CultureInfo.InvariantCulture, @".xlsx");

            wb = new XLWorkbook();
            wb.Worksheets.Add(tblTmpDedupListing, "tmp_Dedup_listing,");
            wb.Worksheets.Add(tblTmpDetailVoucherDup, "tmp_Detail_Voucher_Dup");

            wb.SaveAs(Path.Combine(outputDir, filename));

            misvalue = System.Reflection.Missing.Value;

            oXL = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                UserControl = false
            };

            oWB = oXL.Workbooks.Open(Path.Combine(outputDir, filename));
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWB.ActiveSheet;.Excel._Worksheet)oWB.ActiveSheet;



            oSheet.get_Range("A1", "Y1").Font.Bold = true;
            oSheet.get_Range("A1", "Y1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /************************************************************************************/
            /* Calculate the size of cell range                                                 */
            /************************************************************************************/
            endRange = "U" + (1 + 6).ToString(CultureInfo.InvariantCulture);
            //oSheet.get_Range("A2", endRange).Value2 = saData;

            /************************************************************************************/
            /* format cells                                                                     */
            /************************************************************************************/



            oRng = oSheet.get_Range("G2", endRange);
            oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            /************************************************************************************/
            /* Write and close excel file                                                          */
            /************************************************************************************/
            //oSheet.get_Range("A" + (months + 2).ToString(), "Y" + (months + 10).ToString()).Font.Bold = true;


            oWB.Save();
            //oXL.Visible = true;
            //oXL.UserControl = true;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(oRng);
            Marshal.FinalReleaseComObject(oSheet);

            oWB.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(oWB);

            oXL.Quit();
            Marshal.FinalReleaseComObject(oXL);
            //return oXL;
        }

        public static void ExportSuspenseReportToExcel(DataTable tblAllYears, DataTable tblLastActive, DataTable tblHistorical, string LOB, DateTime date)

        {

            string outputDir = @"REDACTED";
            string filename = LOB.ToUpper() + " - Suspense All Years and Last Active -" + date.ToString("yyyyMM", CultureInfo.InvariantCulture) + "_on_" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) +
                 string.Format(CultureInfo.InvariantCulture, @".xlsx");


            XLWorkbook wb = new XLWorkbook();
            DataTable tblAllYearsCloned = tblAllYears.Clone();
            tblAllYearsCloned.Columns["Report_date"].DataType = typeof(string);
            foreach (DataRow row in tblAllYears.Rows)
            {
                tblAllYearsCloned.ImportRow(row);
            }
            wb.Worksheets.Add(tblAllYearsCloned, "EP Suspense Report - All Years");


            DataTable tblLastActiveCloned = tblLastActive.Clone();
            tblLastActiveCloned.Columns["mepe_eff_dt"].DataType = typeof(string);
            tblLastActiveCloned.Columns["mepe_term_dt"].DataType = typeof(string);
            foreach (DataRow row in tblLastActive.Rows)
            {
                tblLastActiveCloned.ImportRow(row);
            }
            wb.Worksheets.Add(tblLastActiveCloned, "EP - Last Active");
            wb.SaveAs(Path.Combine(outputDir, filename));

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;

            //Start Excel and get Application object.
            oXL = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                UserControl = false
            };

            //Get a new workbook.
            oWB = oXL.Workbooks.Open(Path.Combine(outputDir, filename));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;



            oSheet.get_Range("A1", "Y1").Font.Bold = true;
            oSheet.get_Range("A1", "Y1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /************************************************************************************/
            /* Calculate the size of cell range                                                 */
            /************************************************************************************/
            string endRange = "U" + (1 + 6).ToString(CultureInfo.InvariantCulture);
            //oSheet.get_Range("A2", endRange).Value2 = saData;

            /************************************************************************************/
            /* format cells                                                                     */
            /************************************************************************************/



            //oRng = oSheet.get_Range("G2", endRange);
            //oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            /************************************************************************************/
            /* Write and close excel file                                                          */
            /************************************************************************************/
            //oSheet.get_Range("A" + (months + 2).ToString(), "Y" + (months + 10).ToString()).Font.Bold = true;


            oWB.Save();
            //oXL.Visible = true;
            //oXL.UserControl = true;

            //return oXL;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(oRng);
            Marshal.FinalReleaseComObject(oSheet);

            oWB.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(oWB);

            oXL.Quit();
            Marshal.FinalReleaseComObject(oXL);

            filename = LOB.ToUpper() + " - Suspense Summary -" + date.ToString("yyyyMM", CultureInfo.InvariantCulture) + "_on_" + DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture) +
                 string.Format(CultureInfo.InvariantCulture, @".xlsx");


            wb = new XLWorkbook();
            DataTable tblHistoricalCloned = tblHistorical.Clone();
            tblHistoricalCloned.Columns["first_reported"].DataType = typeof(string);
            foreach (DataRow row in tblHistorical.Rows)
            {
                tblHistoricalCloned.ImportRow(row);
            }
            wb.Worksheets.Add(tblHistoricalCloned, "CHP_report_historical");


            wb.SaveAs(Path.Combine(outputDir, filename));


            misvalue = System.Reflection.Missing.Value;

            //Start Excel and get Application object.
            oXL = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                UserControl = false
            };

            //Get a new workbook.
            oWB = oXL.Workbooks.Open(Path.Combine(outputDir, filename));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;


            oSheet.get_Range("A1", "Y1").Font.Bold = true;
            oSheet.get_Range("A1", "Y1").VerticalAlignment =
            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            /*************/***********************************************************************/
            /* Calculate the size of cell range                                                 */
            /************************************************************************************/
            endRange = "U" + (1 + 6).ToString(CultureInfo.InvariantCulture);
            //oSheet.get_Range("A2", endRange).Value2 = saData;

            /************************************************************************************/
            /* format cells                                                                     */
            /************************************************************************************/



            //oRng = oSheet.get_Range("G2", endRange);
            //oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";

            oRng = oSheet.get_Range("A1", "Y1");
            oRng.EntireColumn.AutoFit();

            /************************************************************************************/
            /* Write and close excel file                                                          */
            /************************************************************************************/
            //oSheet.get_Range("A" + (months + 2).ToString(), "Y" + (months + 10).ToString()).Font.Bold = true;


            oWB.Save();
            //oXL.Visible = true;
            //oXL.UserControl = true;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(oRng);
            Marshal.FinalReleaseComObject(oSheet);

            oWB.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(oWB);

            oXL.Quit();
            Marshal.FinalReleaseComObject(oXL);
            //return oXL;
        }

    }
}