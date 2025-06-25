using System.Runtime.Loader;

namespace RetailCorrector.Plugins
{
    /// <summary>
    /// Интеграция с источником данных
    /// </summary>
    public abstract class SourcePlugin: IPlugin
    {
        public abstract string Name { get; }
        
        public event Action<string, bool, Exception?>? Logging;
        public event Action<string, string?>? Notification;
        /// <summary>
        /// Событие запуска парсинга чеков
        /// </summary>
        public event Action<int>? ParseStarted;
        /// <summary>
        /// Событие обновления статус прогресса
        /// </summary>
        public event Action<int>? ProgressUpdated;
        /// <summary>
        /// Событие получения чека
        /// </summary>
        public event Action<Receipt>? AddedReceipt;

        /// <summary>
        /// Вызов события <see cref="ParseStarted"/>
        /// </summary>
        /// <param name="maxProgress">Количество этапов парсинга</param>
        protected internal void InvokeParseStarted(int maxProgress) => 
            ParseStarted?.Invoke(maxProgress);
        /// <summary>
        /// Вызов события <see cref="ProgressUpdated"/>
        /// </summary>
        /// <param name="value">Текущий статус прогресса</param>
        protected internal void InvokeProgressUpdated(int value) => 
            ProgressUpdated?.Invoke(value);
        /// <summary>
        /// Вызов события <see cref="AddedReceipt"/>
        /// </summary>
        /// <param name="value">Новый чек</param>
        protected internal void InvokeAddedReceipt(Receipt value) =>
            AddedReceipt?.Invoke(value);

        /// <summary>
        /// Запись в журнал действий
        /// </summary>
        /// <param name="text">Текст записи</param>
        /// <param name="error">Является ли запись - ошибкой?</param>
        /// <param name="ex">Исключение записи</param>
        protected internal void Log(string text, bool error, Exception? ex) =>
            Logging?.Invoke(text, error, ex);

        /// <summary>
        /// Оповещение
        /// </summary>
        /// <param name="text">Текст оповещения</param>
        /// <param name="caption">Заголовок оповещения</param>
        protected internal void Notify(string text, string? caption = null) =>
            Notification?.Invoke(text, caption);

        public abstract Task OnLoad(AssemblyLoadContext ctx);
        public abstract Task OnUnload();
        
        /// <summary>
        /// Парсинг чеков
        /// </summary>
        /// <param name="token">Токен отмены действия</param>
        public abstract Task Parse(CancellationToken token);
    }
}
