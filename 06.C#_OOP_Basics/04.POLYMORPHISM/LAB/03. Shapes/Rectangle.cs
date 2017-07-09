﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    protected double Height
    {
        get { return this.height; }
        private set { this.height = value; }
    }

    protected double Width
    {
        get { return this.width; }
        private set { this.width = value; }
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }

    public override double CalculatePerimeter()
    {
        return (2 * this.Height) + (2 * this.Width);
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
