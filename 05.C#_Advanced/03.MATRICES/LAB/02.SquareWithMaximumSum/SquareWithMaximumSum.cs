namespace _02.SquareWithMaximumSum
{
    using System;
    using System.Linq;

    public class SquareWithMaximumSum
    {
        public static void Main(string[] args)
        {
            //Reading Matrices from the Console:
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)         //matrix.GetLength(0) - взимаме броя редове.
            {
                int[] cells = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)     //matrix.GetLength(1) - взимаме броя колони.
                {
                    matrix[row, col] = cells[col];
                }
            }

            int maxTL = 0;
            int maxTR = 0;
            int maxBL = 0;
            int maxBR = 0;
            int maxSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int tl = matrix[row, col];
                    int tr = matrix[row, col + 1];
                    int bl = matrix[row + 1, col];
                    int br = matrix[row + 1, col + 1];
                    int sum = tl + tr + bl + br;

                    if (sum > maxSum)
                    {
                        maxTL = tl;
                        maxTR = tr;
                        maxBL = bl;
                        maxBR = br;
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine($"{maxTL} {maxTR}");
            Console.WriteLine($"{maxBL} {maxBR}");
            Console.WriteLine(maxSum);
        }
    }
}
