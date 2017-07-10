using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Felime : Mammal
{
    public Felime(string animalType, string animalName, double animalWeight, string animalLivingRegion) : base(animalType, animalName, animalWeight, animalLivingRegion)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
