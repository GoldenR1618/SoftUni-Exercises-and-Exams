using System.Collections.Generic;

public class Garage
{
    private HashSet<Car> parkedCars;

    public Garage()
    {
        this.ParkedCars = new HashSet<Car>();
    }

    public HashSet<Car> ParkedCars
    {
        get { return this.parkedCars; }
        private set { this.parkedCars = value; }
    }
}