﻿namespace SyncProgrammingProblems
{
    using System;
    using System.Collections.Generic;

    class SyncProgrammingProblems
    {
        static void Main()
        {
            Console.WriteLine("Enter range first:");
            int rangeFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter range last:");
            int rangeLast = int.Parse(Console.ReadLine());

            Console.WriteLine("Calculating primes... you can't do anything now");
            PrintPrimesInRange(rangeFirst, rangeLast);

            while (true)
            {
                Console.WriteLine("Here, write some text:");
                Console.ReadLine();
            }
        }

        static void PrintPrimesInRange(int rangeFirst, int rangeLast)
        {
            List<int> primesInRange = PrimesInRange(rangeFirst, rangeLast);

            Console.WriteLine("Primes from {0} to {1} calculated. Print now (y/n)?", rangeFirst, rangeLast);
            string userAnswer = Console.ReadLine();

            if (userAnswer == "y" || userAnswer == "Y")
            {
                foreach (var prime in primesInRange)
                {
                    Console.WriteLine(prime);
                }
            }
        }
        static List<int> PrimesInRange(int rangeFirst, int rangeLast)
        {
            List<int> primes = new List<int>();

            for (int number = rangeFirst; number < rangeLast; number++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

       
    }
}
