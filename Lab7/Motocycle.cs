namespace Lab7;

public class Motorcycle : Avto
{
    private bool hasSidecar;
    private double payload;

    public Motorcycle(string brand, string number, double speed, double payload, bool hasSidecar) : base(brand, number,
        speed)
    {
        this.payload = payload;
        this.hasSidecar = hasSidecar;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Speed: {speed}");
        Console.WriteLine($"Payload: {GetPayload()}");
        Console.WriteLine($"Has Sidecar: {hasSidecar}");
    }

    public override double GetPayload()
    {
        if (hasSidecar)
            return payload;
        return 0;
    }
}