using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            var track = Console.ReadLine().ToLower();
            double darenaSuma = 0.00;

            if (track == "trail")
            {
                darenaSuma = (juniors * 5.50 + seniors * 7.00) * 0.95;
            }
            else if (track == "cross-country")
            {
                if ((juniors + seniors) >= 50)
                {
                    darenaSuma = (juniors * 8.00 * 0.75 + seniors * 9.50 * 0.75) *0.95;
                }
                else
                {
                    darenaSuma = (juniors * 8.00 + seniors * 9.50) * 0.95;
                }
            }
            else if (track == "downhill")
            {
                darenaSuma = (juniors * 12.25 + seniors * 13.75) * 0.95;
            }
            else if (track == "road")
            {
                darenaSuma = (juniors * 20.00 + seniors * 21.50) *0.95;
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.WriteLine("{0:F2}", darenaSuma);
        }
    }
}
