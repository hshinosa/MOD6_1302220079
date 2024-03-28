using Video;
using User;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("hshino");
        
        SayaTubeVideo video1 = new SayaTubeVideo("After Dark");
        SayaTubeVideo video2 = new SayaTubeVideo("Kyun");
        SayaTubeVideo video3 = new SayaTubeVideo("Akuma No Ko");
        SayaTubeVideo video4 = new SayaTubeVideo("Star");
        SayaTubeVideo video5 = new SayaTubeVideo("Mars Telkom");
        SayaTubeVideo video6 = new SayaTubeVideo("Kiblat");
        SayaTubeVideo video7 = new SayaTubeVideo("Razer Viper Review");
        SayaTubeVideo video8 = new SayaTubeVideo("ExHuma");
        SayaTubeVideo video9 = new SayaTubeVideo("Falling Star");
        SayaTubeVideo video10 = new SayaTubeVideo("Wonderfull");

        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
        video4.PrintVideoDetails();
        video5.PrintVideoDetails();
        video6.PrintVideoDetails();
        video7.PrintVideoDetails();

        for (int i = 0; i < 215; i++)
        {
            video1.IncreasePlayCount(10000000);
            video2.IncreasePlayCount(10000000);
            video3.IncreasePlayCount(10000000);
            video4.IncreasePlayCount(10000000);
            video5.IncreasePlayCount(10000000);
            video6.IncreasePlayCount(10000000);
            video7.IncreasePlayCount(10000000);
        }
        user1.addVideo(video1);
        user1.addVideo(video2);
        user1.addVideo(video2);
        user1.addVideo(video3);
        user1.addVideo(video4);
        user1.addVideo(video5);
        user1.addVideo(video6);
        user1.addVideo(video7);
        user1.addVideo(video8);
        user1.addVideo(video9);
        user1.addVideo(video10);

        user1.PrintAllVideoPlayCount();
        user1.getTotalVideoPlayCount();
    }
}