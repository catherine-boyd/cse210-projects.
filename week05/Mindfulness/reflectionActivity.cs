using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindfulness;
namespace Mindfulness
{
    internal class ReflectionActivity:Activity
    {

        private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

        private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

        public ReflectionActivity(string name, string description) : base(name, description) { }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }

        private string GetRandomQuestion()
        {
            Random rand = new Random();
            return _questions[rand.Next(_questions.Count)];
        }

        public override void Run()
        {
            Console.WriteLine($"\nPrompt: {GetRandomPrompt()}");
            ShowSpinner(3);

            int elapsed = 0;
            int interval = 8;

            while (elapsed < _duration)
            {
                string question = GetRandomQuestion();
                Console.WriteLine($"\n{question}");
                ShowSpinner(interval);
                elapsed += interval;
            }
        }
    }
}
