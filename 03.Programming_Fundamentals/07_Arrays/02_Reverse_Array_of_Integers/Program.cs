using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reverse_Array_of_Integers
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

            for (int i = arr.Length - 1; i >= 0 ; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
