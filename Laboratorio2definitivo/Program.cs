using System;
using System.Collections.Generic;

namespace Laboratorio2definitivo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool closeprogram = false;
            Console.WriteLine("Bienvenido a Espotifai!");
            Espotifai espotifai = new Espotifai();
            
            while (!closeprogram)
            {
                Console.WriteLine("Los comandos disponibles son:");

                Console.WriteLine("1: Agregar cancion a Espotifai");
                Console.WriteLine("2: Ver canciones en Espotifai");
                Console.WriteLine("3: Ver canciones por criterio");
                Console.WriteLine("4: Agregar cancion a la playlist ");
                Console.WriteLine("5: Ver las playlist");
                Console.WriteLine("0: Salir del programa");
                string comando = Console.ReadLine();

                if (comando == "0")
                {

                    closeprogram = true;
                    Console.WriteLine("Cerraste Espotifai adios!!!!");

                }

                if (comando == "1")
                {

                    // Nombre cancion
                    string nombre_cancion = "";
                    bool nombreValido = false;
                    while (!nombreValido)
                    {
                        Console.WriteLine("Ingresa el nombre de la cancion:");
                        nombre_cancion = Console.ReadLine();
                        if (nombre_cancion.Trim() != "")
                        {
                            nombreValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Debes ingresar un nombre de cancion válido");
                        }
                        // Nombre del album
                        string nombre_album = "";
                        Console.WriteLine("Ingrese el nombre del album: ");

                        nombre_album = Console.ReadLine();

                        if (nombre_album.Trim() != "")
                        {

                            nombreValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Debes ingresar un nombre de album válido");

                        }
                        string nombre_artista = "";
                        Console.WriteLine("Ingrese el nombre del artista: ");
                        nombre_artista = Console.ReadLine();
                        if (nombre_artista.Trim() != "")
                        {
                            nombreValido = true;
                        }

                        else
                        {
                            Console.WriteLine("Debes ingresar un nombre de artista válido");
                        }

                        string nombre_genero = "";
                        Console.WriteLine("Escriba el nombre del genero de la cancion: ");
                        nombre_genero = Console.ReadLine();
                        if (nombre_genero.Trim() != "")
                        {
                            nombreValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Debes ingresar un nombre de genero válido");
                        }
                        Cancion cancion = new Cancion(nombre_cancion, nombre_album, nombre_artista, nombre_genero);

                        espotifai.AgregarCancion(cancion);

                    }
                }

                if (comando == "2")
                {

                    espotifai.VerCanciones();
                }

                if (comando == "3")
                {
                    string criterio_usuario = "";
                    Console.WriteLine("Ingresa el criterio de la cancion:");
                    criterio_usuario = Console.ReadLine();
                    string valor_usuario = "";
                    Console.WriteLine("Ingresa el valor de la cancion:");
                    valor_usuario = Console.ReadLine();
                    espotifai.CancionesPorCriterio(criterio_usuario, valor_usuario);




                }

                if (comando == "4")
                {
                    string criterio_usuario1 = "";
                    Console.WriteLine("Ingresa el criterio de la cancion:");
                    criterio_usuario1 = Console.ReadLine();
                    string valor_usuario1 = "";
                    Console.WriteLine("Ingresa el valor de la cancion:");
                    valor_usuario1 = Console.ReadLine();
                    string nombre_playlist = "";
                    Console.WriteLine("Ingresa el nombre  de la playlist:");
                    nombre_playlist = Console.ReadLine();
                    espotifai.GenerarPlaylist(criterio_usuario1, valor_usuario1, nombre_playlist);




                }
                if (comando == "5")
                {

                    espotifai.VerMisPlaylists();


                }


                
   



















                //Cancion cancion = new Cancion("Lights","Lights","Ellie","Pop");
                //Cancion cancion1 = new Cancion ("Colors","Flow","Flow","Kpop");
                //Espotifai espotifai = new Espotifai();


                //espotifai.AgregarCancion(cancion);

                //espotifai.VerCanciones();



                //espotifai.AgregarCancion(cancion);

                //List<Cancion> espotifai = new List<Cancion>();
                //Espotifai espotifai = new Espotifai();

                //espotifai.Add(cancion);

                //Cancion cancioncita = espotifai.listcanciones[0];
                //Console.WriteLine(cancioncita.Album);
                //Console.WriteLine(cancioncita.Nombre);







                //Cancion cancion1 = new Cancion ("Colors","Flow","Flow","Kpop");





                //Console.WriteLine(cancion.Informacion());
            }
        }
    }
}



