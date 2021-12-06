namespace SourceGeneratorsAttributesLibrary;
/// <summary>
/// this is intended to be used to show a property or field is required and is used for source generation.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class RequiredAttribute : Attribute { }