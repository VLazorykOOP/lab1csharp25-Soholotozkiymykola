using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Error: The number must be three-digit.");
        }
        else
        {
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            if (firstDigit == secondDigit && secondDigit == thirdDigit)
            {
                Console.WriteLine("All digits are the same.");
            }
            else
            {
                Console.WriteLine("Digits are different.");
            }
        }
    }
}
