namespace Lab7;

public abstract class Avto
{
    protected string brand;
    protected string number;
    protected double speed;

    public Avto(string brand, string number, double speed)
    {
        this.brand = brand;
        this.number = number;
        this.speed = speed;
    }

    public abstract void PrintInfo();

    public abstract double GetPayload();
}