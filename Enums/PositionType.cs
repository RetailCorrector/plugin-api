using System.ComponentModel.DataAnnotations;

namespace RetailCorrector
{
    /// <summary>
    /// Тип позиции
    /// </summary>
    public enum PositionType
    {
        /// <summary>
        /// Товар
        /// </summary>
        [Display(Name = "Товар")]
        Product = 1,
        /// <summary>
        /// Проакцизированный товар
        /// </summary>
        [Display(Name = "Акциз")]
        Excise = 2,
        /// <summary>
        /// Выполняемая работа
        /// </summary>
        [Display(Name = "Работа")]
        Work = 3,
        /// <summary>
        /// Оказание услуги
        /// </summary>
        [Display(Name = "Услуга")]
        Service = 4,
        /// <summary>
        /// Ставка в азартной игре
        /// </summary>
        [Display(Name = "Ставка игры")]
        Gambling = 5,
        /// <summary>
        /// Выйгрыш в азартной игре
        /// </summary>
        [Display(Name = "Выигрыш АИ")]
        GamblingWin = 6,
        /// <summary>
        /// Ставка лотереи
        /// </summary>
        [Display(Name = "Ставка лотереи")]
        Lottery = 7,
        /// <summary>
        /// Выйгрыш лотереи
        /// </summary>
        [Display(Name = "Выигрыш лотереи")]
        LotteryWin = 8,
        /// <summary>
        /// Результат интеллектуальной деятельности
        /// </summary>
        [Display(Name = "РИД")]
        IntellectualProperty = 9,
        /// <summary>
        /// Аванс/Преоплата/Кредит
        /// </summary>
        [Display(Name = "Платеж")]
        Payment = 10,
        /// <summary>
        /// Вознаграждение платёжному или иному агенту
        /// </summary>
        [Display(Name = "АВ")]
        Agent = 11,
        /// <summary>
        /// Взнос в счет оплаты, пени, штрафе, вознаграждении, бонусе и др.
        /// </summary>
        [Display(Name = "Выплата")]
        Forfeit = 12,
        /// <summary>
        /// Другое
        /// </summary>
        [Display(Name = "Другое")]
        Other = 13,
        /// <summary>
        /// Передача имущественного права
        /// </summary>
        [Display(Name = "Имущественное право")]
        PropertyLaw = 14,
        /// <summary>
        /// Внереализационный доход
        /// </summary>
        [Display(Name = "Внереализационный доход")]
        NonOperatingIncome = 15,
        /// <summary>
        /// Расход, указанный подпунктах 2 и 3 пункта Налогового кодекса РФ, уменьшающий сумму налога
        /// </summary>
        [Display(Name = "Иные платежи")]
        OtherPayment = 16,
        /// <summary>
        /// Торговый сбор
        /// </summary>
        [Display(Name = "Торговый сбор")]
        TraceFee = 17,
        /// <summary>
        /// Курортный сбор
        /// </summary>
        [Display(Name = "Курортный сбор")]
        ResortFee = 18,
        /// <summary>
        /// Залог
        /// </summary>
        [Display(Name = "Залог")]
        Deposit = 19,
        /// <summary>
        /// Расход, в соответствии со статьей 346.16 пункта Налогового кодекса РФ
        /// </summary>
        [Display(Name = "Расход")]
        Outcome = 20,
        /// <summary>
        /// Обязательное пенсионное страхование для ИП
        /// </summary>
        [Display(Name = "Взносы на ОПС ИП")]
        PensionInsuranceIE = 21,
        /// <summary>
        /// Обязательное пенсионное страхование для ИП
        /// </summary>
        [Display(Name = "Взносы на ОПС")]
        PensionInsurance = 22,
        /// <summary>
        /// Обязательное медицинское страхование для ИП
        /// </summary>
        [Display(Name = "Взносы на ОМС ИП")]
        MedicalInsuranceIE = 23,
        /// <summary>
        /// Обязательное медицинское страхование
        /// </summary>
        [Display(Name = "Взносы на ОМС")]
        MedicalInsurance = 24,
        /// <summary>
        /// Обязательное социальное страхование
        /// </summary>
        [Display(Name = "Взносы на ОСС")]
        SocialInsurance = 25,
        /// <summary>
        /// Казино
        /// </summary>
        [Display(Name = "Платеж казино")]
        Casino = 26,
        #region ФФД 1.2
        /// <summary>
        /// Выдача денежных средств банковским платёжным агентом
        /// </summary>
        /// <remarks>Используется в ФФД 1.2</remarks>
        [Display(Name = "Выдача ДС")]
        FromBankAgent = 27,
        /// <summary>
        /// Проакцизированный товар, подлежащий маркировке, не имеющий кода маркировки
        /// </summary>
        /// <remarks>Используется в ФФД 1.2</remarks>
        [Display(Name = "АТНМ")]
        ExciseNonMark = 30,
        /// <summary>
        /// Проакцизированный товар, подлежащий маркировке, имеющий кода маркировки
        /// </summary>
        /// <remarks>Используется в ФФД 1.2</remarks>
        [Display(Name = "АТМ")]
        ExciseMark = 31,
        /// <summary>
        /// Товар, подлежащий маркировке, не имеющий кода маркировки
        /// </summary>
        /// <remarks>Используется в ФФД 1.2</remarks>
        [Display(Name = "ТНМ")]
        NonMark = 32,
        /// <summary>
        /// Товар, подлежащий маркировке, имеющий кода маркировки
        /// </summary>
        /// <remarks>Используется в ФФД 1.2</remarks>
        [Display(Name = "ТМ")]
        Mark = 33,
        #endregion
    }
}