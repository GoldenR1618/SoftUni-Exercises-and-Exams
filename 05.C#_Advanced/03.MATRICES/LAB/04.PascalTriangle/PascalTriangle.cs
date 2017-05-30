namespace _04.PascalTriangle
{
    using System;

    public class PascalTriangle
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];
            int currentWidth = 1;

            for (int row = 0; row < n; row++)
            {
                triangle[row] = new long[currentWidth];
                long[] currentRow = triangle[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentWidth++;

                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = triangle[row - 1];
                        long prevoiousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = prevoiousRowSum;
                    }
                }
            }

            int rows = triangle.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int cols = triangle[i].GetLength(0);

                for (int j = 0; j < cols - 1; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }

                Console.WriteLine(triangle[i][cols - 1]);
            }
        }
    }
}
