using System.Collections.Generic;
using System.Net.Http;

namespace RetailCorrector
{
    /// <summary>
    /// Информация о запросе для отправки отчета
    /// </summary>
    public struct ReportInfo
    {
        /// <summary>
        /// Метод запроса (GET, POST и т.д.)
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// URL запроса
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Заголовки запроса
        /// </summary>
        public Dictionary<string, string> Headers { get; set; }
        /// <summary>
        /// Тело запроса<br/>
        /// null если метод запроса GET или DELETE
        /// </summary>
        public string? Body { get; set; }

        /// <summary>
        /// Условие успешного выполнения запроса
        /// </summary>
        public string SuccessCondition { get; set; }

        public static explicit operator HttpRequestMessage(ReportInfo info)
        {
            var msg = new HttpRequestMessage(new HttpMethod(info.Method), info.Url);
            if (info.Body is not null)
            {
                var hasContentType = info.Headers.TryGetValue("Content-Type", out var type);
                msg.Content = new StringContent(info.Body, null, hasContentType ? type : null);
            }
            foreach (var (key, value) in info.Headers)
            {
                if (key == "Content-Type") continue;
                msg.Headers.Add(key, value);
            }
            return msg;
        }
    }
}
