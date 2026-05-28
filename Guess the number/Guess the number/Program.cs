using System;
using System.Collections.Generic;

class GuessTheNumberGame
{
    private static List<int> roundScores = new List<int>();
    private static Random random = new Random();
    private const int MaxAttempts = 10;
    private const int MaxNumber = 100;

    static void Main()
    {
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║    Welcome to Guess the Number Game!   ║");
        Console.WriteLine("╚════════════════════════════════════════╝\n");

        bool playAgain = true;

        while (playAgain)
        {
            PlayRound();
            playAgain = AskToPlayAgain();
        }

        EndGame();
    }

    static void PlayRound()
    {
        int secretNumber = random.Next(1, MaxNumber + 1);
        int attempts = 0;
        int guess = -1;
        bool roundWon = false;

        Console.WriteLine($"\n🎮 Starting a new round! Guess a number between 1 and {MaxNumber}.");
        Console.WriteLine($"You have {MaxAttempts} attempts.\n");

        while (attempts < MaxAttempts && !roundWon)
        {
            attempts++;
            Console.Write($"Attempt {attempts}/{MaxAttempts} - Enter your guess: ");

            if (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > MaxNumber)
            {
                Console.WriteLine($"❌ Invalid input! Please enter a number between 1 and {MaxNumber}.\n");
                attempts--;
                continue;
            }

            if (guess == secretNumber)
            {
                roundWon = true;
                int points = CalculatePoints(attempts);
                roundScores.Add(points);

                Console.WriteLine($"\n🎉 Correct! The number was {secretNumber}!");
                Console.WriteLine($"⭐ Points Earned: {points}\n");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine($"📈 Too low! Try higher.\n");
            }
            else
            {
                Console.WriteLine($"📉 Too high! Try lower.\n");
            }
        }

        if (!roundWon)
        {
            Console.WriteLine($"\n😢 Game Over! The correct number was {secretNumber}.");
            Console.WriteLine($"❌ Points Earned: 0\n");
            roundScores.Add(0);
        }

        DisplayStats();
    }

    static int CalculatePoints(int attempts)
    {
        // More attempts = fewer points
        return Math.Max(0, (MaxAttempts - attempts + 1) * 10);
    }

    static void DisplayStats()
    {
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║          Game Statistics               ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.WriteLine($"Rounds Played: {roundScores.Count}");

        if (roundScores.Count > 0)
        {
            int totalPoints = 0;
            int winsCount = 0;

            foreach (var score in roundScores)
            {
                totalPoints += score;
                if (score > 0) winsCount++;
            }

            double averagePoints = (double)totalPoints / roundScores.Count;

            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine($"Average Points: {averagePoints:F2}");
            Console.WriteLine($"Rounds Won: {winsCount}");
            Console.WriteLine($"Win Rate: {(winsCount * 100.0 / roundScores.Count):F1}%");
        }

        Console.WriteLine();
    }

    static bool AskToPlayAgain()
    {
        while (true)
        {
            Console.Write("Do you want to play another round? (y/n): ");
            string response = Console.ReadLine()?.ToLower() ?? "";

            if (response == "y" || response == "yes")
                return true;
            else if (response == "n" || response == "no")
                return false;
            else
                Console.WriteLine("❌ Invalid input! Please enter 'y' or 'n'.\n");
        }
    }

    static void EndGame()
    {
        Console.WriteLine("\n╔════════════════════════════════════════╗");
        Console.WriteLine("║        Final Game Statistics           ║");
        Console.WriteLine("╚════════════════════════════════════════╝");

        if (roundScores.Count > 0)
        {
            int totalPoints = 0;
            int winsCount = 0;

            foreach (var score in roundScores)
            {
                totalPoints += score;
                if (score > 0) winsCount++;
            }

            double averagePoints = (double)totalPoints / roundScores.Count;

            Console.WriteLine($"Total Rounds Played: {roundScores.Count}");
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine($"Average Points Per Round: {averagePoints:F2}");
            Console.WriteLine($"Rounds Won: {winsCount}/{roundScores.Count}");
            Console.WriteLine($"Win Rate: {(winsCount * 100.0 / roundScores.Count):F1}%");
        }
        else
        {
            Console.WriteLine("No rounds were played.");
        }

        Console.WriteLine("\nThanks for playing! 👋");
    }
}
