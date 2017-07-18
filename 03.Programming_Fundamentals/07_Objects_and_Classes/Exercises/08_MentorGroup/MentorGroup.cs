using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _08_Mentor_Group
{
    public class MentorGroup
    {
        public static void Main()
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();

            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                string[] inputEll = input.Split().ToArray();

                List<DateTime> currentAttend = new List<DateTime>();

                if (inputEll.Length > 1)
                {
                    currentAttend = inputEll[1].Split(',')
                        .Select(x => DateTime.ParseExact(x, "dd\\/MM\\/yyyy", CultureInfo.InvariantCulture))
                        .ToList();
                }

                if (students.ContainsKey(inputEll[0]))
                {
                    students[inputEll[0]].Attendency.AddRange(currentAttend);
                }
                else
                {
                    Student currentStudent = new Student
                    {
                        Name = inputEll[0],
                        Attendency = currentAttend,
                        Comments = new List<string>()
                    };

                    students[inputEll[0]] = currentStudent;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of comments")
            {
                string[] inputEll = input.Split('-').ToArray();

                if (students.ContainsKey(inputEll[0]))
                {
                    students[inputEll[0]].Comments.Add(inputEll[1]);
                }

                input = Console.ReadLine();
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.Value.Name);

                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var attend in student.Value.Attendency.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {attend.ToString("dd\\/MM\\/yyyy")}");
                }
            }
            Console.WriteLine();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Attendency { get; set; }
    }
}