using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Closest_Two_Points
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 1; i <= n; i++)
            {
                double[] currentPointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                var currentPoint = new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                };

                points.Add(currentPoint);
            }

            var minDistanceSoFar = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var cuurentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (cuurentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = cuurentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine(minDistanceSoFar);
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
        }

        public static double CalculateDistance(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }

    }

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }
    }
}
