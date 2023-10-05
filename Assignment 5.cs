using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int number = int.Parse(Console.ReadLine());

        
        Console.Write("{0} {0} {0} {0}", number);
        Console.WriteLine(); 

    
        Console.WriteLine("{0}{0}{0}{0}", number);

      
        Console.Write("{0} {0} {0} {0}", number);
        Console.WriteLine();

        Console.WriteLine("{0}{0}{0}{0}", number);
        Console.ReadLine();
    }
}
