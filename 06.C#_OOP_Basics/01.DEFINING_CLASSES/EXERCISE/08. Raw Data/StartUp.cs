using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        List<Car> list = new List<Car>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            string model = input[0];
            double engineSpeed = double.Parse(input[1]);
            double enginePower = double.Parse(input[2]);
            double cargoWeight = double.Parse(input[3]);
            string cargoType = input[4];
            double tire1Pressure = double.Parse(input[5]);
            double tire1Age = double.Parse(input[6]);
            double tire2Pressure = double.Parse(input[7]);
            double tire2Age = double.Parse(input[8]);
            double tire3Pressure = double.Parse(input[9]);
            double tire3Age = double.Parse(input[10]);
            double tire4Pressure = double.Parse(input[11]);
            double tire4Age = double.Parse(input[12]);

            Car current = new Car(model,
                engineSpeed, enginePower,
                cargoWeight, cargoType,
                tire1Pressure, tire1Age,
                tire2Pressure, tire2Age,
                tire3Pressure, tire3Age,
                tire4Pressure, tire4Age);

            list.Add(current);
        }

        string command = Console.ReadLine();

        switch (command)
        {
            case "fragile":
                var result = list.Where(x => x.Cargo.CargoType == "fragile" &&
                (x.Tires.Tire1Pressure < 1 ||
                x.Tires.Tire2Pressure < 1 ||
                x.Tires.Tire3Pressure < 1 ||
                x.Tires.Tire4Pressure < 1));

                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
                break;

            case "flamable":
                var result2 = list.Where(x => x.Cargo.CargoType == "flamable" &&
                x.Engine.EnginePower > 250);

                foreach (var car in result2)
                {
                    Console.WriteLine(car.Model);
                }
                break;

            default:
                break;
        }
    }
}
