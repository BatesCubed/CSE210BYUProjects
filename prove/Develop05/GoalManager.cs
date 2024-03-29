using System.IO;

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
        int index = 0;
        foreach (Goal goal in _goals)
        {
            string mark = "   ";
            if (goal.IsComplete() == true)
            {
                mark = " X ";
            }
            else {
                mark = "   ";
            }
            index += 1;
            Console.WriteLine($"{index}. [{mark}] {goal.GetDetailsString()}");
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
            Console.Clear();
            Console.WriteLine("----------New Checklist Goal----------");
            Console.WriteLine("");
            Console.Write("What is the name of your new goal? ");
            string newCheckListName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----------New CheckList Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newCheckListName}");
            Console.Write("Whats a good description of your goal? ");
            string newCheckListDescription = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----------New CheckList Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newCheckListName}");
            Console.WriteLine($"Description: {newCheckListDescription}");
            Console.Write("How many times do you want to complete this goal in total? ");
            int newCheckListTarget = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("----------New CheckList Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newCheckListName}");
            Console.WriteLine($"Description: {newCheckListDescription}");
            Console.WriteLine($"Target: {newCheckListTarget}");
            Console.Write("How many points will you receive after each part of the goal? ");
            int newCheckListPoints = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("----------New CheckList Goal----------");
            Console.WriteLine("");
            Console.WriteLine($"Name: {newCheckListName}");
            Console.WriteLine($"Description: {newCheckListDescription}");
            Console.WriteLine($"Target: {newCheckListTarget}");
            Console.WriteLine($"Points:  {newCheckListPoints}");
            Console.Write($"How many BONUS points would you like to receive after completing the goal {newCheckListTarget} times? ");
            int newCheckListBonusPoints = int.Parse(Console.ReadLine());
            Console.Clear();
            bool finalDataSaved = false;
            bool saveGoalData = true;
            while (finalDataSaved == false)
                {
                //Start of while loop
                Console.WriteLine("----------New CheckList Goal----------");
                Console.WriteLine("");
                Console.WriteLine($"Name: {newCheckListName}");
                Console.WriteLine($"Description: {newCheckListDescription}");
                Console.WriteLine($"Target: {newCheckListTarget}");
                Console.WriteLine($"Points:  {newCheckListPoints}");
                Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                Console.WriteLine("");
                Console.WriteLine("Goal Data Saved! What next?");
                Console.WriteLine("1. Submit Goal");
                Console.WriteLine("2. Edit Goal");
                Console.WriteLine("3. Delete Goal");
                Console.Write("Data Saved! Do you want to Submit, Edit, or Delete the goal? ");
                string submitOrEditCheckList = Console.ReadLine();
                if (submitOrEditCheckList == "1")
                {
                    finalDataSaved = true;
                    saveGoalData = true;
                }
                else if (submitOrEditCheckList == "2")
                {
                    bool doneEditing = false;
                    while (doneEditing == false)
                    {
                        Console.WriteLine("----------New CheckList Goal----------");
                        Console.WriteLine("");
                        Console.WriteLine($"Name: {newCheckListName}");
                        Console.WriteLine($"Description: {newCheckListDescription}");
                        Console.WriteLine($"Target: {newCheckListTarget}");
                        Console.WriteLine($"Points:  {newCheckListPoints}");
                        Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                        Console.WriteLine("");
                        Console.WriteLine("Editing Goal... ");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Description");
                        Console.WriteLine("3. Target");
                        Console.WriteLine("4. Points");
                        Console.WriteLine("5. Bonus Points");
                        Console.WriteLine("6. Finish & Submit");
                        Console.Write("Which part would you like to edit? ");
                        string chosenEdit = Console.ReadLine();
                        Console.WriteLine("");
                        //Start of Edit variations
                        //EDIT NAME
                        if (chosenEdit == "1")
                        {
                            Console.Write("What is the new name? ");
                            newCheckListName = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Name Updated!");
                            Console.WriteLine("");
                            Console.WriteLine("----------New CheckList Goal----------");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {newCheckListName}");
                            Console.WriteLine($"Description: {newCheckListDescription}");
                            Console.WriteLine($"Target: {newCheckListTarget}");
                            Console.WriteLine($"Points:  {newCheckListPoints}");
                            Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                            Console.WriteLine("");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        //EDIT DESCRIPTION
                        else if (chosenEdit == "2")
                        {
                            Console.Write("What is the new description? ");
                            newCheckListDescription = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Description Updated!");
                            Console.WriteLine("");
                            Console.WriteLine("----------New CheckList Goal----------");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {newCheckListName}");
                            Console.WriteLine($"Description: {newCheckListDescription}");
                            Console.WriteLine($"Target: {newCheckListTarget}");
                            Console.WriteLine($"Points:  {newCheckListPoints}");
                            Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                            Console.WriteLine("");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        //EDIT TARGET
                        else if (chosenEdit == "3")
                        {
                            Console.Write("What is the new target? ");
                            newCheckListTarget = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Target Updated!");
                            Console.WriteLine("");
                            Console.WriteLine("----------New CheckList Goal----------");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {newCheckListName}");
                            Console.WriteLine($"Description: {newCheckListDescription}");
                            Console.WriteLine($"Target: {newCheckListTarget}");
                            Console.WriteLine($"Points:  {newCheckListPoints}");
                            Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                            Console.WriteLine("");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        //EDIT POINTS
                        else if (chosenEdit == "4")
                        {
                            Console.Write("What is the new small point total? ");
                            newCheckListPoints = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Points Updated!");
                            Console.WriteLine("");
                            Console.WriteLine("----------New CheckList Goal----------");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {newCheckListName}");
                            Console.WriteLine($"Description: {newCheckListDescription}");
                            Console.WriteLine($"Target: {newCheckListTarget}");
                            Console.WriteLine($"Points:  {newCheckListPoints}");
                            Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                            Console.WriteLine("");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        //EDIT BONUS POINTS
                        else if (chosenEdit == "5")
                        {
                            Console.Write("What is the new BONUS point total? ");
                            newCheckListBonusPoints = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("BONUS Points Updated!");
                            Console.WriteLine("");
                            Console.WriteLine("----------New CheckList Goal----------");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {newCheckListName}");
                            Console.WriteLine($"Description: {newCheckListDescription}");
                            Console.WriteLine($"Target: {newCheckListTarget}");
                            Console.WriteLine($"Points:  {newCheckListPoints}");
                            Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                            Console.WriteLine("");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        //FINISH AND SUBMIT
                        else if (chosenEdit == "6")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("----------New CheckList Goal----------");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {newCheckListName}");
                            Console.WriteLine($"Description: {newCheckListDescription}");
                            Console.WriteLine($"Target: {newCheckListTarget}");
                            Console.WriteLine($"Points:  {newCheckListPoints}");
                            Console.WriteLine($"BONUS Points: {newCheckListBonusPoints}");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            doneEditing = true;
                            saveGoalData = true;
                            finalDataSaved = true;
                        }
                        //CATCHING TYPOS
                        else {
                            Console.WriteLine("That is an invalid input! Please press ENTER to try again...");
                            Console.ReadLine();
                        }
                    }
                }
                else if (submitOrEditCheckList == "3")
                {
                    saveGoalData = false;
                    finalDataSaved = true;
                    Console.WriteLine("");
                    Console.WriteLine("This Goal has been discarded! Press ENTER to continue...");
                    Console.ReadLine();
                }
                if (saveGoalData == true)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(newCheckListName, newCheckListDescription, newCheckListPoints, newCheckListTarget, newCheckListBonusPoints);
                    _goals.Add(checklistGoal);
                    Console.Write("Goal Created! Press ENTER to Continue... ");
                    Console.ReadLine();
                }
            }
            goalCreateSelected = true;
        }
        else if (goalCreateChoice == 4)
        {
            Console.WriteLine("Thanks for coming! Have fun with your quest! Press ENTER to continue");
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
        Console.Write("Give your goals file a name (Don't add a .txt path to it): ");
        string filePath = $"{Console.ReadLine()}.txt";

        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                if (goal.GetType() == typeof(SimpleGoal))
                {
                    outputFile.WriteLine($"simpleGoal|{goal.GetName()}|{goal.GetDescription}|{goal.GetPoints()}|{goal.IsComplete()}");
                }
                else if (goal.GetType() == typeof(ChecklistGoal))
                {
                    outputFile.WriteLine($"checklistGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetBonusPoints()}")
                }
                
            }
        }
    }

    public void LoadGoals()
    {
        //
    }
}