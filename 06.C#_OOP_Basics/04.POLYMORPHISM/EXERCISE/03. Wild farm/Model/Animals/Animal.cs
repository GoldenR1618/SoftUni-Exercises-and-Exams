using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
    private string animalType;
    private string animalName;
    private double animalWeight;
    private string animalLivingRegion;
    private int foodEaten;
    //////////////////////////////////
    public Animal(string animalType, string animalName, double animalWeight, string animalLivingRegion)
    {
        this.AnimalType = animalType;
        this.AnimalName = animalName;
        this.AnimalWeight = animalWeight;
        this.AnimalLivingRegion = animalLivingRegion;
    }
    //////////////////////////////////
    public string AnimalType
    {
        get
        {
            return this.animalType;
        }
        protected set
        {
            this.animalType = value;
        }
    }

    public string AnimalName
    {
        get
        {
            return this.animalName;
        }
        protected set
        {
            this.animalName = value;
        }
    }

    public double AnimalWeight
    {
        get
        {
            return this.animalWeight;
        }
        protected set
        {
            this.animalWeight = value;
        }
    }

    public string AnimalLivingRegion
    {
        get
        {
            return this.animalLivingRegion;
        }
        protected set
        {
            this.animalLivingRegion = value;
        }
    }

    public int FoodEaten
    {
        get
        {
            return this.foodEaten;
        }
        protected set
        {
            this.foodEaten = value;
        }
    }
    //////////////////////////////////
    public abstract void MakeSound();

    public abstract void Eat(Food food);

    public override string ToString()
    {
        return base.ToString();
    }
}
