namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Math_Demo
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Round(1.556, 2)     - Закръглява до вторият знак след дес. запетая. = {0}", Math.Round(1.556, 2));
            Console.WriteLine(" Math.Round(1.554, 2)     - Закръглява до вторият знак след дес. запетая. = {0}", Math.Round(1.554, 2));
            Console.WriteLine(" Math.Round(9.98, 0)      - Закръглява до най-близкото цяло число.        = {0}", Math.Round(9.98, 0));
            Console.WriteLine(" Math.Round(9.12, 0)      - Закръглява до най-близкото цяло число.        = {0}", Math.Round(9.12, 0));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Abs(3 - 5)          - Вади разликата без знак.                      = {0}", Math.Abs(3 - 5));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Max(3, 5)           - Връща най-голямото число.                     = {0}", Math.Max(3, 5));
            Console.WriteLine(" Math.Min(3, 5)           - Връща най-малкото число.                      = {0}", Math.Min(3, 5));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Truncate(9.98)      - Закръглява надолу до цяло число.              = {0}", Math.Truncate(9.98));
            Console.WriteLine(" Math.Truncate(9.12)      - Закръглява надолу до цяло число.              = {0}", Math.Truncate(9.12));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Floor(9.98)         - Закръглява надолу до цяло число.              = {0}", Math.Floor(9.98));
            Console.WriteLine(" Math.Floor(9.12)         - Закръглява надолу до цяло число.              = {0}", Math.Floor(9.12));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Ceiling(9.98)       - Закръглява нагоре до цяло число.              = {0}", Math.Ceiling(9.98));
            Console.WriteLine(" Math.Ceiling(9.12)       - Закръглява нагоре до цяло число.              = {0}", Math.Ceiling(9.12));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.PI                  - Извежда числото Пи.                           = {0}", Math.PI);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
    }
}
