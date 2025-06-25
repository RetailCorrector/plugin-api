namespace RetailCorrector
{
    /// <summary>
    /// Информация об оплате чека
    /// </summary>
    public struct Payment()
    {
        /// <summary>
        /// Наличная оплата
        /// </summary>
        public uint Cash { get; set; } = 0;
        /// <summary>
        /// Безналичная оплата
        /// </summary>
        public uint ECash { get; set; } = 0;
        /// <summary>
        /// Предоплата (аванс)
        /// </summary>
        public uint Pre { get; set; } = 0;
        /// <summary>
        /// Постаоплата (в кредит)
        /// </summary>
        public uint Post { get; set; } = 0;
        /// <summary>
        /// Встречное предоставление
        /// </summary>
        public uint Provision { get; set; } = 0;

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