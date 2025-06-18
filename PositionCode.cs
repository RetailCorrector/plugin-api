using RetailCorrector.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    [Table("code")]
    public class PositionCode
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        public PositionCodeType Type { get; set; }
        [Column("value")]
        public string Value { get; set; } = "";

        [ForeignKey(nameof(Position))]
        [Column("position")]
        public int PositionId { get; set; }
        public Position Position { get; set; } = null!;
    }
}
