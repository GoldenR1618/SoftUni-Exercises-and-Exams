using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Family
{
    private List<Person> listOfPeople = new List<Person>();

    public List<Person> ListOfPeople
    {
        get
        {
            return this.listOfPeople;
        }
        set
        {
            this.listOfPeople = value;
        }
    }

    public void AddMember(Person member)
    {
        this.ListOfPeople.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.ListOfPeople.OrderByDescending(x => x.Age).First();
    }
}
