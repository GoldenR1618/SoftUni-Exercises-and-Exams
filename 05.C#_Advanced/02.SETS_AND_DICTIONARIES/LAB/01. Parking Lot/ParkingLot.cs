namespace _01.Parking_Lot
{
    using System;
    using System.Collections.Generic;

    public class ParkingLot
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var parking = new SortedSet<string>();

            while (input != "END")
            {
                string[] inputParams = input.Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    parking.Remove(inputParams[1]);
                }

                input = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
