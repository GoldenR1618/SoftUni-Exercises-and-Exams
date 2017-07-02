using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private double money;
    private List<Product> bag;

    public string Name
    {
        set
        {
            if (value == null || value == "" || value == " ")
            {
                throw new ArgumentException("Name cannot be an empty string.");
            }

            this.name = value;
        }
    }

    public double Money
    {
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be a negative number.");
            }

            this.money = value;
        }
    }
}
