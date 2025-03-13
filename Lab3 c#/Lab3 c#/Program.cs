using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double R = 12; // Радіус кола

        bool insideCircle = (x * x + y * y) < (R * R);
        bool onCircle = (x * x + y * y) == (R * R);
        bool belowDiagonal = y < x;
        bool onDiagonal = y == x;
        bool belowXAxis = y < 0;
        bool onXAxis = y == 0 && x >= 0 && x <= R; // Тільки в межах півкола

        if ((insideCircle && belowDiagonal && belowXAxis) ||
            onXAxis || onCircle || onDiagonal)
        {
            if (onCircle || onDiagonal || onXAxis)
                Console.WriteLine("На межі");
            else
                Console.WriteLine("Так");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }
}
