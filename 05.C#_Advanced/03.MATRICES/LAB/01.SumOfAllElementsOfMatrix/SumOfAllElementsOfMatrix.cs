namespace _01.SumOfAllElementsOfMatrix
{
    using System;
    using System.Linq;

    public class SumOfAllElementsOfMatrix
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

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
