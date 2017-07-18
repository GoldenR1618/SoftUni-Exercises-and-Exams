using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            Console.WriteLine(DecimalReversedOrder(number));
        }

        static string DecimalReversedOrder(string number)
        {
            string reverseNumber = string.Join("", number.Reverse());
          
            return reverseNumber;
        }
    }
}
