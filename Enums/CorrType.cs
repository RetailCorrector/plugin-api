namespace RetailCorrector
{
    /// <summary>
    /// Тип коррекции
    /// </summary>
    public enum CorrType : byte
    {
        /// <summary>
        /// Самостоятельная коррекция
        /// </summary>
        ByYourself = 0,
        /// <summary>
        /// Коррекция по предписанию ФНС
        /// </summary>
        ByTaxService = 1
    }
}