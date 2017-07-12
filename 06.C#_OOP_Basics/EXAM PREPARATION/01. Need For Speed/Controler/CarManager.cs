using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        if (!cars.ContainsKey(id))
        {
            if (type == "Performance")
            {
                this.cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
            }
            else
            {
                this.cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
            }
        }
    }

    public string Check(int id)
    {
        Car thisCar = cars[id];

        return thisCar.ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        if (!races.ContainsKey(id))
        {
            switch (type)
            {
                case "Casual":
                    this.races[id] = new CasualRace(length, route, prizePool);
                    break;

                case "Drag":
                    this.races[id] = new DragRace(length, route, prizePool);
                    break;

                case "Drift":
                    this.races[id] = new DriftRace(length, route, prizePool);
                    break;
            }
        }
    }

    public void Open(int id, string type, int length, string route, int prizePool, int lapGold)
    {
        if (!races.ContainsKey(id))
        {
            switch (type)
            {
                case "TimeLimit":
                    races[id] = new TimeLimitRace(length, route, prizePool, lapGold);
                    break;

                case "Circuit":
                    races[id] = new CircuitRace(length, route, prizePool, lapGold);
                    break;
            }
        }
    }

    public void Participate(int carId, int raceId)
    {
        Car thisCar = cars[carId];
        Race thisRace = races[raceId];

        if (!garage.ParkedCars.Contains(thisCar))
        {
            if ((thisRace.GetType().Name == "TimeLimitRace" && thisRace.Participants.Count == 0) || thisRace.GetType().Name != "TimeLimitRace")
            {
                thisRace.Participants.Add(thisCar);
            }
        }
    }

    public string Start(int raceId)
    {
        Race thisRace = races[raceId];

        string result = thisRace.ToString();

        if (thisRace.Participants.Count > 0)
        {
            races.Remove(raceId);
        }

        return result;
    }

    public void Park(int carId)
    {
        Car thisCar = cars[carId];

        if (!races.Values.Any(x => x.Participants.Contains(thisCar)))   //Ако не участва в състезание.
        {
            if (!garage.ParkedCars.Contains(thisCar))   //Ако вече не е паркирана.
            {
                garage.ParkedCars.Add(thisCar); //Паркирай я.
            }
        }
    }

    public void Unpark(int carId)
    {
        Car thisCar = cars[carId];

        if (garage.ParkedCars.Contains(thisCar))
        {
            garage.ParkedCars.Remove(thisCar);
        }
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in garage.ParkedCars)
        {
            car.Tune(tuneIndex, addOn);
        }
    }
}