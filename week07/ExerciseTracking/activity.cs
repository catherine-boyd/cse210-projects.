using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    internal abstract class Activity
    {

        protected string _date;
        protected int _minutes;

        public Activity(int minutes, string date)
        {
            _date = date;
            _minutes = minutes;
        }
        public abstract double GetSpeed();
        public abstract double GetPace();
        public abstract double GetDistance();
        public abstract string GetSummary();
    }
}
