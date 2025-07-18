﻿namespace RetailCorrector
{
    /// <summary>
    /// Информация о чеке
    /// </summary>
    public struct Receipt()
    {
        /// <summary>
        /// Дата и время отбития оригинального чека
        /// </summary>
        public DateTime Created { get; set; } = DateTime.Today;
        /// <summary>
        /// Тип чека
        /// </summary>
        public Operation Operation { get; set; } = Operation.Income;
        /// <summary>
        /// Позиции
        /// </summary>
        public Position[] Items { get; set; } = [];
        /// <summary>
        /// Фискальный признак
        /// </summary>
        public string FiscalSign { get; set; } = "";
        /// <summary>
        /// Тип коррекции
        /// </summary>
        public CorrType CorrectionType { get; set; } = CorrType.ByYourself;
        /// <summary>
        /// Номер документа (акта), поясняющего причину создания чека(ов) коррекции<br/>
        /// </summary>
        public string? ActNumber { get; set; } = null;
        /// <summary>
        /// Оплата
        /// </summary>
        public Payment Payment { get; set; } = new();
        /// <summary>
        /// Итоговая сумма
        /// </summary>
        public uint TotalSum { get; set; } = 0;
        /// <summary>
        /// Отраслевой реквизит чека
        /// </summary>
        public IndustryData[] IndustryData { get; set; } = [];
        /// <summary>
        /// Дополнительные данные
        /// </summary>
        public Dictionary<string, string> Additions { get; private set; } = [];

        /// <summary>
        /// Клонирование чека
        /// </summary>
        public Receipt Clone() => new()
        {
            Created = Created,
            Operation = Operation,
            Items = (Position[])Items.Clone(),
            FiscalSign = FiscalSign,
            ActNumber = ActNumber,
            Payment = Payment,
            TotalSum = TotalSum,
            IndustryData = (IndustryData[])IndustryData.Clone(),
            CorrectionType = CorrectionType,
            Additions = ((KeyValuePair<string, string>[])Additions.ToArray().Clone()).ToDictionary()
        };
    }
}