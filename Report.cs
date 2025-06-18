namespace RetailCorrector
{
    public class Report
    {
        public static Report Current { get; set; } = null!;

        public HttpMethod Method { get; set; }
        public string Url { get; set; } = "";
        public Dictionary<string, List<string>>? Headers { get; set; }
        public string Content { get; set; } = "";
        public string ContentType { get; set; } = "";
    }
}
