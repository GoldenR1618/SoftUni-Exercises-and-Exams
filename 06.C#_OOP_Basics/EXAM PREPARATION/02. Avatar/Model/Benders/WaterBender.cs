﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public double WaterClarity
    {
        get { return this.waterClarity; }
        protected set { this.waterClarity = value; }
    }

    public override double TotalPower()
    {
        return base.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        return "Water " + base.ToString() + $"Water Clarity: {waterClarity:F2}";
    }
}
