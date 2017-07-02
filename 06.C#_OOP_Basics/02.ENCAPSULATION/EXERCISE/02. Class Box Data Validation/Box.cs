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
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    private double Length
    {
        get
        {
            return this.length;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }

            this.length = value;
        }
    }
    private double Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this.width = value;
        }
    }
    private double Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.height = value;
        }
    }

    public string Volume()
    {
        return String.Format("Volume - {0:F2}", this.Length * this.Width * this.Height);
    }

    public string LateralSurfaceArea()
    {
        return String.Format("Lateral Surface Area - {0:F2}", this.Width * this.Height * 2 + this.Length * this.Height * 2);
    }

    public string SurfaceArea()
    {
        return String.Format("Surface Area - {0:F2}", this.Width * this.Height * 2 + this.Length * this.Height * 2 + this.Length * this.Width * 2);
    }
}