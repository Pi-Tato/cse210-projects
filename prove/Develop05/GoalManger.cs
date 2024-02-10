using System;
using System.Collections;

public class GoalManger
{
    List<List<string>> goals = new List<List<string>>();

    List<string> _simpleGoals = new List<string>();
    List<string> _eternalGoals = new List<string>();
    List<string> _checklistGoals = new List<string>();

    
    int _score;
    string name = "", discription = "", pointValue = "";

    SimpleGoal simpleGoal;
    List<SimpleGoal> _simpleGoalList = new List<SimpleGoal>();
    EternalGoal eternalGoal;
    List<EternalGoal> _eternalGoalList = new List<EternalGoal>();
    ChecklistGoal checklistGoal;
    List<ChecklistGoal> _checklistGoalList = new List<ChecklistGoal>();

    public GoalManger()
    {
        goals.Add(_simpleGoals);
        goals.Add(_eternalGoals);
        goals.Add(_checklistGoals);
    }
    public int GetScore()
    {
        return _score;
    }
    public void Start()
    {
        List<string> types = new List<string>
        {
            "Simple", "Eternal", "Checklist"
        };
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Select a type of goal you want to create: ");
        string goalType = Console.ReadLine();
        goalType = types[int.Parse(goalType) - 1];
        
        CreateGoal(goalType);
    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        Console.WriteLine("");
        int l = 0;
        for(int i = 0; i < goals.Count(); i++)
        {
            for(int t = 0; t < goals[i].Count(); t++)
            {
               switch(i)
               {
                   case 0:
                       if(_simpleGoalList[t].IsComplete())
                       {
                           Console.WriteLine($"[X] {l + 1}. {goals[i][t]}");
                       }else
                       {
                           Console.WriteLine($"[ ] {l + 1}. {goals[i][t]}");
                       }
                       break;
                   case 2:
                       if(_checklistGoalList[t].IsComplete())
                       {
                           Console.WriteLine($"[X] {l + 1}. {goals[i][t]}");
                       }else
                       {
                           Console.WriteLine($"[ ] {l + 1}. {goals[i][t]}");
                       }
                       break;
               }
                l++;
            }
        }
    }
    public void CreateGoal(string type)
    {
        switch(type)
        {
            case "Simple":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                discription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                pointValue = Console.ReadLine();

                simpleGoal = new SimpleGoal(name, discription, int.Parse(pointValue));
                _simpleGoalList.Add(simpleGoal);
                _simpleGoals.Add($"{type} - {name} - {discription} - {pointValue}");
                break;
            case "Eternal":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                discription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                pointValue = Console.ReadLine();

                eternalGoal = new EternalGoal(name, discription, int.Parse(pointValue));
                _eternalGoalList.Add(eternalGoal);
                _eternalGoals.Add($"{type} - {name} - {discription} - {pointValue}");
                break;
            case "Checklist":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                discription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                pointValue = Console.ReadLine();

                checklistGoal = new ChecklistGoal(name, discription, int.Parse(pointValue));
                _checklistGoalList.Add(checklistGoal);
                _checklistGoals.Add($"{type} - {name} - {discription} - {pointValue}");
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        Console.Write("");
        string goalNum = Console.ReadLine();
        int goalNumber = int.Parse(goalNum);
        int l = 0;
        for(int i = 0; i < goals.Count(); i++)
        {
            for(int t = 0; t < goals[i].Count(); t++)
            {
                l++;
                if(l == goalNumber)
                {
                    _score += int.Parse(goals[i][t].Split(" - ")[3]);
                    Console.WriteLine($"You earned {int.Parse(goals[i][t].Split(" - ")[3])} points!");
                    Console.WriteLine($"{i}  {t}  {goals[i][t]}");

                    switch(i)
                    {
                        case 0:
                            _simpleGoalList[t].RecordEvent();
                            break;
                        case 1:                        
                            _eternalGoalList[t].RecordEvent();
                            break;
                        case 2:
                            _checklistGoalList[t].RecordEvent();
                            break;
                    }
                    return;
                }

            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            for(int i = 0; i < goals.Count(); i++)
            {
                foreach (string goal in goals[i])
                {
                    outputFile.WriteLine($"{goal}");
                }
            }
        }
    }
    public void LoadGoals()
    {
        _simpleGoals.Clear();
        _eternalGoals.Clear();
        _checklistGoals.Clear();
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            if(parts.Length != 1)
            {
                string type = parts[0];
                string name = parts[1];
                string discription = parts[2];
                string pointValues = parts[3];
                switch(type)
                {
                    case "Simple":
                        _simpleGoals.Add($"{type} - {name} - {discription} - {pointValues}");
                        break;
                    case "Eternal":
                        _eternalGoals.Add($"{type} - {name} - {discription} - {pointValues}");
                        break;
                    case "Checklist":
                        _checklistGoals.Add($"{type} - {name} - {discription} - {pointValues}");
                        break;
                }
            }else
            {
                _score = int.Parse(parts[0]);
            }
        }
    }
}