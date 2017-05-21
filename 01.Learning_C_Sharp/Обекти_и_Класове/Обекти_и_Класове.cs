namespace Обекти_и_Класове
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Обекти_и_Класове
    {
        public void Main(string[] args)
        {
            //Дефиниране на обект от тип котка:
            Cat firstCat = new Cat();
            Cat secondCat = new Cat();

            //Присвояване на атрибутите и:
            firstCat.Name = "Moksi";
            firstCat.Age = 12;
            firstCat.Color = "Red";
            firstCat.IsAsleep = true;

            secondCat.Name = "Moli";
            secondCat.Age = 9;
            secondCat.Color = "Grey";
            secondCat.IsAsleep = false;

            Console.WriteLine($"{firstCat.Name} -> {firstCat.Age} -> {firstCat.Color} -> {firstCat.IsAsleep}");
            Console.WriteLine($"{secondCat.Name} -> {secondCat.Age} -> {secondCat.Color} -> {secondCat.IsAsleep}");

            //Можем да създаваме лист от котки.
            List<Cat> listOfcats = new List<Cat>();

            for (int i = 1; i <= 100; i++)
            {
                var currentCat = new Cat();
                currentCat.Name = "Cat " + i.ToString();
                currentCat.Age = i % 10;
                currentCat.Color = "Black";
                currentCat.IsAsleep = false;

                listOfcats.Add(currentCat);
            }

            Console.WriteLine(listOfcats.Count);
            Console.WriteLine(listOfcats[15].Name);

            Cat someCatFromTheList = listOfcats[27];
            string someCatName = someCatFromTheList.Name;
            Console.WriteLine(someCatName);

            //Бърз начин за създаване на котка и присвояване на атрибутите и:
            Cat thirtCat = new Cat()
            {
                Name = "Ragnar",
                Age = 3,
                Color = "Tiger Tabi",
                IsAsleep = true,
            };

            //Извикване на поведение на обекта от клас котка: 
            Console.WriteLine(thirtCat.SayHello());

            firstCat.GoToSleep();
            Console.WriteLine(firstCat.IsAsleep);
            firstCat.Awake();
            Console.WriteLine(firstCat.IsAsleep);
            firstCat.GoToSleep();
            Console.WriteLine(firstCat.SayHello());

            //Генериране на рандом чилса.
            var random = new Random();              //var random = new Random(100); - Можемн да зададем ръчно инишъл числото. Ако го оставим празно, ще чете милисекунди от времето.
            var randomNumber = random.Next(2, 6);   //Ще генерира произволно число от 2 до 6-1 -> 5.
            Console.WriteLine(randomNumber);

        }
    }

    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAsleep { get; set; }

        public string SayHello()
        {
            if (IsAsleep)
            {
                return "I am sleeping, ask me later!";
            }
            return $"Hi, I am {Name}! I am {Age} years old!";
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void Awake()
        {
            IsAsleep = false;
        }
    }
}