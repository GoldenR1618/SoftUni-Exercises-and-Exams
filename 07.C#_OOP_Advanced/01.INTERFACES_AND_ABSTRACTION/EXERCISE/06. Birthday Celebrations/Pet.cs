using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pet : IName, IBirthdate
{
    private string name;
    private string birthdate;

    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public string Birthdate
    {
        get { return this.birthdate; }
        protected set { this.birthdate = value; }
    }
}
