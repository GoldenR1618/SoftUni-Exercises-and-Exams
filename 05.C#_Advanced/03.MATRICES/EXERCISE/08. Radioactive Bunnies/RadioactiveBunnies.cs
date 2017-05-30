namespace _08._Radioactive_Bunnies
{
    using System;
    using System.Linq;

    public class RadioactiveBunnies
    {
        static int[] playerPosition = new int[2];
        static bool gameOverWon = false;
        static bool gameOverDead = false;

        public static void Main(string[] args)
        {
            char[][] lair = GetMatrix();
            string commands = Console.ReadLine();

            while (!gameOverDead && !gameOverWon)
            {
                foreach (char command in commands)
                {
                    UpdatePlayer(lair, command);
                    UpdateBunnies(lair);
                    if (gameOverWon || gameOverDead) break;
                }
            }
            PrintMatrix(lair);
            Console.WriteLine("{0}: {1}",
                gameOverWon ? "won" : "dead",
                string.Join(" ", playerPosition));
        }

        public static void UpdateBunnies(char[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            // populate bunnies, mark new bunnies with 'b'
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] == 'B')
                    {
                        // populate upper, lower, left & right '.' positions
                        for (int r = Math.Max(0, row - 1); r <= Math.Min(row + 1, rows - 1); r++)
                        {
                            for (int c = Math.Max(0, col - 1); c <= Math.Min(col + 1, cols - 1); c++)
                            {
                                double distanceToBunny = Math.Sqrt(Math.Pow(row - r, 2) + Math.Pow(col - c, 2));
                                if (distanceToBunny == 1)
                                {
                                    if (matrix[r][c] == 'P')
                                    {
                                        gameOverDead = true;
                                        playerPosition = new int[2] { r, c };
                                        matrix[r][c] = 'b';
                                    }
                                    else if (matrix[r][c] == '.')
                                        matrix[r][c] = 'b';
                                }
                            }
                        }
                    }
                }
            }
            // update new bunnies: 'b' => 'B'
            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    if (matrix[row][col] == 'b')
                        matrix[row][col] = 'B';
        }

        public static void UpdatePlayer(char[][] matrix, char command)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            bool isUpdated = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        int stepRow = 0;
                        int stepCol = 0;
                        if (command == 'R') stepCol++;
                        else if (command == 'L') stepCol--;
                        else if (command == 'U') stepRow--;
                        else if (command == 'D') stepRow++;
                        int moveToRow = row + stepRow;
                        int moveToCol = col + stepCol;
                        bool isInside = moveToRow >= 0 && moveToRow < rows &&
                                        moveToCol >= 0 && moveToCol < cols;
                        if (!isInside)
                        {
                            gameOverWon = true;
                            playerPosition = new int[2] { row, col };
                        }
                        else if (matrix[moveToRow][moveToCol] == 'B')
                        {
                            gameOverDead = true;
                            playerPosition = new int[2] { moveToRow, moveToCol };
                        }
                        else
                            matrix[moveToRow][moveToCol] = 'P';
                        matrix[row][col] = '.';
                        isUpdated = true;
                        break;
                    }
                }
                if (isUpdated) break;
            }
        }

        public static char[][] GetMatrix()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            char[][] matrix = new char[rows][];
            for (int row = 0; row < rows; row++)
                matrix[row] = Console.ReadLine().ToCharArray();
            return matrix;
        }

        public static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
                Console.WriteLine(string.Join("", matrix[row]));
        }
    }
}
