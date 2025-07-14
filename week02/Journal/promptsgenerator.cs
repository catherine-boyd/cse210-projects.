using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptGenerator
{
    internal class PromptsGenerator
    {
        List<String> _prompts = new List<String>();
        public PromptsGenerator()
        {
            _prompts.AddRange([
                "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
             ]);
        }
        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(0, _prompts.Count); //0 to 5(excluded)
            return _prompts[index];
        }
    }
}
