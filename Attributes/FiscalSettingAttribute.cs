namespace RetailCorrector.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FiscalSettingAttribute(string id, string displayName) : Attribute
    {
        public string Id { get; } = id;
        public string DisplayName { get; } = displayName;
    }
}
