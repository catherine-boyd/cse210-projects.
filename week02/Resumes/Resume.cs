using Jessica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumes
{
    internal class Resume
    {
        public string _name = "";
        public List<Jessica.Job> _jobs = new List<Jessica.Job>();
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach(Jessica.Job job in _jobs){
                Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear} ");
            }
        }
    }
}