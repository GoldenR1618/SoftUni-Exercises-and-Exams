using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        protected set { this.groundSaturation = value; }
    }

    public override double TotalPower()
    {
        return base.Power * this.GroundSaturation;
    }

    public override string ToString()
    {
        return "Earth " + base.ToString() + $"Ground Saturation: {groundSaturation:F2}";
    }
}
