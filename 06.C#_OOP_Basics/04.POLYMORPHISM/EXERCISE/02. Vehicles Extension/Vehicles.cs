using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicles
{
    private double fuelQuantity;
    private double litersPerKm;
    private double tankCapacity;

    public Vehicles(double fuelQuantity, double litersPerKm, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = litersPerKm;
        this.TankCapacity = tankCapacity;
    }

    public double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

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
    public double TankCapacity
    {
        get
        {
            return this.tankCapacity;
        }
        protected set
        {
            this.tankCapacity = value;
        }
    }

    public abstract void Drive(double distanceOrLiters);
    public abstract void Refuel(double distanceOrLiters);
    public override string ToString()
    {
        return $"{this.FuelQuantity:F2}";
    }
}
