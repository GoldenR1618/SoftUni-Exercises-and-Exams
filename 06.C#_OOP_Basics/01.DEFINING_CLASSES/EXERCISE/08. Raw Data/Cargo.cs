using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cargo
{
    private double cargoWeight;
    private string cargoType;

    public double CargoWeight { get { return this.cargoWeight; } set { this.cargoWeight = value; } }
    public string CargoType { get { return this.cargoType; } set { this.cargoType = value; } }
}
