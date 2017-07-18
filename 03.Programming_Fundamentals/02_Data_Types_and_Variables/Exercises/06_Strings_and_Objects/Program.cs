using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Hello";
            string text2 = "World";

            object twoWord = text1 + " " + text2;

            string text3 = (string)twoWord;
            Console.WriteLine(text3);
        }
    }
}
