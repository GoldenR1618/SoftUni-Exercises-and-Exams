using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private Company company = new Company();
    private List<Pokemon> pokemon = new List<Pokemon>();
    private List<Parents> parents = new List<Parents>();
    private List<Children> children = new List<Children>();
    private Car car = new Car();

    public string Name { get { return this.name; } set { this.name = value; } }
    public Company Company { get { return this.company; } set { this.company = value; } }
    public List<Pokemon> Pokemon { get { return this.pokemon; } set { this.pokemon = value; } }
    public List<Parents> Parents { get { return this.parents; } set { this.parents = value; } }
    public List<Children> Children { get { return this.children; } set { this.children = value; } }
    public Car Car { get { return this.car; } set { this.car = value; } }
}
