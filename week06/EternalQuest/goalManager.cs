using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalQuest
{
    internal class GoalManager 
    {

        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Quit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetail(); break;
                    case "3": RecordEvent(); break;
                    case "4": SaveGoal(); break;
                    case "5": LoadGoal(); break;
                    case "6": running = false; break;
                    default: Console.WriteLine("Invalid option."); break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            int level = _score / 1000 + 1;
            Console.WriteLine($"Score: {_score} | Level: {level}");
        }

        public void ListGoalNames()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        public void ListGoalDetail()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals have been added.");
                return;
            }

            Console.WriteLine("Goals:");
            ListGoalNames();
        }

        public void CreateGoal()
        {
            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Enter your choice: ");
            string type = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();

            Console.Write("Enter point value: ");
            int points = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus for completion: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid type selected.");
                    break;
            }
        }

        public void RecordEvent()
        {
            ListGoalDetail();
            Console.Write("Which goal did you complete? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                int points = _goals[index].RecordEvent();
                _score += points;

                Console.WriteLine($"Event recorded! Points gained: {points}");

                if (_goals[index] is ChecklistGoal && _goals[index].IsComplete())
                {
                    Console.WriteLine("🎉 Badge Earned! Completed checklist goal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }

        public void SaveGoal()
        {
            Console.Write("Enter file name to save: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved.");
        }

        public void LoadGoal()
        {
            Console.Write("Enter file name to load: ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                _goals.Clear();
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string type = parts[0];

                    switch (type)
                    {
                        case "SimpleGoal":
                            var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            if (bool.Parse(parts[4])) sg.RecordEvent();
                            _goals.Add(sg);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "ChecklistGoal":
                            var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            for (int c = 0; c < int.Parse(parts[6]); c++) cg.RecordEvent();
                            _goals.Add(cg);
                            break;
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}