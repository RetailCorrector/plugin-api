using System.ComponentModel.DataAnnotations;

namespace RetailCorrector
{
    /// <summary>
    /// Ставки НДС
    /// </summary>
    public enum TaxRate
    {
        /// <summary>
        /// Ставка 20%
        /// </summary>
        [Display(Name="20%")]
        Tax20 = 1,
        /// <summary>
        /// Ставка 10%
        /// </summary>
        [Display(Name = "10%")]
        Tax10 = 2,
        /// <summary>
        /// Расчитываемая ставка 20/120%
        /// </summary>
        [Display(Name = "20/120%")]
        Calc20 = 3,
        /// <summary>
        /// Расчитываемая ставка 10/110%
        /// </summary>
        [Display(Name = "10/110%")]
        Calc10 = 4,
        /// <summary>
        /// Ставка 0%
        /// </summary>
        [Display(Name = "0%")]
        Tax0 = 5,
        /// <summary>
        /// Не облагается НДС
        /// </summary>
        [Display(Name = "Не облагается")]
        Without = 6,
        /// <summary>
        /// Ставка 5%
        /// </summary>
        [Display(Name = "5%")]
        Tax5 = 7,
        /// <summary>
        /// Ставка 7%
        /// </summary>
        [Display(Name = "7%")]
        Tax7 = 8,
        /// <summary>
        /// Расчитываемая ставка 5/105%
        /// </summary>
        [Display(Name = "5/105%")]
        Calc5 = 9,
        /// <summary>
        /// Расчитываемая ставка 7/107%
        /// </summary>
        [Display(Name = "7/107%")]
        Calc7 = 10,
    }
}