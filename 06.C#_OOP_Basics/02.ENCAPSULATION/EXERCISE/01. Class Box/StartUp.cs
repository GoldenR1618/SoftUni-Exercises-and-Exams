using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Box box = new Box(length, width, height);


        Console.WriteLine(box.SurfaceArea());
        Console.WriteLine(box.LateralSurfaceArea());
        Console.WriteLine(box.Volume());
    }
}