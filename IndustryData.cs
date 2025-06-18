using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    [Table("industry")]
    public class IndustryData
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("gos")]
        public int GosId { get; set; }
        [Column("date")]
        public DateOnly DocDate { get; set; }
        [Column("number")]
        public int DocNumb { get; set; }
        [Column("value")]
        public string DocValue { get; set; } = "";

        [ForeignKey(nameof(Position))]
        [Column("position")]
        public int? PositionId { get; set; }
        public Position? Position { set; get; }

        [ForeignKey(nameof(Receipt))]
        [Column("receipt")]
        public int? ReceiptId { get; set; }
        public Receipt? Receipt { set; get; }
    }
}
