using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        List<Box<int>> listOfBoxes = new List<Box<int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            listOfBoxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
        }

        int[] swapIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Swap(listOfBoxes, swapIndexes[0], swapIndexes[1]);

        listOfBoxes.ForEach(str => Console.WriteLine(str));
    }

    private static void Swap<T>(IList<T> collection, int indexToSwap, int swapWithIndex)
    {
        var temp = collection[indexToSwap];
        collection[indexToSwap] = collection[swapWithIndex];
        collection[swapWithIndex] = temp;
    }
}
