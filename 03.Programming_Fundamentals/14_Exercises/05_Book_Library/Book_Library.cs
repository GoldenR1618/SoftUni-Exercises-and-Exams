namespace _05_Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Book_Library
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> library = new List<Book>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                string release = input[3];
                string isbnNumber = input[4];
                decimal price = decimal.Parse(input[5]);

                Book currentBook = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    Release = release,
                    ISBNnumber = isbnNumber,
                    Price = price
                };

                library.Add(currentBook);
            }

            Dictionary<string, decimal> libDict = new Dictionary<string, decimal>();

            foreach (var item in library)
            {
                if (!libDict.ContainsKey(item.Author))
                {
                    libDict[item.Author] = 0;
                }

                libDict[item.Author] += item.Price;
            }

            var orderedlibDict = libDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var item in orderedlibDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Release { get; set; }

        public string ISBNnumber { get; set; }

        public decimal Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
