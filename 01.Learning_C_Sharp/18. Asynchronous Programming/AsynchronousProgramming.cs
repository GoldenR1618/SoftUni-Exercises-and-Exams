namespace Asynchronous_Programming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Net;
    using System.Diagnostics;

    public class AsynchronousProgramming
    {
        public static void Main(string[] args)
        {
            //Threads:
            //Start() – schedules the thread for execution.
            //Join() – waits for the thread to finish its work (blocks the calling thread).
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            });

            thread.Start();



            //Tasks:
            //Creating tasks can be done in several ways:
            Task task = new Task(() => { Console.WriteLine(""); }); //Initialize a new Task object.
            Task.Run(() => Console.WriteLine(""));  //Task.Run()
            Task.Factory.StartNew(() => Console.WriteLine(""), TaskCreationOptions.LongRunning);    //Task.Factory.StartNew() – enables additional task customization.



            //Thread Race Conditions:
            //A race condition occurs when two or more threads access shared data and they try to change it at the same time.
            List<int> numbers = Enumerable.Range(0, 1000000).ToList();
            for (int i = 0; i < 4; i++)
            {
                Task.Run(() =>
                {
                    while (numbers.Count > 0)
                    {
                        int lastIndex = numbers.Count - 1;
                        numbers.RemoveAt(lastIndex);
                    }
                });
            }



            //Thread Safety – lock:
            //lock - keyword grants access to only one thread at a time and avoids race conditions. Blocks any other threads until the lock is released.
            //lock (collection)
            //{
            // code accessing shared resource    // ...
            //}



            //Generic Tasks:
            //Task<T> is a task that will return a result sometime in the future.
            //Result - blocks the calling thread until the task returns a result.
            Task<long> task2 = Task.Run<long>(() =>
            {
                List<int> primes = PrimesInRange(0, 1000000);

                return primes.Sum();
            });

            // ...
            Console.WriteLine(task2.Result);    //Blocking operation - изчаква резултата и тогава продължава.



            //Tasks with async and await:
            //async - hints the compiler that the method might run in parallel.
            //await is used in a method which has the async keyword. Marks waiting for a resource (a task to complete).



        }

        public static async void DownloadFileAsync(string url, string fileName)
        {
            Console.WriteLine("Downloading...");

            await Task.Run(() =>    //The calling thread exits the method on await
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, fileName);
                }
            }); //Everything after that is executed on another thread.

            Console.WriteLine("Download successful.");
            Process.Start(fileName);
        }

        private static List<int> PrimesInRange(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
