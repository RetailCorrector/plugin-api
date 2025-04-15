namespace RetailCorrector
{
    /// <summary>
    /// Информация о позиции
    /// </summary>
    public struct Position
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип оплаты
        /// </summary>
        public PaymentType PayType { get; set; }
        /// <summary>
        /// Тип позиции
        /// </summary>
        public PositionType PosType { get; set; }
        /// <summary>
        /// Налоговая ставка
        /// </summary>
        public TaxRate TaxRate { get; set; }
        /// <summary>
        /// Единица измерений
        /// </summary>
        public MeasureUnit MeasureUnit { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public uint Price { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public uint Quantity { get; set; }
        /// <summary>
        /// Итоговая сумма
        /// </summary>
        public uint TotalSum { get; set; }
    }
}