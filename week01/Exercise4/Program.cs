using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            string numberString = (Console.ReadLine());
            int number = int.Parse(numberString);
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        int total = 0;
       
        foreach (int number in numbers)
        {
            total = total + number; 
        }
        double average = total/numbers.Count;
        int maximumNumber = numbers.Max();
        int smallestPositivenumber = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The maximumNumber is {maximumNumber}");
        Console.WriteLine($"The miniumNumber is {smallestPositivenumber}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}