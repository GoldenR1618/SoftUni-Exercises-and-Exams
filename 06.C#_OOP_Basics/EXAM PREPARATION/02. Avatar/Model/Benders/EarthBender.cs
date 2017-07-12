using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power) : base(name, power)
    {
    }

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        protected set { this.groundSaturation = value; }
    }
}
