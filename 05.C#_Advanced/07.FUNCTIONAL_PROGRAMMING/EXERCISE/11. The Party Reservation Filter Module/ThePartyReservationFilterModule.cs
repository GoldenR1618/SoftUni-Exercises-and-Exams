namespace _11.The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PartyReservationFilterModule
    {
        public static void Main()
        {
            var filters = new Dictionary<string, Predicate<string>>();
            List<string> collection = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            while (input != "Print")
            {
                var tokens = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string filterType = tokens[1];
                string condition = tokens[2];

                if (command == "Add filter")
                {
                    string nameOfFilter = filterType + condition;
                    Predicate<string> newFilter = null;

                    if (filterType == "Starts with")
                    {
                        newFilter = GetStartsFilter(condition);
                    }
                    else if (filterType == "Ends with")
                    {
                        newFilter = GetEndsFilter(condition);
                    }
                    else if (filterType == "Length")
                    {
                        newFilter = GetLengthFilter(int.Parse(condition));
                    }
                    else if (filterType == "Contains")
                    {
                        newFilter = GetContainsFilter(condition);
                    }

                    if (newFilter != null && !filters.ContainsKey(nameOfFilter))
                    {
                        filters[nameOfFilter] = newFilter;
                    }
                }
                else if (command == "Remove filter")
                {
                    string nameOfFilter = filterType + condition;

                    if (filters.ContainsKey(nameOfFilter))
                    {
                        filters.Remove(nameOfFilter);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                collection.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", collection));
        }

        public static Predicate<string> GetStartsFilter(string condition)
        {
            Predicate<string> newStartsFilter = (string checkedString) =>
            {
                if (checkedString.StartsWith(condition))
                {
                    return true;
                }

                return false;
            };

            return newStartsFilter;
        }

        public static Predicate<string> GetEndsFilter(string condition)
        {
            Predicate<string> newEndsFilter = (string checkedString) =>
            {
                if (checkedString.EndsWith(condition))
                {
                    return true;
                }

                return false;
            };

            return newEndsFilter;
        }

        public static Predicate<string> GetLengthFilter(int len)
        {
            Predicate<string> newLengthFilter = (string checkedString) =>
            {
                if (checkedString.Length == len)
                {
                    return true;
                }

                return false;
            };

            return newLengthFilter;
        }

        public static Predicate<string> GetContainsFilter(string condition)
        {
            Predicate<string> newEndsFilter = (string checkedString) =>
            {
                if (checkedString.Contains(condition))
                {
                    return true;
                }

                return false;
            };

            return newEndsFilter;
        }
    }
}
