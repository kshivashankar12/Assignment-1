using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;

        if (num1 == num2)
        {
            int tripleSum = 3 * sum;
            Console.WriteLine($"The two integers are equal. Triple of their sum is {tripleSum}");
        }
        else
        {
            Console.WriteLine($"The sum of the two integers is {sum}");
        }

     
        Console.ReadLine();
    }
}
