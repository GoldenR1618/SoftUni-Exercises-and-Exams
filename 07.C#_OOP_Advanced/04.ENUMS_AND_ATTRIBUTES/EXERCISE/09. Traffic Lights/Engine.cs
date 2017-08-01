using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    public void Run()
    {
        Queue<TrafficLight> devices = this.SetTrafficLightsDevicesDevices();
        int numberOfLightChanges = int.Parse(Console.ReadLine());
        Console.WriteLine(this.ChangeLights(devices, numberOfLightChanges));
    }

    private string ChangeLights(Queue<TrafficLight> devices, int numberOfLightChanges)
    {
        StringBuilder sb = new StringBuilder();

        while (numberOfLightChanges > 0)
        {
            foreach (var device in devices)
            {
                device.ChangeLight();
                sb.Append($"{device.Light} ");
            }

            sb.Remove(sb.Length - 1, 1).AppendLine();
            numberOfLightChanges--;
        }

        return sb.ToString().Trim();
    }

    private Queue<TrafficLight> SetTrafficLightsDevicesDevices()
    {
        string[] deviceslightsFromInput = Console.ReadLine().Split();
        Queue<TrafficLight> devices = new Queue<TrafficLight>();

        foreach (var lightAsString in deviceslightsFromInput)
        {
            var isValid = Enum.TryParse(lightAsString, out LightColor light);

            if (isValid)
            {
                devices.Enqueue(new TrafficLight(light));
            }
        }

        return devices;
    }
}