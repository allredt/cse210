public class Goal
{
    protected string _goalName, _goalDescription;
    protected int _points;
    public string _goal;
    public Goal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("How would you describe your goal? ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is your goal worth? ");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}|{1}|{2}", _goalName, _goalDescription, _points);
    }
    public void SetGoal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
        // return _goalName + _goalDescription + _points;
    }
    public string getGoalName()
    {
        return _goalName;
    }
    public string getGoalDescription()
    {
        return _goalDescription;
    }
    public int getGoalPoints()
    {
        return _points;
    }
    public void DisplayGetGoalName()
    {
        Console.WriteLine(string.Format("Goal Name: {0} ",_goalName));
    }
    public void DisplayGetGoalDescription()
    {
        Console.WriteLine(string.Format("Description: {0} ",_goalDescription));
    }
    public void DisplayGetGoalPoints()
    {
        Console.WriteLine(string.Format("Points: {0} ",_points));
    }
    public virtual string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}", getGoalName(), getGoalDescription(),
            getGoalPoints());
    }
    public virtual void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        
        Console.Write("Which goal did you accomplish?");
        int recordEvent = int.Parse(Console.ReadLine()) -1;
        Console.WriteLine(string.Format("You now have {0} points.", _points.ToString()));
    }
}