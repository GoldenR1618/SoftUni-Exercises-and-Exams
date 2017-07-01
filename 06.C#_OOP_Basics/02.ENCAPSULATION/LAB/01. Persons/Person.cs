using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
    public string LastName { get { return this.lastName; } set { this.lastName = value; } }
    public int Age { get { return this.age; } set { this.age = value; } }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is a {this.age} years old";
    }
}