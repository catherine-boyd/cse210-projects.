using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindfulness
{
    internal class Activity
    {

        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void Run()
        {

        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"\n=== {_name} ===");
            Console.WriteLine($"{_description}\n");
            Console.WriteLine("How long, in seconds, would you like this session to last?");
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done!");
            ShowSpinner(2);
            Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write("\b\b  \b\b");
            }
            Console.WriteLine();
        }

        public void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public void SetDuration(int duration)
        {
            _duration = duration;
        }
    }
}
