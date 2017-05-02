using System;

class Axe
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var width = 5 * n;
        var leftDashes = 3 * n;
        var middleDashes = 0;
        var rightDashes = width - leftDashes - middleDashes - 2;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", 
                new string('-', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));
            middleDashes++;
            rightDashes--;
        }

        middleDashes--;
        rightDashes++;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('*', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));
        }

        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));
            leftDashes--;
            middleDashes += 2;
            rightDashes--;
        }
        Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDashes),
                new string('*', middleDashes),
                new string('-', rightDashes));
    }
}