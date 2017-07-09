using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split('|').ToList();         //7 | 4  5|1 0| 2 5 |3

            text.Reverse();

            List<string> result = new List<string>();

            foreach (var itemText in text)
            {
                List<string> nums = itemText.Split(' ').ToList();

                foreach (var itemNum in nums)
                {
                    if (itemNum != "")
                    {
                        result.Add(itemNum);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
