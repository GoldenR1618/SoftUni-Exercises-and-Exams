using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicles
{
    private double fuelQuantity;
    private double litersPerKm;

    public Vehicles(double fuelQuantity, double litersPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = litersPerKm;
    }

    public double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        protected set
        {
            this.fuelQuantity = value;
        }
    }
    public double LitersPerKm
    {
        get
        {
            return this.litersPerKm;
        }
        protected set
        {
            this.litersPerKm = value;
        }
    }

    public abstract void Drive(double distanceOrLiters);
    public abstract void Refuel(double distanceOrLiters);
    public override string ToString()
    {
        return $"{this.FuelQuantity:F2}";
    }
}
