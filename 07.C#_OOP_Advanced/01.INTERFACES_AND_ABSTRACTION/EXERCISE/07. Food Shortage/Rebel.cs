using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rebel : IPerson, IBuyer
{
    private string name;
    private int age;
    private string group;
    private int food = 0;

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        protected set { this.age = value; }
    }

    public string Group
    {
        get { return this.group; }
        protected set { this.group = value; }
    }

    public int Food
    {
        get { return this.food; }
        protected set { this.food = value; }
    }

    public void BuyFood()
    {
        food += 5;
    }
}
