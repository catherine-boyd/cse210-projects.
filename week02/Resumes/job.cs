using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jessica
{
    internal class Job
    {
       public string _company = "";
       public string _jobTitle = "";
       public int _startYear = 0;
        public int _endYear = 0;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
        }
    }
}
