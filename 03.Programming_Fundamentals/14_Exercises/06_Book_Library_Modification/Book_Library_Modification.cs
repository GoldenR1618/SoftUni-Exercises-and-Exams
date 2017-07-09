namespace _06_Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class Book_Library_Modification
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
                DateTime release = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
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

            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> libDict = new Dictionary<string, DateTime>();

            foreach (var item in library)
            {
                if (inputDate < item.Release)
                {
                    libDict[item.Title] = item.Release;
                }
            }

            Dictionary<string, DateTime> orderedlibDict = libDict.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in orderedlibDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:dd.MM.yyyy}");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime Release { get; set; }

        public string ISBNnumber { get; set; }

        public decimal Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
