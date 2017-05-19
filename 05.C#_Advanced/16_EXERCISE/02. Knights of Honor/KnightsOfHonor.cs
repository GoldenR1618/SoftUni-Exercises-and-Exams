namespace _02.Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KnightsOfHonor
    {
        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> print = name => Console.WriteLine("Sir " + name);

            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
