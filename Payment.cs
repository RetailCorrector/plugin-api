namespace RetailCorrector
{
    /// <summary>
    /// Информация об оплате чека
    /// </summary>
    public struct Payment
    {
        /// <summary>
        /// Наличная оплата
        /// </summary>
        public uint Cash { get; set; }
        /// <summary>
        /// Безналичная оплата
        /// </summary>
        public uint ECash { get; set; }
        /// <summary>
        /// Предоплата (аванс)
        /// </summary>
        public uint Pre { get; set; }
        /// <summary>
        /// Постаоплата (в кредит)
        /// </summary>
        public uint Post { get; set; }
        /// <summary>
        /// Встречное предоставление
        /// </summary>
        public uint Provision { get; set; }

        public static explicit operator uint[](Payment payment) =>
        [
            payment.Cash,
            payment.ECash,
            payment.Pre,
            payment.Post,
            payment.Provision
        ];
    }
}