namespace _05.NoThreadSafety
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
            while (numbers.Count > 0)
            {
                int lastIndex = numbers.Count - 1;
                numbers.RemoveAt(lastIndex);
            }
        }
    }
}
