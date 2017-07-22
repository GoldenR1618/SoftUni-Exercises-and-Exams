using System.Text;

public class Private : Soldier, IPrivate 
{
    private double salary;

    public Private(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public double Salary
    {
        get { return this.salary; }
        protected set { this.salary = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.AppendLine($"Salary: {this.Salary:F2}");

        return sb.ToString().Trim();
    }
}