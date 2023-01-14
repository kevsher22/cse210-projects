using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int randomNumber = randomGenerator.Next(1, 100);

       int condition = 1;
       while (condition == 1)
       {
            Console.Write("What is your guess? ");
            string input2 = Console.ReadLine();
            int userGuess = int.Parse(input2);

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Guess Higher");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                condition = 0;
            } 
       }

      
    }
}