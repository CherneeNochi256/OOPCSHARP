namespace Lab7;

public class Car : Avto
{
    protected double payload;

    public Car(string brand, string number, double speed, double payload) : base(brand, number, speed)
    {
        this.payload = payload;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Speed: {speed}");
        Console.WriteLine($"Payload: {payload}");
    }

    public override double GetPayload()
    {
        return payload;
    }
}