using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power) : base(name, power)
    {
    }

    public double HeatAggression
    {
        get { return this.heatAggression; }
        protected set { this.heatAggression = value; }
    }
}
