using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zadMVC.Models
{
    public class Song
    {
        public string Name, Artist, Genre;
        public int id;

        public Song() { }
        
        public Song(string Name, string Artist, string Genre, int id)
        {
            this.Name = Name;
            this.Artist = Artist;
            this.Genre = Genre;
            this.id = id;
        }
    }
}