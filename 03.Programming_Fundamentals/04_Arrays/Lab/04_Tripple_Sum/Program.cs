using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  //3 -> 0 6 6

            var counter = 0;

            for (int a = 0; a < arr.Length; a++)            //От 0 до 2
            {
                for (int b = a + 1; b < arr.Length; b++)    //От 1 до 2
                {
                    for (int c = 0; c < arr.Length; c++)    //От 0 до 2
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            Console.WriteLine(arr[a] + " + " + arr[b] + " == " + arr[c]);
                            counter++;
                            break;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
