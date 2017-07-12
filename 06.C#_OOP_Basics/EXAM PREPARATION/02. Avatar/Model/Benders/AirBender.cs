using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power) : base(name, power)
    {
    }

    public double AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        protected set { this.aerialIntegrity = value; }
    }
}
