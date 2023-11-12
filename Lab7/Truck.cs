namespace Lab7;

public class Truck : Avto
{
    protected bool hasTrailer;
    protected double payload;

    public Truck(string brand, string number, double speed, double payload, bool hasTrailer) : base(brand, number,
        speed)
    {
        this.payload = payload;
        this.hasTrailer = hasTrailer;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Speed: {speed}");
        Console.WriteLine($"Payload: {GetPayload()}");
        Console.WriteLine($"Has Trailer: {hasTrailer}");
    }

    public override double GetPayload()
    {
        if (hasTrailer)
            return payload * 2;
        return payload;
    }
}