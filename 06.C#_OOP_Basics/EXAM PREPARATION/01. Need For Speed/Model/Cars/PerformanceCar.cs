using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model,
        int yearOfProduction, int horsepower,
        int acceleration, int suspension,
        int durability)
        : base(brand, model, yearOfProduction,
            horsepower, acceleration,
            suspension, durability)
    {
        this.addOns = new List<string>();
    }

    public IReadOnlyCollection<string> AddOns
    {
        get
        {
            return this.addOns.AsReadOnly();
        }
    }

    public void Increases()
    {

    }
    public void Decreases()
    {

    }

    public void AddAddOns(string addOns)
    {
        this.addOns.Add(addOns);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
