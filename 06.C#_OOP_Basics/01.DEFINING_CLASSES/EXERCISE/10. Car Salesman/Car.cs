using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model;
    private string engine;
    private string weight;
    private string color;

    public string Model { get { return this.model; } set { this.model = value; } }
    public string Engine { get { return this.engine; } set { this.engine = value; } }
    public string Weight { get { return this.weight; } set { this.weight = value; } }
    public string Color { get { return this.color; } set { this.color = value; } }
}
