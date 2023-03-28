using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Songs of Joy", "Tabernacle Choir at Temple Square", 98);
        
        video1.AddComment("John Wizz", "I love the streaming of the tabernacle. It brings peace to my life in challenging times.");
        
        video1.AddComment("Marlene Walker", "This music makes any place I am more like heaven.");
        
        video1.AddComment("Mary Martinez", "Me gusta mucho escuchar esta musica especial. Siento que me trae mucho consuelo y paz. Bravo coro del tabernaculo!.");

        videos.Add(video1);

        Video video2 = new Video("How to create a website", "Developers World", 60);
        
        video2.AddComment("Jhoan Arturs", "It's a nice introduction to web development.");
        
        video2.AddComment("William Charles", "This video helps me to feel more comfortable about programming world.");
        
        video2.AddComment("Michael Walls", "What a tremendous intro. Thanks.");
        
        videos.Add(video2);

        Video video3 = new Video("How to bake a cake?", "Thom's Bakery", 60);
        
        video3.AddComment("Mirla Allen", "Thanks for such explanation.");
        
        video3.AddComment("Jennie Adams", "This video provided me with new tools and techniques that will be valuable.");
        
        video3.AddComment("Richard", "I love it.");
        
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.GetVideoInfo();
            Console.WriteLine();

            video.GetCommentsNumber();
            Console.WriteLine();

            video.GetCommentsList();
            Console.WriteLine();
        }

    }
}