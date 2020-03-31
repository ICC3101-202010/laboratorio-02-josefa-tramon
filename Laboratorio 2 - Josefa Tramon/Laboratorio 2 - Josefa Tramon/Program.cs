using System;
using System.Collections.Generic;
using System.Linq;

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
    

    }



        


        

    


    





    
