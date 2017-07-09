using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            var days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day >= 1 && day <= 7)
                Console.WriteLine(days[day - 1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
