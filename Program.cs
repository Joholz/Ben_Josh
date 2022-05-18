using System;

namespace ConsoleApp_Dev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Making changes");

            Console.WriteLine();

            Console.WriteLine("My name is Josh");

            Console.WriteLine();

            Console.WriteLine("I am the best coder of all time");
            
            
            //a couple breaks here to add some space between title
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); 

            ///as a title, let us change the background color for the title to stand out more
            Console.BackgroundColor = ConsoleColor.Green; //change bg color to greeen
            Console.ForegroundColor = ConsoleColor.DarkBlue; //change our text color to dark blue
            Console.WriteLine("!!!!!!!!Guess My Number!!!!!!!!"); //write our text out so it 
            Console.ForegroundColor = ConsoleColor.White; //undo our color change...change our text back to white
            Console.BackgroundColor = ConsoleColor.Black; //undo our bg color change....change our bg back to black


            //c# already has an object used for generating Random....it's called Random 
            Random rnd = new Random(); //this will be used solely for generating random numbers
            
            //We have the Random object but need to tell it what to do
            int theRandomNumber = rnd.Next(100); //generate a random number...highest random number can only be 100 because of the parameter (100)



            Console.WriteLine("The random number is between 1 - 100");

          

            Boolean youWin = false; //this will tell us if the user got the answer right or not

            int maximumNumberOfGuesses = 10; //we are going to give the user 10 guesses
            int guessNumber = 0; //this is going to be how many guesses they user has used...since it is the beginning of the game, we set this to 0. We will increment this in the 'do while loop' as the user plays
            do { //start our guessing loop 
                guessNumber = guessNumber + 1; //keep track of the user guesses. Everytime they guess again, we increase this number by 1
                //get the value the user typed
                string whatTheUserTyped = Console.ReadLine();

                //convert what the user typed into a number
                int numberGuess1 = Convert.ToInt32(whatTheUserTyped); //we need to do this because we will compare numbers. Their number guessed VS Random number generated

                if (numberGuess1 == theRandomNumber) { //check to see if their answer EQUALS the random number we generated
                    Console.WriteLine("Your guess was CORRECT");
                    youWin = true;
                
                }



                if (numberGuess1 < theRandomNumber) { //check to see if their answer is LOWER than the rnadom number we generated
                    Console.WriteLine("Your answer was too low, sorry man");
                }


                if (numberGuess1 > theRandomNumber) { //check to see if their answer it HIGHER than random number generated
                    Console.WriteLine("Your answer was too high, sorry man");

                }


                /****************************************************************************************/
                //TODO BEN: Add 'if' condition to check if they have reached their maximum number of guesses
                //          If they have used all of their guesses....we want to exit the game and tell them they lose
                //          Exiting the game in this case will just be exiting this 'do while loop'
                //          You may need to search "How to exit do while loop in c#" to find how to force exit this loop
                //          link that may also help: https://www.tutorialsteacher.com/csharp/csharp-do-while-loop




            } while (youWin == false); //keep looping over and over again...we will do this until *youWin = true*....aka user got the answer right


            Console.WriteLine("Press any key to exit");


            Console.ReadKey();//this code waits for the user to press something on their keyboard...we have basically paused the program right here
            //right after any key is pressed on the keyboard the code will continue running


            Environment.Exit(0); //this will close our application



        }
    }
}
