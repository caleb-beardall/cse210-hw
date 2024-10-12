using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //1st Video
        //Creating the 1st video's comments
        Comment comment1 = new Comment("Viviana Roth", "Comment example 1.");
        Comment comment2 = new Comment("Roy McCarty", "Comment example 2.");
        Comment comment3 = new Comment("Halo Townsend", "Comment example 3.");

        //Compiling the 1st video's comments into a list called listComments1
        List<Comment> listComments1 = [comment1, comment2, comment3];
        
        //Creating the 1st Video class object with the inclusion of listComments1
        Video video1 = new Video("Would You Fly To Paris For A Baguette?", "MrBeast", 83, listComments1);


        //Video 2
        //Creating the 2nd video's comments
        Comment comment4 = new Comment("Alexis Guerrero", "Comment example 4.");
        Comment comment5 = new Comment("Margot McCann", "Comment example 5.");
        Comment comment6 = new Comment("Heath Vang", "Comment example 6.");
        Comment comment7 = new Comment("Madisyn Barr", "Comment example 7.");
        
        //Compiling the 2nd video's comments into a list called listComments2
        List<Comment> listComments2 = [comment4, comment5, comment6, comment7];
        
        //Creating the 2nd Video class object with the inclusion of listComments2
        Video video2 = new Video("Real life transforming Cinderella dress", "Justinflom", 168, listComments2);


        //Video 3
        //Creating the 3rd video's comments
        Comment comment8 = new Comment("Harley Ferguson", "Comment example 8.");
        Comment comment9 = new Comment("Juliana McIntyre", "Comment example 9.");
        Comment comment10 = new Comment("Eliseo Hicks", "Comment example 10.");

        //Compiling the 3rd video's comments into a list called listComments3
        List<Comment> listComments3 = [comment8, comment9, comment10];
        
        //Creating the 3rd Video class object with the inclusion of listComments3
        Video video3 = new Video("Power Tools Racing Is INTENSE!!", "howridiculous", 185, listComments3);


        //Video 4
        //Creating the 4th video's comments
        Comment comment11 = new Comment("Alina Small", "Comment example 11.");
        Comment comment12 = new Comment("Rudy Walters", "Comment example 12.");
        Comment comment13 = new Comment("Samara Cuevas", "Comment example 13.");
        Comment comment14 = new Comment("Brecken Fowler", "Comment example 14.");
        
        //Compiling the 4th video's comments into a list called listComments4
        List<Comment> listComments4 = [comment11, comment12, comment13, comment14];
        
        //Creating the 4th Video class object with the inclusion of listComments4
        Video video4 = new Video("100 Minecraft YouTuber Mystery Buttons!", "Preston", 257, listComments4);

        //Compiling the Video class objects into a list called listVideos
        List<Video> listVideos = [video1, video2, video3, video4];
        
        //Iterating through each Video object in the listVideos list
        //and displaying the video's information
        foreach (Video i in listVideos)
        {
            i.DisplayVideoInfo();
        } 
    }
}