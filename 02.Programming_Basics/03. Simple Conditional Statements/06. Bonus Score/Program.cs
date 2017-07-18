using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter score: " + num);
            if (num % 10 ==5)
            {
                if (num % 2 == 0)
                {
                    if (num <= 100)
                    {
                        Console.WriteLine("Bonus score: " + (2 + 5 + 1));
                        Console.WriteLine("Total score: " + (2 + num + 5 + 1));
                    }
                    else if (num > 100 && num <= 1000)
                    {
                        Console.WriteLine("Bonus score: " + (2 + 1 + (num * 0.2)));
                        Console.WriteLine("Total score: " + (2 + 1 + num + (num * 0.2)));
                    }
                    else if (num > 1000)
                    {
                        Console.WriteLine("Bonus score: " + (2 + 1 + (num * 0.1)));
                        Console.WriteLine("Total score: " + (2 + 1 + num + (num * 0.1)));
                    }
                }
                else
                {
                    if (num <= 100)
                    {
                        Console.WriteLine("Bonus score: " + (2 + 5));
                        Console.WriteLine("Total score: " + (2 + num + 5));
                    }
                    else if (num > 100 && num <= 1000)
                    {
                        Console.WriteLine("Bonus score: " + (2 + (num * 0.2)));
                        Console.WriteLine("Total score: " + (2 + num + (num * 0.2)));
                    }
                    else if (num > 1000)
                    {
                        Console.WriteLine("Bonus score: " + (2 + (num * 0.1)));
                        Console.WriteLine("Total score: " + (2 + num + (num * 0.1)));
                    }
                }
            }
            else
            {
                if (num % 2 == 0)
                {
                    if (num <= 100)
                    {
                        Console.WriteLine("Bonus score: " + (5 + 1));
                        Console.WriteLine("Total score: " + (num + 5 + 1));
                    }
                    else if (num > 100 && num <= 1000)
                    {
                        Console.WriteLine("Bonus score: " + (1 + (num * 0.2)));
                        Console.WriteLine("Total score: " + (1 + num + (num * 0.2)));
                    }
                    else if (num > 1000)
                    {
                        Console.WriteLine("Bonus score: " + (1 + (num * 0.1)));
                        Console.WriteLine("Total score: " + (1 + num + (num * 0.1)));
                    }
                }
                else
                {
                    if (num <= 100)
                    {
                        Console.WriteLine("Bonus score: " + (5));
                        Console.WriteLine("Total score: " + (num + 5));
                    }
                    else if (num > 100 && num <= 1000)
                    {
                        Console.WriteLine("Bonus score: " + ((num * 0.2)));
                        Console.WriteLine("Total score: " + (num + (num * 0.2)));
                    }
                    else if (num > 1000)
                    {
                        Console.WriteLine("Bonus score: " + ((num * 0.1)));
                        Console.WriteLine("Total score: " + (num + (num * 0.1)));
                    }
                }
            }
        }
    }
}
