using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
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
