namespace _04.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hospital
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (input != "Output")
            {
                string[] inputArr = input.Split(new char[] { ' ', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string department = inputArr[0];
                string doctor = inputArr[1] + " " + inputArr[2];

                List<string> patients = new List<string>();

                for (int i = 3; i < inputArr.Length; i++)
                {
                    patients.Add(inputArr[i]);
                }

                if (!dictionary.ContainsKey(department))
                {
                    dictionary[department] = new Dictionary<string, List<string>>();
                }

                if (!dictionary[department].ContainsKey(doctor))
                {
                    dictionary[department][doctor] = new List<string>();
                    dictionary[department][doctor] = patients;
                }
                else
                {
                    foreach (var patient in patients)
                    {
                        dictionary[department][doctor].Add(patient);
                    }
                }

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commArgs = command.Split(new char[] { ' ', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                string comm = commArgs[0];

                bool isDepart = false;

                foreach (var item in dictionary)
                {
                    if (item.Key == comm)
                    {
                        isDepart = true;
                        break;
                    }
                }

                string room = "";

                if (isDepart)
                {
                    if (commArgs.Length > 1)
                    {
                        comm = commArgs[0];
                        room = commArgs[1];
                    }
                }
                else
                {
                    comm = commArgs[0] + " " + commArgs[1];
                }

                if (isDepart)
                {
                    if (commArgs.Length > 1)    //Department Room
                    {
                        PrintDepartmentRoom(dictionary, comm, room);
                    }
                    else                        //Department
                    {
                        PrintDepartment(dictionary, comm);
                    }
                }
                else                            //Doctor
                {
                    PrintDoctor(dictionary, comm);
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintDepartment(Dictionary<string, Dictionary<string, List<string>>> dictionary, string comm)
        {
            List<string> result = new List<string>();

            foreach (var depar in dictionary.Where(x => x.Key == comm))
            {
                foreach (var doct in depar.Value)
                {
                    foreach (var item in doct.Value)
                    {
                        result.Add(item);
                    }
                }
            }

            foreach (var item in result.Take(60))
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintDepartmentRoom(Dictionary<string, Dictionary<string, List<string>>> dictionary, string comm, string room)
        {
            List<string> result = new List<string>();

            int skip = int.Parse(room) * 3 - 3;

            foreach (var depar in dictionary.Where(x => x.Key == comm))
            {
                foreach (var doct in depar.Value)
                {
                    foreach (var item in doct.Value)
                    {
                        result.Add(item);
                    }
                }
            }

            foreach (var item in result.Skip(skip).Take(3).OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintDoctor(Dictionary<string, Dictionary<string, List<string>>> dictionary, string comm)
        {
            List<string> result = new List<string>();

            foreach (var depar in dictionary)
            {
                foreach (var doct in depar.Value.Where(x => x.Key == comm))
                {
                    foreach (var patient in doct.Value)
                    {
                        result.Add(patient);
                    }
                }
            }

            foreach (var item in result.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
