using System;

class Program
{
    static void Main()
    {
        double num1, num2;

        Console.Write("Enter the first number: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = double.Parse(Console.ReadLine());

       
        double sum = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {sum}");

        
        double difference = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {difference}");

        double product = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {product}");

       
        if (num2 != 0)
        {
            double quotient = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {quotient}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }

        Console.ReadLine();
    }
}
