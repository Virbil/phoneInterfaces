using System;

public class Galaxy : Phone, IRingable 
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        return $"... {ringTone} ...";
    }
    public string Unlock() 
    {
        return $"Galaxy {versionNumber} unlocked with fingerprint scanner";
    }
    public override void DisplayInfo() 
    {
        Console.WriteLine("#############");
        Console.WriteLine($"Galaxy: {versionNumber}");
        Console.WriteLine($"Battery Percentage: {batteryPercentage}");
        Console.WriteLine($"Carrier: {carrier}");
        Console.WriteLine($"Ring Tone: {ringTone}");
        Console.WriteLine("#############\r\n");
    }
}