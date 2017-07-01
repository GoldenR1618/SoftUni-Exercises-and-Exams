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
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
    public string LastName { get { return this.lastName; } set { this.lastName = value; } }
    public int Age { get { return this.age; } set { this.age = value; } }
    public double Salary { get { return this.salary; } set { this.salary = value; } }

    public void IncreaseSalary(double bonus)
    {
        double amount = this.salary * (bonus / (double)100);

        if (this.age < 30)
        {
            this.salary += (amount / 2);
        }
        else
        {
            this.salary += amount;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.salary:F2} leva";
    }
}