using System;
using System.Collections.Generic;

namespace GuessTheWord
{
    public class Program
    {
        private static void Main(string[] args)
        {
            IView view = new UglyView();

            // Create a new instance of the player listing program
            Controller controller = new Controller(view);

            // Start the program instance
            controller.Start();
        }   
    }
}
