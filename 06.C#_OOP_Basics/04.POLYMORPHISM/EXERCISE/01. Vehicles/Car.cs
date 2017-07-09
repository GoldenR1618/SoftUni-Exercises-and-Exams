using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicles
{
    public Car(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
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
        base.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return "Car: " + base.ToString();
    }
}
