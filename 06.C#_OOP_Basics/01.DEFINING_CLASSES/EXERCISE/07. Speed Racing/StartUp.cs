using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        Car car = new Car();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split(' ');

            string model = args[0];
            double fuelAmount = double.Parse(args[1]);
            double fuelConsumptionFor1km = double.Parse(args[2]);

            Car current = new Car
            {
                Model = model,
                FuelAmount = fuelAmount,
                FuelConsumptionFor1km = fuelConsumptionFor1km
            };

            car.AddCar(current);
        }

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] commands = input.Split(' ');

            string model = commands[1];
            double amountOfKm = double.Parse(commands[2]);

            car.CanMoveThatDistance(model, amountOfKm);

            input = Console.ReadLine();
        }

        car.PrintCars();
    }
}
