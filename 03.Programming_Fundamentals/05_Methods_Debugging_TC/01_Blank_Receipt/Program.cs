using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void PrintHeader()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine(@"------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
