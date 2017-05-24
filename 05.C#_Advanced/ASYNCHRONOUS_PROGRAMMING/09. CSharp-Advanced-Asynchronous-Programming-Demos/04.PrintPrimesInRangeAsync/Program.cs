namespace ManagedThreads
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    class PrimesThread
    {
        static void Main()
        {
            Console.WriteLine("Enter range first:");
            int rangeFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter range last:");
            int rangeLast = int.Parse(Console.ReadLine());

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            Task task  = Task.Factory.StartNew(() =>
            {
                bool finished = false;
                while (!token.IsCancellationRequested && !finished)
                {
                   finished = PrintPrimesInRange(rangeFirst,rangeLast);
                }
            }, token);
            

            Console.WriteLine("What should I do?");
            string command = Console.ReadLine();
            while (true)
            {
                if (command == "stop")
                {
                    tokenSource.Cancel();
                    Console.WriteLine("Process canceled");
                    break;

                }
                else if (command == "exit")
                {
                    break;
                }
                command = Console.ReadLine();
            }
        }

        static bool PrintPrimesInRange(int rangeFirst, int rangeLast)
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

            Console.WriteLine(string.Join(", ", primes));
            return true;
        }
    }
}
