using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private int age;

    public Person()
    {

    }

    public Person(int age)

    {
        this.Name = name;
        this.Age = age;
    }

    public Person(string name, int age)

    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get { return this.name; } set { this.name = value; } }
    public int Age { get { return this.age; } set { this.age = value; } }
}
