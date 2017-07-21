using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IPerson, IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food = 0;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
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

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public string Birthdate
    {
        get { return this.birthdate; }
        protected set { this.birthdate = value; }
    }

    public int Food
    {
        get { return this.food; }
        protected set { this.food = value; }
    }

    public void BuyFood()
    {
        food += 10;
    }
}
