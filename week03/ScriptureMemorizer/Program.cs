using System;
using System.Security.Cryptography.X509Certificates;
using ScriptureMemorizer;
class Program
{
    static void Main(string[] args)
    {
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, text);
        Console.Clear();
        Console.WriteLine($"{scripture.GetDisplayText()}");

        Console.WriteLine("Press the enter key or type quit to exit the program");
        string response = Console.ReadLine();
        while (response != "quit")
        {
            Random random = new Random();
            scripture.HideRandomWords(random.Next(0, text.Split(" ").Length));
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            response = Console.ReadLine();
        }

    }
}
