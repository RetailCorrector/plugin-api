﻿namespace RetailCorrector
{
    public struct Report
    {
        public HttpMethod Method { get; set; }
        public string Url { get; set; }
        public Dictionary<string, List<string>>? Headers { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
    }
}
