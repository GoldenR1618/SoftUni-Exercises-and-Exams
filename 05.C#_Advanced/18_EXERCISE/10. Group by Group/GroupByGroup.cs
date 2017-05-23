namespace _10.Group_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupByGroup
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> students = new List<Person>();

            while (input != "END")
            {
                string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person current = new Person()
                {
                    Name = $"{splitInput[0]} {splitInput[1]}",                  
                    Group = int.Parse(splitInput[2])
                };

                students.Add(current);

                input = Console.ReadLine();
            }

            var groups = students.GroupBy(s => s.Group, s => s.Name).OrderBy(x => x.Key);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key + " - " + string.Join(", ", group));
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }
    }
}
