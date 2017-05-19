namespace _05.Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppliedArithmetics
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string comm = Console.ReadLine().ToLower();

            while (comm != "end")
            {
                switch (comm)
                {
                    case "add": nums = nums.Select(n => n + 1).ToList(); break;
                    case "multiply": nums = nums.Select(n => n * 2).ToList(); break;
                    case "subtract": nums = nums.Select(n => n - 1).ToList(); break;
                    case "print": Console.WriteLine(string.Join(" ", nums)); break;
                    default:
                        break;
                }

                comm = Console.ReadLine();
            }
        }
    }
}
