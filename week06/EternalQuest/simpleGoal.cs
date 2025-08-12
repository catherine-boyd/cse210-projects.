using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalQuest
{
    internal class SimpleGoal : Goal
    {

        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                return _points;
            }
            return 0;
        }

        public override bool IsComplete() => _isComplete;

        public override string GetDetailsString()
        {
            return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
        }
    }
}
