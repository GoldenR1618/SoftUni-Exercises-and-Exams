public class Ferrari : ICar
{
    private string driver;
    private string model = "488-Spider";

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Model
    {
        get { return this.model; }
    }
    public string Driver
    {
        get { return this.driver; }
        protected set { this.driver = value; }
    }

    public string Brakes()
    {
        return $"Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }
}