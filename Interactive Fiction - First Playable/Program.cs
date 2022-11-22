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
        static bool stillReadingBook = true;
        static void Main(string[] args)
        {
            StartGame();
            while (true)
            {
                PickPlot();
                MakeYourChoice();
                if (!stillReadingBook)
                {
                    break;
                }
                WaitForDecision();
            }
            Console.WriteLine();
            Console.WriteLine("You've reached the end, friend.");
            Console.WriteLine();
            Console.ReadKey();
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
                case 2:
                    Console.WriteLine("You tiptoe. The eyes vanish and you see a glimpse of the body.");
                    break;
                case 3:
                    Console.WriteLine("You dash left into the kitchen and look out the window. You see it now, it's a wolf.");
                    break;
            }
        }

        static void MakeYourChoice()
        {
            switch (pageNumber)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("MAKE YOUR CHOICE:");
                    Console.WriteLine();
                    Console.WriteLine("A - You take a few steps closer... - Go to Page 2");
                    Console.WriteLine("B - You run into the house and lock the front door. - Go to Page 3");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("MAKE YOUR CHOICE:");
                    Console.WriteLine();
                    Console.WriteLine("A - You chase the figure. - Go to Page 10");
                    Console.WriteLine("B - You pretend like you never saw anything. - Go to Page 27");
                    break;
                case 3:
                    Console.WriteLine("You reassure your family that everything is alright and you all go to bed feeling safe from the dangers of the outside world.");
                    stillReadingBook = false;
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
                case 2:
                    var key2 = Console.ReadKey().Key;
                    switch (key2)
                    {
                        case ConsoleKey.A:
                            pageNumber = 10;
                            break;
                        case ConsoleKey.B:
                            pageNumber = 27;
                            break;
                    }
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
