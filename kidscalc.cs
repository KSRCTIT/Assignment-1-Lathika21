using System;

class KidsCalculator
{
    static void Main()
    {
        int a = 10, b = 5;

        Console.WriteLine("Total apples = " + (a + b));
        Console.WriteLine("Difference of pencils = " + (a - b));
        Console.WriteLine("Total pages (10 pages copied 5 times) = " + (a * b));
        Console.WriteLine("Chocolates per kid = " + (a / b));
        Console.WriteLine("Leftover candies = " + (a % b));
    }
}
