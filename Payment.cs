using RetailCorrector.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    /// <summary>
    /// Информация об оплате чека
    /// </summary>
    [Table("payment")]
    public class Payment
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        public PaymentType Type { get; set; }
        [Column("value")]
        public uint Value { get; set; }

        [ForeignKey(nameof(Receipt))]
        [Column("receipt")]
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; } = null!;
    }
}