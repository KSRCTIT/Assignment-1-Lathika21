using System;

class MultiplicationTable
{
    static void Main()
    {
        char choice = 'Y';

        while (choice == 'Y' || choice == 'y')
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication Table of " + num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }

            Console.Write("Do you want to try another number? (Y/N): ");
            choice = Convert.ToChar(Console.ReadLine());
        }
    }
}
