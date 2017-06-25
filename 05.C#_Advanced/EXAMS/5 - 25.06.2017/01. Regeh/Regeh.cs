namespace _01.Regeh
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Regeh
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\[.+?<(\d+)REGEH(\d+)>.+?\]";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);


            List<int> nums = new List<int>();   //4 22 16 30

            foreach (Match match in matches)
            {
                nums.Add(int.Parse(match.Groups[1].Value));
                nums.Add(int.Parse(match.Groups[2].Value));
            }

            List<int> indexs = new List<int>();  //4 26 42 72

            for (int i = 0; i < nums.Count; i++)
            {
                int curr = 0;

                for (int j = 0; j <= i; j++)
                {
                    curr += nums[j];
                }

                indexs.Add(curr);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var index in indexs)
            {
                if (index < text.Length)
                {
                    sb.Append(text[index]);
                }
                else
                {
                    sb.Append(text[index - text.Length + 1]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
