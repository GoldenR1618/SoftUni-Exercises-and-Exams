namespace _03_Equal_Sums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class EqualSums
    {
        public static void Main(string[] args)
        {
            int[] input = File.ReadAllText("input6.txt").Split(' ').Select(int.Parse).ToArray();

            int storIndex = 0;

            for (int index = 0; index < input.Length; index++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int left = 0; left < index; left++)
                {
                    sumLeft += input[left];
                }

                for (int right = index + 1; right < input.Length; right++)
                {
                    if (index + 1 >= input.Length)
                    {
                        sumRight = 0;
                    }
                    else
                    {
                        sumRight += input[right];
                    }
                }

                if (sumLeft == sumRight)
                {
                    storIndex = index;
                    break;
                }
            }

            var output = "output6.txt";

            if (storIndex > 0)
            {
                File.AppendAllText(output, storIndex.ToString());
            }
            else if (input.Length < 2)
            {
                File.AppendAllText(output, "0");
            }
            else
            {
                File.AppendAllText(output, "no");
            }

            
        }
    }
}
