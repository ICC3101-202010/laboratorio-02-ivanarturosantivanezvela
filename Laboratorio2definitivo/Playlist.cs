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



        public Playlist(string nombre_playlist,List<Cancion> canciones_agregadas)
            :this()
        {
            
            this.Nombre_playlist = nombre_playlist;
            foreach (Cancion elemento in canciones_agregadas)
            {
                Usuario_playlist.Add(elemento);
            }
            

        }

        public void Informacion_playlist(string nombreplaylist)
        {
           
            
            if (Nombre_playlist==nombreplaylist)
            {
                foreach (Cancion recorrer in Usuario_playlist)
                {

                    Console.WriteLine("En la playlist {0} se encuentran las siguientes canciones: Artista: {1}, Album: {2}, Nombre: {3}, Genero: {4}",nombreplaylist,recorrer.Artista,recorrer.Album,recorrer.Nombre,recorrer.Genero);

                }


            }
           


        }

    }
}