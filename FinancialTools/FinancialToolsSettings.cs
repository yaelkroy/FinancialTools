string SplitPDFDestinationDirectory { get { return _SplitPDFDestinationDirectory; } set { _SplitPDFDestinationDirectory = value; } }
        public static string BulkPDFSearchSourceDirectory { get { return _BulkPDFSearchSourceDirectory; } set { _BulkPDFSearchSourceDirectory = value; } }
        public static string AddMedicareFilesSourceDirectory { get { return _AddMedicareFilesSourceDirectory; } set { _AddMedicareFilesSourceDirectory = value; } }
        public static string BulkPDFSearchDestinationDirectory { get { return _BulkPDFSearchDestinationDirectory; } set { _BulkPDFSearchDestinationDirectory = value; } }
        public static string TempDirectory { get { return _TempDirectory; } set { _TempDirectory = value; } }
        public static string DisenrollmentPackagesDisFormSourceDirectory { get { return _DisenrollmentPackagesDisFormSourceDirectory; } set { _DisenrollmentPackagesDisFormSourceDirectory = value; } }
        public static string DisenrollmentPackagesDisLetSourceDirectory { get { return _DisenrollmentPackagesDisLetSourceDirectory; } set { _DisenrollmentPackagesDisLetSourceDirectory = value; } }
        public static string DisenrollmentPackagesInvoiceSourceDirectory { get { return _DisenrollmentPackagesInvoiceSourceDirectory; } set { _DisenrollmentPackagesInvoiceSourceDirectory = value; } }
        public static string DisenrollmentPackagesNotASourceDirectory { get { return _DisenrollmentPackagesNotASourceDirectory; } set { _DisenrollmentPackagesNotASourceDirectory = value; } }
        public static string DisenrollmentPackagesNotBSourceDirectory { get { return _DisenrollmentPackagesNotBSourceDirectory; } set { _DisenrollmentPackagesNotBSourceDirectory = value; } }
        public static string DisenrollmentPackagesNotCSourceDirectory { get { return _DisenrollmentPackagesNotCSourceDirectory; } set { _DisenrollmentPackagesNotCSourceDirectory = value; } }
        public static string DisenrollmentPackagesDestinationDirectory { get { return _DisenrollmentPackagesDestinationDirectory; } set { _DisenrollmentPackagesDestinationDirectory = value; } }
    }
}string SplitPDFDestinationDirectory
{
    get
    {
        return _SplitPDFDestinationDirectory;
    }
    set
    {
        _SplitPDFDestinationDirectory = value;
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\FinancialTools", true);
        key.SetValue("SplitPDFDestinationDirectory", value);
        key.Close();
    }
}

public static string BulkPDFSearchSourceDirectory
{
    get
    {
        return _BulkPDFSearchSourceDirectory;
    }
    set
    {

            _BulkPDFSearchSourceDirectory = value;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\FinancialTools", true);
            key.SetValue("BulkPDFSearchSourceDirectory", value);
            key.Close();


    }
}
public static string BulkPDFSearchDestinationDirectory
{
    get
    {
        return _BulkPDFSearchDestinationDirectory;
    }
    set
    {
        _BulkPDFSearchDestinationDirectory = value;
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\FinancialTools", true);
        key.SetValue("BulkPDFSearchDestinationDirectory", value);
        key.Close();
    }
}

public static string AddMedicareFilesSourceDirectory
{
    get
    {
        return _AddMedicareFilesSourceDirectory;
    }
    set
    {

        _AddMedicareFilesSourceDirectory = value;
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\FinancialTools", true);
        key.SetValue("AddMedicareFilesSourceDirectory", value);
        key.Close();


    }
}            _DisenrollmentPackagesInvoiceSourceDirectory = value;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\FinancialTools", true);
            key.SetValue("DisenrollmentPackagesInvoiceSourceDirectory", value);
            key.Close();
        } = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\FinancialTools", true);
                key.SetValue("DisenrollmentPackagesDestinationDirectory", value);
                key.Close();
            }
        }
    }
}= Registry.CurrentUser.OpenSubKey(@"SOFTWARE\FinancialTools", true);
                key.SetValue("DisenrollmentPackagesDestinationDirectory", value);
                key.Close();
            }
        }

    }
}