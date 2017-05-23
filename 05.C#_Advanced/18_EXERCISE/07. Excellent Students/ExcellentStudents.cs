namespace _07.Excellent_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExcellentStudents
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string[]> students = new List<string[]>();

            while (input != "END")
            {
                students.Add(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                input = Console.ReadLine();
            }

            List<string[]> result = students.Where(s => s.Skip(2).Any(n => n == "6")).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]}");
            }
        }
    }
}
