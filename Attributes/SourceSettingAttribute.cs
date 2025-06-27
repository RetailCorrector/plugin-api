namespace RetailCorrector.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SourceSettingAttribute(string displayName) : Attribute
    {
        public string DisplayName { get; } = displayName;
    }
}
