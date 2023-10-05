using System;

class Program
{
    static void Main()
    {
        double num1, num2, num3, result;

        Console.Write("Input the first number to multiply: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Input the second number to multiply: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Input the third number to multiply: ");
        num3 = double.Parse(Console.ReadLine());

        // Calculate the multiplication
        result = num1 * num2 * num3;

        // Display the result in the specified format
        Console.WriteLine($"{num1} x {num2} x {num3} = {result}");

        // Pause to see the result
        Console.ReadLine();
    }
}

