namespace _05._Rubiks_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RubiksMatrix
    {
        private static int[][] matrix = new int[1][];
        private static int rows = 0;
        private static int cols = 0;

        public static void InitMatrix(int rows, int cols)
        {
            matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = i * cols + (j + 1);
                }
            }
        }

        public static void moveUpOrDown(int line, long moves, string direction)
        {
            int m = (int)(moves % cols);
            var colValues = new Queue<int>();

            if (direction == "down")
            {
                for (int i = rows - 1; i >= 0; i--)
                {
                    colValues.Enqueue(matrix[i][line]);
                }
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    colValues.Enqueue(matrix[i][line]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                int t = colValues.Dequeue();
                colValues.Enqueue(t);
            }
            if (direction == "down")
            {
                for (int i = rows - 1; i >= 0; i--)
                {
                    matrix[i][line] = colValues.Dequeue();
                }
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix[i][line] = colValues.Dequeue();
                }
            }
        }

        public static void moveLeftOrRight(int line, long moves, string direction)
        {
            int m = (int)(moves % cols);
            var colValues = new Queue<int>();

            if (direction == "right")
            {
                for (int i = cols - 1; i >= 0; i--)
                {
                    colValues.Enqueue(matrix[line][i]);
                }
            }
            else
            {
                for (int i = 0; i < cols; i++)
                {
                    colValues.Enqueue(matrix[line][i]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                int t = colValues.Dequeue();
                colValues.Enqueue(t);
            }
            if (direction == "right")
            {
                for (int i = cols - 1; i >= 0; i--)
                {
                    matrix[line][i] = colValues.Dequeue();
                }
            }
            else
            {
                for (int i = 0; i < cols; i++)
                {
                    matrix[line][i] = colValues.Dequeue();
                }
            }
        }

        public static void RearrangeMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int initValue = i * cols + (j + 1);
                    int currentValue = matrix[i][j];

                    if (initValue != currentValue)
                    {
                        for (int k = 0; k < rows; k++)
                        {
                            var currentRow = matrix[k];
                            int index = Array.IndexOf(currentRow, initValue);
                            if (index > -1)
                            {
                                matrix[k][index] = currentValue;
                                matrix[i][j] = initValue;
                                Console.WriteLine($"Swap ({i}, {j}) with ({k}, {index})");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            var matrixDimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            rows = matrixDimensions[0];
            cols = matrixDimensions[1];
            InitMatrix(rows, cols);

            int n = int.Parse(Console.ReadLine());
            long moves = 0;
            string direction;
            int lineNumber;
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                lineNumber = int.Parse(command[0]);
                direction = command[1];
                moves = long.Parse(command[2]);

                switch (direction)
                {
                    case "up":
                    case "down":
                        moveUpOrDown(lineNumber, moves, direction);
                        break;
                    case "left":
                    case "right":
                        moveLeftOrRight(lineNumber, moves, direction);
                        break;
                }
            }
            RearrangeMatrix();
        }
    }
}