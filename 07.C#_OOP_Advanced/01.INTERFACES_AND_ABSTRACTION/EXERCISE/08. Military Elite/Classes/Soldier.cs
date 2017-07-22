public abstract class Soldier : ISoldier
{
    private string id;
    private string firstName;
    private string lastName;

    public Soldier(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public string FirstName
    {
        get { return this.firstName; }
        protected set { this.firstName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        protected set { this.lastName = value; }
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} ";
    }
}