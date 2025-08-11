using System;
using System.Collections.Generic;
using System.Threading;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu menu = new Menu();
            menu.ShowMenu();
            string input = Console.ReadLine();
            if (input == "4")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }

            int activityValue;
            if (!int.TryParse(input, out activityValue) || activityValue < 1 || activityValue > 3)
            {
                Console.WriteLine("Invalid input. Please select a number between 1 and 3.");
                continue;
            }

            Activity activity;

            switch (activityValue)
            {
                case 1:
                    activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    break;
                case 2:
                    activity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    break;
                case 3:
                    activity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    continue;
            }

            activity.DisplayStartingMessage();
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Please enter a positive number for duration:");
            }
            activity.SetDuration(duration);

            Console.WriteLine("Prepare to begin...");
            activity.ShowSpinner(3);

            activity.Run();

            activity.DisplayEndingMessage();
        }
    }
}
