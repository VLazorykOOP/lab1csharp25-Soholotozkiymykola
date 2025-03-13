using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter inner radius r1: ");
        double r1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter outer radius r2: ");
        double r2 = Convert.ToDouble(Console.ReadLine());

        if (r1 >= r2)
        {
            Console.WriteLine("Error: r1 must be smaller than r2.");
        }
        else
        {
            double area = Math.PI * (Math.Pow(r2, 2) - Math.Pow(r1, 2));
            Console.WriteLine($"Ring area: {area:F2}");
        }
    }
}
