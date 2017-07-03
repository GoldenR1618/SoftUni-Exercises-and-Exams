using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        List<Person> listOfPersons = new List<Person>();
        List<Product> listOfProducts = new List<Product>();
        try
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] peopleInfo = input1.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in peopleInfo)
            {
                string[] splitedPair = p.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                listOfPersons.Add(new Person(splitedPair[0], decimal.Parse(splitedPair[1])));
            }

            string[] productInfo = input2.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in productInfo)
            {
                string[] splitedPair = p.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                listOfProducts.Add(new Product(splitedPair[0], decimal.Parse(splitedPair[1])));
            }

            string input3 = Console.ReadLine();
            while (input3 != "END")
            {
                string[] args = input3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person.BuyProduct(args[0], args[1], listOfPersons, listOfProducts);

                input3 = Console.ReadLine();
            }

            foreach (var person in listOfPersons)
            {
                if (person.Bag.Count > 0)
                {
                    Console.Write($"{person.Name} - ");

                    for (int i = 0; i < person.Bag.Count - 1; i++)
                    {
                        Console.Write($"{person.Bag[i].Name}, ");
                    }

                    Console.WriteLine(person.Bag[person.Bag.Count - 1].Name);
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
