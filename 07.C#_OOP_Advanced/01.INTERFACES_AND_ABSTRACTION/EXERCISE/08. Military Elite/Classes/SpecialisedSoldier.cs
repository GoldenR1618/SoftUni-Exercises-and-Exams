using System;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corps;   //Airforces or Marines.

    public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get { return this.corps; }
        protected set
        {
            if (value == "Airforces" || value == "Marines")
            {
                this.corps = value;
            }
            else
            {
                throw new ArgumentException("Invalid corps");
            }   
        }
    }
}
