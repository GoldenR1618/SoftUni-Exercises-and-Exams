namespace Matrices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Matrices
    {
        public static void Main(string[] args)
        {
            //Matrices:
            //Declaring multidimensional arrays:
            int[,] intMatrix;
            float[,] floatMatrix;
            string[,,] strCube;

            int[,] intMatrix2 = new int[3, 4];
            float[,] floatMatrix2 = new float[8, 2];
            string[,,] stringCube2 = new string[5, 5, 5];

            //Initializing with values multidimensional array:
            int[,] m =
            {
                {1, 2, 3, 4}, // row 0 values
                {5, 6, 7, 8}  // row 1 values
            };

            //Reading Matrices from the Console:
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)         //matrix.GetLength(0) - взимаме броя редове.
            {
                int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)     //matrix.GetLength(1) - взимаме броя колони.
                {
                    matrix[row, col] = cells[col];
                }
            }

            Console.WriteLine();

            //Print the matrix of size:
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine(matrix[row, cols - 1]);
            }
        }
    }
}
