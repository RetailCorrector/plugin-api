namespace RetailCorrector
{
    public class Receipt
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public Operation Operation { get; set; }
        public string Sign { get; set; }
        public CorrType CorrectionType { get; set; }
        public string? ActNumber { get; set; }
        public uint TotalSum { get; set; }

        public List<Position> Items { get; set; } = [];
        public List<Payment> Payment { get; set; } = [];
        public List<IndustryData> IndustryData { get; set; } = [];
    }
}
