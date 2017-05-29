namespace Recursion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Recursion
    {
        public static char[,] lab =
        {
            {' ', 'e', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', '*', '*', '*', ' '},
            {' ', '*', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', '*', ' ', '*', ' ', '*', ' ', ' '},
            {' ', '*', ' ', '*', ' ', '*', ' ', '*', ' ', ' '},
            {' ', '*', ' ', '*', ' ', '*', ' ', '*', ' ', ' '},
            {' ', '*', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            {' ', '*', ' ', ' ', ' ', '*', ' ', '*', ' ', ' '},
            {' ', '*', ' ', '*', ' ', '*', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
        };

        private static char[] path = new char[lab.GetLength(0) * lab.GetLength(1)];
        private static int position = 0;
        private static long counter = 0;
        private static int shortestPath = int.MaxValue;
        private static int longestPath = 0;

        public static void Main(string[] args)
        {
            //Един обект наричаме рекурсивен, ако съдържа себе си или е дефиниран чрез себе си.
            //Рекурсия е програмна техника, при която даден метод извиква сам себе си при ре­ша­ването на определен проблем.
            //Такива методи наричаме рекурсивни.


            //Пътища в лабиринт – рекурсивен алгоритъм:
            FindPath(0, 0, 's');

            Console.WriteLine();
            Console.WriteLine($"Number of found exit paths: {counter}");
            Console.WriteLine($"The shortest path:          {shortestPath} steps");
            Console.WriteLine($"The longest path:           {longestPath} steps");
        }

        public static void FindPath(int row, int col, char direction)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                //We are out of the labyrinth
                return;
            }

            //Append the direction to the path
            path[position] = direction;
            position++;

            //Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                PrintPath(path, 1, position - 1);
            }

            if (lab[row, col] == ' ')
            {
                //The current cell is free. Mark it as visited
                lab[row, col] = 's';

                //Invoke recursion to explore all possible directions
                FindPath(row, col - 1, 'L'); //left
                FindPath(row - 1, col, 'U'); //up
                FindPath(row, col + 1, 'R'); //right
                FindPath(row + 1, col, 'D'); //down

                //Mark back the current cell as free
                lab[row, col] = ' ';
            }

            //Remove the direction from the path
            position--;
        }

        public static void PrintPath(char[] path, int startPos, int endPos)
        {
            Console.Write("Found path to the exit: ");

            int pathLength = 0;

            for (int pos = startPos; pos <= endPos; pos++)
            {
                Console.Write(path[pos]);
                pathLength++;
            }

            if (pathLength < shortestPath)
            {
                shortestPath = pathLength;
            }

            if (pathLength > longestPath)
            {
                longestPath = pathLength;
            }

            counter++;
            Console.WriteLine();
        }
    }
}
