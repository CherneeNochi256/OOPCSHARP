using Lab7;

public class Program
{
    private static void Main()
    {
        Avto car = new Car("Toyota", "ABC123", 100, 500);
        car.PrintInfo();

        Console.WriteLine();

        Avto motorcycleWithSidecar = new Motorcycle("Honda", "XYZ789", 80, 300, true);
        motorcycleWithSidecar.PrintInfo();

        Console.WriteLine();

        Avto motorcycleWithoutSidecar = new Motorcycle("Suzuki", "DEF456", 90, 400, false);
        motorcycleWithoutSidecar.PrintInfo();

        Console.WriteLine();

        Avto truckWithTrailer = new Truck("Volvo", "GHI789", 70, 2000, true);
        truckWithTrailer.PrintInfo();

        Console.WriteLine();

        Avto truckWithoutTrailer = new Truck("MAN", "JKL012", 60, 1500, false);
        truckWithoutTrailer.PrintInfo();
    }
}