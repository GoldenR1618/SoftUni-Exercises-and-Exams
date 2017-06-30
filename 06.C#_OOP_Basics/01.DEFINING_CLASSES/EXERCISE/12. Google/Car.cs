using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string carModel;
    private double carSpeed;

    public string CarModel { get { return this.carModel; } set { this.carModel = value; } }
    public double CarSpeed { get { return this.carSpeed; } set { this.carSpeed = value; } }
}