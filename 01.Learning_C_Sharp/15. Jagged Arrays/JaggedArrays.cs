namespace Jagged_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JaggedArrays
    {
        public static void Main(string[] args)
        {
            //Jagged arrays are multidimensional arrays, but each dimension has different size.
            //A jagged array is an array of arrays and each of the arrays has different length.
            int[][] jag = new int[3][];
            jag[0] = new int[3];
            jag[1] = new int[2];
            jag[2] = new int[5];

            //Filling a Jagged Array:
            int jagCount = int.Parse(Console.ReadLine());

            int[][] jagged = new int[jagCount][];

            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' ');
                jagged[i] = new int[inputNumbers.Length];

                for (int j = 0; j < jagged[i].GetLength(0); j++)
                {
                    jagged[i][j] = int.Parse(inputNumbers[j]);
                }
            }

            Console.WriteLine();

            //Print a Jagged Array:
            int rows = jagged.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int cols = jagged[i].GetLength(0);

                for (int j = 0; j < cols - 1; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }

                Console.WriteLine(jagged[i][cols - 1]);
            }

            //Example of Jagged Arrays:
            int[] numbers = { 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            int[] sizes = new int[3];
            int[] offsets = new int[3];

            foreach (var number in numbers)
            {
                int remainder = number % 3;
                sizes[remainder]++;
            }

            int[][] numbersByRemainder = { new int[sizes[0]], new int[sizes[1]], new int[sizes[2]] };

            foreach (var number in numbers)
            {
                int remainder = number % 3;
                int index = offsets[remainder];
                numbersByRemainder[remainder][index] = number;
                offsets[remainder]++;
            }
        }
    }
}
