using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public string Volume()
    {
        return String.Format("Volume - {0:F2}", this.length * this.width * this.height);
    }

    public string LateralSurfaceArea()
    {
        return String.Format("Lateral Surface Area - {0:F2}", this.width * this.height * 2 + this.length * this.height * 2);
    }

    public string SurfaceArea()
    {
        return String.Format("Surface Area - {0:F2}", this.width * this.height * 2 + this.length * this.height * 2 + this.length * this.width * 2);
    }
}