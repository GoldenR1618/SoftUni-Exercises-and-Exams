namespace _11_Poisonous_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PoisonousPlants
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] days = new int[n];
            int[] minElement = new int[n];

            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (plants[i] < min)
                {
                    min = plants[i];
                }
                minElement[i] = min;
            }

            int max = 0;
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (plants[i] > plants[i - 1])
                {
                    days[i] = 1;
                    if (days[i] >= max)
                    {
                        maxIndex = i;
                        max = days[i];
                    }
                    continue;
                }

                if (plants[i] > minElement[i])
                {
                    if (plants[i] > plants[maxIndex])
                    {
                        days[i] = days[i - 1] + 1;
                    }
                    else
                    {
                        days[i] = days[maxIndex] + 1;
                    }
                }

                if (plants[i] == minElement[i])
                {
                    max = 0;
                }

                if (days[i] >= max)
                {
                    maxIndex = i;
                    max = days[i];
                }
            }

            Console.WriteLine(days.Max());
        }
    }
}
