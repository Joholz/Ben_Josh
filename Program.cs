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

            do { //start our guessing loop 

                //get the value the user typed
                string whatTheUserTyped = Console.ReadLine();

                //convert what the user typed into a number
                int numberGuess1 = Convert.ToInt32(whatTheUserTyped); //we need to do this because we will compare numbers. Their number guessed VS Random number generated

                if (numberGuess1 == theRandomNumber) { //check to see if their answer EQUALS the random number we generated
                    //TODO BEN: add text here 
                    Console.WriteLine("Your guess was CORRECT");
                    youWin = true;
                
                }



                if (numberGuess1 < theRandomNumber) { //check to see if their answer is LOWER than the rnadom number we generated
                    //TODO BEN: add text here 
                    Console.WriteLine("Your answer was too low, sorry man");
                }


                if (numberGuess1 > theRandomNumber) { //check to see if their answer it HIGHER than random number generated
                    //TODO BEN: add text here 
                    Console.WriteLine("Your answer was too high, sorry man");

                }

            } while (youWin == false); //keep looping over and over again...we will do this until *youWin = true*....aka user got the answer right


            Console.WriteLine("Press any key to exit");


            Console.ReadKey();//this code waits for the user to press something on their keyboard...we have basically paused the program right here
            //right after any key is pressed on the keyboard the code will continue running


            Environment.Exit(0); //this will close our application



        }
    }
}
