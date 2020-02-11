using System;

namespace Number_Guess_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            //App setting
            string appName = "Number Guess";
            string versApp = "1.0";
            string author = "Mahdi Burhan";

            //Change Color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Output
            Console.WriteLine($"This is {appName} version {versApp} by {author}");

            //Asking the user to input their name
            Console.WriteLine("Type Name:");
            string userInput = Console.ReadLine();

            Console.WriteLine($"Hello {userInput}, Welcome to the number guesser.....");


            while (true)
            {
                //init correct number that is going to be random
                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //init guess 
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 to 10");


                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //make sure that the player is typing a number

                    if (!int.TryParse(input, out guess))
                    {
                        //Change Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Output
                        Console.WriteLine("This is not a number...");

                        //Reset color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    // make it an int and put it in guess place
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Output
                        Console.WriteLine("Wrong number, try again....");

                        //Reset color
                        Console.ResetColor();
                    }
                }

                //output success message
                if (guess == correctNumber)
                {
                    //Change Color
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //Output
                    Console.WriteLine("Yes, you guessed right...Congrats!");

                    //Reset color
                    Console.ResetColor();
                }

                //Reset color
                Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get the answer on whether they want to play again
                string answer = Console.ReadLine().ToUpper();

                //if else to go with two options
                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }

            } Console.ReadLine();
        }
    }
}
