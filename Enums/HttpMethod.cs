using System.Text.Json.Serialization;

namespace RetailCorrector
{
    [JsonConverter(typeof(JsonStringEnumConverter<HttpMethod>))]
    public enum HttpMethod : byte { GET, POST, PATCH, PUT, DELETE }
}
