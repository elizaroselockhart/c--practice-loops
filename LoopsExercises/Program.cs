using System;

namespace LoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();

                Console.WriteLine("Welcome to CyberLoops, where we loop your stuff real good.\n");
                Console.WriteLine("Today we'll be doing some looping exercises, which are sure to exercise your brain...");
                Console.WriteLine("...Or at least exercise the brain of the person writing the code!");
                Console.WriteLine("\nWhich exercise would you like to run?");
                Console.WriteLine("1. Print Numbers in Reverse Order");
                Console.WriteLine("2. Reverse Counting");
                Console.WriteLine("3. Print the Square of Even Numbers");
                Console.WriteLine("4. Guess the Magic Number");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        NumbersInReverse();
                        break;
                    case "2":
                        ReverseCounting();
                        break;
                    case "3":
                        SquareOfEvenNumbers();
                        break;
                    case "4":
                        GuessMagicNumber();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // Enter your solution here

            Console.WriteLine("Now, CyberLoops will perform a magic trick!");
            Console.WriteLine("Press any key to see the trick.");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            for (int i = 5; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            // Plays a short A, F, C, A# tune.
            Console.Beep(220, 250);
            Console.Beep(349, 250);
            Console.Beep(262, 250);
            Console.Beep(233, 500);


            Console.WriteLine("\nTa - da!\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Press enter to return to the Main Menu.");
            Console.ReadLine();
        }


        static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // Enter your solution here

            Console.WriteLine("Now, CyberLoops will perform a magic trick!");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter ANY number!");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = number; i > 0; i--)
            {
                Console.Write(i + " ");
            }

            // Plays a short A, F, C, A# tune.
            Console.Beep(220, 250);
            Console.Beep(349, 250);
            Console.Beep(262, 250);
            Console.Beep(233, 500);
            Console.WriteLine("\nTa da!\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SquareOfEvenNumbers()
        {
            // Print the squares (the number multiplied by itself) for even numbers between 1-9. For the odd numbers, just print them.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // Enter your solution here

            Console.WriteLine("Now, CyberLoops will perform a magic trick!");
            Console.WriteLine("Press any key to see the trick.");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 1; i < 10; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(i * i + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            // Plays a short A, F, C, A# tune.
            Console.Beep(220, 250);
            Console.Beep(349, 250);
            Console.Beep(262, 250);
            Console.Beep(233, 500);
            Console.WriteLine("\nTa - da!\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            Console.WriteLine("Now, we are going to play a game!");
            Console.Write("Guess a number and we'll tell you if you've ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("W"); 
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("O"); 
            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("N");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("!"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("!"); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("!\n");
            Console.ForegroundColor = ConsoleColor.Green;

            int userInput = Convert.ToInt32(Console.ReadLine()); // This reads the user's input and converts it to an integer. We'll assume that users can only input integers.
            // Enter your solution here.

            int youWon = 0;

            while (youWon != 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if ((userInput % 3) == 0)
                {
                    //Gmajor Scale
                    // G, A, B, C, D, E, F#, high G
                    Console.Beep(196, 200);
                    Console.Beep(220, 200);
                    Console.Beep(247, 200);
                    Console.Beep(262, 200);
                    Console.Beep(294, 200);
                    Console.Beep(330, 200);
                    Console.Beep(370, 200); //for some reason it doesn't play past this? Idk why. :(
                    Console.Beep(392, 750);

                    Console.Write("You ");
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("W");
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("O");
                    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("N");
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("!"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("!"); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("!\n");

                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    youWon = 1;
                }

                else
                {
                    //three G
                    Console.Beep(196, 100);
                    Console.Beep(196, 100);
                    Console.Beep(196, 100);
                    
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Try again.");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
