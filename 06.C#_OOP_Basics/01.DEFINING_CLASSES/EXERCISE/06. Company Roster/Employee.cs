using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    private string name;
    private double salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee()
    {
    }

    public string Name { get { return this.name; } set { this.name = value; } }
    public double Salary { get { return this.salary; } set { this.salary = value; } }
    public string Position { get { return this.position; } set { this.position = value; } }
    public string Department { get { return this.department; } set { this.department = value; } }
    public string Email { get { return this.email; } set { this.email = value; } }
    public int Age { get { return this.age; } set { this.age = value; } }
}