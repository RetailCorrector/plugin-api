using System.ComponentModel.DataAnnotations;

namespace RetailCorrector
{
    /// <summary>
    /// Тип коррекции
    /// </summary>
    public enum CorrType
    {
        /// <summary>
        /// Самостоятельная коррекция
        /// </summary>
        [Display(Name = "Самостоятельно")]
        ByYourself = 0,
        /// <summary>
        /// Коррекция по предписанию ФНС
        /// </summary>
        [Display(Name = "По предписанию")]
        ByTaxService = 1
    }
}