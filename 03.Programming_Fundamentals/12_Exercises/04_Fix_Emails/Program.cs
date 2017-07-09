using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> nameEmail = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                nameEmail[name] = email;
            }

            Dictionary<string, string> fixedNameEmail = nameEmail
                .Where(x => !x.Value.ToLower().EndsWith("us") && !x.Value.ToLower().EndsWith("uk"))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in fixedNameEmail)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
