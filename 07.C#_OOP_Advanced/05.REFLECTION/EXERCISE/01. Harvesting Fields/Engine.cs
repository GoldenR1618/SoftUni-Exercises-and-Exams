namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Engine
    {
        public void Start()
        {
            FieldInfo[] allFields = typeof(HarvestingFields).GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            string command = Console.ReadLine();

            while (command != "HARVEST")
            {
                switch (command)
                {
                    case "private":
                        foreach (var field in allFields.Where(f => f.IsPrivate))
                        {
                            Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                        }
                        
                        break;

                    case "protected":
                        foreach (var field in allFields.Where(f => f.IsFamily))
                        {
                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }

                        break;

                    case "public":
                        foreach (var field in allFields.Where(f => f.IsPublic))
                        {
                            Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                        }

                        break;

                    case "all":
                        foreach (var field in allFields)
                        {
                            if (field.IsFamily)
                            {
                                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                            }                         
                        }

                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
