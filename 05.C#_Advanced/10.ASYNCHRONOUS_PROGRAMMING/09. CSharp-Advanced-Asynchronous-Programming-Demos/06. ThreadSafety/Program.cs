namespace _06.ThreadSafety
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static List<int> numbers;
        static void Main(string[] args)
        {
            numbers = Enumerable.Range(0, 10000).ToList();

            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 4; i++)
            {
                Task task = new Task(() => RemoveAllElements());

                tasks.Add(task);
                task.Start();
            }

            foreach (var thread in tasks)
            {
                try
                {
                    thread.Wait();
                }
                catch (AggregateException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }

            }
        }
        static void RemoveAllElements()
        {
            int currentId = Thread.CurrentThread.ManagedThreadId;
            while (numbers.Count > 0)
            {
                lock (numbers)
                {
                    int lastIndex = numbers.Count - 1;
                    if (lastIndex < 0)
                    {
                        break;
                    }
                    numbers.RemoveAt(lastIndex);
                }
            }
            Console.WriteLine("{0} grabbed and went", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
