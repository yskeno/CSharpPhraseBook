using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2_Exercise1
{
    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        public Song(string title,string name,int length)
        {
            this.Title = title;
            this.ArtistName = name;
            this.Length = length;
        }
    }
}