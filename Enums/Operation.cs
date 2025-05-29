using System.ComponentModel.DataAnnotations;

namespace RetailCorrector
{
    /// <summary>
    /// Операция чека
    /// </summary>
    public enum Operation
    {
        /// <summary>
        /// Приход
        /// </summary>
        [Display(Name = "Приход")]
        Income = 1,
        /// <summary>
        /// Возврат прихода
        /// </summary>
        [Display(Name = "Возврат прихода")]
        RefundIncome = 2,
        /// <summary>
        /// Расход
        /// </summary>
        [Display(Name = "Расход")]
        Outcome = 3,
        /// <summary>
        /// Возврат расхода
        /// </summary>
        [Display(Name = "Возврат расхода")]
        RefundOutcome = 4,
    }
}