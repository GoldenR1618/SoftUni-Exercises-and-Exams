using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Bag = new List<Product>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be a negative");
            }

            this.money = value;
        }
    }

    public List<Product> Bag
    {
        get
        {
            return this.bag;
        }
        private set
        {
            this.bag = value;
        }
    }

    public static void BuyProduct(string person, string product, List<Person> listOfPersons, List<Product> listOfProducts)
    {
        Person thisPerson = listOfPersons.First(x => x.Name == person);
        Product thisProduct = listOfProducts.First(x => x.Name == product);

        if (thisProduct.Cost <= thisPerson.Money)
        {
            thisPerson.Bag.Add(thisProduct);
            thisPerson.Money -= thisProduct.Cost;
            Console.WriteLine($"{thisPerson.Name} bought {thisProduct.Name}");
        }
        else
        {
            Console.WriteLine($"{thisPerson.Name} can't afford {thisProduct.Name}");
        }
    }
}
