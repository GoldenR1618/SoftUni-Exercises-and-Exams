namespace _02.Parking_System
{
    using System;
    using System.Collections.Generic;

    public class ParkingSystem
    {
        private static IDictionary<int, HashSet<int>> spotsTaken;
        private static int rows;
        private static int cols;

        public static void Main()
        {
            spotsTaken = new Dictionary<int, HashSet<int>>();

            string[] dimensions = Console.ReadLine().Split(' ');

            rows = int.Parse(dimensions[0]);
            cols = int.Parse(dimensions[1]);

            string command = Console.ReadLine();

            while (command != "stop")
            {
                string[] commandArgs = command.Split(' ');

                int entryRow = int.Parse(commandArgs[0]);
                int targetRow = int.Parse(commandArgs[1]);
                int targetCol = int.Parse(commandArgs[2]);

                if (IsSpotTaken(targetRow, targetCol))
                {
                    targetCol = TryFindFreeSpot(targetRow, targetCol);
                }

                if (targetCol > 0)  // Row is not full
                {
                    MarkSpotAsTaken(targetRow, targetCol);

                    int distance = Math.Abs(targetRow - entryRow) + targetCol + 1;

                    Console.WriteLine(distance);
                }
                else                //Row is full
                {
                    Console.WriteLine($"Row {targetRow} full");
                }

                command = Console.ReadLine();
            }
        }

        private static int TryFindFreeSpot(int row, int col)
        {
            int newCol = 0;
            int bestLength = int.MaxValue;
            for (int columnIndex = 1; columnIndex < cols; columnIndex++)
            {
                if (!IsSpotTaken(row, columnIndex))
                {
                    int newLength = Math.Abs(col - columnIndex);
                    if (newLength < bestLength)
                    {
                        bestLength = newLength;
                        newCol = columnIndex;
                    }
                }
            }

            return newCol;
        }

        private static bool IsSpotTaken(int row, int col)
        {
            return spotsTaken.ContainsKey(row) && spotsTaken[row].Contains(col);
        }

        private static void MarkSpotAsTaken(int row, int col)
        {
            if (!spotsTaken.ContainsKey(row))
            {
                spotsTaken[row] = new HashSet<int>();
            }
            spotsTaken[row].Add(col);
        }
    }
}
