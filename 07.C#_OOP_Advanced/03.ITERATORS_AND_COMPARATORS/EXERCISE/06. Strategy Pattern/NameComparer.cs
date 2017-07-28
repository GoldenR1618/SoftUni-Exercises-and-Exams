﻿using System.Collections.Generic;

internal class NameComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            result = x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
        }

        return result;
    }
}