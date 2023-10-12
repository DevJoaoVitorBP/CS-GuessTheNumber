/*
Author: João Pereira
Description: A simple number guessing game
*/

using System;

class Program{
    static void Main(String[] args){
        Random random = new Random(); // Create a random object
        int number; // Declare number outside the loop
        int tries; // Variable to count the number of tries
        int guess; // Declare guess outside the loop
        string playAgain; // Declare playAgain outside the loop

    do{
        number = random.Next(1, 100); // Generate a random number between 1 and 100
        tries = 0; // Initialize tries at the start of each game
        guess = 0; // Initialize guess at the start of each game

        do{
            Console.WriteLine("\n\n-----------------------------");
            Console.Write("Guess a number between 1 and 100: ");
            try {
                guess = int.Parse(Console.ReadLine()); // Get the user inputs
                tries++; // Increase the count of tries

                // If the guess is greater than the number
                if(guess > number){
                    Console.WriteLine("\nLower! Try again.");
                }
                
                // If the guess is lower than the number
                else if(guess < number){
                    Console.WriteLine("\nHigher! Try again.");
                }

                // If the guess is equal to the number
                else{
                    Console.WriteLine("\nCongratulations! You guessed it in " + tries + " tries!");
                }
            } catch (FormatException) {
                Console.WriteLine("\nPlease enter a valid number.");
                continue;
            }
        }
        
        // While the guess is not equal to the number the loop will continue until the user guesses the number
        while(guess != number);

        // Ask the user if he wants to play again
        Console.Write("\nDo you want to play again? (yes/no): ");
        playAgain = Console.ReadLine();

    // If the user inputs yes the game will start again
    } while(playAgain.ToLower() == "yes");
    }
}
