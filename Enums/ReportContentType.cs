using System.Text.Json.Serialization;

namespace RetailCorrector.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<ReportContentType>))]
    public enum ReportContentType { JSON }
}
