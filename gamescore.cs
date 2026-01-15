using System;

class GameScore
{
    static void Main()
    {
        int playerA = 20, playerB = 15;

        Console.WriteLine("Player A scored more than B? " + (playerA > playerB));
        Console.WriteLine("Scores are equal? " + (playerA == playerB));
        Console.WriteLine("Player A failed to beat B? " + (playerA <= playerB));
        Console.WriteLine("Player B failed to beat A? " + (playerB <= playerA));
    }
}
