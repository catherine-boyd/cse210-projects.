using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindfulness;

namespace Mindfulness
{
    internal class ListingActivity:Activity
    {

        private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

        public ListingActivity(string name, string description) : base(name, description) 
        {

        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }

        public override void Run()
        {
            Console.WriteLine($"\nPrompt: {GetRandomPrompt()}");
            Console.WriteLine("You will begin listing in a moment...");
            ShowCountdown(3);

            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            Console.WriteLine("Start listing items (press Enter after each one):");

            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    string entry = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(entry))
                    {
                        items.Add(entry);
                    }
                }
            }

            Console.WriteLine($"\nYou listed {items.Count} items.");
        }
    }
}
