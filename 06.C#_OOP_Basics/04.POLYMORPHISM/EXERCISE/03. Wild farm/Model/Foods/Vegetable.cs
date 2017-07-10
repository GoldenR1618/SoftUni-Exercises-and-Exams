using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Vegetable : Food
{
    public Vegetable(int quantity) : base(quantity)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}