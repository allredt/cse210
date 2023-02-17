class Video
{
    public string _title;
    public string _author;
    public int _length;
    protected int count;
    public List<Comment> _comment = new List<Comment>();
    public void Display()
    {
        count +=0;
        
        Console.WriteLine($"Video Title: {_title}, Author: {_author}, Length: {_length}");
        
        foreach (Comment comment in _comment)
        {
            comment.Display();
            count +=1;
        }
        Console.WriteLine($"Number of Comments: {count}.");
    }
}

// Your program should have a class for a Video that has the responsibility 
// to track the title, author, and length (in seconds) of the video. 
// Each video also has responsibility to store a list of comments, 
// and should have a method to return the number of comments. 