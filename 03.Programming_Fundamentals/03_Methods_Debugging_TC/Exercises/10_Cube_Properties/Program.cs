using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            double face = Math.Sqrt(side * side + side * side);
            double space = Math.Sqrt(face * face + side * side);
            double volume = side * side * side;
            double area = side * side * 6;

            switch (parameter)
            {
                case "face": Console.WriteLine($"{face:F2}"); break;
                case "space": Console.WriteLine($"{space:F2}"); break;
                case "volume": Console.WriteLine($"{volume:F2}"); break;
                case "area": Console.WriteLine($"{area:F2}"); break;
                default:
                    break;
            }
        }
    }
}
