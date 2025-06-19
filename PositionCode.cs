using System.Reflection.Emit;
using System.Runtime.InteropServices.JavaScript;
using System.Xml.Linq;

namespace RetailCorrector
{
    /// <summary>
    /// Информация об коде товара
    /// </summary>
    public struct PositionCode()
    {
        public string Unknown { get; set; } = "";
        public string EAN8 { get; set; } = "";
        public string EAN13 { get; set; } = "";
        public string ITF14 { get; set; } = "";
        public string GS1_0 { get; set; } = "";
        public string GS1_M { get; set; } = "";
        public string KMK { get; set; } = "";
        public string MI { get; set; } = "";
        public string EGAIS2 { get; set; } = "";
        public string EGAIS3 { get; set; } = "";
        public string F1 { get; set; } = "";
        public string F2 { get; set; } = "";
        public string F3 { get; set; } = "";
        public string F4 { get; set; } = "";
        public string F5 { get; set; } = "";
        public string F6 { get; set; } = "";

        /// <summary>
        /// Клонирование 
        /// </summary>
        public PositionCode Clone() => new()
        {
            Unknown = Unknown,
            EAN8 = EAN8,
            EAN13 = EAN13,
            ITF14 = ITF14,
            GS1_0 = GS1_0,
            GS1_M = GS1_M,
            KMK = KMK,
            MI = MI,
            EGAIS2 = EGAIS2,
            EGAIS3 = EGAIS3,
            F1 = F1,
            F2 = F2,
            F3 = F3,
            F4 = F4,
            F5 = F5,
            F6 = F6,
        };
    }
}
