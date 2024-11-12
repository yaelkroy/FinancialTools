TEXT      NOT NULL,
                                        CellReference TEXT    NOT NULL);";
        private const string sqlOMIGTableInsert = @"INSERT INTO Sandbox.FinancialTools_OMIGIndex(CIN, FileName, SheetId, SheetName, CellReference) VALUES (@CIN, @FileName, @SheetId, @SheetName, @CellReference);";
        private const string sqlOMIGTableSelectAll = @"SELECT * FROM Sandbox.FinancialTools_OMIGIndex;";
        private const string sqlOMIGTableSelectCIN = @"SELECT * FROM Sandbox.FinancialTools_OMIGIndex WHERE CIN = @CIN;";
        private const string sqlOMIGTableSelectFileName = @"SELECT * FROM Sandbox.FinancialTools_OMIGIndex WHERE FileName = @FileName;";
        private const string sqlOMIGTableSelectSheetId = @"SELECT * FROM Sandbox.FinancialTools_OMIGIndex WHERE SheetId = @SheetId;";
        private const string sqlOMIGTableSelectSheetName = @"SELECT * FROM Sandbox.FinancialTools_OMIGIndex WHERE SheetName = @SheetName;";
        private const string sqlOMIGTableSelectCellReference = @"SELECT * FROM Sandbox.FinancialTools_OMIGIndex WHERE CellReference = @CellReference;";


        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        /********************************************************* Other Queries **********************************************************/
        /************************************************************************************************************************************/
        /************************************************************************************************************************************/

        private const string sqlOMIGTableDrop = @"DROP TABLE Sandbox.FinancialTools_OMIGIndex;";
        private const string sqlOMIGTableDeleteAll = @"DELETE FROM Sandbox.FinancialTools_OMIGIndex;";
        private const string sqlOMIGTableDeleteCIN = @"DELETE FROM Sandbox.FinancialTools_OMIGIndex WHERE CIN = @CIN;";
        private const string sqlOMIGTableDeleteFileName = @"DELETE FROM Sandbox.FinancialTools_OMIGIndex WHERE FileName = @FileName;";
        private const string sqlOMIGTableDeleteSheetId = @"DELETE FROM Sandbox.FinancialTools_OMIGIndex WHERE SheetId = @SheetId;";
        private const string sqlOMIGTableDeleteSheetName = @"DELETE FROM Sandbox.FinancialTools_OMIGIndex WHERE SheetName = @SheetName;";
        private const string sqlOMIGTableDeleteCellReference = @"DELETE FROM Sandbox.FinancialTools_OMIGIndex WHERE CellReference = @CellReference;";

    }
}TEXT NOT NULL,
                                        CellReference TEXT NOT NULL);";
        public const string sqlOMIGAddExcelCell = @"INSERT INTO 
                                                        FinancialTools_OMIGIndex (CIN, FileName, SheetId, SheetName, CellReference) 
                                                        values ( ? , ? , ? , ?, ? ); ";
 
    }
}