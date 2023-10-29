namespace Lab2;

struct ComplexNumber
{
    private double real;
    private double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        double newReal = real + other.real;
        double newImaginary = imaginary + other.imaginary;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Subtract(ComplexNumber other)
    {
        double newReal = real - other.real;
        double newImaginary = imaginary - other.imaginary;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Multiply(ComplexNumber other)
    {
        double newReal = (real * other.real) - (imaginary * other.imaginary);
        double newImaginary = (real * other.imaginary) + (imaginary * other.real);
        return new ComplexNumber(newReal, newImaginary);
    }

    public void Display()
    {
        Console.WriteLine($"({real} + {imaginary}i)");
    }
}