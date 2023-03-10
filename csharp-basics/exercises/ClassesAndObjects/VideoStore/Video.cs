using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _videoTitle;
        public bool Chekced { get; set; }
        public double Rating { get; set; }

        public Video(string title, bool check, double rating)
        {
            this._videoTitle = title;
            this.Chekced = check;
            this.Rating = rating;
        }

        public void BeingCheckedOut()
        {
            this.Chekced = true;
        }

        public void BeingReturned()
        {
            this.Chekced = false;
        }

        public void ReceivingRating(double rating)
        {
            this.Rating = rating;
        }

        public double AverageRating()
        {
            return Rating;
        }

        public bool Available()
        {
            return Chekced;
        }

        public string Title => this._videoTitle;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
