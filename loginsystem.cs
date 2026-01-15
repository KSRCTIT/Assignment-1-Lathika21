using System;

class LoginSystem
{
    static void Main()
    {
        string username = "admin";
        string password = "1234";

        bool isUserValid = username == "admin";
        bool isPassValid = password == "1234";

        
        if (isUserValid && isPassValid)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("At least one correct? " + (isUserValid || isPassValid));

        Console.WriteLine("Opposite of isUserValid = " + (!isUserValid));
        Console.WriteLine("Opposite of isPassValid = " + (!isPassValid));
    }
}
