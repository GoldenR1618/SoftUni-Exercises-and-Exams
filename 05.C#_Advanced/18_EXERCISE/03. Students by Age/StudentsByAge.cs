namespace _03.Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByAge
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string[]> studentsAndAges = new List<string[]>();

            while (input != "END")
            {
                studentsAndAges.Add(input.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));

                input = Console.ReadLine();
            }

            List<string[]> result = studentsAndAges.Where(s => int.Parse(s[2]) >= 18 && int.Parse(s[2]) <= 24).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]} {student[2]}");
            }
        }
    }
}
