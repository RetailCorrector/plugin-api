namespace RetailCorrector
{
    /// <summary>
    /// Структура отчёта
    /// </summary>
    public struct Report
    {
        /// <summary>
        /// Метод запроса
        /// </summary>
        public HttpMethod Method { get; set; }
        /// <summary>
        /// Адрес запроса
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Заголовки запроса
        /// </summary>
        public Dictionary<string, List<string>>? Headers { get; set; }
        /// <summary>
        /// Тело запроса
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Заголовок "Content-Type" запроса
        /// </summary>
        public string ContentType { get; set; }
    }
}
