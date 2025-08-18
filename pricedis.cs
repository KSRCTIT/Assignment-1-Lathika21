using System;

class PriceDiscountt
{
    static void Main()
    {
        double price = 1000.0;
        double discount = 10.0; // percentage
        double finalPrice = price - (price * discount / 100.0);

        Console.WriteLine("Final Price after discount: " + finalPrice);
    }
}
