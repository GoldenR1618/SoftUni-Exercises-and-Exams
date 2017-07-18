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
            string values = Console.ReadLine();

            string[] arr = values.Split(' ').ToArray();

            string[] reversArr = new string[arr.Length];

            for (int i = 0, r = reversArr.Length - 1; i < reversArr.Length; i++, r--)
            {
                reversArr[i] = arr[r];
            }
            Console.WriteLine(string.Join(" ", reversArr));
        }
    }
}
