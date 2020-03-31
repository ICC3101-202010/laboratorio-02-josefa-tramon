using System;

namespace Laboratorio_2___Josefa_Tramon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Song
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
    }
    class Espotifai 
    {
        public Song[] arraySongs;
        public int num;

        public Espotifai()
        {
            this.num = 0;

        }
        public bool AddSong(Song song)
        {
            this.arraySongs[num] = song;

            this.num += 1;
            return true;
        }
        public void seeSong()
        {
            foreach (Song song in this.arraySongs)
            {
                string nonmbre = song.name;
                Console.Write("genero: " + song.gender + ", artista: " + song.artist + ", album: " + song.album + ", nombre: " + song.name + "\n");
            }
                
        }





    }


        


        

    }


    }



}   


    
