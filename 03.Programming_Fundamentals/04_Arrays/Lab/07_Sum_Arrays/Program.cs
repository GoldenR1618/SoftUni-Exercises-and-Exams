using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();    //1 1 1 1 1
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();    //2 2 2

            if (arr1.Length > arr2.Length)  //5 > 3
            {
                int biggerArr = arr1.Length;    //5

                for (int i = 0; i <= arr1.Length; i++)  //От 0 до 5
                {
                    biggerArr = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);    //

                    if (i >= arr1.Length)
                    {
                        break;
                    }

                    Console.Write(biggerArr + " ");
                }
            }
            else
            {
                int biggerArr = arr2.Length;

                for (int i = 0; i <= arr2.Length; i++)
                {
                    biggerArr = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);

                    if (i >= arr2.Length)
                    {
                        break;
                    }

                    Console.Write(biggerArr + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
