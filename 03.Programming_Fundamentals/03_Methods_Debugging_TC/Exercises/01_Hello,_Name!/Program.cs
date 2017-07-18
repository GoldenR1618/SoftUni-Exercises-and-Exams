using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello__Name_
{
    class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Print(name);
        }

        public static void Print(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
