using System;

class Program
{
    static double SquareOfQuotient(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Error: Division by zero is not allowed.");
        }
        return Math.Pow(a / b, 2);
    }

    static void Main()
    {
        Console.Write("Enter the first number (numerator): ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number (denominator): ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        try
        {
            double result = SquareOfQuotient(num1, num2);
            Console.WriteLine($"The square of the quotient is: {result:F2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
