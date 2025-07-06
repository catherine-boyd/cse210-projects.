using System;

class Program
{
    static void Main(string[] args)
    {
        Program.DisplayWelcome();
        string name = Program.PromptUserName();
        int favouriteNumber = Program.PromptUserNumber();
        Program.SquareNumber(name, favouriteNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void SquareNumber(string name , int number)
    {      
        int squaredNumber = number * number;
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}


