= "SELECT * FROM OMIG_Index";
                    NpgsqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        ExcelCell cell = new ExcelCell();
                        cell.Field1 = dr["Field1"].ToString();
                        cell.Field2 = dr["Field2"].ToString();
                        cell.Field3 = dr["Field3"].ToString();
                        cell.Field4 = dr["Field4"].ToString();
                        cellList.Add(cell);
                    }
                    awConnection.Close();
                }
                catch (Exception ex)
                {
                    errorMessages = ex.Message;
                }
            }
            objProgress.ReportProgress(90);
            return cellList;
        }
    }
}= "DROP TABLE Sandbox.FinancialTools_OMIGIndex; ";
                    command.CommandTimeout = 86400;
                    command.ExecuteNonQuery();
                    command.CommandText = @"CREATE TABLE  Sandbox.FinancialTools_OMIGIndex ( 

                                            ID SERIAL PRIMARY KEY,
                                            CIN TEXT NOT NULL,
                                            FileName TEXT NOT NULL,
                                            SheetId TEXT NOT NULL,
                                            SheetName TEXT NOT NULL,
                                            CellReference TEXT NOT NULL
                                            );";
                    command.ExecuteNonQuery();
                    command.CommandText = @"INSERT INTO  Sandbox.FinancialTools_OMIGIndex ( 
                                                        CIN,
                                                        FileName,
                                                        SheetId,
                                                        SheetName,
                                                        CellReference
                                                        )
                                                        VALUES (
                                                        @CIN,
                                                        @FileName,
                                                        @SheetId,
                                                        @SheetName,
                                                        @CellReference
                                                        ); ";
                    command.Parameters.Add(new NpgsqlParameter("CIN", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("FileName", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("Sh                      {
                                            if (cell.CellReference != null)
                                            {
                                                if (rgx.IsMatch(cell.CellReference.InnerText))
                                                {
                                                    string cellValue = "";
                                                    if (cell.DataType != null && cell.DataType == CellValues.SharedString)
                                                    {
                                                        cellValue = values[int.Parse(cell.InnerText)].InnerText;
                                                    }
                                                    else
                                                    {
                                                        cellValue = cell.InnerText;
                                                    }

                                                    command.Parameters[0].Value = cellValue;
                                                    command.Parameters[1].Value = Sheet.Name;
                                                    command.Parameters[2].Value = cell.CellReference.InnerText;

                                                    command.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        transaction.Commit();
                    }
                }
            }
        }
    }
}                                                parameterSheetId.ParameterName = "SheetId";
                                                parameterSheetId.Value = Sheet.Id;
                                                parameterSheetId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                                                command.Parameters.Add(parameterSheetId);
                                                var parameterSheetName = command.CreateParameter();
                                                parameterSheetName.ParameterName = "SheetName";
                                                parameterSheetName.Value = Sheet.Name;
                                                parameterSheetName.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
                                                command.Parameters.Add(parameterSheetName);
                                                var parameterCellReference = command.CreateParameter();
                                                parameterCellReference.ParameterName = "CellReference";
                                                parameterCellReference.Value = cell.CellReference;
                                                parameterCellReference.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
                                                command.Parameters.Add(parameterCellReference);
                                                command.ExecuteNonQuery();    parameterSheetId.ParameterName = "SheetId";
    parameterSheetId.Value = Sheet.Id;
    parameterFilename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
    command.Parameters.Add(parameterSheetId);
    var parameterSheetName = command.CreateParameter();
    parameterSheetName.ParameterName = "SheetName";
    parameterSheetName.Value = Sheet.Name;
    parameterFilename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
    command.Parameters.Add(parameterSheetName);
    var parameterCellReference = command.CreateParameter();
    parameterCellReference.ParameterName = "CellReference";
    parameterCellReference.Value = cell.CellReference;
    parameterCellReference.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
    command.Parameters.Add(parameterCellReference);*/

    /*command.Parameters.AddWithValue("CIN", value);
    command.Parameters.AddWithValue("FileName", filename);
    command.Parameters.AddWithValue("SheetId",  Sheet.Id);
    command.Parameters.AddWithValue("SheetName", Sheet.Name);
    command.Parameters.AddWithValue("CellReference", cell.CellReference);command.Parameters["CIN"].Value = value;
command.Parameters["CIN"].DataTypeName = "Text";
command.Parameters["FileName"].Value = filename;
command.Parameters["FileName"].DataTypeName = "Text";
command.Parameters["SheetId"].Value = Sheet.Id.ToString();
command.Parameters["SheetId"].DataTypeName = "Text";
command.Parameters["SheetName"].Value = Sheet.Name.ToString();
command.Parameters["SheetName"].DataTypeName = "Text";
command.Parameters["CellReference"].Value = cell.CellReference.ToString();
command.Parameters["CellReference"].DataTypeName = "Text";
// Prepare the command.
command.Prepare();


// Add value to the paramater.

command.ExecuteNonQuery();ANITIZE ON *.* TO 'user'@'localhost' IDENTIFIED BY 'password';";
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    errorMessages += ex.ToString();
                }
            }

            return errorMessages;
        }();

                    foreach (DataRow row in data.Rows)
                    {
                        query = "INSERT INTO Sandbox.FinancialTools_OMIGIndex (asofdate, planid, planname, contractid, contractname, omigindex, plancontract) VALUES ('" + row["asofdate"].ToString() + "', '" + row["planid"].ToString() + "', '" + row["planname"].ToString() + "', '" + row["contractid"].ToString() + "', '" + row["contractname"].ToString() + "', '" + row["omigindex"].ToString() + "', '" + row["plancontract"].ToString() + "')";
                        current = "Processing " + k + " out of " + data.Rows.Count + " records";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, awConnection))
                        {
                            command.CommandTimeout = 86400;
                            command.ExecuteNonQuery();
                        }
                        k++;
                    }
                    awConnection.Close();
                }
                catch (Exception ex)
                {
                    errorMessages = ex.ToString();
                    // Handle exception
                }
            }
        }r(2),
                        "Dob Yr" int,
                        "Dob Mo" int,
                        "Dob Day" int,
                        "Paymt Start Yr" int,
                        "Paymt Start Mo" int,
                        "Paymt Start Day" int,
                        "Paymt End Yr" int,
                        "Paymt End Mo" int,
                        "Paymt End Day" int,
                        "UnknownMoney2" Money,
                        "UnknownMoney3" Money,
                        "UnknownMoney4" Money,
                        "UnknownMoney5" Money,
                        "UnknownFlag2" varchar(9),
                        "UnknownFlag3" varchar(9),
                        "UnknownFlag4" varchar(9),
                        "UnknownFlag5" varchar(9),
                        "UnknownFlag6" varchar(9),
                        "UnknownFlag7" varchar(9),
                        "UnknownFlag8" varchar(9),
                        "UnknownFlag9" varchar(9),
                        "UnknownFlag10" varchar(9),
                        "UnknownFlag11" varchar(9),
                        "UnknownFlag12" varchar(9),
                        "UnknownFlag13" varchar(9),
                        "UnknownFlag14" varchar(9),
                        "UnknownFlag15" varchar(9),
                        "UnknownFlag16" varchar(9),
                        "UnknownFlag17" varchar(9),
                        "UnknownFlag18" varchar(9),
                        "UnknownFlag19" varchar(9),
                        "UnknownFlag20" varchar(9),
                        "UnknownFlag21" varchar(9),
                        "UnknownFlag22" varchar(9),
                        "UnknownFlag23" varchar(9),
                        "UnknownFlag24" varchar(9),
                        "UnknownFlag25" varchar(9),
                        "UnknownFlag26" varchar(9),
                        "UnknownFlag27" varchar(9),
                        "UnknownFlag28" varchar(9),
                        "UnknownFlag29" varchar(9),
                        "UnknownFlag30" varchar(9),
                        "UnknownFlag31" varchar(9),
                        "UnknownFlag32" varchar(9),
                        "UnknownFlag33" varchar(9),
                        "UnknownFlag34" varchar(9),
                        "UnknownFlag35" varchar(9),
                        "UnknownFlag36" varchar(9),
                        "UnknownFlag37" varchar(9),
                        "UnknownFlag38" varchar(9),
                        "UnknownFlag39" varchar(9),
                        "UnknownFlag40" varchar(9),
                        "UnknownFlag41" varchar(9),
                        "UnknownFlag42" varchar(9),
                        "UnknownFlag43" varchar(9),
                        "UnknownFlag44" varchar(9),
                        "UnknownFlag45" varchar(9),
                        "UnknownFlag46" varchar(9),
                        "UnknownFlag47" varchar(9),
                        "UnknownFlag48" varchar(9),
                        "UnknownFlag49" varchar(9),
                        "UnknownFlag50" varchar(9),
                        "UnknownFlag51" varchar(9),
                        "UnknownFlag52" varchar(9),
                        "UnknownFlag53" varchar(9),
                        "UnknownFlag54" varchar(9),
                        "UnknownFlag55" varchar(9),
                        "UnknownFlag56" varchar(9),
                        "UnknownFlag57" varchar(9),
                        "UnknownFlag58" varchar(9),
                        "UnknownFlag59" varchar(9),
                        "UnknownFlag60" varchar(9),
                        "UnknownFlag61" varchar(9),
                        "UnknownFlag62" varchar(9),
                        "UnknownFlag63" varchar(9),
                        "UnknownFlag64" varchar(9),
                        "UnknownFlag65" varchar(9),
                        "UnknownFlag66" varchar(9),
                        "UnknownFlag67" varchar(9),
                        "UnknownFlag68" varchar(9),
                        "UnknownFlag69" varchar(9),
                        "UnknownFlag70" varchar(9),
                        "UnknownFlag71" varchar(9),
                        "UnknownFlag72" varchar(9),
                        "UnknownFlag73" varchar(9),
                        "UnknownFlag74" varchar(9),
                        "UnknownFlag75" varchar(9),
                        "UnknownFlag76" varchar(9),
                        "UnknownFlag77" varchar(9),
                        "UnknownFlag78" varchar(9),
                        "UnknownFlag79" varchar(9),
                        "UnknownFlag80" varchar(9),
                        "UnknownFlag81" varchar(9),
                        "UnknownFlag82" varchar(9),
                        "UnknownFlag83" varchar(9),
                        "UnknownFlag84" varchar(9),
                        "UnknownFlag85" varchar(9),
                        "UnknownFlag86" varchar(9),
                        "UnknownFlag87" varchar(9),
                        "UnknownFlag88" varchar(9),
                        "UnknownFlag89" varchar(9),
                        "UnknownFlag90" varchar(9),
                        "UnknownFlag91" varchar(9),
                        "UnknownFlag92" varchar(9),
                        "UnknownFlag93" varchar(9),
                        "UnknownFlag94" varchar(9),
                        "UnknownFlag95" varchar(9),
                        "UnknownFlag96" varchar(9),
                        "UnknownFlag97" varchar(9),
                        "UnknownFlag98" varchar(9),
                        "UnknownFlag99" varchar(9),
                        "UnknownFlag100" varchar(9),
                        "UnknownFlag101" varchar(9),
                        "UnknownFlag102" varchar(9),
                        "UnknownFlag103" varchar(9),
                        "UnknownFlag104" varchar(9),
                        "UnknownFlag105" varchar(9),
                        "UnknownFlag106" varchar(9),
                        "UnknownFlag107" varchar(9),
                        "UnknownFlag108" varchar(9),
                        "UnknownFlag109" varchar(9),
                        "UnknownFlag110" varchar(9),
                        "UnknownFlag111" varchar(9),
                        "UnknownFlag112" varchar(9),
                        "UnknownFlag113" varchar(9),
                        "UnknownFlag114" varchar(9),
                        "UnknownFlag115" varchar(9),
                        "UnknownFlag116" varchar(9),
                        "UnknownFlag117" varchar(9),
                        "UnknownFlag118" varchar(9),
                        "UnknownFlag119" varchar(9),
                        "UnknownFlag120" varchar(9),
                        "UnknownFlag121" varchar(9),
                        "UnknownFlag122" varchar(9),
                        "UnknownFlag123" varchar(9),
                        "UnknownFlag124" varchar(9),
                        "UnknownFlag125" varchar(9),
                        "UnknownFlag126" varchar(9),
                        "UnknownFlag127" varchar(9),
                        "UnknownFlag128" varchar(9),
                        "UnknownFlag129" varchar(9),
                        "UnknownFlag130" varchar(9),
                        "UnknownFlag131" varchar(9),
                        "UnknownFlag132" varchar(9),
                        "UnknownFlag133" varchar(9),
                        "UnknownFlag134" varchar(9),
                        "UnknownFlag135" varchar(9),
                        "UnknownFlag136" varchar(9),
                        "UnknownFlag137" varchar(9),
                        "UnknownFlag138" varchar(9),
                        "UnknownFlag139" varchar(9),
                        "Unknown"Frailty Ind" char,
                        "Prev Ind" char,
                        "Lag Ind" char,
                        "Seg ID" varchar(3),
                        "Enroll Source" char,
                        "EGHP" char,
                        "Part C Premium A" Money,
                        "Part C Premium B" Money,
                        "Rebate A" Money,
                        "Rebate B" Money,
                        "Rebate A Supp" Money,
                        "Rebate B Supp" Money,
                        "Rebate A Reduction" Money,
                        "Rebate B Reduction" Money,
                        "Rebate Part D Supp A" Money,
                        "Rebate Part D Supp B" Money,
                        "Total Part A" Money,
                        "Total Part B" Money,
                        "Total MA" Money,
                        "Part D RA" varchar(7),
                        "Part D Low Income Ind"  char,
                        "Part D Low Income Mult" varchar(7),
                        "Part D Long Term Ind" char,
                        "Part D Long Term Mult" varchar(7),
                        "Rebate Part D Premium Red" Money,
                        "Part D Premium Amt" money,
                        "Part D Subsidy Paymt" money,
                        "Resinsurance Subsidy Amt" money,
                        "Low Income Subsidy Cost" money,
                        "Total Part D" money,
                        "Nbr Paymt D" varchar(2),
                        "PACE Premium Add-On" money,
                        "PACE Cost Add-on" money,
                        "UnknownIndicator1" varchar(7),
                        "UnknownIndicator2" varchar(7),
                        "UnknownAmount1" money,
                        "UnknownAmount2" money,
                        "UnknownIndicator3" varchar(2),
                        "UnknownIndicator4" varchar(8),                            " \"UnknownIndicator5\"," +
                            " \"UnknownIndicator6\", " +
                            " \"UnknownAmount3\", " +
                            " \"UnknownAmount4\", " +
                            " \"UnknownAmount5\", " +
                            " \"UnknownText1\", " +
                            " \"Filename\" " +
                            " ) VALUES (" +
                            " :MCONbr, " +
                            " :RunDate, " +
                            " :PayDate, " +
                            " :HICNbr, " +
                            " :Surname, " +
                            " :FirstInit, " +
                            " :Sex, " +
                            " :DOB, " +
                            " :AgeGroup, " +
                            " :ST, " +
                            " :OutOfArea, " +
                            " :PartA, " +
                            " :PartB, " +
                            " :Hospice, " +
                            " :ESRD, " +
                            " :WorkingAge, " +
                            " :Institutional, " +
                            " :NHC, " +
                            " :Medicaid, " +
                            " :FILLER, " +
                            " :MedicaidInd, " +
                            " :PIPDCG, " +
                            " :DefaultInd, " +
                            " :RiskAdjA, " +
                            " :RiskAdjB, " +
                            " :NbrPaymtA, " +
                            " :NbrPaymtB, " +
                            " :AdjCode, " +
                            " :PaymtStart, " +
                            " :PaymtEnd, " +
                            " :UnknownIndicator5, " +
                            " :UnknownIndicator6, " +
                            " :UnknownAmount3, " +
                            " :UnknownAmount4, " +
                            " :UnknownAmount5, " +
                            " :UnknownText1, " +
                            " :Filename " +
                            " )";
                    command.Parameters.AddWithValue(":MCONbr", MCONbr);
                    command.Parameters.AddWithValue(":RunDate", RunDate);
                    command.Parameters.AddWithValue(":PayDate", PayDate);
                    command.Parameters.AddWithValue(":HICNbr", HICNbr);
                    command.Parameters.AddWithValue(":Surname", Surname);
                    command.Parameters.AddWithValue(":FirstInit", FirstInit);
                    command.Parameters.AddWithValue(":Sex", Sex);
                    command.Parameters.AddWithValue(":DOB", DOB);
                    command.Parameters.AddWithValue(":AgeGroup", AgeGroup);
                    command.Parameters.AddWithValue(":ST", ST);
                    command.Parameters.AddWithValue(":OutOfArea", OutOfArea);
                    command.Parameters.AddWithValue(":PartA", PartA);
                    command.Parameters.AddWithValue(":PartB", PartB);
                    command.Parameters.AddWithValue(":Hospice", Hospice);
                    command.Parameters.AddWithValue(":ESRD", ESRD);
                    command.Parameters.AddWithValue(":WorkingAge", WorkingAge);
                    command.Parameters.AddWithValue(":Institutional", Institutional);
                    command.Parameters.AddWithValue(":NHC", NHC);
                    command.Parameters.AddWithValue(":Medicaid", Medicaid);
                    command.Parameters.AddWithValue(":FILLER", FILLER);
                    command.Parameters.AddWithValue(":MedicaidInd", MedicaidInd);
                    command.Parameters.AddWithValue(":PIPDCG", PIPDCG);
                    command.Parameters.AddWithValue(":DefaultInd", DefaultInd);
                    command.Parameters.AddWithValue(":RiskAdjA", RiskAdjA);
                    command.Parameters.AddWithValue(":RiskAdjB", RiskAdjB);
                    command.Parameters.AddWithValue(":NbrPaymtA", NbrPaymtA);
                    command.Parameters.AddWithValue(":NbrPaymtB", NbrPaymtB);
                    command.Parameters.AddWithValue(":AdjCode", AdjCode);
                    command.Parameters.AddWithValue(":PaymtStart", PaymtStart);
                    command.Parameters.AddWithValue(":PaymtEnd", PaymtEnd);
                    command.Parameters.AddWithValue(":UnknownIndicator5", UnknownIndicator5);
                    command.Parameters.AddWithValue(":UnknownIndicator6", UnknownIndicator6);
                    command.Parameters.AddWithValue(":UnknownAmount3", UnknownAmount3);
                    command.Parameters.AddWithValue(":UnknownAmount4", UnknownAmount4);
                    command.Parameters.AddWithValue(":UnknownAmount5", UnknownAmount5);
                    command.Parameters.AddWithValue(":UnknownText1", UnknownText1);
                    command.Parameters.AddWithValue(":Filename", Filename);The code provided does not contain any sensitive information that needs to be sanitized.                            @PartD,
                            @PartDPlan,
                            @PartDStartDate,
                            @PartDEndDate,
                            @PartDPremiumRed,
                            @PartDPremiumAmt,
                            @PartDSubsidyPaymt,
                            @ResinsuranceSubsidyAmt,
                            @LowIncomeSubsidyCost,
                            @TotalPartD,
                            @NbrPaymtD,
                            @PACEPremiumAddOn,
                            @PACECostAddOn,
                            @UnknownIndicator1,
                            @UnknownIndicator2,
                            @UnknownAmount1,
                            @UnknownAmount2,
                            @UnknownIndicator3,
                            @UnknownIndicator4,
                            @UnknownIndicator5,
                            @UnknownIndicator6,
                            @UnknownAmount3,
                            @UnknownAmount4,
                            @UnknownAmount5,
                            @UnknownText1,
                            @Filename"@Medicaid,
@FILLER,
@MedicaidInd,
@PIPDCG,
@DefaultInd,
@RiskAdjA,
@RiskAdjB,
@NbrPaymtA,
@NbrPaymtB,
@AdjCode,
@PaymtStart,
@PaymtEnd,
@DemoPaymtA,
@DemoPaymtB,
@RiskPaymtA,
@RiskPaymtB,
@LISAmt,
@ESRDMSP,
@UnknownMoney1,
@UnknownFlag1,
@RAAG,
@PRDIP,
@PlanBenefit,
@RaceCode,
@RACode,
@FrailtyInd,
@PrevInd,
@LagInd,
@SegID,
@EnrollSource,
@EGHP,
@PartCPremiumA,
@PartCPremiumB,
@RebateA,
@RebateB,
@RebateASupp,
@RebateBSupp,
@RebateAReduction,
@RebateBReduction,
@RebatePartDSuppA,
@RebatePartDSuppB,
@TotalPartA,
@TotalPartB,
@TotalMA,
@PartDRA,
@PartDLowIncomeInd,
@PartDLowIncomeMult,
@PartDLongTermInd
```c#
@PartDLongTermMult,
                            @RebatePartDPremiumRed,
                            @PartDPremiumAmt,
                            @PartDSubsidyPaymt,
                            @ResinsuranceSubsidyAmt,
                            @LowIncomeSubsidyCost,
                            @TotalPartD,
                            @NbrPaymtD,
                            @PACEPremiumAddOn,
                            @PACECostAddon,
                            @UnknownIndicator1,
                            @UnknownIndicator2,
                            @UnknownAmount1,
                            @UnknownAmount2,
                            @UnknownIndicator3,
                            @UnknownIndicator4,
                            @UnknownIndicator5,
                            @UnknownIndicator6,
                            @UnknownAmount3,
                            @UnknownAmount4,
                            @UnknownAmount5,
                            @UnknownText1,
                            @Filename

                     ); ";


                    command.Parameters.Add(new NpgsqlParameter("MCONbr", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("RunDate", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters.Add(new NpgsqlParameter("PayDate", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters.Add(new NpgsqlParameter("HICNBr", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("Surname", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("FirstInit", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("Sex", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("DOB", NpgsqlTypes.NpgsqlDbType.Date));
```
This code has been sanitized by removing sensitive information.command.Parameters.Add(new NpgsqlParameter("AgeGroup", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("ST", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("OutofArea", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PartA", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PartB", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("Hospice", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("ESRD", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("WorkingAge", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("Insitutional", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("NHC", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("Medicaid", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("FILLER", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("MedicaidInd", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PIPDCG", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("DefaultInd", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("RiskAdjA", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("RiskAdjB", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("NbrPaymtA", NpgsqlTypes.NpgsqlDbType.Varchar));command.Parameters.Add(new NpgsqlParameter("NbrPaymtB", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("AdjCode", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PaymtStart", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters.Add(new NpgsqlParameter("PaymtEnd", NpgsqlTypes.NpgsqlDbType.Date));
                    command.Parameters.Add(new NpgsqlParameter("DemoPaymtA", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("DemoPaymtB", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("RiskPaymtA", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("RiskPaymtB", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("LISAmt", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("ESRDMSP", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("UnknownMoney1", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("UnknownFlag1", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("RAAG", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PRDIP", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PlanBenefit", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("RaceCode", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("RACode", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("FrailtyInd", NpgsqlTypes.NpgsqlDbType.Varchar));Sanitize the following code by removing sensitive information like paths, passwords, logins, database names and table names, and connection strings:

```c#
command.Parameters.Add(new NpgsqlParameter("PrevInd", NpgsqlTypes.NpgsqlDbType.Varchar));
command.Parameters.Add(new NpgsqlParameter("LagInd", NpgsqlTypes.NpgsqlDbType.Varchar));
command.Parameters.Add(new NpgsqlParameter("SegID", NpgsqlTypes.NpgsqlDbType.Varchar));
command.Parameters.Add(new NpgsqlParameter("EnrollSource", NpgsqlTypes.NpgsqlDbType.Varchar));
command.Parameters.Add(new NpgsqlParameter("EGHP", NpgsqlTypes.NpgsqlDbType.Varchar));
command.Parameters.Add(new NpgsqlParameter("PartCPremiumA", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("PartCPremiumB", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebateA", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebateB", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebateASupp", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebateBSupp", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebateAReduction", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebateBReduction", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebatePartDSuppA", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("RebatePartDSuppB", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("TotalPartA", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("TotalPartB", NpgsqlTypes.NpgsqlDbType.Money));
command.Parameters.Add(new NpgsqlParameter("TotalMA", NpgsqlTypes.NpgsqlDbType.Money));
```

Make sure to replace the sensitive information with appropriate placeholders or dummy values before using the code.                    command.Parameters.Add(new NpgsqlParameter("PartDRA", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PartDLowIncomeInd", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PartDLowIncomeMult", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PartDLongTermInd", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PartDLongTermMult", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("RebatePartDPremiumRed", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("PartDPremiumAmt", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("PartDSubsidyPaymt", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("ResinsuranceSubsidyAmt", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("LowIncomeSubsidyCost", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("TotalPartD", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("NbrPaymtD", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("PACEPremiumAddOn", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("PACECostAddon", NpgsqlTypes.NpgsqlDbType.Money));
                    command.Parameters.Add(new NpgsqlParameter("UnknownIndicator1", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("UnknownIndicator2", NpgsqlTypes.NpgsqlDbType.Varchar));
                    command.Parameters.Add(new NpgsqlParameter("UnknownAmou"));].ToString())) data.Rows[i][36] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][37].ToString())) data.Rows[i][37] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][38].ToString())) data.Rows[i][38] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][39].ToString())) data.Rows[i][39] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][40].ToString())) data.Rows[i][40] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][41].ToString())) data.Rows[i][41] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][42].ToString())) data.Rows[i][42] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][43].ToString())) data.Rows[i][43] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][44].ToString())) data.Rows[i][44] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][45].ToString())) data.Rows[i][45] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][46].ToString())) data.Rows[i][46] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][47].ToString())) data.Rows[i][47] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][48].ToString())) data.Rows[i][48] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][49].ToString())) data.Rows[i][49] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][50].ToString())) data.Rows[i][50] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][51].ToString())) data.Rows[i][51] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][52].ToString())) data.Rows[i][52] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][53].ToString())) data.Rows[i][53] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][54].ToString())) data.Rows[i][54] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][55].ToString())) data.Rows[i][55] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][56].ToString())) data.Rows[i][56] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][57].ToString())) data.Rows[i][57] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][58].ToString())) data.Rows[i][58] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][59].ToString())) data.Rows[i][59] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][60].ToString())) data.Rows[i][60] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][61].ToString())) data.Rows[i][61] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][62].ToString())) data.Rows[i][62] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][63].ToString())) data.Rows[i][63] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][64].ToString())) data.Rows[i][64] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][65].ToString())) data.Rows[i][65] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][66].ToString())) data.Rows[i][66] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][67].ToString())) data.Rows[i][67] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][68].ToString())) data.Rows[i][68] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][69].ToString())) data.Rows[i][69] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][70].ToString())) data.Rows[i][70] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][71].ToString())) data.Rows[i][71] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][72].ToString())) data.Rows[i][72] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][73].ToString())) data.Rows[i][73] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][74].ToString())) data.Rows[i][74] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][75].ToString())) data.Rows[i][75] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][76].ToString())) data.Rows[i][76] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][77].ToString())) data.Rows[i][77] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][78].ToString())) data.Rows[i][78] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][79].ToString())) data.Rows[i][79] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][80].ToString())) data.Rows[i][80] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][81].ToString())) data.Rows[i][81] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][82].ToString())) data.Rows[i][82] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][83].ToString())) data.Rows[i][83] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][84].ToString())) data.Rows[i][84] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][85].ToString())) data.Rows[i][85] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][86].ToString())) data.Rows[i][86] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][87].ToString())) data.Rows[i][87] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][88].ToString())) data.Rows[i][88] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][89].ToString())) data.Rows[i][89] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][90].ToString())) data.Rows[i][90] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][91].ToString())) data.Rows[i][91] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][92].ToString())) data.Rows[i][92] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][93].ToString())) data.Rows[i][93] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][94].ToString())) data.Rows[i][94] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][95].ToString())) data.Rows[i][95] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][96].ToString())) data.Rows[i][96] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][97].ToString())) data.Rows[i][97] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][98].ToString())) data.Rows[i][98] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][99].ToString())) data.Rows[i][99] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][100].ToString())) data.Rows[i][100] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][101].ToString())) data.Rows.ToString())) data.Rows[i][36] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][49].ToString())) data.Rows[i][49] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][50].ToString())) data.Rows[i][50] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][51].ToString())) data.Rows[i][51] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][52].ToString())) data.Rows[i][52] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][53].ToString())) data.Rows[i][53] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][54].ToString())) data.Rows[i][54] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][55].ToString())) data.Rows[i][55] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][56].ToString())) data.Rows[i][56] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][57].ToString())) data.Rows[i][57] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][58].ToString())) data.Rows[i][58] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][59].ToString())) data.Rows[i][59] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][60].ToString())) data.Rows[i][60] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][61].ToString())) data.Rows[i][61] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][67].ToString())) data.Rows[i][67] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][68].ToString())) data.Rows[i][68] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][69].ToString())) data.Rows[i][69] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][70].ToString())) data.Rows[i][70] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][71].ToString())) data.Rows[i][71] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][74].ToString())) data.Rows[i][][i][74] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][75].ToString())) data.Rows[i][75] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][78].ToString())) data.Rows[i][78] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][79].ToString())) data.Rows[i][79] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][84].ToString())) data.Rows[i][84] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][85].ToString())) data.Rows[i][85] = "0";
                        if (String.IsNullOrEmpty(data.Rows[i][86].ToString())) data.Rows[i][86] = "0";


                        command.Parameters["Parameter1"].Value = data.Rows[i][0] ;
                        command.Parameters["Parameter2"].Value = DateTime.ParseExact(data.Rows[i][1].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None) ;
                        command.Parameters["Parameter3"].Value = DateTime.ParseExact(data.Rows[i][2].ToString(), "yyyyMM", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None) ;
                        command.Parameters["Parameter4"].Value = data.Rows[i][3] ;
                        command.Parameters["Parameter5"].Value = data.Rows[i][4] ;
                        command.Parameters["Parameter6"].Value = data.Rows[i][5] ;
                        command.Parameters["Parameter7"].Value = data.Rows[i][6] ;
                        command.Parameters["Parameter8"].Value = DateTime.ParseExact(data.Rows[i][7].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None) ;
                        command.Parameters["Parameter9"].Value = data.Rows[i][8] ;
                        command.Parameters["Parameter10"].Value = data.Rows[i][9] ;
                        command.Parameters["Parameter11"].Value = data.Rows[i][10] ;
                        command.Parameters["Parameter12"].Value = data.Rows[i][11] ;ows[i][11] ;
                        command.Parameters["PartB"].Value = data.Rows[i][12] ;
                        command.Parameters["Hospice"].Value = data.Rows[i][13] ;
                        command.Parameters["ESRD"].Value = data.Rows[i][14] ;
                        command.Parameters["WorkingAge"].Value = data.Rows[i][15] ;
                        command.Parameters["Insitutional"].Value = data.Rows[i][16] ;
                        command.Parameters["NHC"].Value = data.Rows[i][17] ;
                        command.Parameters["Medicaid"].Value = data.Rows[i][18] ;
                        command.Parameters["FILLER"].Value = data.Rows[i][19] ;
                        command.Parameters["MedicaidInd"].Value = data.Rows[i][20] ;
                        command.Parameters["PIPDCG"].Value = data.Rows[i][21] ;
                        command.Parameters["DefaultInd"].Value = data.Rows[i][22] ;
                        command.Parameters["RiskAdjA"].Value = data.Rows[i][23] ;
                        command.Parameters["RiskAdjB"].Value = data.Rows[i][24] ;
                        command.Parameters["NbrPaymtA"].Value = data.Rows[i][25] ;
                        command.Parameters["NbrPaymtB"].Value = data.Rows[i][26] ;
                        command.Parameters["AdjCode"].Value = data.Rows[i][27] ;
                        command.Parameters["PaymtStart"].Value = DateTime.ParseExact(data.Rows[i][28].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None) ;
                        command.Parameters["PaymtEnd"].Value = DateTime.ParseExact(data.Rows[i][29].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None) ;
                        command.Parameters["DemoPaymtA"].Value = Convert.ToDecimal( data.Rows[i][30]) ;
                        command.Parameters["DemoPaymtB"].Value = Convert.ToDecimal(data.Rows[i][31]) ;command.Parameters["RiskPaymtA"].Value = Convert.ToDecimal(data.Rows[i][32]);
command.Parameters["RiskPaymtB"].Value = Convert.ToDecimal(data.Rows[i][33]);
command.Parameters["LISAmt"].Value = Convert.ToDecimal(data.Rows[i][34]);
command.Parameters["ESRDMSP"].Value = data.Rows[i][35];
command.Parameters["UnknownMoney1"].Value = Convert.ToDecimal(data.Rows[i][36]);
command.Parameters["UnknownFlag1"].Value = data.Rows[i][37];
command.Parameters["RAAG"].Value = data.Rows[i][38];
command.Parameters["PRDIP"].Value = data.Rows[i][39];
command.Parameters["PlanBenefit"].Value = data.Rows[i][40];
command.Parameters["RaceCode"].Value = data.Rows[i][41];
command.Parameters["RACode"].Value = data.Rows[i][42];
command.Parameters["FrailtyInd"].Value = data.Rows[i][43];
command.Parameters["PrevInd"].Value = data.Rows[i][44];
command.Parameters["LagInd"].Value = data.Rows[i][45];
command.Parameters["SegID"].Value = data.Rows[i][46];
command.Parameters["EnrollSource"].Value = data.Rows[i][47];
command.Parameters["EGHP"].Value = data.Rows[i][48];
command.Parameters["PartCPremiumA"].Value = Convert.ToDecimal(data.Rows[i][49]);
command.Parameters["PartCPremiumB"].Value = Convert.ToDecimal(data.Rows[i][50]);
command.Parameters["RebateA"].Value = Convert.ToDecimal(data.Rows[i][51]);
command.Parameters["RebateB"].Value = Convert.ToDecimal(data.Rows[i][52]);
command.Parameters["RebateASupp"].Value = Convert.ToDecimal(data.Rows[i][53]);.command.Parameters["RebateBSupp"].Value = Convert.ToDecimal(data.Rows[i][54]) ;
                        command.Parameters["RebateAReduction"].Value = Convert.ToDecimal(data.Rows[i][55]) ;
                        command.Parameters["RebateBReduction"].Value = Convert.ToDecimal(data.Rows[i][56]) ;
                        command.Parameters["RebatePartDSuppA"].Value = Convert.ToDecimal(data.Rows[i][57]) ;
                        command.Parameters["RebatePartDSuppB"].Value = Convert.ToDecimal(data.Rows[i][58]) ;
                        command.Parameters["TotalPartA"].Value = Convert.ToDecimal(data.Rows[i][59]) ;
                        command.Parameters["TotalPartB"].Value = Convert.ToDecimal(data.Rows[i][60]) ;
                        command.Parameters["TotalMA"].Value = Convert.ToDecimal(data.Rows[i][61]) ;
                        command.Parameters["PartDRA"].Value = data.Rows[i][62] ;
                        command.Parameters["PartDLowIncomeInd"].Value = data.Rows[i][63] ;
                        command.Parameters["PartDLowIncomeMult"].Value = data.Rows[i][64] ;
                        command.Parameters["PartDLongTermInd"].Value = data.Rows[i][65] ;
                        command.Parameters["PartDLongTermMult"].Value = data.Rows[i][66] ;
                        command.Parameters["RebatePartDPremiumRed"].Value = Convert.ToDecimal(data.Rows[i][67]) ;
                        command.Parameters["PartDPremiumAmt"].Value = Convert.ToDecimal(data.Rows[i][68]) ;
                        command.Parameters["PartDSubsidyPaymt"].Value = Convert.ToDecimal(data.Rows[i][69]) ;
                        command.Parameters["ResinsuranceSubsidyAmt"].Value = Convert.ToDecimal(data.Rows[i][70]) ;
                        command.Parameters["LowIncomeSubsidyCost"].Value = Convert.ToDecimal(data.Rows[i][71]) ;
                        command.Parameters["TotalPartD"].Value = Convert.ToDecimal(data.Rows[i][72]) ;
                        command.Parameters["NbrPaymtD"].Value = data.Rows[i][73] ;
                        command.Parameters["PACEPremiumAddOn"].Value = Convert.ToDecimal(data.Rows[i][74]) ;
                        command.Parameters["PACECostAddon"].Value = Convert.ToDecimal(data.Rows[i][75]) ;
                        command.Parameters["UnknownIndicator1"].Value = data.Rows[i][76] ;
                        command.Parameters["UnknownIndicator2"].Value = data.Rows[i][77] ;
                        command.Parameters["UnknownAmount1"].Value = Convert.ToDecimal(data.Rows[i][78]) ;
                        command.Parameters["UnknownAmount2"].Value = Convert.ToDecimal(data.Rows[i][79]) ;
                        command.Parameters["UnknownIndicator3"].Value = data.Rows[i][80] ;
                        command.Parameters["UnknownIndicator4"].Value = data.Rows[i][81] ;
                        command.Parameters["UnknownIndicator5"].Value = data.Rows[i][82] ;
                        command.Parameters["UnknownIndicator6"].Value = data.Rows[i][83] ;
                        command.Parameters["UnknownAmount3"].Value = Convert.ToDecimal(data.Rows[i][84]) ;
                        command.Parameters["UnknownAmount4"].Value = Convert.ToDecimal(data.Rows[i][85]) ;
                        command.Parameters["UnknownAmount5"].Value = Convert.ToDecimal(data.Rows[i][86]) ;
                        command.Parameters["UnknownText1"].Value = data.Rows[i][87] ;
                        command.Parameters["Filename"].Value = data.Rows[i][88] ; 

                        query = @"INSERT INTO  Sandbox.FinancialTools_MedicareImport ( " +
                            " \"MCO Nbr\"," +
                            " \"Run Date\", " +
                            " \"Pay Date\", " +
                            " \"HIC NBr\", " +
                            " \"Surname\", " +
                            " \"First Init\", " +
                            " \"Sex\", " +
                            " \"DOB\"";" +
                            " \"Age Group\", " +
                            " \"ST\", " +
                            " \"Out of Area\", " +
                            " \"Part A\", " +
                            " \"Part B\", " +
                            " \"Hospice\", " +
                            " \"ESRD\", " +
                            " \"Working Age\", " +
                            " \"Insitutional\", " +
                            " \"NHC\", " +
                            " \"Medicaid\", " +
                            " \"FILLER\", " +
                            " \"Medicaid Ind\", " +
                            " \"PIP DCG\", " +
                            " \"Default Ind\", " +
                            " \"Risk Adj A\", " +
                            " \"Risk Adj B\", " +
                            " \"Nbr Paymt A\", " +
                            " \"Nbr Paymt B\", " +
                            " \"Adj Code\", " +
                            " \"Paymt Start\", " +
                            " \"Paymt End\", " +
                            " \"Demo Paymt A\", " +
                            " \"Demo Paymt B\", " +
                            " \"Risk Paymt A\", " +
                            " \"Risk Paymt B\", " +
                            " \"LIS Amt\", " +
                            " \"ESRD MSP\", " +
                            " \"UnknownMoney1\", " +
                            " \"UnknownFlag1\", " +
                            " \"RAAG\", " +
                            " \"PRDIP\", " +
                            " \"Plan Benefit\", " +
                            " \"Race Code\", " +
                            " \"RA Code\", " +
                            " \"Frailty Ind\", " +
                            " \"Prev Ind\", " +
                            " \"Lag Ind\", " +
                            " \"Seg ID\", " +
                            " \"Enroll Source\", " +"EGHP",
"Part C Premium A",
"Part C Premium B",
"Rebate A",
"Rebate B",
"Rebate A Supp",
"Rebate B Supp",
"Rebate A Reduction",
"Rebate B Reduction",
"Rebate Part D Supp A",
"Rebate Part D Supp B",
"Total Part A",
"Total Part B",
"Total MA",
"Part D RA",
"Part D Low Income Ind",
"Part D Low Income Mult",
"Part D Long Term Ind",
"Part D Long Term Mult",
"Rebate Part D Premium Red",
"Part D Premium Amt",
"Part D Subsidy Paymt",
"Resinsurance Subsidy Amt",
"Low Income Subsidy Cost",
"Total Part D",
"Nbr Paymt D",
"PACE Premium Add-On",
"PACE Cost Add-on",
"UnknownIndicator1",
"UnknownIndicator2",
"UnknownAmount1",
"UnknownAmount2",
"UnknownIndicator3",
"UnknownIndicator4",
"UnknownIndicator5"," \"UnknownIndicator6\", " +
                            " \"UnknownAmount3\", " +
                            " \"UnknownAmount4\", " +
                            " \"UnknownAmount5\", " +
                            " \"UnknownText1\", " +
                            " \"Filename\""

                            + @" )
                                                    VALUES ( " +
                            "'" + data.Rows[i][0] + "'," +
                            "'" + DateTime.ParseExact(data.Rows[i][1].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None).ToString("MM/dd/yyyy") + "'," +
                            "'" + DateTime.ParseExact(data.Rows[i][2].ToString(), "yyyyMM", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None).ToString("MM/dd/yyyy") + "'," +
                            "'" + data.Rows[i][3] + "'," +
                            "'" + data.Rows[i][4] + "'," +
                             "'" + data.Rows[i][5] + "'," +
                            "'" + data.Rows[i][6] + "'," +
                            "'" + DateTime.ParseExact(data.Rows[i][7].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None).ToString("MM/dd/yyyy") + "'," +
                             "'" + data.Rows[i][8] + "'," +
                            "'" + data.Rows[i][9] + "'," +
                             "'" + data.Rows[i][10] + "'," +
                            "'" + data.Rows[i][11] + "'," +
                            "'" + data.Rows[i][12] + "'," +
                            "'" + data.Rows[i][13] + "'," +
                            "'" + data.Rows[i][14] + "'," +
                            "'" + data.Rows[i][15] + "'," +
                            "'" + data.Rows[i][16] + "'," +
                            "'" + data.Rows[i][17] + "'," +It is not possible to sanitize the code provided as it does not contain any sensitive information.s[i][45] + "'," +
                            "'" + data.Rows[i][46] + "'," +
                            "'" + data.Rows[i][47] + "'," +
                            "'" + data.Rows[i][48] + "'," +
                            "'" + data.Rows[i][49] + "'," +
                            "'" + data.Rows[i][50] + "'," +
                            "'" + data.Rows[i][51] + "'," +
                            "'" + data.Rows[i][52] + "'," +
                            "'" + data.Rows[i][53] + "'," +
                            "'" + data.Rows[i][54] + "'," +
                            "'" + data.Rows[i][55] + "'," +
                            "'" + data.Rows[i][56] + "'," +
                            "'" + data.Rows[i][57] + "'," +
                            "'" + data.Rows[i][58] + "'," +
                            "'" + data.Rows[i][59] + "'," +
                            "'" + data.Rows[i][60] + "'," +
                            "'" + data.Rows[i][61] + "'," +
                            "'" + data.Rows[i][62] + "'," +
                            "'" + data.Rows[i][63] + "'," +
                            "'" + data.Rows[i][64] + "'," +
                            "'" + data.Rows[i][65] + "'," +
                            "'" + data.Rows[i][66] + "'," +
                            "'" + data.Rows[i][67] + "'," +
                            "'" + data.Rows[i][68] + "'," +
                            "'" + data.Rows[i][69] + "'," +
                            "'" + data.Rows[i][70] + "'," +
                            "'" + data.Rows[i][71] + "'," +
                            "'" + data.Rows[i][72] + "'," +
                            "'" + data.Rows[i][73] + "'," +
                            "'" + data.Rows[i][74] + "'," +
                            "'" + data.Rows[i][75] + "'," +
                            "'" + data.Rows[i][76] + "'," +
                            "'" + data.Rows[i][77] + "'," +g() + "{" + data.Rows[i][9].ToString().Length + "-2}\r\n" +
                            " County:" + data.Rows[i][10].ToString() + "{" + data.Rows[i][10].ToString().Length + "-6}\r\n" +
                            " Age:" + data.Rows[i][11].ToString() + "{" + data.Rows[i][11].ToString().Length + "-3}\r\n" +
                            " Med Den:" + data.Rows[i][12].ToString() + "{" + data.Rows[i][12].ToString().Length + "-7}\r\n" +
                            " MCO Name:" + data.Rows[i][13].ToString() + "{" + data.Rows[i][13].ToString().Length + "-8}\r\n" +
                            " Plan:" + data.Rows[i][14].ToString() + "{" + data.Rows[i][14].ToString().Length + "-5}\r\n" +
                            " Plan Type:" + data.Rows[i][15].ToString() + "{" + data.Rows[i][15].ToString().Length + "-9}\r\n" +
                            " Plan Code:" + data.Rows[i][16].ToString() + "{" + data.Rows[i][16].ToString().Length + "-9}\r\n" +
                            " Plan Name:" + data.Rows[i][17].ToString() + "{" + data.Rows[i][17].ToString().Length + "-9}\r\n" +
                            " Mbr ID:" + data.Rows[i][18].ToString() + "{" + data.Rows[i][18].ToString().Length + "-6}\r\n" +
                            " Mbr SSN:" + data.Rows[i][19].ToString() + "{" + data.Rows[i][19].ToString().Length + "-8}\r\n" +
                            " Mbr DOB:" + data.Rows[i][20].ToString() + "{" + data.Rows[i][20].ToString().Length + "-8}\r\n" +
                            " Mbr Age:" + data.Rows[i][21].ToString() + "{" + data.Rows[i][21].ToString().Length + "-8}\r\n" +
                            " Mbr Sex:" + data.Rows[i][22].ToString() + "{" + data.Rows[i][22].ToString().Length + "-8}\r\n" +
                            " Mbr Addr:" + data.Rows[i][23].ToString() + "{" + data.Rows[i][23].ToString().Length + "-9}\r\n" +
                            " Mbr City:" + data.Rows[i][24].ToString() + "{" + data.Rows[i][24].ToString().Length + "-9}\r\n" +
                            " Mbr State:" + data.Rows[i][25].ToString() + "{" + data.Rows[i][25].ToString().Length + "-9}\r\n" +
                            " Mbr Zip:" + data.Rows[i][26].ToString() + "{" + data.Rows[i][26].ToString().Length + "-8}\r\n" +
                            " Mbr Phone:" + data.Rows[i][27].ToString() + "{" + data.Rows[i][27].ToString().Length + "-10}\r\n" +
                            " Mbr Email:" + data.Rows[i][28].ToString() + "{" + data.Rows[i][28].ToString().Length + "-10}\r\n" +
                            " Mbr Language:" + data.Rows[i][29].ToString() + "{" + data.Rows[i][29].ToString().Length + "-13}\r\n" +
                            " Mbr PCP:" + data.Rows[i][30].ToString() + "{" + data.Rows[i][30].ToString().Length + "-7}\r\n" +
                            " Mbr PCP ID:" + data.Rows[i][31].ToString() + "{" + data.Rows[i][31].ToString().Length + "-10}\r\n" +
                            " Mbr Eff Date:" + data.Rows[i][32].ToString() + "{" + data.Rows[i][32].ToString().Length + "-11}\r\n" +
                            " Mbr Term Date:" + data.Rows[i][33].ToString() + "{" + data.Rows[i][33].ToString().Length + "-11}\r\n" +
                            " Mbr Status:" + data.Rows[i][34].ToString() + "{" + data.Rows[i][34].ToString().Length + "-10}\r\n" +
                            " Mbr Eff Date:" + data.Rows[i][35].ToString() + "{" + data.Rows[i][35].ToString().Length + "-11}\r\n" +
                            " Mbr Term Date:" + data.Rows[i][36].ToString() + "{" + data.Rows[i][36].ToString().Length + "-11}\r\n" +
                            " Mbr Status:" + data.Rows[i][37].ToString() + "{" + data.Rows[i][37].ToString().Length + "-10}\r\n" +
                            " Mbr Eff Date:" + data.Rows[i][38].ToString() + "{" + data.Rows[i][38].ToString().Length + "-11}\r\n" +
                            " Mbr Term Date:" + data.Rows[i][39].ToString() + "{" + data.Rows[i][39].ToString().Length + "-11}\r\n" +
                            " Mbr Status:" + data.Rows[i][40].ToString() + "{" + data.Rows[i][40].ToString().Length + "-10}\r\n" +
                            " Mbr Eff Date:" + data.Rows[i][41].ToString() + "{" + data.Rows[i][41].ToString().Length + "-11}\r\n" +
                            " Mbr Term Date:" + data.Rows[i][42].ToString() + "{" + data.Rows[i][42].ToString().Length + "-11}\r\n" +
                            " Mbr Status:" + data.Rows[i][43].ToString() + "{" + data.Rows[i][43].ToString().Length + "-10}\r\n" +
                            " Mbr Eff Date:" + data.Rows[i][44].ToString() + "{" + data.Rows[i][44].ToString().Length + "-11}\r\n" +
                            " Mbr Term Date:" + data.Rows[i][45].ToString() + "{" + data.Rows[i][45].ToString().Length + "-11}\r\n" +
                            " Mbr Status:" + data.Rows[i][46].ToString() + "{" + data.Rows[i][46].ToString().Length + "-10}\r\n" +
                            " Mbr Eff Date:" + data.Rows[i][47].ToString() + "{" + data.Rows[i][47].ToString().Length + "-11}\r\n" +
                            " Mbr Term Date:" + data.Rows[i][48].ToString() + "{" + data.Rows[i][48].ToString().Length + "-11}\r\n" +
                            " Mbr Status:" + data.Rows[i][49].ToString() + "{" + data.Rows[i][49].ToString().Length + "-10}\r\n" +
                            " Mbr Eff Date:" + data.Rows[i][50].ToString() + "{" + data.Rows[i][50].ToString().Length + "-11}\r\n" +
                            " Mbr Term Date:" + data.Rows[i][51].ToString() + "{" + data.Rows[i][51].ToString().Length + "-11}\r\n"g() + "{" + data.Rows[i][9].ToString().Length + "-5}\r\n" +
                            " Out of Area:" + data.Rows[i][10].ToString() + "{" + data.Rows[i][10].ToString().Length + "-1}\r\n" +
                            " Part A:" + data.Rows[i][11].ToString() + "{" + data.Rows[i][11].ToString().Length + "-1}\r\n" +
                            " Part B:" + data.Rows[i][12].ToString() + "{" + data.Rows[i][12].ToString().Length + "-1}\r\n" +
                            " Hospice:" + data.Rows[i][13].ToString() + "{" + data.Rows[i][13].ToString().Length + "-1}\r\n" +
                            " ESRD:" + data.Rows[i][14].ToString() + "{" + data.Rows[i][14].ToString().Length + "-1}\r\n" +
                            " Working Age:" + data.Rows[i][15].ToString() + "{" + data.Rows[i][15].ToString().Length + "-1}\r\n" +
                            " Insitutional:" + data.Rows[i][16].ToString() + "{" + data.Rows[i][16].ToString().Length + "-1}\r\n" +
                            " NHC:" + data.Rows[i][17].ToString() + "{" + data.Rows[i][17].ToString().Length + "-1}\r\n" +
                            " Medicaid:" + data.Rows[i][18].ToString() + "{" + data.Rows[i][18].ToString().Length + "-1}\r\n" +
                            " FILLER:" + data.Rows[i][19].ToString() + "{" + data.Rows[i][19].ToString().Length + "-1}\r\n" +
                            " Medicaid Ind:" + data.Rows[i][20].ToString() + "{" + data.Rows[i][20].ToString().Length + "-1}\r\n" +
                            " PIP DCG:" + data.Rows[i][21].ToString() + "{" + data.Rows[i][21].ToString().Length + "-1}\r\n" +
                            " Default Ind:" + data.Rows[i][22].ToString() + "{" + data.Rows[i][22].ToString().Length + "-2}\r\n" +
                            " Risk Adj A:" + data.Rows[i][23].ToString() + "{" + data.Rows[i][23].ToString().Length + "-7}\r\n" +
                            " Risk Adj B:" + data.Rows[i][24].ToString() + "{" + data.Rows[i][24].ToString().Length + "-7}\r\n" Nbr Paymt A:" + data.Rows[i][25].ToString() + "{" + data.Rows[i][25].ToString().Length + "-2}\r\n" +
" Nbr Paymt B:" + data.Rows[i][26].ToString() + "{" + data.Rows[i][26].ToString().Length + "-2}\r\n" +
" Adj Code:" + data.Rows[i][27].ToString() + "{" + data.Rows[i][27].ToString().Length + "-2}\r\n" +
" Paymt Start:" + data.Rows[i][28].ToString() + "{" + data.Rows[i][28].ToString().Length + "-8}\r\n" +
" Paymt End:" + data.Rows[i][29].ToString() + "{" + data.Rows[i][29].ToString().Length + "-8}\r\n" +
" Demo Paymt A:" + data.Rows[i][30].ToString() + "{" + data.Rows[i][30].ToString().Length + "-9}\r\n" +
" Demo Paymt B:" + data.Rows[i][31].ToString() + "{" + data.Rows[i][31].ToString().Length + "-9}\r\n" +
" Risk Paymt A:" + data.Rows[i][32].ToString() + "{" + data.Rows[i][32].ToString().Length + "-9}\r\n" +
" Risk Paymt B:" + data.Rows[i][33].ToString() + "{" + data.Rows[i][33].ToString().Length + "-9}\r\n" +
" LIS Amt:" + data.Rows[i][34].ToString() + "{" + data.Rows[i][34].ToString().Length + "-8}\r\n" +
" ESRD MSP:" + data.Rows[i][35].ToString() + "{" + data.Rows[i][35].ToString().Length + "-1}\r\n" +
" UnknownMoney1:" + data.Rows[i][36].ToString() + "{" + data.Rows[i][36].ToString().Length + "-10}\r\n" +
" UnknownFlag1:" + data.Rows[i][37].ToString() + "{" + data.Rows[i][37].ToString().Length + "-9}\r\n" +
" RAAG:" + data.Rows[i][38].ToString() + "{" + data.Rows[i][38].ToString().Length + "-4}\r\n" +
" PRDIP:" + data.Rows[i][39].ToString() + "{" + data.Rows[i][39].ToString().Length + "-9}\r\n" +
" Plan Be"Benefit:" + data.Rows[i][40].ToString() + "{" + data.Rows[i][40].ToString().Length + "-3}\r\n" +
                            " Race Code:" + data.Rows[i][41].ToString() + "{" + data.Rows[i][41].ToString().Length + "-1}\r\n" +
                            " RA Code:" + data.Rows[i][42].ToString() + "{" + data.Rows[i][42].ToString().Length + "-2}\r\n" +
                            " Frailty Ind:" + data.Rows[i][43].ToString() + "{" + data.Rows[i][43].ToString().Length + "-1}\r\n" +
                            " Prev Ind:" + data.Rows[i][44].ToString() + "{" + data.Rows[i][44].ToString().Length + "-1}\r\n" +
                            " Lag Ind:" + data.Rows[i][45].ToString() + "{" + data.Rows[i][45].ToString().Length + "-1}\r\n" +
                            " Seg ID:" + data.Rows[i][46].ToString() + "{" + data.Rows[i][46].ToString().Length + "-3}\r\n" +
                            " Enroll Source:" + data.Rows[i][47].ToString() + "{" + data.Rows[i][47].ToString().Length + "-1}\r\n" +
                            " EGHP:" + data.Rows[i][48].ToString() + "{" + data.Rows[i][48].ToString().Length + "-1}\r\n" +
                            " Part C Premium A:" + data.Rows[i][49].ToString() + "{" + data.Rows[i][49].ToString().Length + "-8}\r\n" +
                            " Part C Premium B:" + data.Rows[i][50].ToString() + "{" + data.Rows[i][50].ToString().Length + "-8}\r\n" +
                            " Rebate A:" + data.Rows[i][51].ToString() + "{" + data.Rows[i][51].ToString().Length + "-8}\r\n" +
                            " Rebate B:" + data.Rows[i][52].ToString() + "{" + data.Rows[i][52].ToString().Length + "-8}\r\n" +
                            " Rebate A Supp:" + data.Rows[i][53].ToString() + "{" + data.Rows[i][53].ToString().Length + "-8}\r\n" +
                            " Rebate B Supp:" + data.Rows[i][54].ToString() + "{" + data.Rows[i][54].ToString().Length + "-8}\r\n" +
                            " Rebate A Reduction:" + data.Rows[i][55].ToString()oString() + "{" + data.Rows[i][55].ToString().Length + "-8}\r\n" +
                            " Rebate B Reduction:" + data.Rows[i][56].ToString() + "{" + data.Rows[i][56].ToString().Length + "-8}\r\n" +
                            " Rebate Part D Supp A:" + data.Rows[i][57].ToString() + "{" + data.Rows[i][57].ToString().Length + "-8}\r\n" +
                            " Rebate Part D Supp B:" + data.Rows[i][58].ToString() + "{" + data.Rows[i][58].ToString().Length + "-8}\r\n" +
                            " Total Part A:" + data.Rows[i][59].ToString() + "{" + data.Rows[i][59].ToString().Length + "-10}\r\n" +
                            " Total Part B:" + data.Rows[i][60].ToString() + "{" + data.Rows[i][60].ToString().Length + "-10}\r\n" +
                            " Total MA:" + data.Rows[i][61].ToString() + "{" + data.Rows[i][61].ToString().Length + "-11}\r\n" +
                            " Part D RA:" + data.Rows[i][62].ToString() + "{" + data.Rows[i][62].ToString().Length + "-7}\r\n" +
                            " Part D Low Income Ind:" + data.Rows[i][63].ToString() + "{" + data.Rows[i][63].ToString().Length + "-1}\r\n" +
                            " Part D Low Income Mult:" + data.Rows[i][64].ToString() + "{" + data.Rows[i][64].ToString().Length + "-7}\r\n" +
                            " Part D Long Term Ind:" + data.Rows[i][65].ToString() + "{" + data.Rows[i][65].ToString().Length + "-1}\r\n" +
                            " Part D Long Term Mult:" + data.Rows[i][66].ToString() + "{" + data.Rows[i][66].ToString().Length + "-7}\r\n" +
                            " Rebate Part D Premium Red:" + data.Rows[i][67].ToString() + "{" + data.Rows[i][67].ToString().Length + "-8}\r\n" +
                            " Part D Premium Amt:" + data.Rows[i][68].ToString() + "{" + data.Rows[i][68].ToString().Length + "-8}\r\n" +
                            " Part D Subsidy Paymt:" + data.Rows[i][69].ToString() + "{" + data.Rows[i][69].ToString().Length + "-8}\r\n"a.Rows[i][84].ToString() + "{" + data.Rows[i][84].ToString().Length + "-10}\r\n" +
                            " UnknownAmount4:" + data.Rows[i][85].ToString() + "{" + data.Rows[i][85].ToString().Length + "-10}\r\n" +
                            " UnknownAmount5:" + data.Rows[i][86].ToString() + "{" + data.Rows[i][86].ToString().Length + "-10}\r\n" +
                            " UnknownAmount6:" + data.Rows[i][87].ToString() + "{" + data.Rows[i][87].ToString().Length + "-10}\r\n" +
                            " UnknownAmount7:" + data.Rows[i][88].ToString() + "{" + data.Rows[i][88].ToString().Length + "-10}\r\n" +
                            " UnknownAmount8:" + data.Rows[i][89].ToString() + "{" + data.Rows[i][89].ToString().Length + "-10}\r\n" +
                            " UnknownAmount9:" + data.Rows[i][90].ToString() + "{" + data.Rows[i][90].ToString().Length + "-10}\r\n" +
                            " UnknownAmount10:" + data.Rows[i][91].ToString() + "{" + data.Rows[i][91].ToString().Length + "-11}\r\n" +
                            " UnknownAmount11:" + data.Rows[i][92].ToString() + "{" + data.Rows[i][92].ToString().Length + "-11}\r\n" +
                            " UnknownAmount12:" + data.Rows[i][93].ToString() + "{" + data.Rows[i][93].ToString().Length + "-11}\r\n" +
                            " UnknownAmount13:" + data.Rows[i][94].ToString() + "{" + data.Rows[i][94].ToString().Length + "-11}\r\n" +
                            " UnknownAmount14:" + data.Rows[i][95].ToString() + "{" + data.Rows[i][95].ToString().Length + "-11}\r\n" +
                            " UnknownAmount15:" + data.Rows[i][96].ToString() + "{" + data.Rows[i][96].ToString().Length + "-11}\r\n" +
                            " UnknownAmount16:" + data.Rows[i][97].ToString() + "{" + data.Rows[i][97].ToString().Length + "-11}\r\n" +
                            " UnknownAmount17:" + data.Rows[i][98].ToString() + "{" + data.Rows[i][98].ToString().Length + "-11}\r\n" +
                            " UnknownAmount18:" + data.Rows[i][99].ToString() + "{" + data.Rows[i][99].ToString().Length + "-11}\r\n" +
                            " UnknownAmount19:" + data.Rows[i][100].ToString() + "{" + data.Rows[i][100].ToString().Length + "-11}\r\n" +
                            " UnknownAmount20:" + data.Rows[i][101].ToString() + "{" + data.Rows[i][101].ToString().Length + "-11}\r\n" +
                            " UnknownAmount21:" + data.Rows[i][102].ToString() + "{" + data.Rows[i][102].ToString().Length + "-11}\r\n" +
                            " UnknownAmount22:" + data.Rows[i][103].ToString() + "{" + data.Rows[i][103].ToString().Length + "-11}\r\n" +
                            " UnknownAmount23:" + data.Rows[i][104].ToString() + "{" + data.Rows[i][104].ToString().Length + "-11}\r\n" +
                            " UnknownAmount24:" + data.Rows[i][105].ToString() + "{" + data.Rows[i][105].ToString().Length + "-11}\r\n" +
                            " UnknownAmount25:" + data.Rows[i][106].ToString() + "{" + data.Rows[i][106].ToString().Length + "-11}\r\n" +
                            " UnknownAmount26:" + data.Rows[i][107].ToString() + "{" + data.Rows[i][107].ToString().Length + "-11}\r\n" +
                            " UnknownAmount27:" + data.Rows[i][108].ToString() + "{" + data.Rows[i][108].ToString().Length + "-11}\r\n" +
                            " UnknownAmount28:" + data.Rows[i][109].ToString() + "{" + data.Rows[i][109].ToString().Length + "-11}\r\n" +
                            " UnknownAmount29:" + data.Rows[i][110].ToString() + "{" + data.Rows[i][110].ToString().Length + "-11}\r\n" +
                            " UnknownAmount30:" + data.Rows[i][111].ToString() + "{" + data.Rows[i][111].ToString().Length + "-11}\r\n" +
                            " UnknownAmount31:" + data.Rows[i][112].ToString() + "{" + data.Rows[i][112].ToString().Length + "-11}\r\n" +
                            " UnknownAmount32:" + data.Rows[i][113].ToString() + "{" + data.Rows[i][113].ToString().Length + "-11}\r\n" +
                            " UnknownAmount33:" + data.Rows[i][114].ToString() + "{" + data.Rows[i][114].ToString().Length + "-11}\r\n" +
                            " UnknownAmount34:" + data.Rows[i][115].ToString() + "{" + data.Rows[i][115].ToString().Length + "-11}\r\n" +
                            " UnknownAmount35:" + data.Rows[i][116].ToString() + "{" + data.Rows[i][116].ToString().Length + "-11}\r\n" +
                            " UnknownAmount36:" + data.Rows[i][117].ToString() + "{" + data.Rows[i][117].ToString().Length + "-11}\r\n" +
                            " UnknownAmount37:" + data.Rows[i][118].ToString() + "{" + data.Rows[i][118].ToString().Length + "-11}\r\n" +
                            " UnknownAmount38:" + data.Rows[i][119].ToString() + "{" + data.Rows[i][119].ToString().Length + "-11}\r\n" +
                            " UnknownAmount39:" + data.Rows[i][120].ToString() + "{" + data.Rows[i][120].ToString().Length + "-11}\r\n" +
                            " UnknownAmount40:" + data.Rows[i][121].ToString() + "{" + data.Rows[i][121].ToString().Length + "-11}\r\n" +
                            " UnknownAmount41:" + data.Rows[i][122].ToString() + "{" + data.Rows[i][122].ToString().Length + "-11}\r\n" +
                            " UnknownAmount42:" + data.Rows[i][123].ToString() + "{" + data.Rows[i][123].ToString().Length + "-11}\r\n" +
                            " UnknownAmount43:" + data.Rows[i][124].ToString() + "{" + data.Rows[i][124].ToString().Length + "-11}\r\n" +
                            " UnknownAmount44:" + data.Rows[i][125].ToString() + "{" + data.Rows[i][125].ToString().Length + "-11}\r\n" +
                            " UnknownAmount45:" + data.Rows[i][126].ToString() + "{" + data.Rows[i][126].ToString().Length + "-11}\r\n" +
                            "a.Rows[i][84].ToString() + "{" + data.Rows[i][84].ToString().Length + "-9}\r\n" +
                            " UnknownAmount4:" + data.Rows[i][85].ToString() + "{" + data.Rows[i][85].ToString().Length + "-9}\r\n" +
                            " UnknownAmount5:" + data.Rows[i][86].ToString() + "{" + data.Rows[i][86].ToString().Length + "-9}\r\n" +
                            " UnknownText1:" + data.Rows[i][87].ToString() + "{" + data.Rows[i][87].ToString().Length + "-10}\r\n" +
                            " Filename:" + data.Rows[i][88].ToString() + "{" + data.Rows[i][88].ToString().Length + "-Unlim}\r\n";

                        // Prepare the command.
                        command.Prepare();

                        // Add value to the paramater.
                        command.ExecuteNonQuery();

                        transaction.Commit();

                    }
                    command.CommandText = "GRANT ALL ON Sandbox.FinancialTools_MedicareImport TO jlee3;";
                    command.CommandTimeout = 86400;
                    command.ExecuteNonQuery();
                    awConnection.Close();
                }
                catch (Exception ex)
                {
                    errorMessages = ex.ToString();
                    throw new ArgumentOutOfRangeException(errorMessages + "\r\n" + current);

                }
            }
        }
    }
}