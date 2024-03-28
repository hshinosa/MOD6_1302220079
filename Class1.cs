using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string judul_video)
        {
            Random random = new Random();

            this.title = judul_video;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
             int tes = this.playCount + playCount;
             this.playCount = tes;
        }
        public int getPlayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return title;
        }
   
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video id : " + id);
            Console.WriteLine("Video title : " + title);
            Console.WriteLine("Video play count : " + playCount);
        }
    }
}