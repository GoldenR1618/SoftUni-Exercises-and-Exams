using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Amount = ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter imput currency (BGN, USD, EUR, GBP):");
            var imput = Console.ReadLine();

            Console.WriteLine("Please enter output currency (BGN, USD, EUR, GBP):");
            var output = Console.ReadLine();


            //BGN to...
            if (imput == "BGN" && output == "BGN")
            {
                Console.Write(Math.Round((amount / 1), 2));
                Console.WriteLine(" BGN");
            }

            if (imput == "BGN" && output == "USD")
            {
                Console.Write(Math.Round((amount / 1.79549),2));
                Console.WriteLine(" USD");
            }

            if (imput == "BGN" && output == "EUR")
            {
                Console.Write(Math.Round((amount / 1.95583), 2));
                Console.WriteLine(" EUR");
            }

            if (imput == "BGN" && output == "GBP")
            {
                Console.Write(Math.Round((amount / 2.53405), 2));
                Console.WriteLine(" GBP");
            }

            //USD to...
            if (imput == "USD" && output == "BGN")
            {
                Console.Write(Math.Round((amount * 1.79549), 2));
                Console.WriteLine(" BGN");
            }

            if (imput == "USD" && output == "USD")
            {
                Console.Write(Math.Round((amount * 1), 2));
                Console.WriteLine(" USD");
            }

            if (imput == "USD" && output == "EUR")
            {
                Console.Write(Math.Round((amount * (1.79549 / 1.95583)), 2));
                Console.WriteLine(" EUR");
            }

            if (imput == "USD" && output == "GBP")
            {
                Console.Write(Math.Round((amount * (1.79549 / 2.53405)), 2));
                Console.WriteLine(" GBP");
            }

            //EUR to...
            if (imput == "EUR" && output == "BGN")
            {
                Console.Write(Math.Round((amount * 1.95583), 2));
                Console.WriteLine(" BGN");
            }

            if (imput == "EUR" && output == "USD")
            {
                Console.Write(Math.Round((amount * (1.95583 / 1.79549)), 2));
                Console.WriteLine(" USD");
            }

            if (imput == "EUR" && output == "EUR")
            {
                Console.Write(Math.Round((amount * 1), 2));
                Console.WriteLine(" EUR");
            }

            if (imput == "EUR" && output == "GBP")
            {
                Console.Write(Math.Round((amount * (1.95583 / 2.53405)), 2));
                Console.WriteLine(" GBP");
            }

            //GBP to...
            if (imput == "GBP" && output == "BGN")
            {
                Console.Write(Math.Round((amount * 2.53405), 2));
                Console.WriteLine(" BGN");
            }

            if (imput == "GBP" && output == "USD")
            {
                Console.Write(Math.Round((amount * (2.53405 / 1.79549)), 2));
                Console.WriteLine(" USD");
            }

            if (imput == "GBP" && output == "EUR")
            {
                Console.Write(Math.Round((amount * (2.53405 / 1.95583)), 2));
                Console.WriteLine(" EUR");
            }

            if (imput == "GBP" && output == "GBP")
            {
                Console.Write(Math.Round((amount * 1), 2));
                Console.WriteLine(" GBP");
            }
        }
    }
}
