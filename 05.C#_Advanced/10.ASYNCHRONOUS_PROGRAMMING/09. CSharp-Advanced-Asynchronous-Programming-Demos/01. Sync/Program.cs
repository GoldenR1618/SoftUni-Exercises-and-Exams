namespace _01.Sync
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintNumbersInRange(n);
            Console.WriteLine("Main thread is done");
        }

        private static void PrintNumbersInRange(int bound)
        {
            for (int i = 0; i <= bound; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
