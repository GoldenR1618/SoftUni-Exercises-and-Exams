using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char letterThree = char.Parse(Console.ReadLine());
            Console.WriteLine($"{letterThree}{letterTwo}{letterOne}");
        }
    }
}
