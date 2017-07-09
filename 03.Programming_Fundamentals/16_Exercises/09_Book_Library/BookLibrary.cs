namespace _09_Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Globalization;

    public class BookLibrary
    {
        public static void Main(string[] args)
        {
            List<Book> listOfbooks = new List<Book>();

            string[] input = File.ReadAllLines("input.txt");

            for (int i = 1; i < input.Length; i++)
            {
                string[] currentRow = input[i].Split(' ');

                string title = currentRow[0];
                string author = currentRow[1];
                string publisher = currentRow[2];
                DateTime releaseDate = DateTime.ParseExact(currentRow[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = currentRow[4];
                decimal price = decimal.Parse(currentRow[5]);

                Book currentBook = new Book()
                {
                    Title = title,
                    Author = author,
                    Publishet = publisher,
                    ReleaseDate = releaseDate,
                    ISBN = isbn,
                    Price = price
                };

                listOfbooks.Add(currentBook);
            }

            foreach (var item in listOfbooks.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Author))
            {
                File.AppendAllText("output.txt", $"{item.Author} -> {item.ReleaseDate}{Environment.NewLine}");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publishet { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }
    }
}
