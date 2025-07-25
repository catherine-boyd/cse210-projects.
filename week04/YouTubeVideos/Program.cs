using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Comments> comments = new List<Comments>();
        Comments comments1 = new Comments( "Steve", "This video is very nice.");
        Comments comments2 = new Comments("Catherine", "This video is very weired");
        Comments comment3 = new Comments("Boyd", "This video is wonderfull");
        comments.Add(comments1);
        comments.Add(comments2);
        comments.Add(comment3);
        Video video1 = new Video("Katherine", comments, 3, "word" );
        Video video2 = new Video("Steve", comments, 4, "book");
        Video video3 = new Video("Ansah", comments, 6, "assignment");
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            Console.Write($"{video.GetTitle()} ");
            Console.Write($"{video.GetAuthor()} ");
            Console.Write($"{video.GetLength()} ");
            Console.Write($"{video.GetCommentLength()} ");
            Console.WriteLine();
            foreach (Comments comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()} ");
                Console.WriteLine($"{comment.GetText()} ");
            }
            Console.WriteLine();
        }
        
        

    }
}
class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;
    private List<Comments> _comments = new List<Comments>();

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    public int GetCommentLength()
    {
        return _comments.Count;
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }
    public Video(string author, List<Comments> comments, int length, string title)
    {
        _author = author;
        _length = length;
        _comments = comments;
        _title = title;
    }
    public int Length()
    {
        return _length;
    }
}

class Comments
{
    string _name = "";
    string _text = "";


    public Comments(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetText()
    {
        return _text;
    }
}