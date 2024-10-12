using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //Video 1
        Comment comment1 = new Comment("Viviana Roth", "Comment example 1.");
        Comment comment2 = new Comment("Roy McCarty", "Comment example 2.");
        Comment comment3 = new Comment("Halo Townsend", "Comment example 3.");

        List<Comment> listComments1 = [comment1, comment2, comment3];
        
        Video video1 = new Video("Would You Fly To Paris For A Baguette?", "MrBeast", 83, listComments1);


        //Video 2
        Comment comment4 = new Comment("Alexis Guerrero", "Comment example 4.");
        Comment comment5 = new Comment("Margot McCann", "Comment example 5.");
        Comment comment6 = new Comment("Heath Vang", "Comment example 6.");
        Comment comment7 = new Comment("Madisyn Barr", "Comment example 7.");
        
        List<Comment> listComments2 = [comment4, comment5, comment6, comment7];
        
        Video video2 = new Video("Real life transforming Cinderella dress", "Justinflom", 168, listComments2);


        //Video 3
        Comment comment8 = new Comment("Harley Ferguson", "Comment example 8.");
        Comment comment9 = new Comment("Juliana McIntyre", "Comment example 9.");
        Comment comment10 = new Comment("Eliseo Hicks", "Comment example 10.");

        List<Comment> listComments3 = [comment8, comment9, comment10];
        
        Video video3 = new Video("Power Tools Racing Is INTENSE!!", "howridiculous", 185, listComments3);


        //Video 4
        Comment comment11 = new Comment("Alina Small", "Comment example 11.");
        Comment comment12 = new Comment("Rudy Walters", "Comment xample 12.");
        Comment comment13 = new Comment("Samara Cuevas", "Comment xample 13.");
        Comment comment14 = new Comment("Brecken Fowler", "Comment xample 14.");
        
        List<Comment> listComments4 = [comment11, comment12, comment13, comment14];
        
        Video video4 = new Video("100 Minecraft YouTuber Mystery Buttons!", "Preston", 257, listComments4);

        List<Video> listVideos = [video1, video2, video3, video4];
        
        foreach (Video i in listVideos)
        {
            i.DisplayVideoInfo();
        }
        
    }
}