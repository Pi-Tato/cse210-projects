using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments = new List<Comment>
    {
        new Comment("Jen", "Best class ever!"),
        new Comment("Bob", "My favorite class ever!"),
        new Comment("Sally", "I hate this class!")
    };

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    
    
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"{_comments.Count} comments:");
        Console.WriteLine($"");

        for(int i = 0; i < _comments.Count; i++)
        {
            _comments[i].Display();
        }
    }

}