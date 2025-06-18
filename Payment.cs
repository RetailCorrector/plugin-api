using RetailCorrector.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCorrector
{
    /// <summary>
    /// Информация об оплате чека
    /// </summary>
    public class Payment
    {
        public int Id { get; set; }
        public PaymentType Type { get; set; }
        public uint Value { get; set; }

        [ForeignKey(nameof(Receipt))]
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
    }
}