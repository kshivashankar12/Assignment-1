using System;

class Program
{
    static void Main()
    {
        int x, y, z;

        Console.Write("Enter first number: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        y = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        z = int.Parse(Console.ReadLine());

        int result1 = (x + y) * z;
        int result2 = (x * y) + (y * z);

        Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y)*z is {result1} and x*y + y*z is {result2}");

       
        Console.ReadLine();
    }
}
