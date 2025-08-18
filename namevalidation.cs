using System;

class NameValidation
{
    static bool IsValidName(string name)
    {
        foreach (char c in name)
        {
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (IsValidName(name))
            Console.WriteLine("Valid name. Proceed for ID card printing.");
        else
            Console.WriteLine("Invalid name! Only letters and spaces are allowed.");
    }
}
