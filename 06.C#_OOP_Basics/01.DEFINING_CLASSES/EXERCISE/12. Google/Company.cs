using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Company
{
    private string companyName;
    private string department;
    private double salary;

    public string CompanyName { get { return this.companyName; } set { this.companyName = value; } }
    public string Department { get { return this.department; } set { this.department = value; } }
    public double Salary { get { return this.salary; } set { this.salary = value; } }
}
