namespace Pepegov.MicroserviceFramerwork.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class FeatureGroupNameAttribute : Attribute
{
    public FeatureGroupNameAttribute(string groupName) => GroupName = groupName;
    public string GroupName { get; }
}