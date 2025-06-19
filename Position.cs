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
        /// <summary>
        /// Отраслевой реквизит позиции
        /// </summary>
        public IndustryData[] IndustryData { get; set; }
        /// <summary>
        /// Коды товара
        /// </summary>
        public PositionCode Codes { get; set; }
        
        /// <summary>
        /// Клонирование позиции
        /// </summary>
        public Position Clone() => new()
        {
            Name = Name,
            PayType = PayType,
            PosType = PosType,
            TaxRate = TaxRate,
            MeasureUnit = MeasureUnit,
            Price = Price,
            Quantity = Quantity,
            TotalSum = TotalSum,
            IndustryData = (IndustryData[])IndustryData.Clone(),
            Codes = Codes.Clone()
        };
    }
}