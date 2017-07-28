using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Lake<T> : IEnumerable<T>
{
    private IList<T> data;

    public Lake(IEnumerable<T> items)
    {
        this.Data = new List<T>(items);
    }

    public IList<T> Data
    {
        get { return this.data; }
        private set { this.data = value; }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Data.Count; i+=2)
        {
            yield return this.Data[i];
        }

        if (this.Data.Count % 2 == 0)
        {
            for (int j = this.Data.Count - 1; j >= 0; j -= 2)
            {
                yield return this.Data[j];
            }
        }
        else
        {
            for (int j = this.Data.Count - 2; j >= 0; j -= 2)
            {
                yield return this.Data[j];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
