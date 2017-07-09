using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().ToLower().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = text.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
