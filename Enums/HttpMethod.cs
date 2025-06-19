using System.Text.Json.Serialization;

namespace RetailCorrector
{
    /// <summary>
    /// Метод HTTP-запроса
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<HttpMethod>))]
    public enum HttpMethod : byte {
        /// <summary>
        /// GET-запрос: Получение данных
        /// </summary>
        GET,
        /// <summary>
        /// POST-запрос: Отправка новых данных
        /// </summary>
        POST,
        /// <summary>
        /// PATCH-запрос: Частичное обновление данных
        /// </summary>
        PATCH,
        /// <summary>
        /// PUT-запрос: Полное обновление данных
        /// </summary>
        PUT,
        /// <summary>
        /// DELETE-запрос: Удаление данных
        /// </summary>
        DELETE
    }
}
