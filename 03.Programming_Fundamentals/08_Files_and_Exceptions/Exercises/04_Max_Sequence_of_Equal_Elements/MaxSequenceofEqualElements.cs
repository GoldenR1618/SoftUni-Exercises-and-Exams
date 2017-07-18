namespace _04_Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class MaxSequenceofEqualElements
    {
        public static void Main(string[] args)
        {
            List<int> input = File.ReadAllText("input4.txt").Split(' ').Select(int.Parse).ToList();

            int currentNumber = 0;
            int currentSeq = 1;

            int maxNumber = 0;
            int maxSeq = 0;

            for (int i = 0; i < input.Count -1; i++)
            {
                currentNumber = input[i];

                if (input[i] == input[i + 1])
                {
                    currentSeq++;
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxNumber = currentNumber;
                        maxSeq = currentSeq;
                    }

                    currentNumber = 0;
                    currentSeq = 1;
                }
            }

            if (currentSeq > maxSeq)
            {
                maxNumber = currentNumber;
                maxSeq = currentSeq;
            }

            if (maxSeq < 2)
            {
                File.AppendAllText("output4.txt", "0");
            }
            else
            {
                for (int i = 1; i <= maxSeq; i++)
                {
                    File.AppendAllText("output4.txt", maxNumber.ToString() + " ");
                }
            } 
        }
    }
}
