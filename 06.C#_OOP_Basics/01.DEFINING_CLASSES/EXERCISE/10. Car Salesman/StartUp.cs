using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        List<Engine> listOfEngines = new List<Engine>();
        List<Car> listOfCars = new List<Car>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string model = input1[0];
            double power = double.Parse(input1[1]);
            string displacement = "n/a";
            string efficiency = "n/a";

            if (input1.Length == 3)
            {
                double parsedNum = 0;

                if (!double.TryParse(input1[2], out parsedNum))
                {
                    efficiency = input1[2];
                }
                else
                {
                    displacement = parsedNum.ToString();
                }
            }

            if (input1.Length == 4)
            {
                displacement = input1[2];
                efficiency = input1[3];
            }

            Engine current = new Engine
            {
                Model = model,
                Power = power,
                Displacement = displacement,
                Efficiency = efficiency
            };

            listOfEngines.Add(current);
        }

        int m = int.Parse(Console.ReadLine());

        for (int j = 0; j < m; j++)
        {
            string[] input2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string model = input2[0];
            string engine = input2[1];
            string weight = "n/a";
            string color = "n/a";

            if (input2.Length == 3)
            {
                double parsedNum = 0;

                if (!double.TryParse(input2[2], out parsedNum))
                {
                    color = input2[2];
                }
                else
                {
                    weight = parsedNum.ToString();
                }
            }

            if (input2.Length == 4)
            {
                weight = input2[2];
                color = input2[3];
            }

            Car current = new Car
            {
                Model = model,
                Engine = engine,
                Weight = weight,
                Color = color
            };

            listOfCars.Add(current);
        }

        foreach (var car in listOfCars)
        {
            Engine thisEngine = listOfEngines.Where(x => x.Model == car.Engine).First();

            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine}:");
            Console.WriteLine($"    Power: {thisEngine.Power}");
            Console.WriteLine($"    Displacement: {thisEngine.Displacement}");
            Console.WriteLine($"    Efficiency: {thisEngine.Efficiency}");
            Console.WriteLine($"  Weight: {car.Weight}");
            Console.WriteLine($"  Color: {car.Color}");
        }
    }
}
