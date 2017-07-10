using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        string animalInfo = "";
        string foodInfo = "";

        while (true)
        {
            animalInfo = Console.ReadLine();
            if (animalInfo == "End")
            {
                break;
            }
            foodInfo = Console.ReadLine();

            string[] animalArgs = animalInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string animalType = animalArgs[0];
            string animalName = animalArgs[1];
            double animalWeight = double.Parse(animalArgs[2]);
            string animalLivingRegion = animalArgs[3];
            string catBreed = "";
            if (animalArgs.Length == 5)
            {
                catBreed = animalArgs[4];
            }

            string[] foodArgs = foodInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string foodType = foodArgs[0];
            int quantiy = int.Parse(foodArgs[1]);
            Food currentFood;
            if (foodType == "Vegetable")
            {
                currentFood = new Vegetable(quantiy);
            }
            else
            {
                currentFood = new Meat(quantiy);
            }

            switch (animalType)
            {
                case "Mouse":
                    Animal mouse = new Mouse(animalType, animalName, animalWeight, animalLivingRegion);
                    mouse.MakeSound();
                    mouse.Eat(currentFood);
                    Console.WriteLine(mouse);
                    break;

                case "Cat":
                    Animal cat = new Cat(animalType, animalName, animalWeight, animalLivingRegion, catBreed);
                    cat.MakeSound();
                    cat.Eat(currentFood);
                    Console.WriteLine(cat);
                    break;

                case "Tiger":
                    Animal tiger = new Tiger(animalType, animalName, animalWeight, animalLivingRegion);
                    tiger.MakeSound();
                    tiger.Eat(currentFood);
                    Console.WriteLine(tiger);
                    break;

                case "Zebra":
                    Animal zebra = new Zebra(animalType, animalName, animalWeight, animalLivingRegion);
                    zebra.MakeSound();
                    zebra.Eat(currentFood);
                    Console.WriteLine(zebra);
                    break;

                default:
                    break;
            }
        }
    }
}
