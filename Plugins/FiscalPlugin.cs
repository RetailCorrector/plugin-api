using System.Runtime.Loader;

namespace RetailCorrector.Plugins
{
    /// <summary>
    /// Интеграция с ККТ
    /// </summary>
    public abstract class FiscalPlugin: IPlugin
    {
        public abstract string Name { get; }
                
        public event Action<string, bool, Exception?>? Logging;
        public event Action<string, string?>? Notification;
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
        /// <summary>
        /// Подключение к ККТ
        /// </summary>
        /// <returns>true, если удалось подключить к ККТ, иначе false</returns>
        public abstract Task<bool> Connect();
        /// <summary>
        /// Показать количество неотравленных чеков в буфере ККТ
        /// </summary>
        /// <returns>Количество неотравленных чеков</returns>
        public abstract Task<uint> CountDocsInBuffer();
        /// <summary>
        /// Обработка чек
        /// </summary>
        /// <returns>true, если чек успешно отбит, иначе false</returns>
        public abstract Task<bool> ProcessingReceipt(Receipt receipt);
        /// <summary>
        /// Отключение от ККТ
        /// </summary>
        public abstract Task Disconnect();
        public abstract Task OnUnload();
    }
}
