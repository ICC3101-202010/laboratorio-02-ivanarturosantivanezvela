using System;
using System.Collections.Generic;
namespace Laboratorio2definitivo
{
    public class Playlist
    {

        public string Nombre_playlist;
        public List<Cancion> Usuario_playlist;


        public Playlist()
        {
            Usuario_playlist = new List<Cancion>();

        }



        public Playlist(string nombre_playlist, Cancion cancion_aplaylist)
            :this()
        {
            
            this.Nombre_playlist = nombre_playlist;
            Usuario_playlist.Add(cancion_aplaylist);

        }

        public void Informacion_playlist(string nombredelaplaylist)
        {
           if (Nombre_playlist==nombredelaplaylist)

            {
                foreach (Cancion recorrer in Usuario_playlist)
                {

                    Console.WriteLine("En la playlist {0} se encuentran las siguientes canciones: Artista: {1}, Album: {2}, Nombre: {3}, Genero: {4}",nombredelaplaylist,recorrer.Artista,recorrer.Album,recorrer.Nombre,recorrer.Genero);

                }


            }
           


        }

    }
}