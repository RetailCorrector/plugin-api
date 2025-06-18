using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    public class IndustryData
    {
        public int Id { get; set; }

        public int GosId { get; set; }
        public DateOnly DocDate { get; set; }
        public int DocNumb { get; set; }
        public string DocValue { get; set; } = "";

        [ForeignKey(nameof(Position))]
        public int? PositionId { get; set; }
        public Position? Position { set; get; }

        [ForeignKey(nameof(Receipt))]
        public int? ReceiptId { get; set; }
        public Receipt? Receipt { set; get; }
    }
}
