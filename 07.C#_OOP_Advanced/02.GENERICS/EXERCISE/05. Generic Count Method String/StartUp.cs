using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        List<Box<string>> listOfBoxes = new List<Box<string>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            listOfBoxes.Add(new Box<string>(Console.ReadLine()));
        }

        Box<string> compare = new Box<string>(Console.ReadLine());

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
