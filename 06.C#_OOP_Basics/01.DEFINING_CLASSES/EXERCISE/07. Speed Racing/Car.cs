using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionFor1km;
    private double distanceTraveled;
    private List<Car> listOfCars = new List<Car>();

    public string Model { get { return this.model; } set { this.model = value; } }
    public double FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value; } }
    public double FuelConsumptionFor1km { get { return this.fuelConsumptionFor1km; } set { this.fuelConsumptionFor1km = value; } }
    public double DistanceTraveled { get { return this.distanceTraveled; } set { this.distanceTraveled = value; } }

    public void AddCar(Car car)
    {
        this.listOfCars.Add(car);
    }

    public void CanMoveThatDistance(string model, double amountOfKm)
    {
        Car currentCar = listOfCars.Where(x => x.Model == model).ToList()[0];


    }
}