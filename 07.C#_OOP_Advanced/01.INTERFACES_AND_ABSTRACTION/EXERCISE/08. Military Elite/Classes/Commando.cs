using System.Collections.Generic;
using System.Text;

public class Commando :SpecialisedSoldier, ICommando
{
    private HashSet<Mission> missions;

    public Commando(string id, string firstName, string lastName, double salary, string corps, HashSet<Mission> missions) : base(id, firstName, lastName, salary, corps)
    {
        this.Missions = new HashSet<Mission>(missions);
    }

    public HashSet<Mission> Missions
    {
        get { return this.missions; }
        protected set { this.missions = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Missions:");

        foreach (var mission in missions)
        {
            sb.AppendLine("  " + mission.ToString());
        }

        return sb.ToString().Trim();
    }
}
