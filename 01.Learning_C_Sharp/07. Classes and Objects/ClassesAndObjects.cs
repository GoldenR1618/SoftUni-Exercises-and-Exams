namespace Classes_and_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClassesAndObjects
    {
        public static void Main(string[] args)
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
        }
    }

    public class Cat                                //Class declaration – това е редът, на който декларираме името на класа.
    {                                               //Тяло на клас – по подобие на методите, класовете също имат част, която следва декларацията им, оградена с фигурни скоби – "{" и "}" между които се намира съдържанието на класа.
        private string name;                        //Fields – те са променливи, декларирани в класа. В тях се пазят данни, които отразяват състоянието на обекта и са нужни за работата на методите на класа. Стойността, която се пази в полетата, отразява конкретното състояние на дадения обект, но съществуват и такива полета, наречени статични, които са общи за всички обекти.
        private string age;
        private string color;

        public Cat()                                //Default constructor – това е псевдометод, който се из­пол­зва за създа­ване на нови обекти.
        {
            this.name = null;
        }

        public Cat(string name)                     //Constructor.
        {
            this.name = name;
        }

        public string Name { get; set; }            //Свойства (properties) – така наричаме характеристиките на даден клас. Обикновено стойността на тези характеристики се пази в полета. Подобно на полетата, свойствата могат да бъдат притежа­вани само от конкретен обект или да са споделени между всички обекти от тип даден клас.
        public int Age { get; set; }
        public string Color { get; set; }
        public bool IsAsleep { get; set; }

        public string SayHello()                    //Методи (methods)
        {
            if (IsAsleep)
            {
                return "I am sleeping, ask me later!";
            }
            return $"Hi, I am {Name}! I am {Age} years old!";
        }

        public void GoToSleep()                     //Методи (methods) - void метод.
        {
            IsAsleep = true;
        }

        public void Awake()                         //Методи (methods) - void метод.
        {
            IsAsleep = false;
        }
    }
}
