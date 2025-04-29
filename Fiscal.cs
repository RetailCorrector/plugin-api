namespace RetailCorrector;

public static class Fiscal
{
    /// <summary>
    /// Наименование 
    /// </summary>
    public const string Name = "";
    private readonly static Version version = typeof(Fiscal).Assembly.GetName().Version!; // ВЕРСИЯ НАСТРАИВАЕТСЯ В ФАЙЛЕ ПРОЕКТА
    /// <summary>
    /// true, если данная интеграция работает с облачной кассой, иначе false
    /// </summary>
    public const bool CloudFiscal = false;
    /// <summary>
    /// Статус смены
    /// </summary>
    public static SessionStatus? SessionStatus => RetailCorrector.SessionStatus.Opened;
    /// <summary>
    /// Событие логирования
    /// </summary>
    public static event LoggingRecord Logging;
    /// <summary>
    /// Флаг подключения к ККТ
    /// </summary>
    public static bool IsConnected => true;
    /// <summary>
    /// Флаг активности интеграции
    /// </summary>
    public static bool IsActivated => isActivated;
    private static bool isActivated;
    /// <summary>
    /// Информация о последней ошибке
    /// </summary>
    public static string LastError => "";
    /// <summary>
    /// Количество неотправленных чеков
    /// </summary>
    public static int UnsendDocumentsCount => 0;
    /// <summary>
    /// Формат фискального документа
    /// </summary>
    public static FiscalFormat Format => format;
    private static FiscalFormat format;

    private static void Info(string text) => Logging?.Invoke(text);
    private static void Error(string text, Exception? ex = null) => Logging?.Invoke(text, true, ex);

    public static bool Activate(params string[] args)
    {
        Info($"Активация фискальной интеграции \"{Name} {version}\"...");
        try
        {
            // Поключение драйвера или HTTP-клиента
            Info($"Фискальная интеграция запущена!");
            // Настройка драйвера
            isActivated = true;
            return true;
        }
        catch (Exception ex)
        {
            Error("Не удалось активировать фискальную интеграцию!", ex);
            isActivated = false;
            return false;
        }
    }

    public static void Deactivate()
    {
        // Освобождение кассы
        // Освобождение драйвера или HTTP-клиента
        Info($"Фискальная интеграция отключена!");
        isActivated = false;
    }

    public static bool Connect()
    {
        try
        {
            // Попытка подключения к ККТ
            if (!IsConnected)
                throw new Exception($"Не удалось подкючиться к ККТ (Ошибка: {LastError})");
            // Получение ФФД 
            return true;
        }
        catch(Exception ex)
        {
            Error("Не удалось подключиться к ККТ", ex);
            // Освободить устройство, если удалось подключиться!
            return false;
        }
    }

    public static bool OpenSession()
    {
        Info($"Открытие смены...");
        // Открытие смены
        var success = SessionStatus == RetailCorrector.SessionStatus.Opened;
        if (!success) Error($"Не удалось открыть смену (Ошибка: {LastError})");
        return success;
    }

    public static bool CloseSession()
    {
        Info($"Закрытие смены...");
        // Закрытие смены
        var success = SessionStatus == RetailCorrector.SessionStatus.Closed;
        if (!success) Error($"Не удалось закрыть смену (Ошибка: {LastError})");
        return success;
    }

    public static bool CancelDocument()
    {
        Info($"Отмена документа...");
        // Отмена документа (чека)
        return false;
    }

    public static bool ProcessingReceipt(Receipt info)
    {
        if (!OpenReceipt(info)) return CancelDocument();
        foreach(var pos in info.Items)
            if (!RegisterPosition(pos)) return CancelDocument();
        if(!Payment(info.Payment)) return CancelDocument();
        if(!CloseReceipt(info.RoundedSum)) return CancelDocument();
        return true;
    }

    private static bool OpenReceipt(Receipt info)
    {
        Info($"Открытие документа {info.FiscalSign} от {info.Created:dd'-'MM'-'yyyy}...");
        // Открытие документа
        return true;
    }

    private static bool RegisterPosition(Position pos)
    {
        Info($"Добавление {pos.Quantity/1000D} * \"{pos.Name}\"...");
        // Регистрация позиции
        return true;
    }

    private static bool Payment(Payment info)
    {
        var arr = (uint[])info;
        for (byte type = 0; type < 5; type++)
            if (arr[type] != 0 && !SinglePayment(type, arr[type])) return false;
        return true;
    }

    private static bool SinglePayment(byte type, uint sum)
    {
        Info($"{type switch
        {
            0 => "Наличная оплата документа",
            1 => "Безналичная оплата документа",
            2 => "Предоплата",
            3 => "Постоплата",
            4 => "Встречное предоставление",
            _ => "Неизвестный вид оплаты документа"
        }} на сумму {sum / 100D} руб.");
        // Оплата
        return true;
    }

    private static bool CloseReceipt(uint? totalSum)
    {
        if(totalSum is not null)
        {
            Info("Округление итоговой суммы...");
            // Установка итоговой суммы
        }
        Info("Закрытие документа...");
        // Закрытие документа
        return true;
    }
}
