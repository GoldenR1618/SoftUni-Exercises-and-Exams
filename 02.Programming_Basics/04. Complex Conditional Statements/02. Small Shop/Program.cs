using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.6);
                }
            }
            if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.4);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.50);
                }
            }
            if (town == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }
}
