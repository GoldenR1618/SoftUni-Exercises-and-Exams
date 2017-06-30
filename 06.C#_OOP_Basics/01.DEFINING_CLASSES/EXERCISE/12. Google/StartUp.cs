using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        List<Person> listOfPersons = new List<Person>();

        string input1 = Console.ReadLine();

        while (input1 != "End")
        {
            string[] args = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string name = args[0];
            string typeClass = args[1];

            switch (typeClass)
            {
                case "company":
                    string companyName = args[2];
                    string department = args[3];
                    double salary = double.Parse(args[4]);

                    if (!listOfPersons.Any(x => x.Name == name))    //Ако не съществува човек с такова име.
                    {
                        Company currentCompany = new Company
                        {
                            CompanyName = companyName,
                            Department = department,
                            Salary = salary
                        };

                        Person currentPerson = new Person
                        {
                            Name = name,
                            Company = currentCompany,
                        };

                        listOfPersons.Add(currentPerson);
                    }
                    else    //Ако вече съществуа човек с такова име.
                    {
                        Person thisPerson = listOfPersons.Where(x => x.Name == name).First();

                        thisPerson.Company.CompanyName = companyName;
                        thisPerson.Company.Department = department;
                        thisPerson.Company.Salary = salary;
                    }

                    break;

                case "pokemon":
                    string pokemonName = args[2];
                    string pokemonType = args[3];

                    if (!listOfPersons.Any(x => x.Name == name))    //Ако не съществува човек с такова име.
                    {
                        Pokemon currentPokemon = new Pokemon
                        {
                            PokemonName = pokemonName,
                            PokemonType = pokemonType
                        };

                        Person currentPerson = new Person();
                        currentPerson.Name = name;
                        currentPerson.Pokemon.Add(currentPokemon);

                        listOfPersons.Add(currentPerson);
                    }
                    else    //Ако вече съществуа човек с такова име.
                    {
                        Person thisPerson = listOfPersons.Where(x => x.Name == name).First();

                        Pokemon currentPokemon = new Pokemon
                        {
                            PokemonName = pokemonName,
                            PokemonType = pokemonType
                        };

                        thisPerson.Pokemon.Add(currentPokemon);
                    }

                    break;

                case "parents":
                    string parentName = args[2];
                    string parentBirthday = args[3];

                    if (!listOfPersons.Any(x => x.Name == name))    //Ако не съществува човек с такова име.
                    {
                        Parents currentParents = new Parents
                        {
                            ParentName = parentName,
                            ParentBirthday = parentBirthday
                        };

                        Person currentPerson = new Person();
                        currentPerson.Name = name;
                        currentPerson.Parents.Add(currentParents);

                        listOfPersons.Add(currentPerson);
                    }
                    else    //Ако вече съществуа човек с такова име.
                    {
                        Person thisPerson = listOfPersons.Where(x => x.Name == name).First();

                        Parents currentParents = new Parents
                        {
                            ParentName = parentName,
                            ParentBirthday = parentBirthday
                        };

                        thisPerson.Parents.Add(currentParents);
                    }

                    break;

                case "children":
                    string childName = args[2];
                    string childBirthday = args[3];

                    if (!listOfPersons.Any(x => x.Name == name))    //Ако не съществува човек с такова име.
                    {
                        Children currentChildren = new Children
                        {
                            ChildName = childName,
                            ChildBirthday = childBirthday
                        };

                        Person currentPerson = new Person();
                        currentPerson.Name = name;
                        currentPerson.Children.Add(currentChildren);

                        listOfPersons.Add(currentPerson);
                    }
                    else    //Ако вече съществуа човек с такова име.
                    {
                        Person thisPerson = listOfPersons.Where(x => x.Name == name).First();

                        Children currentChildren = new Children
                        {
                            ChildName = childName,
                            ChildBirthday = childBirthday
                        };

                        thisPerson.Children.Add(currentChildren);
                    }

                    break;

                case "car":
                    string carModel = args[2];
                    double carSpeed = double.Parse(args[3]);

                    if (!listOfPersons.Any(x => x.Name == name))    //Ако не съществува човек с такова име.
                    {
                        Car currentCar = new Car
                        {
                            CarModel = carModel,
                            CarSpeed = carSpeed
                        };

                        Person currentPerson = new Person
                        {
                            Name = name,
                            Car = currentCar,
                        };

                        listOfPersons.Add(currentPerson);
                    }
                    else    //Ако вече съществуа човек с такова име.
                    {
                        Person thisPerson = listOfPersons.Where(x => x.Name == name).First();

                        thisPerson.Car.CarModel = carModel;
                        thisPerson.Car.CarSpeed = carSpeed;
                    }

                    break;

                default:
                    break;
            }

            input1 = Console.ReadLine();
        }

        string input2 = Console.ReadLine();

        Person resultPerson = listOfPersons.Where(x => x.Name == input2).First();

        Console.WriteLine(resultPerson.Name);
        Console.WriteLine("Company:");
        if (resultPerson.Company.Salary == 0)
        {
           
        }
        else
        {
            Console.WriteLine($"{resultPerson.Company.CompanyName} {resultPerson.Company.Department} {resultPerson.Company.Salary:F2}");
        }
        Console.WriteLine("Car:");
        if (resultPerson.Car.CarSpeed == 0)
        {

        }
        else
        {
            Console.WriteLine($"{resultPerson.Car.CarModel} {resultPerson.Car.CarSpeed}");
        }
        Console.WriteLine("Pokemon:");
        foreach (var pokemon in resultPerson.Pokemon)
        {
            Console.WriteLine($"{pokemon.PokemonName} {pokemon.PokemonType}");
        }
        Console.WriteLine("Parents:");
        foreach (var parent in resultPerson.Parents)
        {
            Console.WriteLine($"{parent.ParentName} {parent.ParentBirthday}");
        }
        Console.WriteLine("Children:");
        foreach (var child in resultPerson.Children)
        {
            Console.WriteLine($"{child.ChildName} {child.ChildBirthday}");
        }
    }
}
