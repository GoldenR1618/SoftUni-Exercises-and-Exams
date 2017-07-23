using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box<T>
{
    public Box()
    {
        this.Value = default(T);
    }

    public Box(T value)
    {
        this.Value = value;
    }

    public T Value { get; set; }

    public override string ToString()
    {
        return $"{typeof(T).FullName}: {this.Value}";
    }
}
