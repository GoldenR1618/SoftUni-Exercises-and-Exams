using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model;
    private Engine engine = new Engine();
    private Cargo cargo = new Cargo();
    private Tires tires = new Tires();

    public Car(string model,
        double engineSpeed, double enginePower,
        double cargoWeight, string cargoType,
        double tire1Pressure, double tire1Age,
        double tire2Pressure, double tire2Age,
        double tire3Pressure, double tire3Age,
        double tire4Pressure, double tire4Age)
    {
        this.Model = model;
        this.Engine.EngineSpeed = engineSpeed;
        this.Engine.EnginePower = enginePower;
        this.Cargo.CargoWeight = cargoWeight;
        this.Cargo.CargoType = cargoType;
        this.Tires.Tire1Pressure = tire1Pressure;
        this.Tires.Tire1Age = tire1Age;
        this.Tires.Tire2Pressure = tire2Pressure;
        this.Tires.Tire2Age = tire2Age;
        this.Tires.Tire3Pressure = tire3Pressure;
        this.Tires.Tire3Age = tire3Age;
        this.Tires.Tire4Pressure = tire4Pressure;
        this.Tires.Tire4Age = tire4Age;
    }

    public string Model { get { return this.model; } set { this.model = value; } }
    public Engine Engine { get { return this.engine; } set { this.engine = value; } }
    public Cargo Cargo { get { return this.cargo; } set { this.cargo = value; } }
    public Tires Tires { get { return this.tires; } set { this.tires = value; } }
}
