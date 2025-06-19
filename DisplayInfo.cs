#pragma warning disable

using RetailCorrector;

public static class DisplayInfo
{
    /// <summary>
    /// Локализация единиц измерения
    /// </summary>
    public static Dictionary<MeasureUnit, string> MeasureUnits { get; } = new()
    {
        { MeasureUnit.Default, "По-штучно" },
        { MeasureUnit.g, "Грам" },
        { MeasureUnit.kg, "Килограм" },
        { MeasureUnit.t, "Тонна" },
        { MeasureUnit.cm, "Сентиметр" },
        { MeasureUnit.dm, "Дециметр" },
        { MeasureUnit.m, "Метр" },
        { MeasureUnit.cm2, "Квадратный Сентиметр" },
        { MeasureUnit.dm2, "Квадратный Дециметр" },
        { MeasureUnit.m2, "Квадратный Метр" },
        { MeasureUnit.mL, "Миллилитр" },
        { MeasureUnit.L, "Литр" },
        { MeasureUnit.m3, "Кубический Метр" },
        { MeasureUnit.kW_h, "Киловатт * час" },
        { MeasureUnit.GCal, "Гигакалорий" },
        { MeasureUnit.Day, "Дней" },
        { MeasureUnit.h, "Часов" },
        { MeasureUnit.min, "Минут" },
        { MeasureUnit.sec, "Секунд" },
        { MeasureUnit.kByte, "Килобайт" },
        { MeasureUnit.MByte, "Мегабайт" },
        { MeasureUnit.GByte, "Гигабайт" },
        { MeasureUnit.TByte, "Терабайт" },
        { MeasureUnit.Other, "Другое" },
    };

    /// <summary>
    /// Локализация единиц измерения (сокращённый вид)
    /// </summary>
    public static Dictionary<MeasureUnit, string> ShortMeasureUnits { get; } = new()
    {
        { MeasureUnit.Default, "шт" },
        { MeasureUnit.g, "гр" },
        { MeasureUnit.kg, "кг" },
        { MeasureUnit.t, "т" },
        { MeasureUnit.cm, "см" },
        { MeasureUnit.dm, "дм" },
        { MeasureUnit.m, "м" },
        { MeasureUnit.cm2, "см2" },
        { MeasureUnit.dm2, "дм2" },
        { MeasureUnit.m2, "м2" },
        { MeasureUnit.mL, "мл" },
        { MeasureUnit.L, "л" },
        { MeasureUnit.m3, "м3" },
        { MeasureUnit.kW_h, "кВт*ч" },
        { MeasureUnit.GCal, "Гкал" },
        { MeasureUnit.Day, "д" },
        { MeasureUnit.h, "ч" },
        { MeasureUnit.min, "м" },
        { MeasureUnit.sec, "с" },
        { MeasureUnit.kByte, "КБ" },
        { MeasureUnit.MByte, "МБ" },
        { MeasureUnit.GByte, "ГБ" },
        { MeasureUnit.TByte, "ТБ" },
    };

    /// <summary>
    /// Локализация типов коррекции
    /// </summary>
    public static Dictionary<CorrType, string> CorrectionTypes { get; } = new()
    {
        { CorrType.ByYourself, "Самостоятельно" },
        { CorrType.ByTaxService, "По предписанию" },
    };

    /// <summary>
    /// Локализация операций документа
    /// </summary>
    public static Dictionary<Operation, string> Operations { get; } = new()
    {
        { Operation.Income, "Приход" },
        { Operation.RefundIncome, "Возврат прихода" },
        { Operation.Outcome, "Расход" },
        { Operation.RefundOutcome, "Возврат расхода" },
    };

    /// <summary>
    /// Локализация ставок НДС
    /// </summary>
    public static Dictionary<TaxRate, string> TaxRates { get; } = new()
    {
        { TaxRate.Tax20, "20%" },
        { TaxRate.Tax10, "10%" },
        { TaxRate.Calc20, "20/120%" },
        { TaxRate.Calc10, "10/110%" },
        { TaxRate.Tax0, "0%" },
        { TaxRate.Without, "Не облагается" },
        { TaxRate.Tax5, "5%" },
        { TaxRate.Tax7, "7%" },
        { TaxRate.Calc5, "5/105%" },
        { TaxRate.Calc7, "7/107%" },
    };

    /// <summary>
    /// Локализация типов позиции
    /// </summary>
    public static Dictionary<PositionType, string> PositionTypes { get; } = new()
    {
        { PositionType.Product, "Товар" },
        { PositionType.Excise, "Акциз" },
        { PositionType.Work, "Работа" },
        { PositionType.Service, "Услуга" },
        { PositionType.Gambling, "Ставка игры" },
        { PositionType.GamblingWin, "Выигрыш АИ" },
        { PositionType.Lottery, "Ставка лотереи" },
        { PositionType.LotteryWin, "Выигрыш лотереи" },
        { PositionType.IntellectualProperty, "РИД" },
        { PositionType.Payment, "Платеж" },
        { PositionType.Agent, "АВ" },
        { PositionType.Forfeit, "Выплата" },
        { PositionType.Other, "Другое" },
        { PositionType.PropertyLaw, "Имущественное право" },
        { PositionType.NonOperatingIncome, "Внереализационный доход" },
        { PositionType.OtherPayment, "Иные платежи" },
        { PositionType.TraceFee, "Торговый сбор" },
        { PositionType.ResortFee, "Курортный сбор" },
        { PositionType.Deposit, "Залог" },
        { PositionType.Outcome, "Расход" },
        { PositionType.PensionInsuranceIE, "Взносы на ОПС ИП" },
        { PositionType.PensionInsurance, "Взносы на ОПС" },
        { PositionType.MedicalInsuranceIE, "Взносы на ОМС ИП" },
        { PositionType.MedicalInsurance, "Взносы на ОМС" },
        { PositionType.SocialInsurance, "Взносы на ОСС" },
        { PositionType.Casino, "Платеж казино" },
        { PositionType.FromBankAgent, "Выдача ДС" },
        { PositionType.ExciseNonMark, "АТНМ" },
        { PositionType.ExciseMark, "АТМ" },
        { PositionType.NonMark, "ТНМ" },
        { PositionType.Mark, "ТМ" },
    };

    /// <summary>
    /// Локализация способов оплаты позиции
    /// </summary>
    public static Dictionary<PaymentType, string> PaymentTypes { get; } = new()
    {
        { PaymentType.FullPrepaid, "Полная предоплата" },
        { PaymentType.PartPrepaid, "Частичная предоплата" },
        { PaymentType.Advance, "Аванс" },
        { PaymentType.FullPayment, "Полная оплата" },
        { PaymentType.PartPayment, "Частичная оплата" },
        { PaymentType.ToCredit, "Передача в кредит" },
        { PaymentType.Postpaid, "Оплата кредита" },
    };
}