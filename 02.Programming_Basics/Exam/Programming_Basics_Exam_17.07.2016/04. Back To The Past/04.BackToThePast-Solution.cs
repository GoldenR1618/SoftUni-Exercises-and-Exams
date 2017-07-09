using System;

class BackToThePast
{
    static void Main()
    {
        var inheritance = double.Parse(Console.ReadLine());
        var yearToLive = int.Parse(Console.ReadLine());
        var years = 18;

        for (int i = 1800; i <= yearToLive; i++)
        {
            if (i % 2 == 0)
            {
                inheritance -= 12000;
            }
            else
            {
                inheritance -= (12000 + 50 * years);
            }
            years++;
        }
        if (inheritance < 0)
        {
            Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(inheritance));
        }
        else
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", inheritance);
        }

    }
}