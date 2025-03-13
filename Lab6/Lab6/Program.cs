using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = a + (a + b - 1) / (Math.Pow(a, 2) + 1) - (a * b);

        Console.WriteLine($"Result: {result:F2}");
    }
}
