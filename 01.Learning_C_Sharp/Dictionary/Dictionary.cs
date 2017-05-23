namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dictionary
    {
        public static void Main(string[] args)
        {   //.ContainsKey(), .ContainsValue(), .TryGetValue(), .Count, .Key, .Keys, .Value, .Values, Add(), Remove(), Clear()
            Dictionary<string, int> student = new Dictionary<string, int>();    //string са ключовете, int са данните.



            Console.WriteLine("Добавяне стойност към съответен ключ:");
            student["Gosho"] = 5;       //Добавя 5 на Gosho.
            student["Tzvetan"] = 4;
            student["Ilian"] = 6;
            student.Add("Elena", 5);    //Добавя 5 на Elena.
            student.Remove("Ilian");    //Трие Ilian.
            student.Clear();            //Изчиства целият речник.
            student["Gosho"] = 3;
            student["Tzvetan"] = 2;
            student["Ilian"] = 4;



            Console.WriteLine("Проверка дали ключа \"Maria\" съществуа в речника, или дали съществува дадена стойност:");
            bool existsKey = student.ContainsKey("Maria");
            bool existsValue = student.ContainsValue(5);
            Console.WriteLine(existsKey);
            if (student.ContainsKey("Maria"))
            {
                Console.WriteLine(student["Maria"]);
            }
            Console.WriteLine();



            Console.WriteLine("Големината на речника (броя записи):");
            Console.WriteLine(student.Count);
            Console.WriteLine();



            Console.WriteLine("Колекция от ключовете:");
            var keys = student.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();



            Console.WriteLine("Колекция от стойностите:");
            var value = student.Values;
            foreach (var key in value)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();



            Console.WriteLine("Взимам ключа и стойността заедно:");
            foreach (var item in student)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            Console.WriteLine("Взимам ключа и стойността по отделно:");
            foreach (var item in student)
            {
                Console.WriteLine(item.Key);    //Взимам ключа.
                Console.WriteLine(item.Value);  //Взимам стойността
            }
            Console.WriteLine();



            Console.WriteLine("Можем да имаме речник от листове:");
            Dictionary<string, List<int>> marks = new Dictionary<string, List<int>>();
            marks["Ivan"] = new List<int> { 4, 5, 3, 6 };   //Оценките на Ivan пазени в лист.
            marks["Pesho"] = new List<int> { 3, 3, 5, 2 };
            marks["Ivan"].Add(4);                           //Добави 4-ка на Ivan.
            Console.WriteLine();



            Console.WriteLine("TryGetValue е нещо като TryParse. Връща стойноста само ако е true. " +
                "Така се предпазваме от гръмване на кода ако поискаме стойност на несъществуващ ключ:");
            int number = 0;
            bool valueExists = student.TryGetValue("Ilian", out number);
            Console.WriteLine();
        }
    }
}
