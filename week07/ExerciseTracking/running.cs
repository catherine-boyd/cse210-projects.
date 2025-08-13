using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciseTracking
{
    internal class Running : Activity
    {

        private double _distance;
        public Running(double distance, int minutes, string date)
           : base(minutes, date)
        {
            _distance = distance;
        }
        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetPace()
        {
            return _minutes / _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / _minutes) * 60;
        }
        public override string GetSummary()
        {
            return _date + " (" + _minutes + "min)- Distance " + GetDistance() + " km, Speed: " + GetSpeed() + " kph, Pace:" + GetPace() + " min per km";
        }
    }
}