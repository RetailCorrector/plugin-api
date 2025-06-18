using RetailCorrector.Enums;

namespace RetailCorrector
{
    /// <summary>
    /// Информация об коде товара
    /// </summary>
    public readonly struct PositionCode(string value, PositionCodeType type = 0)
    {
        /// <summary>
        /// Тип кода товара
        /// </summary>
        public PositionCodeType Type { get; } = type;
        /// <summary>
        /// Код товара
        /// </summary>
        public string Value { get; } = value;
    }
}
