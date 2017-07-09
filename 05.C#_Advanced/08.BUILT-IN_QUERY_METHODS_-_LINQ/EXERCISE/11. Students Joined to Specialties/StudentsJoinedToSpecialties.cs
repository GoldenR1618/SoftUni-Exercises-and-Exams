namespace _11.Students_Joined_to_Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsJoinedToSpecialties
    {
        public static void Main(string[] args)
        {
            List<StudentSpecialty> listOfSpecialty = new List<StudentSpecialty>();
            List<Student> listOfStudents = new List<Student>();

            string input = Console.ReadLine();  //{specialty name} {specialty name} {faculty number}

            while (input != "Students:")
            {
                StudentSpecialty current = new StudentSpecialty();
                string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                current.SpecialtyName = splitInput[0] + " " + splitInput[1];
                current.FacultyNumbet = splitInput[2];

                listOfSpecialty.Add(current);

                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine(); //{faculty number} {student's first name} {student's second name}

            while (input2 != "END")
            {
                Student current = new Student();
                string[] splitInput2 = input2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                current.FacultyNumbet = splitInput2[0];
                current.StudentName = splitInput2[1] + " " + splitInput2[2];

                listOfStudents.Add(current);

                input2 = Console.ReadLine();
            }

            var result = listOfStudents.Join(listOfSpecialty, student => student.FacultyNumbet, specialty => specialty.FacultyNumbet, (student, specialty) => new { student.StudentName, student.FacultyNumbet, specialty.SpecialtyName }).OrderBy(student => student.StudentName);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.StudentName} {item.FacultyNumbet} {item.SpecialtyName}");
            }
        }
    }

    public class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public string FacultyNumbet { get; set; }
    }

    public class Student
    {
        public string StudentName { get; set; }
        public string FacultyNumbet { get; set; }
    }
}
