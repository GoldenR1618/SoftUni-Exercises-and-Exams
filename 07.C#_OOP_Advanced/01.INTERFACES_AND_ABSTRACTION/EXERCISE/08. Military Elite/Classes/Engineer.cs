using System.Collections.Generic;
using System.Text;

public class Engineer :SpecialisedSoldier, IEngineer
{
    private HashSet<Repair> repairs;

    public Engineer(string id, string firstName, string lastName, double salary, string corps, HashSet<Repair> repairs) : base(id, firstName, lastName, salary, corps)
    {
        this.Repairs = new HashSet<Repair>(repairs);
    }

    public HashSet<Repair> Repairs
    {
        get { return this.repairs; }
        protected set { this.repairs = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Repairs:");

        foreach (var repair in repairs)
        {
            sb.AppendLine("  " + repair.ToString());
        }

        return sb.ToString().Trim();
    }
}
