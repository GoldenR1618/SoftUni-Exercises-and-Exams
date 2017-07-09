﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string name;
    public int age;

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age)

    {
        this.name = "No name";
        this.age = age;
    }

    public Person(string name, int age)

    {
        this.name = name;
        this.age = age;
    }

    public string Name { get { return this.name; } set { this.name = value; } }
    public int Age { get { return this.age; } set { this.age = value; } }
}
