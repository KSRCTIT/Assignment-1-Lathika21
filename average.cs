using System;

class StudentAverage
{
    static double CalculateAverage(int[] marks)
    {
        int sum = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }
        return (double)sum / marks.Length;
    }

    static void Main()
    {
        int[] marks = new int[5];
        Console.WriteLine("Enter marks for 5 subjects:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        double avg = CalculateAverage(marks);
        Console.WriteLine("Average = " + avg);

        if (avg >= 40)
            Console.WriteLine("Result: Passed");
        else
            Console.WriteLine("Result: Failed");
    }
}
