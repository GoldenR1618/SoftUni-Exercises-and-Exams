namespace _01.Matrix_of_Palindromes
{
    using System;
    using System.Linq;

    public class MatrixOfPalindromes
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = input[0];
            int c = input[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int indexCol = 0;

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    int colIndex = col + row;
                    Console.Write($"{alphabet[row]}{alphabet[colIndex]}{alphabet[row]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
