using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeSeconds = hours * 60 * 60 + minutes * 60 + seconds;
            float timeHour = hours + minutes / 60 + seconds / 60 / 60;

            float speedMetersPerSecond = distanceMeters / timeSeconds;
            float speedKilometersPerHour = (distanceMeters / 1000) / timeHour;
            float speedMilesPerHour = (distanceMeters / 1609) / timeHour;

            Console.WriteLine($"{speedMetersPerSecond}");
            Console.WriteLine($"{speedKilometersPerHour}");
            Console.WriteLine($"{speedMilesPerHour}");
        }
    }
}
