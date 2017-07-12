using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterMonument : Monument
{
    private int waterAffinity ;

    public WaterMonument(string name) : base(name)
    {
    }

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
        protected set { this.waterAffinity = value; }
    }
}
