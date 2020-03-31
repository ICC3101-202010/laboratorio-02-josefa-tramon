using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2___Josefa_Tramon
{
    public class Espotifai
    {
        private List<Song> arraySongs;

        public Espotifai()
        {
            List<Song> list = new List<Song>();
            ArraySongs = list;
        }

        internal List<Song> ArraySongs { get => arraySongs; set => arraySongs = value; }

        public bool AddSong(Song song)
        {
            this.ArraySongs.Add(song);
            return true;
        }
        public void seeSong()
        {
            if (ArraySongs.Count != 0)
            {
                foreach (Song song in this.ArraySongs)
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
