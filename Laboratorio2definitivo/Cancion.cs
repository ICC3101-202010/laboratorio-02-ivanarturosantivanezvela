using System;
using System.Collections.Generic;
namespace Laboratorio2definitivo
{
    public class Cancion
    {

        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;






        public Cancion(string nombre, string album, string artista, string genero)
        {


            this.Nombre = nombre;
            this.Album = album;
            this.Artista = artista;
            this.Genero = genero;






        }
        public string Informacion()


        {
            string display1 = Artista;
            string display2 = Album;
            string display3 = Artista;
            string display4 = Genero;

            return "Genero: " + display4 + " " + "Artista: " + display3 + "Album: " + display2 + "Nombre: " + display1;



        }






    }
}