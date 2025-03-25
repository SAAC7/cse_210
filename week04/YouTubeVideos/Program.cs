using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("Introduction to C# Programming", "Tech Academy", 1200);
        video1.AddComment(new Comment("JohnDoe", "Great tutorial!"));
        video1.AddComment(new Comment("CodeLearner", "Very helpful explanation."));
        video1.AddComment(new Comment("ProgrammingFan", "Loved the content."));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Advanced Algorithms", "Code Masters", 1800);
        video2.AddComment(new Comment("AlgoEnthusiast", "Complex but well explained."));
        video2.AddComment(new Comment("StudentCoder", "Challenging concepts."));
        video2.AddComment(new Comment("TechGeek", "Excellent deep dive."));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Data Structures Explained", "Learn Coding", 1500);
        video3.AddComment(new Comment("Programmer101", "Clear and concise."));
        video3.AddComment(new Comment("CodingNinja", "Helped me understand trees."));
        video3.AddComment(new Comment("DevStudent", "Great visualization."));
        videos.Add(video3);

        // Iterate through videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._Title}");
            Console.WriteLine($"Author: {video._Author}");
            Console.WriteLine($"Length: {video._LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._Commentername}: {comment._CommentTextt}");
            }
            
            Console.WriteLine(); // Empty line between videos
        }



    }



    private string GetInput(string input){
         string text;
        while(true){
            Console.WriteLine(input);
            text = Console.ReadLine();
            if(!string.IsNullOrEmpty(text)){
                return text;
            }

        }
    }
}