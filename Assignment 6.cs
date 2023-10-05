using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the amount of Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double kelvin = celsius + 273.15;

        
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Kelvin = {kelvin:F0}");
        Console.WriteLine($"Fahrenheit = {fahrenheit:F0}");

        
        Console.ReadLine();
    }
}

