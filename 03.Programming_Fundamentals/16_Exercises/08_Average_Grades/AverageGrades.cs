namespace _08_Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input1.txt");

            List<Student> students = new List<Student>();

            for (int i = 1; i < input.Length; i++)
            {
                string[] parse = input[i].Split(' ');

                Student currentStudent = new Student();

                string name = parse[0];
                currentStudent.Name = name;

                List<double> grades = new List<double>();

                for (int r = 1; r < parse.Length; r++)
                {
                    grades.Add(double.Parse(parse[r])); 
                }

                currentStudent.Grade = grades;

                if (currentStudent.AverageGrade >= 5)
                {
                    students.Add(currentStudent);
                } 
            }

            foreach (var item in students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                File.AppendAllText("output1.txt", $"{item.Name:F2} -> {item.AverageGrade:F2}{Environment.NewLine}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grade { get; set; }

        public double AverageGrade
        {
            get
            {
                return Grade.Average();
            }
        }
    }
}
