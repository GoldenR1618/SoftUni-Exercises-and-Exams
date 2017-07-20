using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : ICallOtherPhones, IBrowsingWideWeb
{
    private ICollection<string> phoneNumbers;
    private ICollection<string> webUrls;

    public Smartphone(ICollection<string> phoneNumbers, ICollection<string> webUrls)
    {
        this.PhoneNumbers = new List<string>(phoneNumbers);
        this.WebUrls = new List<string>(webUrls);
    }

    public ICollection<string> PhoneNumbers
    {
        get { return this.phoneNumbers; }
        protected set { this.phoneNumbers = value; }
    }
    public ICollection<string> WebUrls
    {
        get { return this.webUrls; }
        protected set { this.webUrls = value; }
    }

    public string Browse(string url)
    {
        if (url.Any(x => char.IsDigit(x)))
        {
            return "Invalid URL!";
        }
        else
        {
            return $"Browsing: {url}!";
        }
    }

    public string Call(string number)
    {
        if (!number.All(x => char.IsDigit(x)))
        {
            return "Invalid number!";
        }
        else
        {
            return $"Calling... {number}";
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var item in this.PhoneNumbers)
        {
            sb.AppendLine(Call(item));
        }

        foreach (var url in this.WebUrls)
        {
            sb.AppendLine(Browse(url));
        }

        return sb.ToString();
    }
}
