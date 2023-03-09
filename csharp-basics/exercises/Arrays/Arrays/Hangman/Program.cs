namespace Hangman;
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "apple", "banana", "cherry", "orange", "pear" };
        Random random = new Random();
        string wordToGuess = words[random.Next(words.Length)];
        int maxGuesses = 6;
        string lettersGuessed = "";
        string currentGuess = new string('_', wordToGuess.Length);

        Console.WriteLine("Welcome to the word-guessing game! You have {0} guesses to guess the word.", maxGuesses);

        while (maxGuesses > 0 && currentGuess.Contains('_'))
        {
            Console.WriteLine(DrawLine());
            Console.WriteLine("Current guess: {0}", currentGuess);
            Console.WriteLine("Letters guessed: {0}", lettersGuessed);
            Console.WriteLine("Guesses left: {0}", maxGuesses);

            Console.Write("Guess a letter: ");
            string guess = Console.ReadLine()!;

            if (guess.Length != 1)
            {
                Console.WriteLine("Please enter a single letter.");
                continue;
            }

            lettersGuessed += guess;

            if (wordToGuess.Contains(guess))
            {
                Console.WriteLine("Correct!");
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess[0])
                    {
                        currentGuess = currentGuess.Remove(i, 1).Insert(i, guess);
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect.");
                maxGuesses--;
            }
        }

        if (maxGuesses == 0)
        {
            Console.WriteLine("Sorry, you ran out of guesses. The word was '{0}'.", wordToGuess);
        }
        else
        {
            Console.WriteLine("Congratulations, you guessed the word '{0}' with {1} guesses left!", wordToGuess, maxGuesses);
        }

        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }

    static string DrawLine()
    {
        var line = string.Concat(Enumerable.Repeat("-=", 20));
        return line;
    }
}