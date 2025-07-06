using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        int magicNumber = random.Next(1, 100);
        int numberOfGuesses = 1;
        while (true)
        {
            Console.WriteLine("What is your guess? ");
            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);
            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You have guessed {numberOfGuesses} times.");
                Console.WriteLine("Do you want to play the game again? Yes(Y) or No(N)");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "Y")
                {
                    numberOfGuesses = 0;
                    random = new Random();
                    magicNumber = random.Next(1, 100);
                }
                else
                {
                    break;
                }
                   
            }
            numberOfGuesses++;
        }
       
    }   
}

