namespace RetailCorrector
{
    public class Receipt
    {
        public int Id { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public Operation Operation { get; set; } = Operation.Income;
        public string FiscalSign { get; set; } = "";
        public CorrType CorrectionType { get; set; } = CorrType.ByYourself;
        public string? ActNumber { get; set; }
        public uint TotalSum { get; set; } = 0;

        public List<Position> Items { get; set; } = [];
        public List<Payment> Payment { get; set; } = [];
        public List<IndustryData> IndustryData { get; set; } = [];
    }
}
