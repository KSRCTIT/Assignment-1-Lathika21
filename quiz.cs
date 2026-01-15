using System;

class Quiz
{
    static void Main()
    {
        int score = 50;
        Console.WriteLine("Starting Score = " + score);

        score += 10;  // Correct answer
        Console.WriteLine("After correct answer = " + score);

        score -= 5;   // Wrong answer
        Console.WriteLine("After wrong answer = " + score);

        score *= 2;   // Bonus round
        Console.WriteLine("After bonus round = " + score);

        score /= 5;   // Penalty
        Console.WriteLine("After penalty = " + score);
    }
}
