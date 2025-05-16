using System;
using System.Collections.Generic;

namespace GuessTheWord
{
    public class Game
    {
        public string ChosenWord { get; }
        public string Hint { get; }
        private readonly char[] display;

        public Game(string word, string hint)
        {
            ChosenWord = word;
            Hint = hint;
            display = GenerateDisplay(word);
        }

        private char[] GenerateDisplay(string word)
        {
            int length = word.Length;
            int numToReveal = Math.Max(1, (int)Math.Floor(length * 0.4));
            char[] masked = new string('_', length).ToCharArray();

            Random maskRand = new Random(word.GetHashCode());
            HashSet<int> revealedIndices = new HashSet<int>();
            while (revealedIndices.Count < numToReveal)
            {
                int index = maskRand.Next(length);
                revealedIndices.Add(index);
            }

            foreach (int i in revealedIndices)
            {
                masked[i] = word[i];
            }

            return masked;
        }

        public string GetWord()
        {
            return new string(display);
        }
    }
}
