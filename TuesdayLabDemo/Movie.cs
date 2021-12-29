using System;
using System.Collections.Generic;
using System.Text;

namespace TuesdayLabDemo
{
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(string title, string rating, int length, bool isGood)
        {
            Title = title;
            Rating = rating;
            Length = length;
            IsGood = isGood;
        }

        public string Title { get; set; }
        public string Rating { get; set; }
        public int Length { get; set; }
        public bool IsGood { get; set; }
    }
}
