using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        String stringGrade = Console.ReadLine();
        int grade = int.Parse(stringGrade);
        string letter = "";

        if (grade >= 90)
        {
            var lastDigit = char.GetNumericValue(stringGrade.ToArray()[1]);
            if (lastDigit < 3)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }

        }
        else if (grade >= 80)
        {
            var lastDigit = char.GetNumericValue(stringGrade.ToArray()[1]);
            if (lastDigit < 3)
            {
                letter = "B-";
            }
            else if (lastDigit >= 7)
            {
                letter = "B+";
            }
            else
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            var lastDigit = char.GetNumericValue(stringGrade.ToArray()[1]);
            if (lastDigit < 3)
            {
                letter = "C-";
            }
            else if (lastDigit >= 7)
            {
                letter = "C+";
            }
            else
            {
                letter = "C";
            }
        }
        else if (grade >= 60)
        {
            var lastDigit = char.GetNumericValue(stringGrade.ToArray()[1]);
            if (lastDigit < 3)
            {
                letter = "D-";
            }
            else if (lastDigit >= 7)
            {
                letter = "D+";
            }
            else
            {
                letter = "D";
            }

        }
        else if (grade < 60)
        {
             letter = "F";
        }
        Console.WriteLine($"{letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Pass, congratulations.You did a great job!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("Failed, try harder next time.");
        }

    }
}