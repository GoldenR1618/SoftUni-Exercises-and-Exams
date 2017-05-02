namespace _02_Advertisement_Message
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Advertisement_Message
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{phrases[random.Next(0, phrases.Length)]} {events[random.Next(0, events.Length)]} {author[random.Next(0, author.Length)]} {cities[random.Next(0, cities.Length)]}");
            }
        }
    }
}
