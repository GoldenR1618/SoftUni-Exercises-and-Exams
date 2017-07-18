namespace _06_Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            Dictionary<string, string> nameEmail = new Dictionary<string, string>();

            for (int i = 0; i < input.Length; i = i+ 2)
            {
                if (input[i] == "stop")
                {
                    break;
                }

                string name = input[i];
                string email = input[i + 1];

                nameEmail[name] = email;
            }

            Dictionary<string, string> fixedNameEmail = nameEmail
                .Where(x => !x.Value.ToLower().EndsWith("us") && !x.Value.ToLower().EndsWith("uk"))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in fixedNameEmail)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}{Environment.NewLine}");
            }
        }
    }
}
