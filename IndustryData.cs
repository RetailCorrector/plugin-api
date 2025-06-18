namespace RetailCorrector
{
    /// <summary>
    /// Отраслевой реквизит
    /// </summary>
    public struct IndustryData
    {
        /// <summary>
        /// Идентификатор ФОИВ
        /// </summary>
        public byte GosId { get; set; }
        /// <summary>
        /// Дата документа основания
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// Номер документа основания
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Значение отраслевого реквизита
        /// </summary>
        public string Value { get; set; }
    }
}
