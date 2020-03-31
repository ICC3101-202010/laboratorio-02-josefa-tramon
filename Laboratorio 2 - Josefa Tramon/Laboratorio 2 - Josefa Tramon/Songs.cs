using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2___Josefa_Tramon
{
    public class Song
    {
        private string name;

        private string album;

        private string gender;

        private string artist;


        public Song(string name, string album, string artist, string gender)

        {
            this.name = name;

            this.album = album;

            this.artist = artist;

            this.gender = gender;

        }

        public string Name
        {
            get { return name; }
        }
        public string Album
        {
            get { return album; }
        }
        public string Artist
        {
            get { return artist; }
        }
        public string Gender
        {
            get { return gender; }
        }
    }
}
