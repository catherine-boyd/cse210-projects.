using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindfulness;

namespace Mindfulness
{
    internal class BreathingActivity:Activity
    {

        public BreathingActivity(string name, string description) : base(name, description) { }

        public override void Run()
        {
            int interval = 6;
            int elapsed = 0;

            while (elapsed < _duration)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(3);
                Console.WriteLine("Now breathe out...");
                ShowCountdown(3);
                elapsed += interval;
            }
        }
    }
}