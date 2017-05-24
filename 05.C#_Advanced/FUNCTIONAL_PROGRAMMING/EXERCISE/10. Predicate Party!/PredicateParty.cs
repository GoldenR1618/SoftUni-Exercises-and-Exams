namespace _10.Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] comm = Console.ReadLine().Split(' ').ToArray();

            while (comm[0] != "Party!")
            {
                if (comm[0] == "Remove")
                {
                    switch (comm[1])
                    {
                        case "StartsWith": names = RemoveStartsWith(names, comm[2]); break;
                        case "EndsWith": names = RemoveEndsWith(names, comm[2]); break;
                        case "Length": names = names.Where(x => x.Length != int.Parse(comm[2])).ToList(); break;

                        default:
                            break;
                    }
                }
                else if (comm[0] == "Double")
                {
                    switch (comm[1])
                    {
                        case "StartsWith": names = DoubleStartsWith(names, comm[2]); break;
                        case "EndsWith": names = DoubleEndsWith(names, comm[2]); break;
                        case "Length": names = DoubleLength(names, comm[2]); break;

                        default:
                            break;
                    }
                }

                comm = Console.ReadLine().Split(' ').ToArray();
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
        }

        public static List<string> DoubleLength(List<string> names, string v)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length == int.Parse(v))
                {
                    names.Insert(i, names[i]);
                    i++;
                }
            }

            return names;
        }

        public static List<string> DoubleEndsWith(List<string> names, string v)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Substring(names[i].Length - v.Length) == v)
                {
                    names.Insert(i, names[i]);
                    i++;
                }
            }

            return names;
        }

        public static List<string> DoubleStartsWith(List<string> names, string v)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Substring(0, v.Length) == v)
                {
                    names.Insert(i, names[i]);
                    i++;
                }
            }

            return names;
        }

        public static List<string> RemoveEndsWith(List<string> names, string v)
        {
            List<string> result = new List<string>();

            foreach (var name in names)
            {
                if (name.Substring(name.Length - v.Length) != v)
                {
                    result.Add(name);
                }
            }

            return result;
        }

        public static List<string> RemoveStartsWith(List<string> names, string v)
        {
            List<string> result = new List<string>();

            foreach (var name in names)
            {
                if (name.Substring(0, v.Length) != v)
                {
                    result.Add(name);
                }
            }
            
            return result;
        }
    }
}
