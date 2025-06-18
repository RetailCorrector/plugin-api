using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    [Table("position")]
    public class Position
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("payment")]
        public PaymentMethod PayType { get; set; } = PaymentMethod.FullPayment; 
        [Column("type")]
        public PositionType PosType { get; set; } = PositionType.Product;
        [Column("tax")]
        public TaxRate TaxRate { get; set; } = TaxRate.Tax10;
        [Column("unit")]
        public MeasureUnit? MeasureUnit { get; set; } = RetailCorrector.MeasureUnit.Default;
        [Column("price")]
        public uint Price { get; set; }
        [Column("quantity")]
        public uint Quantity { get; set; } = 1000;
        [Column("sum")]
        public uint TotalSum { get; set; }

        public List<IndustryData> IndustryData { get; set; } = [];
        public List<PositionCode> Codes { get; set; } = [];

        [ForeignKey(nameof(Receipt))]
        [Column("receipt")]
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; } = null!;
    }
}
