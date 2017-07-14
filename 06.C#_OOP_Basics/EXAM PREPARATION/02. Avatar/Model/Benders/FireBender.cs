using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression
    {
        get { return this.heatAggression; }
        protected set { this.heatAggression = value; }
    }

    public override double TotalPower()
    {
        return base.Power * this.HeatAggression;
    }

    public override string ToString()
    {
        return "Fire " + base.ToString() + $"Heat Aggression: {heatAggression:F2}";
    }
}
