namespace _04_Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Average_Grades
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 1; i <= n; i++)
            {
                Student currentStudent = new Student();

                string[] input = Console.ReadLine().Split(' ');

                string name = input[0];
                currentStudent.Name = name;

                List<double> currentStudentGrades = new List<double>();

                for (int j = 1; j < input.Length; j++)
                {
                    currentStudentGrades.Add(double.Parse(input[j]));
                }

                currentStudent.Grades = currentStudentGrades;

                students.Add(currentStudent);
            }

            List<Student> orderedStudents = students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            foreach (var item in orderedStudents)
            {
                if (item.AverageGrade >= 5)
                {
                    Console.WriteLine($"{item.Name:f2} -> {item.AverageGrade:f2}");
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }
}
