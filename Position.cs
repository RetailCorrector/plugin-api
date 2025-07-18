﻿namespace RetailCorrector
{
    /// <summary>
    /// Информация о позиции
    /// </summary>
    public struct Position()
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Тип оплаты
        /// </summary>
        public PaymentType PayType { get; set; } = PaymentType.FullPayment;
        /// <summary>
        /// Тип позиции
        /// </summary>
        public PositionType PosType { get; set; } = PositionType.Product;
        /// <summary>
        /// Налоговая ставка
        /// </summary>
        public TaxRate TaxRate { get; set; } = TaxRate.Tax10;
        /// <summary>
        /// Единица измерений
        /// </summary>
        public MeasureUnit MeasureUnit { get; set; } = MeasureUnit.None;
        /// <summary>
        /// Цена
        /// </summary>
        public uint Price { get; set; } = 0;
        /// <summary>
        /// Количество
        /// </summary>
        public uint Quantity { get; set; } = 1;
        /// <summary>
        /// Итоговая сумма
        /// </summary>
        public uint TotalSum { get; set; } = 0;
        /// <summary>
        /// Отраслевой реквизит позиции
        /// </summary>
        public IndustryData[] IndustryData { get; set; } = [];
        /// <summary>
        /// Коды товара
        /// </summary>
        public PositionCode Codes { get; set; } = new();
        /// <summary>
        /// Дополнительные данные
        /// </summary>
        public Dictionary<string, string> Additions { get; private set; } = [];
        
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
            Codes = Codes.Clone(),
            Additions = ((KeyValuePair<string, string>[])Additions.ToArray().Clone()).ToDictionary()
        };
    }
}