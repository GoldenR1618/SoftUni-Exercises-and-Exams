using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sum_Reversed_Numbers
{
    class Sum_Reversed_Numbers
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();  //123 234 12

            List<string> reverseTextNums = new List<string>();

            string temp = "";
            string result = "";

            for (int i = 0; i < nums.Count; i++)
            {
                temp = nums[i];

                for (int r = temp.Length - 1; r >= 0; r--)
                {
                   result = result + temp[r];
                }

                reverseTextNums.Add(result);
                temp = "";
                result = "";
            }

            int sum = 0;

            for (int k = 0; k < reverseTextNums.Count; k++)
            {
                sum = sum + int.Parse(reverseTextNums[k]);
            }

            Console.WriteLine(sum);
        }
    }
}
