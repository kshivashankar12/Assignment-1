using System;

class Program
{
    static void Main()
    {
        int num1, num2, temp;

        Console.Write("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);
        Console.ReadLine();
    }
}
