using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Test_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<double> nums = new List<double>();

            foreach (string num in input)
            {
                nums.Add(double.Parse(num));
            }

            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}