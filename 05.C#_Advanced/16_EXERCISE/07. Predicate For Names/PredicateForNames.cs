namespace _07.Predicate_For_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateForNames
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            names = names.Where(x => x.Length <= n).ToList(); 

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
