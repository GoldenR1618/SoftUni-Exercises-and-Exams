using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person : IPerson
{
    private string name;
    private string id;

    public Person(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }
    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }
}
