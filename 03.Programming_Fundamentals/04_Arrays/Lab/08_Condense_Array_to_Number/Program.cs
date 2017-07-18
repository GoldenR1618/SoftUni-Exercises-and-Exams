using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condense_Array_to_Number
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  //5 -> 5 0 4 1 2

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                int result = 0;
                int firstLengthTempArr = arr.Length - 1;        //4

                for (int i = 0; i < firstLengthTempArr; i++)    //От 0 до 3
                {
                    int[] tempArr = new int[arr.Length - 1];    //4

                    for (int j = 0; j < tempArr.Length; j++)    //От 0 до 3
                    {
                        tempArr[j] = arr[j] + arr[j + 1];       //0: 5 4 5 3  
                    }

                    arr = tempArr;
                    result = tempArr[0];
                }

                Console.WriteLine(result);
            }
        }
    }
}
