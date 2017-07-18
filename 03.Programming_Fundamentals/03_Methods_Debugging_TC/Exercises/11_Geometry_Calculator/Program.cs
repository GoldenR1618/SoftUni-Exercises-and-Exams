using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            switch (figureType)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double heightTriangle = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0:F2}", (sideTriangle * heightTriangle) / 2);
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0:F2}", sideSquare * sideSquare);
                    break;
                case "rectangle":
                    double widthRectangle = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0:F2}", widthRectangle * heightRectangle);
                    break;
                case "circle":
                    double radiusCircle = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0:F2}", Math.PI * radiusCircle * radiusCircle);
                    break;
                default:
                    break;
            }
        }
    }
}
