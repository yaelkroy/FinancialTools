ult = result.Distinct().ToList();
            int pdfCount = result.Count;
            for (int i = 0; i < pdfCount; i++)
            {
                string pdfPath = result[i];
                string fileName = Path.GetFileName(pdfPath);
                string outputFilePath = Path.Combine(outputDir, fileName);
                PDDocument document = PDDocument.load(pdfPath);
                PDFTextStripper stripper = new PDFTextStripper();
                string text = stripper.getText(document);
                if (text.Contains("Spenddown"))
                {
                    File.Copy(pdfPath, outputFilePath);
                }
                document.close();
                objProgress.ReportProgress(50 + Convert.ToInt32(i / pdfCount * 50));
            }
            objProgress.ReportProgress(100);
        }
    }
}ult = result.Distinct().ToList();
            ids = result.Count;
            for (int idx = 0; idx < ids; idx++)
            {
                Regex rgx = new Regex(@"[a-zA-Z]{2}\d{5}[a-zA-Z]{1}");
                MatchCollection match = rgx.Matches(result[idx].ToUpper());
                string CIN = match[0].Value;



                rgx = new Regex(@"\d{9}");
                match = rgx.Matches(result[idx].ToUpper());
                string ID = match[0].Value;
                string newDir = outputDir + @"\" + ID + "_" + CIN + @"\";
                
                LanguageUtils.IgnoreErrors(() => Directory.CreateDirectory(newDir));
                File.Copy(result[idx], Path.Combine(newDir, Path.GetFileName(result[idx])), true);
                objProgress.ReportProgress(50 + Convert.ToInt32(idx / ids * 50));

            }
            objProgress.ReportProgress(100);
        }
        public static void Split(string docType, System.ComponentModel.BackgroundWorker objProgress = null)
        {
            String tempDir = [TempDirectory];
            string inputDir = [SplitPDFSourceDirectory];
            string outputDir = [SplitPDFDestinationDirectory];
            string[] filePaths = Directory.GetFiles(inputDir, "*.pdf", SearchOption.AllDirectories);
            /*********************************************************************************/
            /* Staring process file by file from input folder                                */
            /*********************************************************************************/

            int ifiles = filePaths.Length;
            for (int fidx = 0; fidx < ifiles; fidx++)
            {
String filename = filePaths[fidx];

// Get a fresh copy of the sample PDF file
//const string filename = "input.pdf";
File.Copy(Path.Combine(filename), Path.Combine(tempDir, Path.GetFileName(filename)), true);

// Open the file
/*********************************************************************************/
/* Use PDFBox to load file to read it                                            */
/*********************************************************************************/
PDDocument inputDocument = PDDocument.load(Path.Combine(tempDir, Path.GetFileName(filename)));
var originalCatalog = inputDocument.getDocumentCatalog();
java.util.List sourceDocumentPages = originalCatalog.getAllPages();
//Console.WriteLine(filename);
//Instantiating Splitter class
/*********************************************************************************/
/* Initialize variables for subscriber data                                           */
/*********************************************************************************/
int byPagesNum = 0, rowDay = 0, wordDay = 0,
    rowMonth = 0, wordMonth = 0,
    rowYear = 0, wordYear = 0,
    rowFirstName = 0, wordFirstName = 0,
    rowLastName = 0, wordLastName = 0,
    rowId = 0, wordId = 0,
    rowMedicaidId = 0, wordMedicaidId = 0;
String procName = "", subOutDir = "", firstName = "", lastName = "", day = "", month = "", year = "", keywordId = "", id = "",
    keywordMedicaidId = "", flagMedicaidId = "", medicaidId = "", keywordFirstName = "", keywordLastName = "";

if (docType.Contains("NAMI Individu* The invoices downloaded from Fidelis Webfocus
* Reports -> Finance/MLTC invoices ->
* MLTC SPND Invoice -> Production History -> FIN077_AUTOMATIC_PRD********************/
                    /* The invoices downloaded from Fidelis Webfocus                                  */
                    /* http://webfocusclient-prd.fideliscare.org/ibi_apps/bip/portal/FidelisReporting */
                    /* Reports -> Finance/MLTC invoices ->                                            */
                    /* MLTC SPND Invoice -> Production History -> FIN077_AUTOMATIC_PRD                */
                    /**********************************************************************************/
                    byPagesNum = 1;
                    procName = "WebFocus";
                    rowDay = 9; wordDay = 3;
                    rowMonth = 9; wordMonth = 2;
                    rowYear = 9; wordYear = 4;
                    rowFirstName = 11; wordFirstName = 0;
                    rowLastName = 11; wordLastName = 1;
                    rowId = 3; wordId = 0;
                    rowMedicaidId = 7; wordMedicaidId = 1;
                    subOutDir = outputDir + "\\" + docType + "\\";


                }

                /**********************************************************************************/
                /* spenddown letters Category A into SPND_A folder                                */
                /**********************************************************************************/
                if (docType.Contains("Notification Letters - A Category", StringComparison.OrdinalIgnoreCase))
                {
                    byPagesNum = 4;
                    procName = "SPND_A";
                    rowDay = 6; wordDay = 1;
                    rowMonth = 6; wordMonth = 0;
                    rowYear = 6; wordYear = 2;
                    rowFirstName = 10; wordFirstName = 0;
                    rowLastName = 10; wordLastName = 1;
                    keywordId = "Member Id"; rowId = 72; wordId = 2;
                    rowMedicaidId = 0; wordMedicaidId = 0;subOutDir = outputDir + "\\" + docType + "\\";
                }
                /**********************************************************************************/
                /* spenddown letters Category B into SPND_B folder                                */
                /**********************************************************************************/
                if (docType.Contains("Notification Letters - B Category", StringComparison.OrdinalIgnoreCase))
                {
                    byPagesNum = 4;
                    procName = "SPND_A";
                    rowDay = 6; wordDay = 1;
                    rowMonth = 6; wordMonth = 0;
                    rowYear = 6; wordYear = 2;
                    rowFirstName = 10; wordFirstName = 0;
                    rowLastName = 10; wordLastName = 1;
                    keywordId = "Member Id"; rowId = 72; wordId = 2;
                    rowMedicaidId = 0; wordMedicaidId = 0;
                    subOutDir = outputDir + "\\" + docType + "\\";
                }
                /**********************************************************************************/
                /* spenddown letters Category C into SPND_C folder                                */
                /**********************************************************************************/
                if (docType.Contains("Notification Letters - C Category", StringComparison.OrdinalIgnoreCase))
                {
                    byPagesNum = 4;
                    procName = "SPND_A";
                    rowDay = 6; wordDay = 1;
                    rowMonth = 6; wordMonth = 0;
                    rowYear = 6; wordYear = 2;
                    rowFirstName = 10; wordFirstName = 0;
                    rowLastName = 10; wordLastName = 1;
                    keywordId = "Member Id"; rowId = 72; wordId = 2;
                    rowMedicaidId = 0; wordMedicaidId = 0;outputDir + "\\" + docType + "\\";outputDir + "\\" + docType + "\\";
                }
                /**********************************************************************************/
                /* old spenddown invoice from SAP                                                   */
                /**********************************************************************************/
                if (docType.Contains("Spenddown Invoices from SAP", StringComparison.OrdinalIgnoreCase))
                {
                    byPagesNum = 1;
                    procName = "SAPSPND";
                    rowDay = 12; wordDay = 1;
                    rowMonth = 12; wordMonth = 0;
                    rowYear = 12; wordYear = 2;
                    rowFirstName = 11; wordFirstName = 0;
                    rowLastName = 11; wordLastName = 1;
                    rowId = 10; wordId = 3;
                    rowMedicaidId = 6; wordMedicaidId = 0;
                    subOutDir = outputDir + "\\" + docType + "\\";
                }
                /**********************************************************************************/
                /* old NAMI invoice from SAP                                                   */
                /**********************************************************************************/
                if (filename.Contains("NAMI Individual Invoices from SAP", StringComparison.OrdinalIgnoreCase))
                {
                    byPagesNum = 1;
                    procName = "SAPNAMI";
                    rowDay = 12; wordDay = 1;
                    rowMonth = 12; wordMonth = 0;
                    rowYear = 12; wordYear = 2;
                    rowFirstName = 11; wordFirstName = 0;
                    rowLastName = 11; wordLastName = 1;
                    rowId = 10; wordId = 3;
                    rowMedicaidId = 6; wordMedicaidId = 0;
                    subOutDir = outputDir + "\\" + docType + "\\";
                })
                {
                    PDDocument doc = new PDDocument();
                    PDFTextStripperByArea stripperArea = new PDFTextStripperByArea();
                    stripperArea.setSortByPosition(true);
                    stripperArea.setWordSeparator("|");
                    stripperArea.setLineSeparator("|");
                    stripperArea.setPage(i / byPagesNum + 1);

                    stripperArea.extractRegions(inputDocument.getPage(i), doc);

                    strText = stripper.getText(doc);

                    doc.close();

                    String[] lines = strText.Split('|');

                    if (lines.Length > 0)
                    {
                        String[] firstLine = lines[0].Split();
                        String date = firstLine[wordMonth] + "/" + firstLine[wordDay] + "/" + firstLine[wordYear];

                        String[] patientLine = lines[rowFirstName].Split();
                        String firstName = patientLine[wordFirstName];
                        String lastName = patientLine[wordLastName];

                        String[] idLine = lines[rowId].Split();
                        String id = idLine[wordId];

                        String[] medicaidIdLine = lines[rowMedicaidId].Split();
                        String medicaidId = medicaidIdLine[wordMedicaidId];

                        String outputFilename = subOutDir + name + "_" + id + "_" + date + ".pdf";

                        PDDocument newDoc = new PDDocument();
                        PDPage page = new PDPage();
                        newDoc.addPage(page);

                        PDPageContentStream contentStream = new PDPageContentStream(newDoc, page);

                        contentStream.setFont(PDType1Font.HELVETICA_BOLD, 12);
                        contentStream.beginText();
                        contentStream.newLineAtOffset(100, 700);
                        contentStream.showText("Name: " + firstName + " " + lastName);
                        contentStream.newLineAtOffset(0, -20);
                        contentStream.showText("ID: " + id);
                        contentStream.newLineAtOffset(0, -20);
                        contentStream.showText("Medicaid ID: " + medicaidId);
                        contentStream.endText();

                        contentStream.close();

                        newDoc.save(outputFilename);
                        newDoc.close();
                    }
                }ng line in lines)
                            {
                                if (k == 0)
                                {
                                    //Console.WriteLine(line);
                                    subscriberData = line.Split(',');
                                    //Console.WriteLine(subscriberData[0]);
                                    k++;
                                }
                                else
                                {
                                    //Console.WriteLine(line);
                                    subscriberData = line.Split(',');
                                    //Console.WriteLine(subscriberData[0]);
                                    /***********************************************************************************/
                                    /* Inserting the subscriber data into the database                                */
                                    /***********************************************************************************/
                                    //InsertSubscriberData(subscriberData);
                                    k++;
                                }
                            }
                        }
                    }
                    newDocument.close();
                    i += byPagesNum;
                    fidx++;
                }                            {
                                /***********************************************************************************/
                                /* Replace all symbols to spaces except letters and numbers                        */
                                /***********************************************************************************/
                                String curLine = Regex.Replace(line, @"\p{P}", " ");


                                //Console.WriteLine(k.ToString(), ": ", line);
                                /***********************************************************************************/
                                /* Splitting row into the words                                                      */
                                /***********************************************************************************/
                                String[] words = curLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                if ((rowDay == k) && (wordDay >= 0)) day = words[wordDay];
                                if ((rowMonth == k) && (wordMonth >= 0)) month = words[wordMonth];
                                if ((rowYear == k) && (wordMonth >= 0)) year = words[wordYear];
                                if (keywordFirstName.Length > 0)
                                {
                                    if (curLine.Contains(keywordFirstName))
                                    {
                                        String nextLine = Regex.Replace(lines[k + rowFirstName], @"\p{P}", " ");
                                        String[] nextWords = nextLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                        firstName = nextWords[wordFirstName];

                                    }
                                }
                                else                                {
                                    if (rowFirstName == k) firstName = words[wordFirstName];
                                }

                                if (keywordLastName.Length > 0)
                                {

                                    if (curLine.Contains(keywordLastName))
                                    {
                                        String nextLine = Regex.Replace(lines[k + rowFirstName], @"\p{P}", " ");
                                        String[] nextWords = nextLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                        lastName = nextWords[wordLastName];
                                    }
                                }
                                else
                                {
                                    if (rowLastName == k) lastName = words[wordLastName];
                                }
                                /***********************************************************************************/
                                /* If there is a keyword to find we do, if not - use just index of word            */
                                /***********************************************************************************/
                                if (keywordId.Length > 0)
                                {
                                    if (curLine.Contains(keywordId)) id = words[wordId];
                                }
                                else
                                {
                                    if (rowId == k) id = words[wordId];
                                }
                                if (keywordMedicaidId.Length > 0)
                                {

                                    if (curLine.Contains(keywordMedicaidId))
                                    {
                                        /**d.Length == 0)
                                        {
                                            medicaidId = words[wordMedicaidId];
                                        }
                                        else
                                        {
                                            if (flagMedicaidId.Contains("combine"))
                                            {
                                                Int32 qLetters = System.Convert.ToInt32(flagMedicaidId.Replace("combine ", ""));
                                                medicaidId = "";
                                                int iCount = 0, inx = wordMedicaidId - 1;
                                                while (iCount < qLetters)
                                                {
                                                    if (words[inx] != "")
                                                    {
                                                        medicaidId += words[inx];

                                                    }
                                                    inx++;

                                                }

                                            }

                                        }
                                    }

                                }
                                else
                                {
                                    if (rowMedicaidId == k)
                                    {
                                        if (flagMedicaidId.Length == 0)
                                        {
                                            medicaidId = words[wordMedicaidId];
                                        }
                                        else
                                        {
                                            if (flagMedicaidId.Contains("combine"))
                                            {
                                                Int32 qLetters = System.Convert.ToInt32(flagMedicaidId.Replace("combine ", ""));
                                                medicaidId = "";
                                                int iCount = 0, inx = wordMedicaidId - 1;
                                                while (iCount < qLetters)
                                                {
                                                    if (words[inx] != "")
                                                    {
                                                        medicaidId += words[inx];

                                                    }
                                                    inx++;

                                                }

                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
/*********************************************************************************/d.Length == 0)
                                        {
                                            medicaidId = words[wordMedicaidId];
                                        }
                                        else
                                        {
                                            if (flagMedicaidId.Contains("combine"))
                                            {
                                                Int32 qLetters = System.Convert.ToInt32(flagMedicaidId.Replace("combine ", ""));
                                                medicaidId = "";
                                                int iCount = 0, inx = wordMedicaidId - 1;
                                                while (iCount < qLetters)
                                                {
                                                    if (words[inx] != "")
                                                    {
                                                        medicaidId += words[inx];
                                                        iCount++;

                                                    }
                                                    inx++;

                                                }

                                            }

                                        }
                                    }
                                }



                                k++;
                            }


                        }


                    }
                    //Console.WriteLine("{0} {1} {2} {3} {4} {5},{6}", firstName, lastName, id, medicaidId, month, day, year);
                    Boolean skip = false;
                    Boolean exists = false;
                    /***********************************************************************************/
                    /* If to exclude exclusions                                                       */                    if ((!skip) || exists)
                    {
                        Directory.CreateDirectory(subOutDir);
                        String partSubDirName = "", partFileName = "";
                        /***********************************************************************************/
                        /* Different rules for data conversion since in documents dates are in different formats */
                        /***********************************************************************************/
                        if ((procName == "SPND_A") || (procName == "SPND_B") || (procName == "SPND_C"))
                        {
                            partSubDirName = DateTime.Parse(year + "/" + month).ToString("yyyy-MM");
                            partFileName = id;
                        }
                        if (procName == "NAMIFocus")
                        {
                            partSubDirName = DateTime.Parse(month + "-" + day + "-" + year).ToString("yyyy-MM-dd");
                            partFileName = medicaidId + "_" + DateTime.Parse(month + "-" + day + "-" + year).ToString("MMddyyyy") + "_" + id;
                        }
                        if (procName == "WebFocus")
                        {
                            partSubDirName = DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("yyyy-MM");
                            partFileName = id + "_" + DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("MMyyyy") + "_" + medicaidId;
                        }
                    }if (procName == "SAPSPND")
                        {
                            partSubDirName = DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("yyyy-MM");
                            partFileName = id + "_" + DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("MMyyyy") + "_" + medicaidId;
                        }
                        if (procName == "SAPNAMI")
                        {
                            partSubDirName = DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("yyyy-MM");
                            partFileName = id + "_" + DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("MMyyyy") + "_" + medicaidId;
                        }
                        if (procName == "SAPNAMIF")
                        {
                            partSubDirName = DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("yyyy-MM");
                            partFileName = id + "_" + DateTime.ParseExact(year + " " + month, "yyyy MMMM", CultureInfo.InvariantCulture).ToString("MMyyyy") + "_" + medicaidId;
                        }
                        if (procName == "DisLet")
                        {
                            partSubDirName = DateTime.ParseExact(year + "/" + month, "yyyy/%M", CultureInfo.InvariantCulture).ToString("yyyy-MM");
                            partFileName = id + "_" + DateTime.ParseExact(year + "/" + month, "yyyy/%M", CultureInfo.InvariantCulture).ToString("MMyyyy") + "_" + medicaidId;

                        }
                        if (procName == "DisForm")
                            partSubDirName= DateTime.Now.ToString("yyyy-MM");
partFileName = medicaidId + "_" + DateTime.Now.ToString("MMyyyy");

}

String datedSubDir = subOutDir + partSubDirName + @"\";
Directory.CreateDirectory(datedSubDir);
/***********************************************************************************/
/* forming filename of the new file                                              */
/***********************************************************************************/
String newFilePath = datedSubDir + lastName + "_" + firstName + "_" + partFileName + ".pdf";
int ix = 1;
/***********************************************************************************/
/* If file exsists add the relevant letter                                         */
/***********************************************************************************/
if (File.Exists(newFilePath))
{
    while (File.Exists(newFilePath + "_" + ix.ToString()))
    {
        ix++;
    }

    //Console.WriteLine("{0} exists!", Path.GetFileName(newFilePath));

    newFilePath = newFilePath.Insert(newFilePath.LastIndexOf('.'), "_" + ix.ToString());
    //Console.WriteLine("{0} created!", Path.GetFileName(newFilePath));

}

newDocument.save(newFilePath);
}
else
{
    Console.WriteLine("{0} is not found", id);
}
newDocument.close();                //Console.WriteLine(newFilePath);
                //Console.WriteLine("{0} {1} {2} {3} {4} {5},{6}", firstName, lastName, id, medicaidId, month, day, year);

            }

            inputDocument.close();
        }
    }
    public static void MergeDisenrollmentPackages(System.ComponentModel.BackgroundWorker objProgress = null)
    {
        // To check the length of  
        // Command line arguments   
        //Console.WriteLine(DateTime.ParseExact("2020/01", "yyyy/%M", CultureInfo.InvariantCulture).ToString("yyyy-MM"));

        string[] filePaths = Directory.GetFiles(FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory, "*.pdf", SearchOption.AllDirectories);
        /***********************************************************************************/
        /* we will use disenrollment forms as the beginning files                           */
        /***********************************************************************************/
        int ifiles = filePaths.Length;
        for (int fidx = 0; fidx < ifiles; fidx++)
        {
            /***********************************************************************************/
            /* Extracting subscriber data from file names                                     */
            /***********************************************************************************/
            String filename = filePaths[fidx];
            String medicaidId = filename.Replace(FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory, "");
            String FirstName = filename.Replace(FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory, "");
            String LastName = filename.Replace(FinancialToolsSettings.DisenrollmentPackagesDisFormSourceDirectory, "");
            medicaidId = medicaidId.Substring(medicaidId.IndexOf("_") + 1, me                medicaidId = medicaidId.Substring(medicaidId.IndexOf("_") + 1, 8);
                LastName = LastName.Substring(0, LastName.IndexOf("_"));
                FirstName = FirstName.Replace(LastName + "_", "");
                FirstName = FirstName.Substring(0, FirstName.IndexOf("_"));
                // Get a fresh copy of the sample PDF file
                File.Copy(Path.Combine(filename), Path.Combine(FinancialToolsSettings.TempDirectory, Path.GetFileName(filename)), true);
                Console.WriteLine("disform: {0}", filename);
                // Open the file
                /***********************************************************************************/
                /* Use PDFbox Merger to merge                                                     */
                /***********************************************************************************/
                PDDocument doc = PDDocument.load(Path.Combine(FinancialToolsSettings.TempDirectory, Path.GetFileName(filename)));
                PDFMergerUtility pdfMerger = new PDFMergerUtility();
                /***********************************************************************************/
                /* Get files by combining sequence                                                */
                /***********************************************************************************/
                string[] DisLetFilePaths = Directory.GetFiles(FinancialToolsSettings.DisenrollmentPackagesDisLetSourceDirectory, "*" + medicaidId + ".pdf", SearchOption.AllDirectories);
                string[] WebFocusFilePaths = Directory.GetFiles(FinancialToolsSettings.TempDirectory, "*" + medicaidId + ".pdf", SearchOption.AllDirectories);
                String id = "";
                /***********************************************************************************/                /* Just in case there is no Dissenrollment letter                                  */
                /* we are trying to use invoice deom webfocus to get subscriber id                 */
                /***********************************************************************************/
                if (DisLetFilePaths.Length > 0)
                {
                    id = DisLetFilePaths[0].Replace(FinancialToolsSettings.DisenrollmentPackagesDisLetSourceDirectory, "");
                    id = id.Substring(id.IndexOf("_") + 1, id.Length - id.IndexOf("_") - 1);
                    id = id.Substring(id.IndexOf("_") + 1, id.Length - id.IndexOf("_") - 1);
                    id = id.Substring(0, id.IndexOf("_"));
                }
                else
                {
                    id = WebFocusFilePaths[0].Replace(FinancialToolsSettings.DisenrollmentPackagesDisLetSourceDirectory, "");
                    id = id.Substring(id.IndexOf("_") + 1, id.Length - id.IndexOf("_") - 1);
                    id = id.Substring(id.IndexOf("_") + 1, id.Length - id.IndexOf("_") - 1);
                    id = id.Substring(0, id.IndexOf("_"));
                }
                Console.WriteLine("{0} of {1}: {2} {3} {4} {5}", fidx + 1, ifiles, FirstName, LastName, id, medicaidId);
                /***********************************************************************************/
                /* Get spendown letters (NB: directories should be sorted    by date               */
                /***********************************************************************************/
                string[] SPNDAFilePaths = Directory.GetFiles(FinancialToolsSettings.DisenrollmentPackagesNotASourceDirectory, "*" + id + ".pdf", SearchOption.AllDirectories);
                string[] SPNDBFilePaths = Directory.GetFiles(FinancialToolsSettings.DisenrollmentPackagesNotBSourceDirectory, "*" + id + ".pdf", SearchOption.AllDirectories);
                           + id + ".pdf");
                pdfMerger.addSources(SPNDFilePaths);
                pdfMerger.mergeDocuments();pdfMerger.mergeDocuments(MemoryUsageSetting.setupMainMemoryOnly());
                pdfMerger.saveDocument(new FileStream(outputPath, FileMode.Create));
                pdfMerger.close();```java
pdfMerger.mergeDocuments();
doc.close();
```