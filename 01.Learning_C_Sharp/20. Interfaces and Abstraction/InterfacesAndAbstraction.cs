namespace Interfaces_and_Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InterfacesAndAbstraction
    {
        public static void Main(string[] args)
        {
            //Abstraction:
            //Achieved with interfaces and abstract classes
            //Abstraction is a process of hiding the implementation details and showing only functionality to the user.

            //Encapsulation:
            //Achieved with access modifiers(private, public…)
            //Encapsulation is used to hide the code and data inside a single unit to protect the data from the outside the world.

            IAnimal cat = new Cat("Moli", 13);
            IAnimal dog = new Dog("Dzhak", 12);
        }
    }

    public interface IAnimal
    {
        string Name { get; }    //Няма аксес модифаери на пропъртитата и методите, защото всички са public по дифолт.

        int Age { get; }        //Не пишем сетъри. Ако са ни необходими ги добавяме в наследените класове.

        string MakeNoise();     //Не може да имаме тяло на метод.

    }

    public class Cat : IAnimal
    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public string MakeNoise()
        {
            return "Myau";
        }
    }

    public class Dog : IAnimal
    {
        private string name;
        private int age;

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public string MakeNoise()
        {
            return "Bau";
        }
    }
}
