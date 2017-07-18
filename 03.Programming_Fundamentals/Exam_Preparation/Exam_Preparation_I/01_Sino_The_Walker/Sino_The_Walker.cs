namespace _01_Sino_The_Walker
{
    using System;

    public class Sino_The_Walker
    {
        public static void Main(string[] args)
        {
            TimeSpan timeLeaves = TimeSpan.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine()) % 86400;          //Махаме цял ден, ако ни подадът огромно число.
            int timeStepSec = int.Parse(Console.ReadLine()) % 86400;    //Махаме цял ден, ако ни подадът огромно число.
            long walkTimeSec = steps * timeStepSec;

            TimeSpan walkTime = TimeSpan.FromSeconds(walkTimeSec);      //Конвертираме int в секунди.
            TimeSpan arrivalTime = timeLeaves.Add(walkTime);
            
            Console.WriteLine($"Time Arrival: {arrivalTime:hh\\:mm\\:ss}");
        }
    }
}
