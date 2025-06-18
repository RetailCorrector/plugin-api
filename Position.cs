using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    public class Position
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public PaymentMethod PayType { get; set; } = PaymentMethod.FullPayment;
        public PositionType PosType { get; set; } = PositionType.Product;
        public TaxRate TaxRate { get; set; } = TaxRate.Tax10;
        public MeasureUnit? MeasureUnit { get; set; } = RetailCorrector.MeasureUnit.Default;
        public uint Price { get; set; }
        public uint Quantity { get; set; } = 1000;
        public uint TotalSum { get; set; }

        public List<IndustryData> IndustryData { get; set; } = [];
        public List<PositionCode> Codes { get; set; } = [];

        [ForeignKey(nameof(Receipt))]
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; } = null!;
    }
}
