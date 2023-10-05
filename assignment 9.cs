using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of days: ");
        if (int.TryParse(Console.ReadLine(), out int totalDays))
        {
            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            remainingDays %= 7;

            Console.WriteLine("\nInput Details:");
            Console.WriteLine($"Total Days: {totalDays}");
            Console.WriteLine("\nConversion:");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {remainingDays}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of days.");
        }
    }
}
