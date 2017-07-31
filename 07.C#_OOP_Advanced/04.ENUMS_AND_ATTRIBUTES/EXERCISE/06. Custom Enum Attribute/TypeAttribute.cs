using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
public class TypeAttribute : Attribute
{
    private string type;
    private string category;
    private string description;

    public TypeAttribute(string type, string category, string description)
    {
        this.Type = type;
        this.Category = category;
        this.Description = description;
    }

    public string Type
    {
        get { return this.type; }
        private set { this.type = value; }
    }

    public string Category
    {
        get { return this.category; }
        private set { this.category = value; }
    }

    public string Description
    {
        get { return this.description; }
        private set { this.description = value; }
    }

    public override string ToString()
    {
        return $"Type = {this.Type}, Description = {this.Description}";
    }
}