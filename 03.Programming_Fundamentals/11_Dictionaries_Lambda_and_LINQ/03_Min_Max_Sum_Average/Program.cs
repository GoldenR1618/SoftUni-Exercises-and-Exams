using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Min_Max_Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] arr = new int[numberOfElements];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {arr.Sum()}");
            Console.WriteLine($"Min = {arr.Min()}");
            Console.WriteLine($"Max = {arr.Max()}");
            Console.WriteLine($"Average = {arr.Average()}");
        }
    }
}
