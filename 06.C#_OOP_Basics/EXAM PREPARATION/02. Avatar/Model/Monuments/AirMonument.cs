using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name) : base(name)
    {
    }

    public int AirAffinity
    {
        get { return this.airAffinity; }
        protected set { this.airAffinity = value; }
    }
}
