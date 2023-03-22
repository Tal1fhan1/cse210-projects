using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> videos = new List<string>();

        Video video1 = new Video();
        video1._comments = new List<string>();
        video1._author = "Pewdiepie";
        video1._lengthInSeconds = 300;
        video1._title = "We're having a baby!";
        
        Comment comment1 = new Comment();
        comment1._name = "JellyfishHunter";
        comment1._text = "Congratulations!!!";
        video1._comments.Add(comment1.FullComment());

        Comment comment2 = new Comment();
        comment2._name = "user283948";
        comment2._text = "Wow, you two are going to be great parents.";
        video1._comments.Add(comment2.FullComment());

        Comment comment3 = new Comment();
        comment3._name = "All-4-1";
        comment3._text = "OMG, I didn't even know that she was pregnant :O";
        video1._comments.Add(comment3.FullComment());

        videos.Add($"{video1.FullVideo()} ({video1.NumberOfComments()} comments)");
        videos.Add(comment1.FullComment());
        videos.Add(comment2.FullComment());
        videos.Add(comment3.FullComment());


        Video video2 = new Video();
        video2._comments = new List<string>();
        video2._author = "Jacksepticeye";
        video2._lengthInSeconds = 1500;
        video2._title = "Shadow of the Colossus Playthrough: Part 1";

        Comment comment4 = new Comment();
        comment4._name = "OneMunchPan";
        comment4._text = "What an incredible game! It never gets old.";
        video2._comments.Add(comment4.FullComment());

        Comment comment5 = new Comment();
        comment5._name = "Tanjibro86";
        comment5._text = "Part 1? Isn't this like the twentieth time that he's played it? XD.";
        video2._comments.Add(comment5.FullComment());

        Comment comment6 = new Comment();
        comment6._name = "IndigoLantern";
        comment6._text = "The sense of scale in this game is still unmatched.";
        video2._comments.Add(comment6.FullComment());

        Comment comment7 = new Comment();
        comment7._name = "MainsawChan108";
        comment7._text = "I know this is his favorite game and all, but why doesn't he play anything else?";
        video2._comments.Add(comment7.FullComment());

        videos.Add($"{video2.FullVideo()} ({video2.NumberOfComments()} comments)");
        videos.Add(comment4.FullComment());
        videos.Add(comment5.FullComment());
        videos.Add(comment6.FullComment());
        videos.Add(comment7.FullComment());


        Video video3 = new Video();
        video3._comments = new List<string>();
        video3._author = "Markiplier";
        video3._lengthInSeconds = 900;
        video3._title = "Try Not To Get Demonitized Challenge";

        Comment comment8 = new Comment();
        comment8._name = "SpiderPig'sMallet";
        comment8._text = "I'm surprised this video hasn't been flagged yet XD";
        video3._comments.Add(comment8.FullComment());

        Comment comment9 = new Comment();
        comment9._name = "AbuDabi";
        comment9._text = "LOL, he's not even trying to avoid demonitization.";
        video3._comments.Add(comment9.FullComment());

        Comment comment10 = new Comment();
        comment10._name = "KnightStand";
        comment10._text = "The YouTube algorithm is quaking right now lol";
        video3._comments.Add(comment10.FullComment());

        videos.Add($"{video3.FullVideo()} ({video3.NumberOfComments()} comments)");
        videos.Add(comment8.FullComment());
        videos.Add(comment9.FullComment());
        videos.Add(comment10.FullComment());

        Console.WriteLine();
        foreach (string video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine();
        }
    }
}