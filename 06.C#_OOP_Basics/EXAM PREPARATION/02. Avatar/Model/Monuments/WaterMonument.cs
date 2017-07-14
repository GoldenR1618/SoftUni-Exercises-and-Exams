using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
        protected set { this.waterAffinity = value; }
    }

    public override string ToString()
    {
        return "Water " + base.ToString() + $"Water Affinity: {WaterAffinity}";
    }
}
