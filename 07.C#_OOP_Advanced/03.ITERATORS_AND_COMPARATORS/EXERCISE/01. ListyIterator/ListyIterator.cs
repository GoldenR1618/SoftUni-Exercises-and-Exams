using System;
using System.Collections.Generic;

public class ListyIterator<T>
{
    private IList<T> data;
    private int index;

    public ListyIterator(IEnumerable<T> items)
    {
        this.Data = new List<T>(items);
    }

    public IList<T> Data
    {
        get { return this.data; }
        private set { this.data = value; }
    }

    public bool HasNext()
    {
        if ((this.index + 1) < this.Data.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Move()
    {
        if (HasNext())
        {
            this.index++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Print()
    {
        if (this.Data.Count > 0)
        {
            Console.WriteLine(this.Data[this.index]);
        }
        else
        {
            throw new ArgumentException("Invalid Operation!");
        }
    }
}
