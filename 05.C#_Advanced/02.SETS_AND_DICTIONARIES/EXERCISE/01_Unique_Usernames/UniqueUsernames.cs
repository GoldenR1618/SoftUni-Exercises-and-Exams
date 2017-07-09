namespace _01_Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    public class UniqueUsernames
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> nameSet = new HashSet<string>();

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();

                nameSet.Add(name);
            }

            foreach (var item in nameSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
