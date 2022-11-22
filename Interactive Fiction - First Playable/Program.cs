using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction___First_Playable
{
    internal class Program
    {
        static int pageNumber = 1;
        static string storyTitle = "The Time Machine";
        static void Main(string[] args)
        {
            StartGame();
            while (true)
            {
                PickPlot();
                MakeYourChoice();
                WaitForDecision();
            }
        }

        static void StartGame()
        {
            Console.WriteLine("ADJUST CONSOLE SCREEN SIZE");
            Console.WriteLine(". . .then press any key to begin. . .");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Interactive Fiction - First Playable project");
            Console.WriteLine("____________________________________________");
            Console.WriteLine("- Campus: NSCC Truro Campus");
            Console.WriteLine("- Program: Game Development (Common / No Concentration)");
            Console.WriteLine("- Course: Logic and Programming I");
            Console.WriteLine("- Date: November, 2022");
            Console.WriteLine("- Name: Balázs Kiss");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(storyTitle);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("_________");
            Console.WriteLine("A - New Game");
            Console.WriteLine();
            Console.Write("> ");
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("New Game!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PAGE " + pageNumber.ToString() + ":");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void PickPlot()
        {
            switch(pageNumber)
            {
                case 1:
                    Console.WriteLine("You live in the middle of a forest with your wife and two children. You built a house that kept your family warm in Winter, a well that supplied you with clean water and a hunting tower to bring fresh meat. You're cooking the deer you hunted today when you see glowing eyes peering in the moonlight.");
                    break;
            }
        }

        static void MakeYourChoice()
        {
            Console.WriteLine();
            Console.WriteLine("MAKE YOUR CHOICE:");
            Console.WriteLine();
            switch (pageNumber)
            {
                case 1:
                    Console.WriteLine("A - You take a few steps closer... - Go to Page 2");
                    Console.WriteLine("B - You run into the house and lock the front door. - Go to Page 3");
                    break;
            }
        }

        static void WaitForDecision()
        {
            Console.WriteLine();
            Console.Write("> ");
            switch (pageNumber)
            {
                case 1:
                    var key = Console.ReadKey().Key;
                    switch (key)
                    {
                        case ConsoleKey.A:
                            pageNumber = 2;
                            break;
                        case ConsoleKey.B:
                            pageNumber = 3;
                            break;
                    }
                    break;
            }
            Console.WriteLine();
        }
    }
}
