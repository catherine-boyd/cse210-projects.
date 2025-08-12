using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalQuest
{
    internal class ChecklistGoal : Goal
    {

        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = 0;
        }

        public override int RecordEvent()
        {
            if (_amountCompleted < _target)
            {
                _amountCompleted++;
                if (_amountCompleted == _target)
                {
                    return _points + _bonus;
                }
                return _points;
            }
            return 0;
        }

        public override bool IsComplete() => _amountCompleted >= _target;

        public override string GetDetailsString()
        {
            return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
        }
    }
}