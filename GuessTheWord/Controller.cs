using System;
using System.Collections.Generic;
using System.Dynamic;

namespace GuessTheWord
{
    public class Controller
    {
        private readonly IView view;

        public Controller(IView view)
        {
            this.view = view;
        }

        public void Start()
        {
            IDictionary<string, string> wordsWithHints = new Dictionary<string, string>()
            {
                { "apple", "fruit" },
                { "banana", "fruit" },
                { "tiger", "animal" },
                { "elephant", "animal" },
                { "guitar", "instrument" },
                { "violin", "instrument" },
                { "canada", "country" },
                { "brazil", "country" },
                { "laptop", "object" },
                { "microscope", "scientific instrument" }
            };

            // Select a random word
            Random rand = new Random();
            List<string> words = new List<string>(wordsWithHints.Keys);
            string chosenWord = words[rand.Next(words.Count)];
            string hint = wordsWithHints[chosenWord];
            

            Game game = new Game(chosenWord, hint);

            Console.WriteLine("Guess the full word!");
            Console.WriteLine($"Hint: It's a {hint}.");
            Console.WriteLine($"Word: {game.GetWord()}");

            string guess;
            do
            {
                guess = view.AskPlayerGuess();

                if (guess != chosenWord)
                    view.ShowIncorrectMessage();
            } while (guess != chosenWord);

            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
        }
    }
}