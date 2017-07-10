using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Food
{    
    private int quantity;

    public Food(int quantity)
    {
        this.Quantity = quantity;
    }

    public int Quantity
    {
        get
        {
            return this.quantity;
        }
        protected set
        {
            this.quantity = value;
        }
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
