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

            //Класовете могат да наследяват освен един клас, колкото си искаме интерфейси:
            //public interface IAnimal
            //public abstract class Mammal
            //public class Person : Mammal, IAnimal

            //Най-честата структура в практиката е:
            //1. Няколко интерфейса най-отгоре.
            //2. Абстрактен клас описващ общите черти.
            //3. Конкретни класове описващи конкретиките.

            IAnimal cat = new Cat("Moli", 13);
            IAnimal dog = new Dog("Dzhak", 12);
        }
    }

    public interface IAnimal    //Интерфейс използваме, когато искаме да опишем общи черти с различно поведение в наследниците.
    {                           //Не може да имаме полета, константи и конструктори.
        string Name { get; }    //Няма аксес модифаери на пропъртитата и методите, защото всички са public по дифолт. Може САМО автоматични пропъртита.

        int Age { get; }        //Не пишем сетъри. Ако са ни необходими ги добавяме в наследените класове.

        string MakeNoise();     //Не може да имаме тяло на метод.
    }

    public abstract class Animal    //Абстрактен клас използваме за да опишем всички общи черти с еднакво/подобно поведение в наследниците.
    {

    }

    public class Cat : Animal, IAnimal
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

    public class Dog : Animal, IAnimal
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
