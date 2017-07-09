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
        int n = int.Parse(Console.ReadLine());

        Car car = new Car(double.Parse(line1[1]), (double.Parse(line1[2]) + 0.9));
        Truck truck = new Truck(double.Parse(line2[1]), (double.Parse(line2[2]) + 1.6));

        for (int i = 0; i < n; i++)
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

                    break;

                default: break;
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}
