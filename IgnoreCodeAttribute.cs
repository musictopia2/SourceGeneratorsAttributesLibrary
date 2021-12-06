namespace SourceGeneratorsAttributesLibrary;
/// <summary>
/// this is used that if specified, then everything on the page would be ignored
/// even if nothing is shown as included which means all, then will be ignored.
/// </summary>
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public class IgnoreCodeAttribute : Attribute { }