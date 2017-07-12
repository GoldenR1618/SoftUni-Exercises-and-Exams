using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power) : base(name, power)
    {
    }

    public double WaterClarity
    {
        get { return this.waterClarity; }
        protected set { this.waterClarity = value; }
    }
}
