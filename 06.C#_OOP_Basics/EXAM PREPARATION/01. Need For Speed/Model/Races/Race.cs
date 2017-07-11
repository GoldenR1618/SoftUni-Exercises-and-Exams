using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.participants = new List<Car>();
    }

    public int Length
    {
        get
        {
            return this.length;
        }
        protected set
        {
            this.length = value;
        }
    }
    public string Route
    {
        get
        {
            return this.route;
        }
        protected set
        {
            this.route = value;
        }
    }
    public int PrizePool
    {
        get
        {
            return this.prizePool;
        }
        protected set
        {
            this.prizePool = value;
        }
    }
    public IReadOnlyCollection<Car> Participants
    {
        get
        {
            return this.participants.AsReadOnly();
        }
    }

    public void AddCar(Car car)
    {
        this.participants.Add(car);
    }
}
