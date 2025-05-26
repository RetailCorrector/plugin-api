using RetailCorrector.Enums;
using System.Collections.Generic;

namespace RetailCorrector
{
    public struct Report
    {
        public HttpMethod Method { get; set; }
        public string Url { get; set; }
        public Dictionary<string, List<string>>? Headers { get; set; }
        public ReportContent Content { get; set; }
    }

    public struct ReportContent
    {
        public ReportContentType Type { get; set; }
        public Dictionary<string, object> Values { get; set; }
    }
}
