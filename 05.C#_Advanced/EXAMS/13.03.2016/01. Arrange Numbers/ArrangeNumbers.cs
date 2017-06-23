namespace _01.Arrange_Numbers
{
    using System;
    using System.Collections.Generic;

    public class ArrangeNumbers
    {
        public static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            List<string> numNames = new List<string>
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
            };

            SortedDictionary<string, string> result = new SortedDictionary<string, string>();

            for (int i = 0; i < nums.Length; i++)
            {
                string currNum = nums[i];
                string resNum = "";

                for (int j = 0; j < currNum.Length; j++)
                {
                    string currDiggit = currNum[j].ToString();

                    if (j == 0)
                    {
                        resNum = resNum + numNames[int.Parse(currDiggit)];
                    }
                    else
                    {
                        resNum = resNum + "-" + numNames[int.Parse(currDiggit)];
                    }
                }

                if (result.ContainsKey(resNum))
                {
                    result[resNum] += ", " + currNum;
                }
                else
                {
                    result.Add(resNum, currNum);
                }
            }

            Console.WriteLine(string.Join(", ", result.Values));
        }
    }
}
