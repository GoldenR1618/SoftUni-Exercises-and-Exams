using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicles
{
    public Car(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        double maxDistance = base.FuelQuantity / base.LitersPerKm;

        if (maxDistance >= distance)
        {
            Console.WriteLine($"Car travelled {distance} km");
            base.FuelQuantity -= distance * base.LitersPerKm;
        }
        else
        {
            Console.WriteLine("Car needs refueling");
        } 
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (liters > base.TankCapacity - base.FuelQuantity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }

        base.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return "Car: " + base.ToString();
    }
}
