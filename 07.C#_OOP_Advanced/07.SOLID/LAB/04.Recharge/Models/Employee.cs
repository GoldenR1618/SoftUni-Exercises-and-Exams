﻿namespace _04.Recharge
{
    using System;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base (id)
        {
        }

        public void Sleep()
        {
        }
    }
}