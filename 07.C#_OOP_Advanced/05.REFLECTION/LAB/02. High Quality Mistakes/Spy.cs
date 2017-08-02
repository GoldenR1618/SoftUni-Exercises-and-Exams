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

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type targetType = Type.GetType(className);

        FieldInfo[] wrongFields = targetType.GetFields(BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.Public);

        foreach (var field in wrongFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        MethodInfo[] pulbicMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] nonpulbicMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var method in nonpulbicMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var method in pulbicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
}
