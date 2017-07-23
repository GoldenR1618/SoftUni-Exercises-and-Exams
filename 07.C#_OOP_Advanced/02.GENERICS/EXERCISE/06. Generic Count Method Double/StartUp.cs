using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        List<Box<double>> listOfBoxes = new List<Box<double>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            listOfBoxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
        }

        Box<double> compare = new Box<double>(double.Parse(Console.ReadLine()));

        Console.WriteLine(CountGreaterThanComparisonValue(listOfBoxes, compare));
    }

    private static int CountGreaterThanComparisonValue<T>(IEnumerable<T> collection, T comparisonValue) where T : IComparable<T>
    {
        var count = 0;

        foreach (var item in collection)
        {
            if (item.CompareTo(comparisonValue) > 0)
            {
                count++;
            }
        }

        return count;
    }
}
