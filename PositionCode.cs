namespace RetailCorrector
{
    /// <summary>
    /// Информация об коде товара
    /// </summary>
    public struct PositionCode()
    {
        /// <summary>
        /// Нераспознаный код
        /// </summary>
        public string Unknown { get; set; } = "";
        /// <summary>
        /// EAN-8
        /// </summary>
        public string EAN8 { get; set; } = "";
        /// <summary>
        /// EAN-13
        /// </summary>
        public string EAN13 { get; set; } = "";
        /// <summary>
        /// ITF-14
        /// </summary>
        public string ITF14 { get; set; } = "";
        /// <summary>
        /// GS1.0
        /// </summary>
        public string GS1_0 { get; set; } = "";
        /// <summary>
        /// GS1.M
        /// </summary>
        public string GS1_M { get; set; } = "";
        /// <summary>
        /// Компактный маркировочный код
        /// </summary>
        public string KMK { get; set; } = "";
        /// <summary>
        /// Код мехового изделия
        /// </summary>
        public string MI { get; set; } = "";
        /// <summary>
        /// ЕГАИС2.0
        /// </summary>
        public string EGAIS2 { get; set; } = "";
        /// <summary>
        /// ЕГАИС3.0
        /// </summary>
        public string EGAIS3 { get; set; } = "";
        /// <summary>
        /// Ф.1
        /// </summary>
        public string F1 { get; set; } = "";
        /// <summary>
        /// Ф.2
        /// </summary>
        public string F2 { get; set; } = "";
        /// <summary>
        /// Ф.3
        /// </summary>
        public string F3 { get; set; } = "";
        /// <summary>
        /// Ф.4
        /// </summary>
        public string F4 { get; set; } = "";
        /// <summary>
        /// Ф.5
        /// </summary>
        public string F5 { get; set; } = "";
        /// <summary>
        /// Ф.6
        /// </summary>
        public string F6 { get; set; } = "";

        /// <summary>
        /// Клонирование кодов позиции
        /// </summary>
        public PositionCode Clone() => new()
        {
            Unknown = Unknown,
            EAN8 = EAN8,
            EAN13 = EAN13,
            ITF14 = ITF14,
            GS1_0 = GS1_0,
            GS1_M = GS1_M,
            KMK = KMK,
            MI = MI,
            EGAIS2 = EGAIS2,
            EGAIS3 = EGAIS3,
            F1 = F1,
            F2 = F2,
            F3 = F3,
            F4 = F4,
            F5 = F5,
            F6 = F6,
        };
    }
}
