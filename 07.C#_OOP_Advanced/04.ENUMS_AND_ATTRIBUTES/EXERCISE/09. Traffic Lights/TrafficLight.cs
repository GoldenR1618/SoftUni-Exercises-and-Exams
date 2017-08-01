using System;

public class TrafficLight
{
    private readonly int lightsCount;

    public TrafficLight(LightColor light)
    {
        this.Light = light;
        this.lightsCount = Enum.GetNames(typeof(LightColor)).Length;
    }

    public LightColor Light { get; private set; }

    public void ChangeLight()
    {
        int nextValue = (int)this.Light + 1;

        if (nextValue == this.lightsCount)
        {
            nextValue = 0;
        }

        LightColor nextLight = (LightColor)nextValue;
        this.Light = nextLight;
    }
}
