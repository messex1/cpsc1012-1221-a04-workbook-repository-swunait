using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectProblem1
{
    public class CD
    {
        private string _title;
        private string _artist;
        private int _tracks;
        private double _price;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be blank");
                }
                _title = value;
            }
        }

        public string Artist
        {
            get
            {
                return _artist;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Artist cannot be blank");
                }
                _artist = value;
            }
        }

        public int Tracks
        {
            get
            {
                return _tracks;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Tracks must be 1 or more");
                }
                _tracks = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0.05)
                {
                    throw new ArgumentException("Price must be $0.05 or more");
                }
                _price = value;
            }
        }

        public CD(string Title, string Artist, int Tracks, double Price)
        {
            this.Title = Title;
            this.Artist = Artist;
            this.Tracks = Tracks;
            this.Price = Price;
        }

        public string CDInfo()
        {
            return $"{Title, -15} {Artist, -15} {Price, 8:C}";
        }
    }
}
