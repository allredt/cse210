public class MathAssignment : Assignment
{
    private string section, problems;
    public MathAssignment(string name, string topic, string _section, string _problems) : base (name, topic)
    {
        section = _section;
        problems = _problems;
    }
    public string GetSection()
    {
        return section;
    }
    public string GetProblems()
    {
        return problems;
    }

    public string GetHomeworkList()
    {
        return section +", #"+ problems;
    }
}