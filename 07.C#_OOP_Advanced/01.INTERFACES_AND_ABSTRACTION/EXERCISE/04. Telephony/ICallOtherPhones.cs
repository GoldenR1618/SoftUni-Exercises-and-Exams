using System.Collections.Generic;

public interface ICallOtherPhones
{
    ICollection<string> PhoneNumbers { get; }

    string Call(string number);
}
