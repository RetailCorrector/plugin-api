using System.ComponentModel.DataAnnotations;

namespace RetailCorrector
{
    /// <summary>
    /// Тип оплаты позиции
    /// </summary>
    public enum PaymentType : byte
    {
        /// <summary>
        /// Полная предварительная оплата
        /// </summary>
        [Display(Name = "Полная предоплата")]
        FullPrepaid = 1,
        /// <summary>
        /// Частичная предварительная оплата
        /// </summary>
        [Display(Name = "Частичная предоплата")]
        PartPrepaid = 2,
        /// <summary>
        /// Аванс
        /// </summary>
        [Display(Name = "Аванс")]
        Advance = 3,
        /// <summary>
        /// Полная оплата
        /// </summary>
        [Display(Name = "Полная оплата")]
        FullPayment = 4,
        /// <summary>
        /// Частичная оплата с последующей оплатой в кредит
        /// </summary>
        [Display(Name = "Частичная оплата")]
        PartPayment = 5,
        /// <summary>
        /// Передача предмета расчета без его оплаты с последующей оплатой в кредит
        /// </summary>
        [Display(Name = "Передача в кредит")]
        ToCredit = 6,
        /// <summary>
        /// Оплата предмета расчета после его передачи (оплата кредита)
        /// </summary>
        [Display(Name = "Оплата кредита")]
        Postpaid = 7,
    }
}