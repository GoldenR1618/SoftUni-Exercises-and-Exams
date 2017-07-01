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
            //Private Access Modifier:
            //Main way that an object encapsulates itself and hides data from the outside world.
            //Class and interfaces cannot be private.
            //Can only be accessed within the declared class itself.

            //Protected Access Modifier:
            //Can be accessed only by the subclasses.
            //Class and interfaces cannot be protected.
            //Preventing a nonrelated class from trying to use it.

            //Internal Access Modifier:
            //Internal is default modifier in C#. 
            //Available to any other class in the same project.

            //Public Access Modifier:
            //A Class, method, constructor declared inside a public class can be accessed from any class belonging to the .NET World.
            //Using are needed if we try to access public class in different namespace.
            //The main() method of an application has to be public.



            //Дефиниране на обект от тип котка:
            Cat firstCat = new Cat();
            Cat secondCat = new Cat();

            //Присвояване на атрибутите и:
            firstCat.Name = "Moksi";
            firstCat.Age = 12;
            firstCat.Color = "Red";
            firstCat.IsASleep = true;

            secondCat.Name = "Moli";
            secondCat.Age = 9;
            secondCat.Color = "Grey";
            secondCat.IsASleep = false;

            Console.WriteLine($"{firstCat.Name} -> {firstCat.Age} -> {firstCat.Color} -> {firstCat.IsASleep}");
            Console.WriteLine($"{secondCat.Name} -> {secondCat.Age} -> {secondCat.Color} -> {secondCat.IsASleep}");

            //Можем да създаваме лист от котки.
            List<Cat> listOfcats = new List<Cat>();

            for (int i = 1; i <= 100; i++)
            {
                var currentCat = new Cat();
                currentCat.Name = "Cat " + i.ToString();
                currentCat.Age = i % 10;
                currentCat.Color = "Black";
                currentCat.IsASleep = false;

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
                IsASleep = true,
            };

            //Извикване на поведение на обекта от клас котка: 
            Console.WriteLine(thirtCat.SayHello());

            firstCat.GoToSleep();
            Console.WriteLine(firstCat.IsASleep);
            firstCat.Awake();
            Console.WriteLine(firstCat.IsASleep);
            firstCat.GoToSleep();
            Console.WriteLine(firstCat.SayHello());
        }
    }

    public class Cat
    {
        //Fields – те са променливи, декларирани в класа. В тях се пазят данни,
        //които отразяват състоянието на обекта и са нужни за работата на методите на класа.
        //Стойността, която се пази в полетата, отразява конкретното състояние на дадения обект,
        //но съществуват и такива полета, наречени статични, които са общи за всички обекти.
        private string name;
        private int age;
        private string color;
        private List<Vaccinations> listOfvacc;
        private bool isASleep;
        private Position position;



        //Default constructor – това е псевдометод, който се из­пол­зва за създа­ване на нови обекти.
        public Cat()
        {
            this.ListOfvacc = new List<Vaccinations>(); //Всичко, което е между скобите като код се извиква в момента на съзаване на обект от тип Cat!!!
                                                        //При създаване на нов клас Cat, веднага се инициализира List-а,
                                                        //за да не ни се налага да инициализираме преди да добаваме с ADD.                                                      
        }

        //Constructor - конструктор с подаден параметър в скобите в момента на създаването.
        public Cat(string name) //Когато конструктора е с параметър/ри, ние правим ЗАДЪЛЖИТЕЛНО въвеждането на този параметър/ри при инициализация!!!
        {
            this.Name = name;   //Използваме Name а не name, за да минем през пропъртито и да си направим валидацията ако има такава!!!
        }

        public Cat(string name, int age)
            : this(name)         //Тук викаме предишният конструктор (само с името), за да не се налага да преписваме цялата логика от него,
        {                       //а направо продължаваме да описваме само логиката за "age".
            this.Age = age;
        }



        //Properties (свойства) – така наричаме характеристиките на даден клас.
        //Обикновено стойността на тези характеристики се пази в полета.
        //Подобно на полетата, свойствата могат да бъдат притежа­вани само от
        //конкретен обект или да са споделени между всички обекти от тип даден клас.
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (name == null)
                {
                    throw new ArgumentException("Name is missing...");          //Всички валидации се правят САМО в SET-ра на пропъртитата!!!
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (age == 0)
                {
                    throw new ArgumentException("Age is missing...");           //Всички валидации се правят САМО в SET-ра на пропъртитата!!!
                }

                this.age = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public List<Vaccinations> ListOfvacc
        {
            get
            {
                return this.listOfvacc;
            }
            set
            {
                this.listOfvacc = value;
            }
        }

        public bool IsASleep
        {
            get
            {
                return this.isASleep;
            }
            set
            {
                this.isASleep = value;
            }
        }



        //Method - връщащ стойност.
        public string SayHello()
        {
            if (IsASleep)
            {
                return "I am sleeping, ask me later!";
            }

            return $"Hi, I am {Name}! I am {Age} years old!";
        }

        public Position Move(int xOffset, int yOffset)
        {
            this.position = new Position(this.position.X + xOffset, this.position.Y + yOffset);
            return this.position;
        }

        //Void method - не връщащ нищо.
        public void GoToSleep()
        {
            IsASleep = true;
        }

        public void Awake()
        {
            IsASleep = false;
        }

        //Static metod - статичните методи, не се викат през някоя от създадените котки (firstCat), а пре класа Cat, защото това е метод глобален за всички котки.
        public static int NumbersOfLegs()
        {
            return 4;
        }
    }



    public class Vaccinations
    {
        private string nameOfVacc;
        private DateTime date;

        public Vaccinations(string nameOfVacc, DateTime date)
        {
            this.NameOfVacc = nameOfVacc;
            this.Date = date;               //Използваме Date а не date, за да минем през пропъртито и да си направим валидацията ако има такава!!!
        }

        public string NameOfVacc
        {
            get
            {
                return this.nameOfVacc;
            }
            set
            {
                this.nameOfVacc = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
    }



    public class Position
    {
        private int x;
        private int y;

        public Position(int x, int y)
        {
            this.X = x;             //Използваме X а не x, за да минем през пропъртито и да си направим валидацията ако има такава!!!
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
    }
}
