using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        List<Video> videos = new List<Video>();
        List<Video> rented = new List<Video>();

        public VideoStore()
        {
            
        }

        public void AddVideo(Video newVideo)
        {
            videos.Add(newVideo);
        }
        
        public void Checkout(string title)
        {
            foreach (var video in videos)
            {
                if (video.Title == title)
                {
                    video.Chekced = true;
                    rented.Add(video);
                    videos.Remove(video);
                    break;
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var video in rented)
            {
                if (video.Title == title)
                {
                    video.Chekced = false;
                    videos.Add(video);
                    rented.Remove(video);
                    break;
                }
            }
        }

        public void TakeUsersRating(double rating, Video forVideo)
        {
            forVideo.Rating = rating;
        }

        public void ListInventory()
        {
            Console.WriteLine("Vidoes that are in store:");
            foreach (var video in videos)
            {
                Console.WriteLine(video.Title);
            }
            Console.WriteLine("Videos that are rented: ");
            foreach (var videos in rented)
            {
                Console.WriteLine(videos.Title);
            }
        }
    }
}
