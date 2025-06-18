using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    [Table("receipt")]
    public class Receipt
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("date")]
        public DateTime Created { get; set; } = DateTime.Now;
        [Column("type")]
        public Operation Operation { get; set; } = Operation.Income;
        [Column("sign")]
        public string FiscalSign { get; set; } = "";
        [Column("corr")]
        public CorrType CorrectionType { get; set; } = CorrType.ByYourself;
        [Column("act")]
        public string? ActNumber { get; set; }
        [Column("total")]
        public uint TotalSum { get; set; } = 0;

        public List<Position> Items { get; set; } = [];
        public List<Payment> Payment { get; set; } = [];
        public List<IndustryData> IndustryData { get; set; } = [];
    }
}
