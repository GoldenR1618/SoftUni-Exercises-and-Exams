namespace _05.Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterStudentsByEmailDomain
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

            List<string[]> result = students.Where(s => s[2].Contains("@gmail.com")).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]}");
            }
        }
    }
}
