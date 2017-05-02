namespace _03_Endurance_Rally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Endurance_Rally
    {
        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            List<double> zones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> checkpoints = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            foreach (var name in names)
            {
                double fuel = name[0];                              //Ако присвоим стринг към инт - взимаме номера в ASCII таблицата.
                int reached = 0;
                bool isFinished = true;

                for (int iz = 0; iz < zones.Count; iz++)
                {
                    if (IsCheckpoint(iz, checkpoints))
                    {
                        fuel += zones[iz];
                    }
                    else
                    {
                        fuel -= zones[iz];

                        if (fuel <= 0)
                        {
                            reached = iz;
                            isFinished = false;
                            break;
                        }  
                    }
                }

                if (isFinished)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{name} - reached {reached}");
                }
            }
        }

        private static bool IsCheckpoint(int iz, List<double> checkpoints)
        {
            bool check = false;

            for (int ic = 0; ic < checkpoints.Count; ic++)
            {
                if (iz == checkpoints[ic])
                {
                    check = true;
                }
            }

            return check;
        }
    }
}
