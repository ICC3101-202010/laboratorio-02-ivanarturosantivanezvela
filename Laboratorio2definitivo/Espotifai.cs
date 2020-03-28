using System;
using System.Collections.Generic;
namespace Laboratorio2definitivo
{
    public class Espotifai
    {
        public List<Cancion> listcanciones;






        public Espotifai()
        {
            listcanciones = new List<Cancion>();


        }

        public bool AgregarCancion(Cancion cancion)
        {





            //for(int i=0 ; i < listcanciones.Count; i++)
            foreach (Cancion variable in listcanciones)
            {


                if (variable.Nombre == cancion.Nombre && variable.Album == cancion.Album && variable.Artista == cancion.Artista && variable.Genero == cancion.Genero)
                {

                    Console.WriteLine("No se puede agregar cancion repetida");
                    //listcanciones.RemoveAt(i);
                    Console.WriteLine("false");
                    return false;

                    //listcanciones.Remove(cancion);


                }


            }

            listcanciones.Add(cancion);
            Console.WriteLine("true");
            return true;


        }

        public void VerCanciones()
        {

            foreach (Cancion contador in listcanciones)
            {

                Console.WriteLine("Nombre: {0} Album: {1} Artista: {2} Genero: {3}", contador.Nombre, contador.Album, contador.Artista, contador.Genero);


            }


        }

        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {


            foreach (Cancion lista_decanciones in listcanciones)
            {

                if (criterio == "Genero")

                {
                    if (lista_decanciones.Genero == valor)
                    {

                        Console.WriteLine("Nombre: {0} Album: {1} Artista: {2} Genero: {3}", lista_decanciones.Nombre, lista_decanciones.Album, lista_decanciones.Artista, lista_decanciones.Genero);


                    }
                    else
                    {
                        Console.WriteLine("No hay canciones con ese criterio y valor");
                        return listcanciones;
                    }

                }
                else if (criterio == "Artista")

                {
                    if (lista_decanciones.Artista == valor)
                    {
                        Console.WriteLine("Nombre: {0} Album: {1} Artista: {2} Genero: {3}", lista_decanciones.Nombre, lista_decanciones.Album, lista_decanciones.Artista, lista_decanciones.Genero);

                    }
                    else
                    {
                        Console.WriteLine("No hay canciones con ese criterio y valor");
                        return listcanciones;
                    }
                }
                else if (criterio == "Album")

                {
                    if (lista_decanciones.Album == valor)
                    {
                        Console.WriteLine("Nombre: {0} Album: {1} Artista: {2} Genero: {3}", lista_decanciones.Nombre, lista_decanciones.Album, lista_decanciones.Artista, lista_decanciones.Genero);

                    }
                    else
                    {
                        Console.WriteLine("No hay canciones con ese criterio y valor");
                        return listcanciones;
                    }
                }
                else if (criterio == "Nombre")

                {
                    if (lista_decanciones.Nombre == valor)
                    {
                        Console.WriteLine("Nombre: {0} Album: {1} Artista: {2} Genero: {3}", lista_decanciones.Nombre, lista_decanciones.Album, lista_decanciones.Artista, lista_decanciones.Genero);

                    }
                    else
                    {
                        Console.WriteLine("No hay canciones con ese criterio y valor");
                        return listcanciones;
                    }
                }
                else
                {


                    Console.WriteLine("No hay canciones con ese criterio y valor");
                    return listcanciones;

                }





            }

            return listcanciones;
        }
    }
}


