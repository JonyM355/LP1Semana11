using System;

namespace GuessTheWord
{
    public class UglyView : IView
    {
        public string AskPlayerGuess()
        {
            Console.Write("Your guess: ");
            return Console.ReadLine().Trim().ToLower();
        }

        public void ShowIncorrectMessage()
        {
            Console.WriteLine("Incorrect. Try again.");
        }
    }
}