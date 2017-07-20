using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : Person
{
    private int age;

    public Citizen(string name, int age, string id) : base(name, id)
    {
        this.Age = age;
    }

    public int Age
    {
        get { return this.age; }
        protected set { this.age = value; }
    }
}
