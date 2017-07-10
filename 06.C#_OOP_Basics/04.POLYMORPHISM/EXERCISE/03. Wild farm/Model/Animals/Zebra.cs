using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Zebra : Mammal
{
    public Zebra(string animalType, string animalName, double animalWeight, string animalLivingRegion) : base(animalType, animalName, animalWeight, animalLivingRegion)
    {
    }

    public override void Eat(Food food)
    {
        if (food is Vegetable)
        {
            base.FoodEaten = food.Quantity;
        }
        else
        {
            Console.WriteLine("Zebras are not eating that type of food!");
        }
    }

    public override void MakeSound()
    {
        Console.WriteLine("Zs");
    }

    public override string ToString()
    {
        return $"{base.AnimalType}[{base.AnimalName}, {base.AnimalWeight}, {base.AnimalLivingRegion}, {base.FoodEaten}]";
    }
}
