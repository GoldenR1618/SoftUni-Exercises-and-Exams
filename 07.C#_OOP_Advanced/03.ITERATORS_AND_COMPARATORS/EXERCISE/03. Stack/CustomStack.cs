using System;
using System.Collections;
using System.Collections.Generic;

internal class CustomStack<T> : IEnumerable<T>
{
    private IList<T> data;

    public CustomStack()
    {
        this.Data = new List<T>();
    }

    public IList<T> Data
    {
        get { return this.data; }
        private set { this.data = value; }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Data.Count - 1; i >= 0; i--)
        {
            yield return this.Data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public void Push(T[] elements)
    {
        foreach (var item in elements)
        {
            this.Data.Add(item);
        }   
    }

    public void Pop()
    {
        if (Data.Count == 0)
        {
            throw new ArgumentException("No elements");
        }

        this.Data.RemoveAt(this.Data.Count - 1);
    }
}