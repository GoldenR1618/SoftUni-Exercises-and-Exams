using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Truck : Vehicles
{
    public Truck(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
    {
    }

    public override void Drive(double distance)
    {
        double maxDistance = base.FuelQuantity / base.LitersPerKm;

        if (maxDistance >= distance)
        {
            Console.WriteLine($"Truck travelled {distance} km");
            base.FuelQuantity -= distance * base.LitersPerKm;
        }
        else
        {
            Console.WriteLine("Truck needs refueling");
        }
    }

    public override void Refuel(double liters)
    {
        base.FuelQuantity += (liters * 0.95);
    }

    public override string ToString()
    {
        return "Truck: " + base.ToString();
    }
}
