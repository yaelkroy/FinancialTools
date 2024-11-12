,
            String PldsDescription,
            String PdpdID,
            Boolean Committed)
        {
            _Amount = Amount;
            _EffectiveDate = EffectiveDate;
            _TerminationDate = TerminationDate;
            _SbsbCK = SbsbCK;
            _MemeCK = MemeCK;
            _BleiCK = BleiCK;
            _ID = ID;
            _Description = Description;
            _CspiID = CspiID;
            _PldsDescription = PldsDescription;
            _PdpdID = PdpdID;
            _Committed = Committed;
        }

        public override string ToString()
        {
            return "Transaction ID: " + _ID + ", Amount: " + _Amount + ", Description: " + _Description;
        }
    }
}public class DataModel
{
    public decimal Amount { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime TerminationDate { get; set; }
    public int SbsbCK { get; set; }
    public int MemeCK { get; set; }
    public int BleiCK { get; set; }
    public int ID { get; set; }
    public string Description { get; set; }
    public string CspiID { get; set; }
    public string PldsDescription { get; set; }
    public string PdpdID { get; set; }
    public bool Committed { get; set; }

    public DataModel(decimal Amount, DateTime EffectiveDate, DateTime TerminationDate, int SbsbCK, int MemeCK, int BleiCK, int ID, string Description, string CspiID, string PldsDescription, string PdpdID, bool Committed = default)
    {
        this.Amount = Amount;
        this.EffectiveDate = EffectiveDate;
        this.TerminationDate = TerminationDate;
        this.SbsbCK = SbsbCK;
        this.MemeCK = MemeCK;
        this.BleiCK = BleiCK;
        this.ID = ID;
        this.Description = Description;
        this.CspiID = CspiID;
        this.PldsDescription = PldsDescription;
        this.PdpdID = PdpdID;
        this.Committed = Committed;
    }
}