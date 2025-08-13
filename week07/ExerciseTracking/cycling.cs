using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    internal class Cycling : Activity
    {

        private int _speed;
        public Cycling(int speed, int minutes, string date)
            : base(minutes, date)
        {
            _speed = speed;
        }


        public override double GetSpeed()
        {
            return _speed;
        }
        public override double GetPace()
        {
            return 60 / _speed;
        }
        public override double GetDistance()
        {
            return (_minutes * _speed) / 60;
        }
        public override string GetSummary()
        {
            return _date + " (" + _minutes + "min)- Distance " + GetDistance() + " km, Speed: " + GetSpeed() + " kph, Pace:" + GetPace() + " min per km";
        }
    }
}