using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0.00;
            double evenMin = 1000000000.00;
            double evenMax = -1000000000.00;

            double oddSum = 0.00;
            double oddMin = 1000000000.00;
            double oddMax = -1000000000.00;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)                 //ЧЕТНО
                {
                    evenSum = evenSum + num;

                    if (evenMin > num)          //ЧЕТНО МАЛКО
                    {
                        evenMin = num; 
                    }

                    if (evenMax < num)          //ЧЕТНО ГОЛЯМО
                    {
                        evenMax = num;
                    }
                }
                else                            //НЕЧЕТНО
                {
                    oddSum = oddSum + num;

                    if (oddMin > num)           //НЕЧЕТНО МАЛКО
                    {
                        oddMin = num;
                    }

                    if (oddMax < num)           //НЕЧЕТНО ГОЛЯМО
                    {
                        oddMax = num;
                    }
                }
            }
            if (evenMin == 1000000000.00)
            {

            }
            Console.WriteLine("OddSum=" + oddSum + ",");
            if (oddMin == 1000000000.00)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin + ",");
            }

            if (oddMax == -1000000000.00)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax + ",");
            }
            
            Console.WriteLine("EvenSum=" + evenSum + ",");

            if (evenMin == 1000000000.00)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin + ",");
            }

            if (evenMax == -1000000000.00)
            {
                Console.WriteLine("EvenMax=No,");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax + ",");
            }
            
        }
    }
}
