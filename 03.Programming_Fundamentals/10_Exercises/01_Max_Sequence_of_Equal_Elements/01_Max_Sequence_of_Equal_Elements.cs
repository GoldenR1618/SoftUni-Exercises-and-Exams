using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Max_Sequence_of_Equal_Elements
{
    class Max_Sequence_of_Equal_Elements
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();  //3 4 4 5 5 5 2 2

            List<int> temptList = new List<int>();  //2 2
            List<int> finalList = new List<int>();  //5 5 5

            int counter = 1;    //2
            int maxCounter = 1; //3

            temptList.Add(nums[0]);

            for (int i = 0; i < nums.Count - 1; i++)    //6
            {
                if (nums[i] == nums[i + 1]) //2 == 2
                {
                    counter++;
                    temptList.Add(nums[i + 1]);
                }
                else
                {
                    counter = 1;
                    temptList.Clear();
                    temptList.Add(nums[i + 1]);
                }

                if (counter > maxCounter)
                {
                    finalList.Clear();
                    maxCounter = counter;
                    finalList.AddRange(temptList);
                }
            }

            if (maxCounter == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                Console.WriteLine(string.Join(" ", finalList));
            }
        }
    }
}
