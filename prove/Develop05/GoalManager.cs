public class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.Clear();
        int menuChoice = 0;
        while (menuChoice != 6)
        {
            Console.WriteLine("Welcome to your Eternal Quest!!");
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("-----------Menu-----------");
            Console.WriteLine("");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            
            menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                CreateGoal();
                Console.Clear();
            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("List Goals");
                //Temporary
                ListGoalDetails();
                Console.ReadLine();
                Console.Clear();
            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("Save Goals");
                Console.ReadLine();
                Console.Clear();
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine("Load Goals");
                Console.ReadLine();
                Console.Clear();
            }
            else if (menuChoice == 5)
            {
                Console.WriteLine("Record Event");
                Console.ReadLine();
                Console.Clear();
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Quitting, goodbye!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        //
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void CreateGoal()
    {
        Console.Clear();
        bool goalCreateFinish = false;
        bool goalCreateSelected = false;
        while (goalCreateSelected != true)
        {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("");
        Console.WriteLine("1. Simple Goal - This goal can be completed one time");
        Console.WriteLine("2. Eternal Goal - You can complete this game many times!");
        Console.WriteLine("3. Checklist Goal - Complete a task a set amount of times and get BONUS points!");
        Console.WriteLine("4. Cancel & Go Back");
        Console.WriteLine("");
        Console.Write("What type of goal would you like to create?: ");
        int goalCreateChoice = int.Parse(Console.ReadLine());
        
        if (goalCreateChoice == 1)
        {
            goalCreateSelected = true;
//Start of Creating the Goal
            Console.Clear();
            Console.WriteLine("----------New Simple Goal----------");
            Console.WriteLine("");
            Console.Write("What is the name of your new goal? ");
            string newSimpleName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----------New Simple Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newSimpleName}");
            Console.Write("Whats a good description of your goal? ");
            string newSimpleDescription = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----------New Simple Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newSimpleName}");
            Console.WriteLine($"Description: {newSimpleDescription}");
            Console.Write("How many points will you receive after completing the goal? ");
            int newSimplePoints = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("----------New Simple Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newSimpleName}");
            Console.WriteLine($"Description: {newSimpleDescription}");
            Console.WriteLine($"Points: {newSimplePoints}");
//End of Creating the Goal, and Start of Editing Goal
            Console.WriteLine("");
            Console.WriteLine("Do you want to Submit the goal? Or Edit the Goal?");
            Console.WriteLine("1. Submit Goal");
            Console.WriteLine("2. Edit Goal");
            Console.WriteLine("3. Delete Goal");
            string submitOrEditGoal = Console.ReadLine();
            bool endCreateSimpleLoop = false;
            while (endCreateSimpleLoop != true)
            {
                if (submitOrEditGoal == "1")
                {
                    Console.Clear();
                    Console.WriteLine("----------New Simple Goal----------");
                    Console.WriteLine("");
                    Console.WriteLine($"Name: {newSimpleName}");
                    Console.WriteLine($"Description: {newSimpleDescription}");
                    Console.WriteLine($"Points: {newSimplePoints}");
                    Console.WriteLine("");
                    Console.WriteLine("Goal Created! Press ENTER to Continue!");
                    goalCreateFinish = true;
                    endCreateSimpleLoop = true;
                    Console.ReadLine();
                }
                else if (submitOrEditGoal == "2")
                {
                    Console.Clear();
                    bool doneEditingSimple = false;
                    while (doneEditingSimple == false)
                    {
                        Console.WriteLine("----------New Simple Goal----------");
                        Console.WriteLine("");
                        Console.WriteLine($"1. Name: {newSimpleName}");
                        Console.WriteLine($"2. Description: {newSimpleDescription}");
                        Console.WriteLine($"3. Points: {newSimplePoints}");
                        Console.WriteLine("4. Finish & Submit Goal");
                        Console.WriteLine("");
                        Console.Write("What would you like to edit? ");
                        string simpleVariableToEdit = Console.ReadLine();
                        if (simpleVariableToEdit == "1")
                        {
                            Console.Write("What is the new name? ");
                            newSimpleName = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Name successfully changed!");
                            doneEditingSimple = false;
                        }
                        else if (simpleVariableToEdit == "2")
                        {
                            Console.Write("What is the new description? ");
                            newSimpleDescription = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Description successfully changed!");
                            doneEditingSimple = false;
                        }
                        else if (simpleVariableToEdit == "3")
                        {
                            Console.Write("What is the new point total? ");
                            newSimplePoints = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Points successfully changed!");
                            doneEditingSimple = false;
                        }
                        else if (simpleVariableToEdit == "4")
                        {
                            Console.WriteLine("Goal Created! Press ENTER to Continue!");
                            Console.ReadLine();
                            doneEditingSimple = true;
                            goalCreateFinish = true;
                        }
                        else {
                            Console.WriteLine("That is an invalid input, press ENTER to try again");
                            Console.ReadLine();
                            doneEditingSimple = false;
                            goalCreateFinish = false;
                        }
                    }
                    endCreateSimpleLoop = true;
                }
                else if (submitOrEditGoal == "3")
                {
                    Console.WriteLine("This goal has been discarded... press ENTER to continue");
                    endCreateSimpleLoop = true;
                    goalCreateFinish = false;
                    Console.ReadLine();
                }
                if (goalCreateFinish == true)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(newSimpleName, newSimpleDescription, newSimplePoints);
                    _goals.Add(simpleGoal);
                }
            }
        }
        else if (goalCreateChoice == 2)
        {
            Console.Clear();
            Console.WriteLine("----------New Eternal Goal----------");
            Console.WriteLine("");
            Console.Write("What is the name of your new goal? ");
            string newEternalName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----------New Eternal Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newEternalName}");
            Console.Write("Whats a good description of your goal? ");
            string newEternalDescription = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----------New Eternal Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newEternalName}");
            Console.WriteLine($"Description: {newEternalDescription}");
            Console.Write("How many points will you receive after completing the goal? ");
            int newEternalPoints = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("----------New Eternal Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newEternalName}");
            Console.WriteLine($"Description: {newEternalDescription}");
            Console.WriteLine($"Points: {newEternalPoints}");
            Console.WriteLine("");
            Console.WriteLine("Do you want to Submit the goal? Or Edit the Goal?");
            Console.WriteLine("1. Submit Goal");
            Console.WriteLine("2. Edit Goal");
            Console.WriteLine("3. Delete Goal");
            string submitOrEditGoal = Console.ReadLine();
            bool endCreateEternalLoop = false;
            while (endCreateEternalLoop != true)
            {
                if (submitOrEditGoal == "1")
                {
                    Console.Clear();
                    Console.WriteLine("----------New Eternal Goal----------");
                    Console.WriteLine("");
                    Console.WriteLine($"Name: {newEternalName}");
                    Console.WriteLine($"Description: {newEternalDescription}");
                    Console.WriteLine($"Points: {newEternalPoints}");
                    Console.WriteLine("");
                    Console.WriteLine("Goal Created! Press ENTER to Continue!");
                    goalCreateFinish = true;
                    endCreateEternalLoop = true;
                    Console.ReadLine();
                }
                else if (submitOrEditGoal == "2")
                {
                    Console.Clear();
                    bool doneEditingEternal = false;
                    while (doneEditingEternal == false)
                    {
                        Console.WriteLine("----------New Eternal Goal----------");
                        Console.WriteLine("");
                        Console.WriteLine($"1. Name: {newEternalName}");
                        Console.WriteLine($"2. Description: {newEternalDescription}");
                        Console.WriteLine($"3. Points: {newEternalPoints}");
                        Console.WriteLine("4. Finish & Submit Goal");
                        Console.WriteLine("");
                        Console.Write("What would you like to edit? ");
                        string eternalVariableToEdit = Console.ReadLine();
                        if (eternalVariableToEdit == "1")
                        {
                            Console.Write("What is the new name? ");
                            newEternalName = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Name successfully changed!");
                            doneEditingEternal = false;
                        }
                        else if (eternalVariableToEdit == "2")
                        {
                            Console.Write("What is the new description? ");
                            newEternalDescription = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Description successfully changed!");
                            doneEditingEternal = false;
                        }
                        else if (eternalVariableToEdit == "3")
                        {
                            Console.Write("What is the new point total? ");
                            newEternalPoints = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Points successfully changed!");
                            doneEditingEternal = false;
                        }
                        else if (eternalVariableToEdit == "4")
                        {
                            Console.WriteLine("Goal Created! Press ENTER to Continue!");
                            goalCreateFinish = true;
                            Console.ReadLine();
                            doneEditingEternal = true;
                            endCreateEternalLoop = true;
                        }
                        else {
                            Console.WriteLine("That is an invalid input, press ENTER to try again");
                            Console.ReadLine();
                            Console.Clear();
                            goalCreateFinish = false;
                            endCreateEternalLoop = false;
                        }
                    }
                }
                else if (submitOrEditGoal == "3")
                {
                    Console.WriteLine("This goal has been discarded... press ENTER to continue");
                    Console.ReadLine();
                    goalCreateFinish = false;
                    endCreateEternalLoop = true;
                }
            }
            if (goalCreateFinish == true)
            {
                EternalGoal eternalGoal = new EternalGoal(newEternalName, newEternalDescription, newEternalPoints);
                _goals.Add(eternalGoal);
            }
            goalCreateSelected = true;
        }
        else if (goalCreateChoice == 3)
        {
            Console.WriteLine("CheckList Goal");
            Console.ReadLine();
            Console.Clear();
            goalCreateSelected = true;
        }
        else if (goalCreateChoice == 4)
        {
            Console.WriteLine("Done... see ya soon");
            Console.ReadLine();
            Console.Clear();
            goalCreateSelected = true;
        }
        else
        {
            goalCreateSelected = false;
            Console.WriteLine("That input is invalid, press ENTER to try again");
            Console.ReadLine();
        }
        }
    }

    public void RecordEvent()
    {
        //
    }

    public void SaveGoals()
    {
        //
    }

    public void LoadGoals()
    {
        //
    }
}