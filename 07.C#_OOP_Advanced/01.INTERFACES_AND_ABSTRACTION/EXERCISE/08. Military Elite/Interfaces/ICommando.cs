using System.Collections.Generic;

public interface ICommando
{
    HashSet<Mission> Missions { get; }
}
