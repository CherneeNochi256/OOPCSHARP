namespace Lab1;

public class Program

{

    public static void Main(string[] args)
    {
        Console.WriteLine("\n-------------------Lab1.3.1-----------------------\n");
        
        ComplexNumber c1 = new ComplexNumber(2, 3);
        ComplexNumber c2 = new ComplexNumber(1, -2);

        c1.Display(); // Output the first complex number
        c2.Display(); // Output the second complex number

        ComplexNumber sum = c1.Add(c2); // Add two complex numbers
        sum.Display();

        ComplexNumber difference = c1.Subtract(c2); // Subtract two complex numbers
        difference.Display();

        ComplexNumber product = c1.Multiply(c2); // Multiply two complex numbers
        product.Display();
        
        Console.WriteLine("\n-------------------Lab1.3.2-----------------------\n");


        Polynomial p1 = new Polynomial(2, 3, 1);
        Polynomial p2 = new Polynomial(1, -2, 0);

        p1.Display(); // Output the description of the first polynomial
        p2.Display(); // Output the description of the second polynomial

        double x = 5;
        double result = p1.Evaluate(x); // Evaluate the value of the first polynomial for a given argument
        Console.WriteLine($"The value of the polynomial for x={x} is: {result}");

        Polynomial p3 = p1.Add(p2); // Add two polynomials
        p3.Display();

        Polynomial p4 = p1.Subtract(p2); // Subtract two polynomials
        p4.Display();

        Polynomial p5 = p1.Multiply(p2); // Multiply two polynomials
        p5.Display();
    }
}