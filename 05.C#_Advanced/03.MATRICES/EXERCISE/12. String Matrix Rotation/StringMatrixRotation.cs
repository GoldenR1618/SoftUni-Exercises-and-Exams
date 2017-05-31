namespace _12.String_Matrix_Rotation
{
    using System;
    using System.Collections.Generic;

    public class StringMatrixRotation
    {
        public static void Main(string[] args)
        {
            string[] comm = Console.ReadLine().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string line = Console.ReadLine();

            List<string> lines = new List<string>();

            int command = int.Parse(comm[1]);

            while (command >= 360)
            {
                command -= 360;
            }

            int longestLine = 0;

            while (line != "END")
            {
                lines.Add(line);

                if (line.Length > longestLine)
                {
                    longestLine = line.Length;
                }

                line = Console.ReadLine();
            }

            List<string> modLines = new List<string>();

            foreach (var item in lines)
            {
                modLines.Add(item.PadRight(longestLine));
            }

            char[,] matrix = new char[modLines.Count, longestLine];

            for (int row = 0; row < modLines.Count; row++)
            {
                for (int col = 0; col < longestLine; col++)
                {
                    matrix[row, col] = modLines[row][col];
                }
            }

            switch (command)
            {
                case 0:
                    RotateMatrix0(matrix);
                    break;
                case 90:
                    RotateMatrix90(matrix);
                    break;
                case 180:
                    RotateMatrix180(matrix);
                    break;
                case 270:
                    RotateMatrix270(matrix);
                    break;
                default:
                    break;
            }
        }

        public static void RotateMatrix90(char[,] matrix)
        {
            char[,] matrix90 = new char[matrix.GetLength(1), matrix.GetLength(0)];

            for (int row = 0, row2 = matrix.GetLength(0) - 1; row < matrix.GetLength(0); row++, row2--)
            {
                for (int col = 0, col2 = matrix.GetLength(1) - 1; col < matrix.GetLength(1); col++, col2--)
                {
                    matrix90[col, row2] = matrix[row, col];
                }
            }

            PrintMatrix(matrix90);
        }

        public static void RotateMatrix180(char[,] matrix)
        {
            char[,] matrix180 = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = 0, row2 = matrix.GetLength(0) - 1; row < matrix.GetLength(0); row++, row2--)
            {
                for (int col = 0, col2 = matrix.GetLength(1) - 1; col < matrix.GetLength(1); col++, col2--)
                {
                    matrix180[row, col] = matrix[row2, col2];
                }
            }

            PrintMatrix(matrix180);
        }

        public static void RotateMatrix270(char[,] matrix)
        {
            char[,] matrix270 = new char[matrix.GetLength(1), matrix.GetLength(0)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0, col2 = matrix.GetLength(1) - 1; col < matrix.GetLength(1); col++, col2--)
                {
                    matrix270[col2, row] = matrix[row, col];
                }
            }

            PrintMatrix(matrix270);
        }

        private static void RotateMatrix0(char[,] matrix)
        {
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine(matrix[row, matrix.GetLength(1) - 1]);
            }
        }
    }
}
