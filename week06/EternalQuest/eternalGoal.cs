using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalQuest
{
    internal class EternalGoal : Goal
    {

        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            return _points;
        }

        public override bool IsComplete() => false;

        public override string GetDetailsString()
        {
            return $"[∞] {_shortName} ({_description})";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{_shortName}|{_description}|{_points}";
        }
    }
}
