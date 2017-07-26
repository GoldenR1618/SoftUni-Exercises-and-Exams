using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    private string title;
    private int year;
    private IReadOnlyList<string> authors;

    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = authors;
    }

    public string Title
    {
        get { return this.title; }
        private set { this.title = value; }
    }

    public int Year
    {
        get { return this.year; }
        private set { this.year = value; }
    }

    public IReadOnlyList<string> Authors
    {
        get { return this.authors; }
        private set { this.authors = value; }
    }

}