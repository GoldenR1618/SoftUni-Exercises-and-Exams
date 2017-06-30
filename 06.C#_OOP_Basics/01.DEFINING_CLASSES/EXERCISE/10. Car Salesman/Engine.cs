using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private string model;
    private double power;
    private string displacement;
    private string efficiency;

    public string Model { get { return this.model; } set { this.model = value; } }
    public double Power { get { return this.power; } set { this.power = value; } }
    public string Displacement { get { return this.displacement; } set { this.displacement = value; } }
    public string Efficiency { get { return this.efficiency; } set { this.efficiency = value; } }
}
