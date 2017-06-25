namespace _02.Nature_s_Prophet
{
    using System;
    using System.Linq;
    using System.Text;

    public class NatureSProphet
    {
        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            int n = dimensions[0];
            int m = dimensions[1];

            int[,] garden = new int[n, m];

            while (input != "Bloom Bloom Plow")
            {
                int[] digInput = input.Split(' ').Select(int.Parse).ToArray();

                int row = digInput[0];
                int col = digInput[1];

                for (int r = 0; r < n; r++)
                {
                    garden[r, col]++;
                }

                for (int c = 0; c < m; c++)
                {
                    garden[row, c]++;
                }

                garden[row, col]--;

                input = Console.ReadLine();
            }

            var Output = new StringBuilder();

            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    Output.Append(garden[row, col] + " ");
                }

                Output.Append("\n");
            }

            Console.Write(Output);
        }
    }
}
