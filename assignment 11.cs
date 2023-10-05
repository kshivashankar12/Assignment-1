using System;

class ps11
{
    
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int maximumNumber = Math.Max(firstNumber, secondNumber);
        int minimumNumber = Math.Min(firstNumber, secondNumber);

        Console.WriteLine($"Maximum number: {maximumNumber}");
        Console.WriteLine($"Minimum number: {minimumNumber}");
        Console.Read();
    }
}