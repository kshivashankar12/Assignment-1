using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        
        double absoluteDifference = Math.Abs(num1 - num2);

        
        if (num1 > num2)
        {
            
            double result = 2 * absoluteDifference;
            Console.WriteLine($"The first number is greater. Double the absolute difference = {result}");
        }
        else
        {
            Console.WriteLine($"The absolute difference = {absoluteDifference}");
        }

       
        Console.ReadLine();
    }
}
