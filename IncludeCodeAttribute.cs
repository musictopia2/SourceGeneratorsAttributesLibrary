/// <summary>
/// this is used that if specified, then everything on the page would be included:
/// 
/// hint:  if anything has the includecode attribute, then only those are included
/// </summary>
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public class IncludeCodeAttribute : Attribute { }