class Comment
{
    public string _name;
    public string _content;

    public void Display()
    {
        Console.WriteLine($"{_name}: ({_content})");
    }
}

// A comment should be defined by the Comment class which has the responsibility 
// for tracking both the name of the person who made the comment and the text of the comment.