namespace _01.Action_Print
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ActionPrint
    {
        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> print = name => Console.WriteLine(name);

            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
