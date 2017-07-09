namespace Classes_and_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            //--------------------------------------------------------------------------------------------------------------//
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
            //A Class, method, constructor declared inside a public class can be accessed
            //from any class belonging to the .NET World.
            //Using are needed if we try to access public class in different namespace.
            //The main() method of an application has to be public.
            //--------------------------------------------------------------------------------------------------------------//

            //--------------------------------------------------------------------------------------------------------------//
            //Compile time polymorphism:
            //int Sum(int a, int b, int c); double Sum(Double a, Double b); -> Method overloading. Argument lists could differ in: Number of parameters, Data type of parameters, Sequence of Data type of parameters.
            //Rules for Overloading Method:
            //1. Overloading can take place in the same class or in its sub-class.
            //2. Constructor can be overloaded.
            //3. Overloaded methods must have a different argument list.
            //4. Overloaded method should always be the part of the same class (can also take place in sub class), with same name but different parameters.
            //5. They may have the same or different return types.

            //Runtime polymorphism:
            //Animal puffy = new Dog(); -> Method overriding.
            //Правим един виртуален метод в главният клас. Оувъррайдваме същият метод във всеки един от субкласовете, като добавяме специфична за класа функционалност.
            //Rules for Overriding Method:
            //1. Overriding can take place sub-class.
            //2. Argument list must be the same as that of the parent method.
            //3. The overriding method must have same return type.
            //4. Access modifier cannot be more restrictive.
            //5. Private and static methods can NOT be overriden.
            //6. The overriding method must not throw new or broader checked exceptions.
            //--------------------------------------------------------------------------------------------------------------//

            //--------------------------------------------------------------------------------------------------------------//
            //Abstract Classes:
            //1. Abstract class can NOT be instantiated.
            //      Shape shape = new Shape(); -> Compile time error
            //      Shape circle = new Circle(); -> polymorphism
            //2. An abstract class may or may not include abstract methods.
            //3. If abstract class include abstract methods, you need to extend it! -> public abstract void Draw(); -> Във всички субкласове трябва да се направи същият клас и да се вкара локална логика!
            //--------------------------------------------------------------------------------------------------------------//

            //Keyword - sealed: Allow classes to derive from your class and prevent them from overriding specific virtual methods or properties.

            //Static        -> Association with a type (class)          -> Initialization just before the first time usage  -> Memory Clearance on program exit
            //Non-Static    -> Association with an instances (objects)  -> Initialization when the constructor is called    -> Memory Clearance by the garbage collector

            Family family = new Family("MyFamily");
            List<Person> persons = new List<Person>();

            try
            {
                string input = string.Empty;
                while ((input = Console.ReadLine()) != "End")
                {
                    string[] args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    persons.Add(new Person(args[0], int.Parse(args[1])));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string personInfo = Console.ReadLine();

            Console.WriteLine("------------ Person Info: ------------");
            Console.WriteLine(persons.First(p => p.Name == personInfo));

            persons.ForEach(p => family.AddPerson(p));

            Console.WriteLine("---------- Oldest person is: ---------");
            Console.WriteLine(family.GetOldestPerson());
            Console.WriteLine("----------- Family members: ----------");
            Console.WriteLine(family);
            Console.WriteLine("--------------------------------------");
        }
    }

    public class Family
    {
        // Fields – те са променливи, декларирани в класа. В тях се пазят данни, които отразяват състоянието на обекта и са нужни за работата на методите на класа. Стойността, която се пази в полетата, отразява конкретното състояние на дадения обект, но съществуват и такива полета, наречени статични, които са общи за всички обекти.
        private string familyName;
        private List<Person> listOfPerson;

        // Constructors - конструктор с подаден параметър в скобите в момента на създаването. С празни скоби е default конструктора.
        public Family(string familyName)
        {
            this.FamilyName = familyName;   //Използваме FamilyName а не familyName, за да минем през пропъртито и да си направим валидацията ако има такава!!!
            this.listOfPerson = new List<Person>(); //При създаване на нов клас Family, веднага се инициализира List-а,
                                                    //за да не ни се налага да инициализираме преди да добавяме елементи в него.
        }

        // Properties (свойства) – така наричаме характеристиките на даден клас. Обикновено стойността на тези характеристики се пази в полета. Подобно на полетата, свойствата могат да бъдат притежа­вани само от конкретен обект или да са споделени между всички обекти от тип даден клас.
        public string FamilyName
        {
            get
            {
                return this.familyName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Family name cannot be null");
                }

                this.familyName = value;
            }
        }
        public IReadOnlyCollection<Person> ListOfPerson     //Начин за пълна недостъпност на листа. Можем да добавяме елемети само през метода.
        {
            get
            {
                return this.listOfPerson.AsReadOnly();      //Дори когато махнем сетъра, пак можем да достъпваме обекта през гетара, защото това е референтен тип променлива. За това дабавяме и .AsReadOnly().
            }
        }

        // Methods:
        public void AddPerson(Person person)    //void - Не връща стойност.
        {
            this.listOfPerson.Add(person);
        }
        public Person GetOldestPerson()         //Връща стойност от тип Person.
        {
            return this.ListOfPerson.OrderByDescending(x => x.Age).First();
        }
        public static void PrintHello()         //Статичните методи, не се викат през някоя от създадените инстанции на класа Family (myFamily примерно), а директно през класа Family, защото това е метод глобален за всички семейства -> Family.PrintHello()
        {
            Console.WriteLine("Hello!");
        }
        public override string ToString()       //Оувъррайдваме ToString() метода.
        {
            return String.Format("The family has {0} members.", this.ListOfPerson.Count);
        }
    }

    public class Person
    {
        // Fields:
        private string name;
        private int age;

        // Constructors:
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Properties:
        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }

                this.name = value;
            }
        }
        public virtual int Age  //Указваме, че можем да оувъррайдваме това свойство.
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative");
                }

                this.age = value;
            }
        }

        // Methods:
        public override string ToString()
        {
            return String.Format("{0} is a {1} years old.", this.Name, this.Age);
        }
        public virtual string ExplainMyself()
        {
            return String.Format("{0} is a {1} years old.", this.Name, this.Age);
        }
    }

    public class Child : Person //Child наследява класа Person.
    {
        public Child(string name, int age) : base(name, age)    //Викаме контруктора от базовият клас. С :this викаме конструктор от същият клас.
        {
            //Не се налага да описваме вътре нещата, защото сме извикали друг описан конструктор.
        }

        public override int Age //Оувъррайдваме свойството, което сме си дръпнали през извиканият базов конструктор.
        {
            get
            {
                return base.Age;
            }
            protected set
            {
                if (value >= 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }

                base.Age = value;
            }
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "I am a child!";
        }
    }
}