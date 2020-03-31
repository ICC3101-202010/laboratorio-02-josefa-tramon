using System;

namespace Laboratorio_2___Josefa_Tramon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] opciones = { 1, 2, 3 };
            Console.WriteLine("Hello, welcome to Espotifai\n");
            string line;
            string opcion = "";
            Espotifai spotify = new Espotifai();
            while (opcion != "3")
            {
                Console.WriteLine("Indique su opcion\n1. agregar canción\n2. ver canciones\n3. salir\n");
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.WriteLine("Indique nombre\n");
                    string name= Console.ReadLine();
                    Console.WriteLine("Indique almbum\n");
                    string album = Console.ReadLine();
                    Console.WriteLine("Indique artista\n");
                    string artist = Console.ReadLine();
                    Console.WriteLine("Indique genero\n");
                    string gender = Console.ReadLine();
                    line = Console.ReadLine();
                    spotify.AddSong(new Song(name, album, artist, gender));
                }
                else if (opcion == "2") 
                {
                    spotify.seeSong();
                }

            }
                

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
    public class Espotifai 
    {
        public List<Song> arraySongs;

        public Espotifai()
        {

        }
        public bool AddSong(Song song)
        {
            this.arraySongs.add(song);
            return true;
        }
        public void seeSong()
        {
            if (arraySongs.size != 0)
            {
                foreach (Song song in this.arraySongs)
                {
                    Console.Write("genero: " + song.Gender + ", artista: " + song.Artist + ", album: " + song.Album + ", nombre: " + song.Name + "\n");
                }
            }
            else
            {
                Console.Write("no hay canciones\n");
            }
                
        }





    }


        


        

    }


    





    
