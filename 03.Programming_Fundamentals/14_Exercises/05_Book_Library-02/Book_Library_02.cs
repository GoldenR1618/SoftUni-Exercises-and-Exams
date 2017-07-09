namespace _05_Book_Library_02
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Book_Library_02
    {
        static void Main(string[] args)
        {
            int numberOfBooks = Int32.Parse(Console.ReadLine());
            Library lib = new Library();
            lib.Books = new List<Book>();
            lib.Name = "OMFG";

            for (int i = 0; i < numberOfBooks; i++)
            {
                Book currentBook = Book.ReadBook();
                lib.Books.Add(currentBook);
            }

            Dictionary<string, decimal> libDict = new Dictionary<string, decimal>();

            foreach (var book in lib.Books)
            {
                if (!libDict.ContainsKey(book.Author))
                {
                    libDict.Add(book.Author, book.Price);
                }
                else
                {
                    libDict[book.Author] += book.Price;
                }
            }

            var toPrint = libDict.OrderByDescending(r => r.Value).ThenBy(r => r.Key);

            foreach (var pair in toPrint)
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static Book ReadBook()
        {
            var tokens = Console.ReadLine().Split(' ').ToList();
            decimal price = Decimal.Parse(tokens[5]);
            DateTime date = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Book book = new Book() { Title = tokens[0], Author = tokens[1], Publisher = tokens[2], ReleaseDate = date, ISBN = tokens[4], Price = price };
            return book;
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
