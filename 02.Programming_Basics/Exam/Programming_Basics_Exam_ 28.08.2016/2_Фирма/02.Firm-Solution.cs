using System;

class Firm
{
    static void Main()
    {
        var projectHours = int.Parse(Console.ReadLine());
        var availableDays = int.Parse(Console.ReadLine());
        var overtimeWorkers = int.Parse(Console.ReadLine());

        var workDays = availableDays * 0.90;
        var overtime = overtimeWorkers * 2 * availableDays;

        var workHours = Math.Floor(workDays * 8 + overtime);

        
        if (projectHours <= workHours)
        {
            Console.WriteLine("Yes!{0} hours left.", workHours - projectHours);
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", projectHours - workHours);
        }
    }
}

