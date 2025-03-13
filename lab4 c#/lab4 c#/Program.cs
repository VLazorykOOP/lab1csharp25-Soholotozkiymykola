using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter gender (m - male, f - female): ");
        char gender = Char.ToLower(Convert.ToChar(Console.ReadLine()));

        if (gender == 'm')
        {
            Console.WriteLine("Possible male names: John, Michael, David, Alex, James");
        }
        else if (gender == 'f')
        {
            Console.WriteLine("Possible female names: Emily, Sarah, Jessica, Anna, Sophia");
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Enter 'm' or 'f'.");
        }
    }
}
