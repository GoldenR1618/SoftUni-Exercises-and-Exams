namespace _02.SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main(string[] args)
        {
            var vip = new HashSet<string>();
            var regular = new SortedSet<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }

                if (IsVIP(input))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (IsVIP(input))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }

            regular.UnionWith(vip);

            Console.WriteLine(regular.Count);

            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }

        private static bool IsVIP(string input)
        {
            if (char.IsDigit(input[0]))
            {
                return true;
            }

            return false;
        }
    }
}
