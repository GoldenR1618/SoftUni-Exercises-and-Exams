using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            for (int number = 2; number <= maxNumber; number++)
            {
                bool checkToPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        checkToPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {checkToPrime}");
            }
        }
    }
}
