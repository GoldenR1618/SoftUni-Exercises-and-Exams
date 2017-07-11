using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Garage
{
    private List<Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new List<Car>();
    }

    public IReadOnlyCollection<Car> ParkedCars
    {
        get
        {
            return this.parkedCars.AsReadOnly();
        }
    }

    public void AddCar(Car car)
    {
        this.parkedCars.Add(car);
    }
}
