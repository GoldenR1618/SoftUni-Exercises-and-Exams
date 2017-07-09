namespace _03.Squares_in_Matrix
{
    using System;
    using System.Linq;

    public class SquaresInMatrix
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = input[0];
            int c = input[1];

            string[,] matrix = new string[r, c];

            for (int row = 0; row < r; row++)
            {
                string[] cells = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }

            int count = 0;

            for (int row = 0; row < r - 1; row++)
            {
                for (int col = 0; col < c - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col + 1] == matrix[row + 1, col] && matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
