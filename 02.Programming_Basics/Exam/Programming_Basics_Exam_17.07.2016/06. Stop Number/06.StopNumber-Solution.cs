using System;

class StopNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int specialCase = int.Parse(Console.ReadLine());

        for (int i = m; i >= n; i--)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                if (specialCase == i)
                {
                    break;
                }
                Console.Write("{0} ", i);
            }
        }
    }
}