using System;

namespace RetailCorrector
{
    /// <summary>
    /// Формат фискальных документов
    /// </summary>
    public enum FiscalFormat
    {
        /// <summary>
        /// Неизвестный формат
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// ФФД 1.0
        /// </summary>
        [Obsolete("Не используется")]
        _1_0 = 1,
        /// <summary>
        /// ФФД 1.05
        /// </summary>
        _1_05 = 2,
        /// <summary>
        /// ФФД 1.1
        /// </summary>
        _1_1 = 3,
        /// <summary>
        /// ФФД 1.2
        /// </summary>
        _1_2 = 4
    }
}