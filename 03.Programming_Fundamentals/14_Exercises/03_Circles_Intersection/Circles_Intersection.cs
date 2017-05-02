namespace _03_Circles_Intersection
{
    using System;
    using System.Linq;

    public class Circles_Intersection
    {
        public static void Main(string[] args)
        {
            double[] firstCircleInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondCircleInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var x1 = firstCircleInput[0];
            var y1 = firstCircleInput[1];
            var radius1 = firstCircleInput[2];

            var x2 = secondCircleInput[0];
            var y2 = secondCircleInput[1];
            var radius2 = secondCircleInput[2];

            Point firstCenter = new Point(x1, y1);
            Point secondCenter = new Point(x2, y2);

            Circle firstCircle = new Circle(firstCenter, radius1);
            Circle secondCircle = new Circle(secondCenter, radius2);

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class Circle
    {
        public Point Center { get; set; }

        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            double d = Point.CalculateDistance(c1.Center, c2.Center);

            if (d <= c1.Radius + c2.Radius)
            {
                return true;
            }

            return false;
        }
    }

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }
    }
}
