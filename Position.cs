using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    public class Position
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public PaymentMethod PayType { get; set; }
        public PositionType PosType { get; set; }
        public TaxRate TaxRate { get; set; }
        public MeasureUnit? MeasureUnit { get; set; }
        public uint Price { get; set; }
        public uint Quantity { get; set; }
        public uint TotalSum { get; set; }

        public List<IndustryData> IndustryData { get; set; } = [];
        public List<PositionCode> Codes { get; set; } = [];

        [ForeignKey(nameof(Receipt))]
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
    }
}
