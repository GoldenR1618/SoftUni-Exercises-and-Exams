namespace _02.Async
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Task task = new Task(() => PrintNumbersInRange(n));
            task.Start();
            Console.WriteLine("Main thread is done");
            task.Wait();
        }
        private static void PrintNumbersInRange(int bound)
        {
            for (int i = 0; i <= bound; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread {0} is done", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
