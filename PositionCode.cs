using RetailCorrector.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    public class PositionCode
    {
        public int Id { get; set; }
        public PositionCodeType Type { get; set; }
        public string Value { get; set; }

        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
