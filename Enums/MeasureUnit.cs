using System.ComponentModel.DataAnnotations;

namespace RetailCorrector
{
    /// <summary>
    /// Единица измерения
    /// </summary>
    public enum MeasureUnit
    {
        /// <summary>
        /// Отсутствует
        /// </summary>
        None = -1,
        /// <summary>
        /// Штук/Единиц
        /// </summary>
        [Display(Name = "По-штучно")]
        Default = 0,
        /// <summary>
        /// Грам
        /// </summary>
        [Display(Name = "Грам")]
        g = 10,
        /// <summary>
        /// Килограм
        /// </summary>
        [Display(Name = "Килограм")]
        kg = 11,
        /// <summary>
        /// Тонна
        /// </summary>
        [Display(Name = "Тонна")]
        t = 12,
        /// <summary>
        /// Сентиметр
        /// </summary>
        [Display(Name = "Сентиметр")]
        cm = 20,
        /// <summary>
        /// Дециметр
        /// </summary>
        [Display(Name = "Дециметр")]
        dm = 21,
        /// <summary>
        /// Метр
        /// </summary>
        [Display(Name = "Метр")]
        m = 22,
        /// <summary>
        /// Квадратный Сентиметр
        /// </summary>
        [Display(Name = "Квадратный Сентиметр")]
        cm2 = 30,
        /// <summary>
        /// Квадратный Дециметр
        /// </summary>
        [Display(Name = "Квадратный Дециметр")]
        dm2 = 31,
        /// <summary>
        /// Квадратный Метр
        /// </summary>
        [Display(Name = "Квадратный Метр")]
        m2 = 32,
        /// <summary>
        /// Миллилитр
        /// </summary>
        [Display(Name = "Миллилитр")]
        mL = 40,
        /// <summary>
        /// Литр
        /// </summary>
        [Display(Name = "Литр")]
        L = 41,
        /// <summary>
        /// Кубический Метр
        /// </summary>
        [Display(Name = "Кубический Метр")]
        m3 = 42,
        /// <summary>
        /// Киловатт * час
        /// </summary>
        [Display(Name = "Киловатт * час")]
        kW_h = 50,
        /// <summary>
        /// Гигакалорий
        /// </summary>
        [Display(Name = "Гигакалорий")]
        GCal = 51,
        /// <summary>
        /// Дней
        /// </summary>
        [Display(Name = "Дней")]
        Day = 70,
        /// <summary>
        /// Часов
        /// </summary>
        [Display(Name = "Часов")]
        h = 71,
        /// <summary>
        /// Минут
        /// </summary>
        [Display(Name = "Минут")]
        min = 72,
        /// <summary>
        /// Секунд
        /// </summary>
        [Display(Name = "Секунд")]
        sec = 73,
        /// <summary>
        /// Килобайт
        /// </summary>
        [Display(Name = "Килобайт")]
        kByte = 80,
        /// <summary>
        /// Мегабайт
        /// </summary>
        [Display(Name = "Мегабайт")]
        MByte = 81,
        /// <summary>
        /// Гигабайт
        /// </summary>
        [Display(Name = "Гигабайт")]
        GByte = 82,
        /// <summary>
        /// Терабайт
        /// </summary>
        [Display(Name = "Терабайт")]
        TByte = 83,
        /// <summary>
        /// Другое
        /// </summary>
        [Display(Name = "Другое")]
        Other = 255
    }
}