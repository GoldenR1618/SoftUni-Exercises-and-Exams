using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    protected double Radius
    {
        get { return this.radius; }
        private set { this.radius = value; }
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(this.Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return Math.PI * 2 * this.Radius;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}
