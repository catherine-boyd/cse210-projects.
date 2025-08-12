using System;
using System.Drawing;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}

/*
=============== ?? Report on Exceeding Requirements ===============
-  Added Leveling System (1 level per 1000 points).
-  Badge Notification for completing Checklist Goals.
-  Full Save/Load Functionality with file parsing.
-  Designed for future extensibility (e.g. negative goals, GUI).
===============================================================
*/