using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NationsBuilder
{
    private List<Bender> benders = new List<Bender>();
    private List<Monument> monuments = new List<Monument>();
    private int issuedWar = 0;
    private StringBuilder sb = new StringBuilder();

    public void AssignBender(List<string> benderArgs)
    {
        string type = benderArgs[1];
        string name = benderArgs[2];
        int power = int.Parse(benderArgs[3]);
        double secondaryParameter = double.Parse(benderArgs[4]);

        switch (type)
        {
            case "Air":
                Bender airBender = new AirBender(name, power, secondaryParameter);
                benders.Add(airBender);
                break;

            case "Water":
                Bender waterBender = new WaterBender(name, power, secondaryParameter);
                benders.Add(waterBender);
                break;

            case "Fire":
                Bender fireBender = new FireBender(name, power, secondaryParameter);
                benders.Add(fireBender);
                break;

            case "Earth":
                Bender earthBender = new EarthBender(name, power, secondaryParameter);
                benders.Add(earthBender);
                break;

            default:
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[1];
        string name = monumentArgs[2];
        int affinity = int.Parse(monumentArgs[3]);

        switch (type)
        {
            case "Air":
                Monument airMonument = new AirMonument(name, affinity);
                monuments.Add(airMonument);
                break;

            case "Water":
                Monument waterMonument = new WaterMonument(name, affinity);
                monuments.Add(waterMonument);
                break;

            case "Fire":
                Monument fireMonument = new FireMonument(name, affinity);
                monuments.Add(fireMonument);
                break;

            case "Earth":
                Monument earthMonument = new EarthMonument(name, affinity);
                monuments.Add(earthMonument);
                break;

            default:
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
        sb.Append("Benders: ");

        if (benders.Any(x => x.GetType().ToString() == $"{nationsType}Bender"))
        {
            sb.AppendLine();

            switch (nationsType)
            {
                case "Air":
                    for (int i = 0; i < benders.Count; i++)
                    {
                        if (benders[i] is AirBender current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                case "Water":
                    for (int i = 0; i < benders.Count; i++)
                    {
                        if (benders[i] is WaterBender current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                case "Fire":
                    for (int i = 0; i < benders.Count; i++)
                    {
                        if (benders[i] is FireBender current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                case "Earth":
                    for (int i = 0; i < benders.Count; i++)
                    {
                        if (benders[i] is EarthBender current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                default:
                    break;
            }
        }
        else
        {
            sb.AppendLine("None");
        }

        sb.Append("Monuments: ");

        if (monuments.Any(x => x.GetType().ToString() == $"{nationsType}Monument"))
        {
            sb.AppendLine();

            switch (nationsType)
            {
                case "Air":
                    for (int i = 0; i < monuments.Count; i++)
                    {
                        if (monuments[i] is AirMonument current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                case "Water":
                    for (int i = 0; i < monuments.Count; i++)
                    {
                        if (monuments[i] is WaterMonument current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                case "Fire":
                    for (int i = 0; i < monuments.Count; i++)
                    {
                        if (monuments[i] is FireMonument current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                case "Earth":
                    for (int i = 0; i < monuments.Count; i++)
                    {
                        if (monuments[i] is EarthMonument current)
                        {
                            sb.AppendLine("###" + current.ToString());
                        }
                    }
                    break;

                default:
                    break;
            }
        }
        else
        {
            sb.AppendLine("None");
        }

        return sb.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        issuedWar++;

        double airBenderTotalPower = 0;
        double waterBenderTotalPower = 0;
        double fireBenderTotalPower = 0;
        double earthBenderTotalPower = 0;

        foreach (var bender in benders)
        {
            if (bender is AirBender)
            {
                airBenderTotalPower += bender.TotalPower();
            }

            if (bender is WaterBender)
            {
                waterBenderTotalPower += bender.TotalPower();
            }

            if (bender is FireBender)
            {
                fireBenderTotalPower += bender.TotalPower();
            }

            if (bender is EarthBender)
            {
                earthBenderTotalPower += bender.TotalPower();
            }
        }

        int totalAirAffinity = 0;
        int totalWaterAffinity = 0;
        int totalFireAffinity = 0;
        int totalEarthAffinity = 0;

        foreach (var monument in monuments)
        {
            if (monument is AirMonument airCurrent)
            {
                totalAirAffinity += airCurrent.AirAffinity;
            }

            if (monument is WaterMonument waterCurrent)
            {
                totalWaterAffinity += waterCurrent.WaterAffinity;
            }

            if (monument is FireMonument fireCurrent)
            {
                totalFireAffinity += fireCurrent.FireAffinity;
            }

            if (monument is EarthMonument earthCurrent)
            {
                totalEarthAffinity += earthCurrent.EarthAffinity;
            }
        }

        if (totalAirAffinity > 0)
        {
            airBenderTotalPower = (airBenderTotalPower / 100) * totalAirAffinity;
        }

        if (totalWaterAffinity > 0)
        {
            waterBenderTotalPower = (waterBenderTotalPower / 100) * totalWaterAffinity;
        }

        if (totalFireAffinity > 0)
        {
            fireBenderTotalPower = (fireBenderTotalPower / 100) * totalFireAffinity;
        }

        if (totalEarthAffinity > 0)
        {
            earthBenderTotalPower = (earthBenderTotalPower / 100) * totalEarthAffinity;
        }
        
        if (airBenderTotalPower > waterBenderTotalPower &&
            airBenderTotalPower > fireBenderTotalPower &&
            airBenderTotalPower > earthBenderTotalPower)
        {
            string keepedNation = "Air";
            DeleteBenderAndMonument(keepedNation);
        }
        else if (waterBenderTotalPower > airBenderTotalPower &&
            waterBenderTotalPower > fireBenderTotalPower &&
            waterBenderTotalPower > earthBenderTotalPower)
        {
            string keepedNation = "Water";
            DeleteBenderAndMonument(keepedNation);
        }
        else if (fireBenderTotalPower > airBenderTotalPower &&
            fireBenderTotalPower > waterBenderTotalPower &&
            fireBenderTotalPower > earthBenderTotalPower)
        {
            string keepedNation = "Fire";
            DeleteBenderAndMonument(keepedNation);
        }
        else
        {
            string keepedNation = "Earth";
            DeleteBenderAndMonument(keepedNation);
        }

        sb.AppendLine($"War {issuedWar} issued by {nationsType}");
    }

    public string GetWarsRecord()
    {
        return sb.ToString().Trim();
    }

    private void DeleteBenderAndMonument(string keepedNation)
    {
        for (int i = 0; i < benders.Count; i++)
        {
            if (benders[i].GetType().ToString() != $"{keepedNation}Bender")
            {
                benders.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < monuments.Count; i++)
        {
            if (monuments[i].GetType().ToString() != $"{keepedNation}Monument")
            {
                monuments.RemoveAt(i);
                i--;
            }
        }
    }
}