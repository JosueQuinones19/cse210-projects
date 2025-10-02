using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("Learning C# Basics", "Josue", 600);
        Video video2 = new Video("OOP Concepts Explained", "Ashley", 900);
        Video video3 = new Video("How to Stay Productive", "David", 750);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "This was super helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks a lot!"));

        // Add comments to video2
        video2.AddComment(new Comment("Eve", "Very clear examples."));
        video2.AddComment(new Comment("Mallory", "Nice video!"));
        video2.AddComment(new Comment("Trent", "Loved it!"));

        // Add comments to video3
        video3.AddComment(new Comment("Oscar", "Really motivating."));
        video3.AddComment(new Comment("Peggy", "Great tips!"));
        video3.AddComment(new Comment("Victor", "Thank you for this!"));

        // Display all video info
        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
    }
}
