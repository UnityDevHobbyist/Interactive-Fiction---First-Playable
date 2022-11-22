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
                Console.Clear();
            }
            Console.WriteLine();
            switch (pageNumber)
            {
                case 3:
                    Console.WriteLine("You've unlocked the safe ending.");
                    break;
                case 8:
                    Console.WriteLine("You've unlocked the sad ending.");
                    break;
                case 6:
                    Console.WriteLine("You've unlocked the happy ending.");
                    break;
                case 4:
                    Console.WriteLine("You've unlocked the rough ending.");
                    break;
                case 11:
                    Console.WriteLine("You've unlocked the curious ending.");
                    break;
                case 10:
                    Console.WriteLine("You've unlocked the tiresome ending.");
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static void StartGame()
        {
            Console.WriteLine("ADJUST CONSOLE SCREEN SIZE");
            Console.WriteLine(". . .then press any key to begin. . .");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are 6 possible endings.");
            Console.ForegroundColor = ConsoleColor.White;
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
                    Console.WriteLine("You live in the middle of a forest with your wife and two children. You built a house that keeps your family warm in Winter, a well that supplied you with clean water and a hunting tower to bring fresh meat. You're cooking the deer you hunted today when you see glowing eyes peering in the moonlight.");
                    break;
                case 2:
                    Console.WriteLine("You tiptoe. The eyes vanish and you see a glimpse of the body.");
                    break;
                case 3:
                    Console.WriteLine("You dash left into the kitchen and look out the window. You see it now, it's a wolf.");
                    break;
                case 5:
                    Console.WriteLine("You take your lantern. The figure runs into a cave, you're starting to realize this is dangerous.");
                    break;
                case 7:
                    Console.WriteLine("You forgot where your home is. You start to worry.");
                    break;
                case 8:
                    Console.WriteLine("You're becoming restless and hungry. You hear howling. That's not good. You see the same eyes staring at you. Multiple.");
                    break;
                case 6:
                    Console.WriteLine("The next morning comes, the birds are singing, the sun is shining, your children are calling your name. They found you! You're crying with joy.");
                    break;
                case 4:
                    Console.WriteLine("You're almost back home. You're a bit angry and trip over a twig. Your clothes are dirty. It has been a long day but you're happy now that you're with your family.");
                    break;
                case 9:
                    Console.WriteLine("The cave is dark. The eyes stop and turn toward you. You extend your arm for a better view. It's a wolf.");
                    break;
                case 11:
                    Console.WriteLine("Without showing fear, the wolf runs away into the cave. You get back home and you're greeted with dinner. Your family is relieved that you're back and you finally get some sleep.");
                    break;
                case 10:
                    Console.WriteLine("The wolf chases you. Luckily, there is a big rock that will give you high ground. You climb it and the wolf runs away. You make your way back home.");
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
                    Console.WriteLine("A - Take a few steps closer... - Go to Page 2");
                    Console.WriteLine("B - Run into the house and lock the front door. - Go to Page 3");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("MAKE YOUR CHOICE:");
                    Console.WriteLine();
                    Console.WriteLine("A - Chase the figure. - Go to Page 5");
                    Console.WriteLine("B - Pretend like you never saw anything. - Go to Page 4");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("You reassure your family that everything is alright and you all go to bed feeling safe from the dangers of the outside world.");
                    stillReadingBook = false;
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("MAKE YOUR CHOICE:");
                    Console.WriteLine();
                    Console.WriteLine("A - Go into the cave. - Go to Page 9");
                    Console.WriteLine("B - Head back. - Go to Page 7");
                    break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("MAKE YOUR CHOICE:");
                    Console.WriteLine();
                    Console.WriteLine("A - Climb a tree to sleep in. - Go to Page 6");
                    Console.WriteLine("B - Continue searching. - Go to Page 8");
                    break;
                case 8:
                    stillReadingBook = false;
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("You come back home to a warm vegetable stew. You play ball with your children and you dance with your wife. It has been a wonderful day.");
                    stillReadingBook = false;
                    break;
                case 4:
                    stillReadingBook = false;
                    break;
                case 9:
                    Console.WriteLine();
                    Console.WriteLine("MAKE YOUR CHOICE:");
                    Console.WriteLine();
                    Console.WriteLine("A - Freeze, then stare at the wolf. - Go to Page 11");
                    Console.WriteLine("B - Run away. - Go to Page 10");
                    break;
                case 11:
                    stillReadingBook = false;
                    break;
                case 10:
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
                            pageNumber = 5;
                            break;
                        case ConsoleKey.B:
                            pageNumber = 4;
                            break;
                    }
                    break;
                case 5:
                    var key3 = Console.ReadKey().Key;
                    switch (key3)
                    {
                        case ConsoleKey.A:
                            pageNumber = 9;
                            break;
                        case ConsoleKey.B:
                            pageNumber = 7;
                            break;
                    }
                    break;
                case 7:
                    var key4 = Console.ReadKey().Key;
                    switch (key4)
                    {
                        case ConsoleKey.A:
                            pageNumber = 6;
                            break;
                        case ConsoleKey.B:
                            pageNumber = 8;
                            break;
                    }
                    break;
                case 9:
                    var key5 = Console.ReadKey().Key;
                    switch (key5)
                    {
                        case ConsoleKey.A:
                            pageNumber = 11;
                            break;
                        case ConsoleKey.B:
                            pageNumber = 10;
                            break;
                    }
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
