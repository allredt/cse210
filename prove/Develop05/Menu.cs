class Menu
{
    private List<string> mainMenu, createGoalMenu;
    private int mainMenuSelection;

    public Menu()
    {
        mainMenu = new List<string>
        {
            "Menu Options",
            "1. Create new goal",
            "2. List goals",
            "3. Save goals",
            "4. Load goals",
            "5. Record event",
            "6. Quit"
        };

        createGoalMenu = new List<string>
        {
            "The types of goals are:",
            "1. Simple goals",
            "2. Eternal goals",
            "3. Checklist Goals"
        };

    }

    public void DisplayMainMenu()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }

    public void DisplayPoints(int _totalPoints)
    {
        Console.WriteLine(string.Format("You have {0} total points. \n", _totalPoints));
    }

    public int DisplayGetMainMenu()
    {
        Console.Write("Select a choice from the main menu: ");
        return int.Parse(Console.ReadLine());
    }

    public int GetMainMenuSelection()
    {
        return mainMenuSelection;
    }

    public int DisplayGetCreateGoalMenu()
    {
        foreach (string menuItem in createGoalMenu)
        {
            Console.WriteLine(menuItem);
        }

        Console.Write("Select a choice from the menu:");
        return int.Parse(Console.ReadLine());
    }
}