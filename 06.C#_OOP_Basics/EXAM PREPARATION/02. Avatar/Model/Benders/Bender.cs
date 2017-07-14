﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public int Power
    {
        get { return this.power; }
        protected set { this.power = value; }
    }

    public abstract double TotalPower();

    public override string ToString()
    {
        return $"Bender: {Name}, Power: {Power}, ";
    }
}
