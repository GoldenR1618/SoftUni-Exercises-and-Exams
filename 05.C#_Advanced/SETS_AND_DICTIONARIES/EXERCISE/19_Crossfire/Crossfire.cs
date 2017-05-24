namespace _19_Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Crossfire
    {
        public static void Main(string[] args)
        {
            List<List<int>> matrix = GetMatrix();
            string input = "";

            while ((input = Console.ReadLine()) != "Nuke it from orbit")
            {
                int[] targetCoordinates = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                matrix = DestroyMatrixCells(matrix, targetCoordinates);
            }
            PrintMatrix(matrix);
        }

        public static List<List<int>> DestroyMatrixCells(List<List<int>> matrix, int[] coordinates)
        {
            int targetRow = coordinates[0];
            int targetCol = coordinates[1];
            int radius = coordinates[2];
            bool containsDestroyedCells = false;
            // update horizontal cells
            if (targetRow >= 0 && targetRow < matrix.Count)
            {
                for (int col = Math.Max(0, targetCol - radius); col <= Math.Min(targetCol + radius, matrix[targetRow].Count - 1); col++)
                {
                    matrix[targetRow][col] = 0;
                    containsDestroyedCells = true;
                }
            }
            // update vertical cells
            if (targetCol >= 0)
            {
                for (int row = Math.Max(0, targetRow - radius); row <= Math.Min(targetRow + radius, matrix.Count - 1); row++)
                {
                    if (targetCol < matrix[row].Count)
                    {
                        matrix[row][targetCol] = 0;
                        containsDestroyedCells = true;
                    }
                }
            }
            // remove destroyed matrix cells
            if (containsDestroyedCells)
            {
                for (int row = 0; row < matrix.Count; row++)
                {
                    if (matrix[row].Contains(0))
                    {
                        List<int> elements = new List<int>();
                        for (int col = 0; col < matrix[row].Count; col++)
                            if (matrix[row][col] != 0)
                                elements.Add(matrix[row][col]);
                        if (elements.Count > 0)
                            matrix[row] = elements;
                        else
                        {
                            matrix.RemoveAt(row);
                            row--;
                        }
                    }
                }
            }
            return matrix;
        }

        public static void PrintMatrix(List<List<int>> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
                Console.WriteLine(string.Join(" ", matrix[row]));
        }

        public static List<List<int>> GetMatrix()
        {
            int[] matrixDimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];
            List<List<int>> matrix = new List<List<int>>();
            int number = 1;
            for (int row = 0; row < rows; row++)
            {
                matrix.Add(new List<int>());
                for (int col = 0; col < cols; col++)
                    matrix[row].Add(number++);
            }
            return matrix;
        }
    }
}
