using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private HashSet<Private> privates;

    public LeutenantGeneral(string id, string firstName, string lastName, double salary, HashSet<Private> privates) : base(id, firstName, lastName, salary)
    {
        this.Privates = new HashSet<Private>(privates);
    }

    public HashSet<Private> Privates
    {
        get { return this.privates; }
        protected set { this.privates = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Privates:");

        foreach (var pr in privates)
        {
            sb.AppendLine("  " + pr.ToString());
        }

        return sb.ToString().Trim();
    }
}
