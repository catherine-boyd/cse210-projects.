using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    internal class Swimming : Activity
    {

        private int _laps;
        public Swimming(int laps, int minutes, string date)
            : base(minutes, date)
        {
            _laps = laps;
        }
        public override double GetDistance()
        {
            return (_laps * 50) / 1000;
        }
        public override double GetSpeed()
        {
            return (GetDistance() / _minutes) * 60;
        }
        public override double GetPace()
        {
            return 60 / GetSpeed();
        }
        public override string GetSummary()
        {
            return _date + " (" + _minutes + "min)- Distance " + GetDistance() + " km, Speed: " + GetSpeed() + " kph, Pace:" + GetPace() + " min per km";
        }
    }
}
