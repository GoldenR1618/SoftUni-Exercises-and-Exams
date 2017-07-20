public class Citizen : IPerson
{
    private string name;
    private int age;

    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
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
}
