public class Citizen : IPerson, IBirthable, IIdentifiable
{
    private string name;
    private int age;
    private string id;
    private string birthdate;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        protected set { this.age = value; }
    }
    public string Birthdate
    {
        get { return this.birthdate; }
        protected set { this.birthdate = value; }
    }
    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }
}
