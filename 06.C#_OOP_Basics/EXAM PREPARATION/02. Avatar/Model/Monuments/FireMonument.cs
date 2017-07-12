using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name) : base(name)
    {
    }

    public int FireAffinity
    {
        get { return this.fireAffinity; }
        protected set { this.fireAffinity = value; }
    }
}
