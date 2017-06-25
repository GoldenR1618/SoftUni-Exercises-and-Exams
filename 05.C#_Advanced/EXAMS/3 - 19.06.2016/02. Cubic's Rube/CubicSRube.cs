namespace _02.Cubic_s_Rube
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class CubicSRube
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            BigInteger sumAllCells = 0;
            BigInteger notChangedCells = BigInteger.Pow(n, 3);

            while (input != "Analyze")
            {
                int[] nums = input.Split(' ').Select(int.Parse).ToArray();

                int x = nums[0];
                int y = nums[1];
                int z = nums[2];

                int particles = nums[3];

                if (x >= 0 && x < n && y >= 0 && y < n && z >= 0 && z < n)
                {
                    sumAllCells += particles;

                    if (particles > 0)
                    {
                        notChangedCells--;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(sumAllCells);
            Console.WriteLine(notChangedCells);
        }
    }
}
