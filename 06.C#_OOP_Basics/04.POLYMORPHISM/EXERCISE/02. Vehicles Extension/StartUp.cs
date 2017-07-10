using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        string[] line1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] line2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] line3 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(Console.ReadLine());

        Car car = new Car(double.Parse(line1[1]), (double.Parse(line1[2]) + 0.9), double.Parse(line1[3]));
        Truck truck = new Truck(double.Parse(line2[1]), (double.Parse(line2[2]) + 1.6), double.Parse(line2[3]));
        Bus bus = new Bus(double.Parse(line3[1]), (double.Parse(line3[2]) + 1.4), double.Parse(line3[3]));

        for (int i = 0; i < n; i++)
        {
            try
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
                string typeVehicle = input[1];
                double distanceOrLiters = double.Parse(input[2]);

                switch (command)
                {
                    case "Drive":
                        if (typeVehicle == "Car")
                        {
                            car.Drive(distanceOrLiters);
                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.Drive(distanceOrLiters);
                        }
                        else if (typeVehicle == "Bus")
                        {
                            bus.Drive(distanceOrLiters);
                        }

                        break;

                    case "Refuel":
                        if (typeVehicle == "Car")
                        {
                            car.Refuel(distanceOrLiters);
                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.Refuel(distanceOrLiters);
                        }
                        else if (typeVehicle == "Bus")
                        {
                            bus.Refuel(distanceOrLiters);
                        }

                        break;

                    case "DriveEmpty":
                        bus.DriveEmpty(distanceOrLiters);
                        break;

                    default: break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}