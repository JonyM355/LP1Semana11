using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class UglyView : IView
    {
        public Player AskPlayerInfo()
        {
            string name;
            int score;

            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            return new Player(name, score);
        }

        public string MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");

            return Console.ReadLine();
        }

        public void ShowByeMessage()
        {
            Console.WriteLine("Bye!");
        }

        public void ShowPressKeyMessage()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }

        public void ShowUnknownOptMessage()
        {
            Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
        }
    }
}