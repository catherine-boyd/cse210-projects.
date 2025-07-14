using System;

namespace Jessica
{
    internal class Resume

    {
        private string _name = "";
        private List<Job> _jobs = new List<Job>();
        
        public void Display()
        {
            Console.WriteLine($"{_name}");
            foreach (Job job in _jobs)
            {
                Console.WriteLine($"{job}");
            }
        }
    }
}

