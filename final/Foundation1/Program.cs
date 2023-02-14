using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._name = "user1";
        comment1._content = "comment1";

        Comment comment2 = new Comment();
        comment2._name = "user2";
        comment2._content = "comment2";

        Comment comment3 = new Comment();
        comment3._name = "user3";
        comment3._content = "comment3";

        Video video = new Video();
        video._title = "Title1";
        video._author = "Author1";
        video._length = 1;

        Video video2 = new Video();
        video2._title = "Title2";
        video2._author = "Author2";
        video2._length = 2;

        Video video3 = new Video();
        video3._title = "Title3";
        video3._author = "Author3";
        video3._length = 3;

        video._comment.Add(comment1);
        video._comment.Add(comment2);
        video._comment.Add(comment3);

        video2._comment.Add(comment1);
        video2._comment.Add(comment2);
        video2._comment.Add(comment3);

        video3._comment.Add(comment1);
        video3._comment.Add(comment2);
        video3._comment.Add(comment3);

        video.Display();
        video2.Display();
        video3.Display();
    }
}
// Scenario
// You have been hired by a company that does product awareness monitoring by 
// tracking the placement of their products in YouTube videos. They want you 
// to write a program that can help them work with the tens of thousands of 
// videos they have identified as well as the comments on them.

// Program Specification
// Write a program to keep track of YouTube videos and comments left on them.
// As mentioned this could be part of a larger project to analyze them, 
// but for this assignment, you will only need to worry about storing the 
// information about a video and the comments.

// Once you have the classes in place, write a program that creates 3-4 videos, 
// sets the appropriate values, and for each one add a list of 3-4 comments 
// (with the commenter's name and text). Put each of these videos in a list.

// Then, have your program iterate through the list of videos and for each one, 
// display the title, author, length, number of comments (from the method) 
// and then list out all of the comments for that video. Repeat this display 
// for each video in the list.