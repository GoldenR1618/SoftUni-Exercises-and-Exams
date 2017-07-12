using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name) : base(name)
    {
    }

    public int EarthAffinity
    {
        get { return this.earthAffinity; }
        protected set { this.earthAffinity = value; }
    }
}
