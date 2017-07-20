using System.Collections.Generic;

public interface IBrowsingWideWeb
{
    ICollection<string> WebUrls { get; }

    string Browse(string url);
}
