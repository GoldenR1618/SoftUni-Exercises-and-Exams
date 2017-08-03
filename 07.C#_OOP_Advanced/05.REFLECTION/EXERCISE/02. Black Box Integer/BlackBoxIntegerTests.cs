namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    class BlackBoxIntegerTests
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Type type = typeof(BlackBoxInt);
            BlackBoxInt instance = (BlackBoxInt)Activator.CreateInstance(type, true);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            string[] command = Console.ReadLine().Split('_');

            while (command[0] != "END")
            {
                sb.Clear();

                int  value = int.Parse(command[1]);

                methods.FirstOrDefault(m => m.Name == command[0])?.Invoke(instance, new object[] { value });

                foreach (var field in fields)
                {
                    sb.AppendLine(field.GetValue(instance).ToString());
                }

                Console.WriteLine(sb.ToString().Trim());

                command = Console.ReadLine().Split('_');
            }
        }
    }
}
