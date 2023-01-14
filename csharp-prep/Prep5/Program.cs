using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       string userName = PromptUserName();
       int userNumber = PromptUserNumber();
       int userSquare = SquareNumber(userNumber);
       DisplayResult(userName, userSquare); 
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int userNumber = int.Parse(input);

        return userNumber;
    }


    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}