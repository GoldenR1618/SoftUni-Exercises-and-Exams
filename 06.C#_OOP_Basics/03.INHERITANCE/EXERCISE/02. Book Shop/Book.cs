using System;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public virtual decimal Price
    {
        get { return this.price; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;
        }
    }

    public string Author
    {
        get { return this.author; }
        protected set
        {
            string[] args = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length > 1)
            {
                if (char.IsDigit(args[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }

            this.author = value;
        }
    }

    public string Title
    {
        get { return this.title; }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this.title = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:F1}")
            .AppendLine();

        return sb.ToString();
    }
}