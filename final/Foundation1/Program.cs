using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of Video
        var video1 = new Video("How to Cook Pasta", "Chef John", 600);
        var video2 = new Video("Python Programming Tutorial", "Tech With Tim", 1800);
        var video3 = new Video("Yoga for Beginners", "Yoga with Adriene", 900);
        var video4 = new Video("Travel Vlog: Japan", "Travel With Me", 1200);

        // Create comments for each video
        var commentsVideo1 = new List<Comment>
        {
            new Comment("Alice", "Great video!"),
            new Comment("Bob", "Thanks for the tips!"),
            new Comment("Charlie", "I love pasta!")
        };

        var commentsVideo2 = new List<Comment>
        {
            new Comment("Dave", "Very informative."),
            new Comment("Eve", "Helped me a lot, thanks!"),
            new Comment("Frank", "Good explanation.")
        };

        var commentsVideo3 = new List<Comment>
        {
            new Comment("Grace", "Perfect for beginners."),
            new Comment("Heidi", "Very relaxing."),
            new Comment("Ivan", "Just what I needed.")
        };

        var commentsVideo4 = new List<Comment>
        {
            new Comment("Judy", "Beautiful places!"),
            new Comment("Ken", "I want to visit Japan now."),
            new Comment("Leo", "Nice vlog!")
        };

        // Add comments to videos
        foreach (var comment in commentsVideo1)
        {
            video1.AddComment(comment);
        }

        foreach (var comment in commentsVideo2)
        {
            video2.AddComment(comment);
        }

        foreach (var comment in commentsVideo3)
        {
            video3.AddComment(comment);
        }

        foreach (var comment in commentsVideo4)
        {
            video4.AddComment(comment);
        }

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3, video4 };

        // Iterate through the list of videos and display their information
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
