using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldsNames)
    {
        StringBuilder sb = new StringBuilder();
        Type targetType = Type.GetType(className);

        sb.AppendLine($"Class under investigation: {targetType}");

        Object classInstance = Activator.CreateInstance(targetType);

        FieldInfo[] fields = targetType.GetFields(BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var field in fields.Where(f => fieldsNames.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }
}
