using System;

class PrintWithDatatype
{
    static void Main()
    {
        int age = 25;
        float temperature = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine("Value: " + age + " | Type: " + age.GetType());
        Console.WriteLine("Value: " + temperature + " | Type: " + temperature.GetType());
        Console.WriteLine("Value: " + grade + " | Type: " + grade.GetType());
        Console.WriteLine("Value: " + isPassed + " | Type: " + isPassed.GetType());
    }
}
