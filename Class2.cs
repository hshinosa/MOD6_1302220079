using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Video;

namespace User
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Random random = new Random();
            id = random.Next(10000, 99999);
            this.username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int getTotalVideoPlayCount()
        {
            int jumlah = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                jumlah = jumlah + uploadedVideos[i].getPlayCount();
            }
            return jumlah;
        }

        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User : " + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            }
            Console.WriteLine("Total PlayCount: " + getTotalVideoPlayCount());
        }
    }
}