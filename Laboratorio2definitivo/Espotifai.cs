using System;
using System.Collections.Generic;
namespace Laboratorio2definitivo
{
    public class Espotifai
    {
        public List<Cancion> listcanciones;
        public List<Playlist> Playlistespotifai;
        int count = 0;
        //public Dictionary<string ,Cancion> grupo;






        public Espotifai()
        {
            listcanciones = new List<Cancion>();
            Playlistespotifai = new List<Playlist>();
            //grupo = new Dictionary<string, Cancion>();

        }

        public bool AgregarCancion(Cancion cancion)
        {





            //for(int i=0 ; i < listcanciones.Count; i++)
            foreach (Cancion variable in listcanciones)
            {


                if (variable.Nombre == cancion.Nombre && variable.Album == cancion.Album && variable.Artista == cancion.Artista)
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
                        Console.WriteLine("No hay canciones con ese criterio y/o valor");
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
                        Console.WriteLine("No hay canciones con ese criterio y/o valor");
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
                        Console.WriteLine("No hay canciones con ese criterio y/o valor");
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
                        Console.WriteLine("No hay canciones con ese criterio y/o valor");
                        return listcanciones;
                    }
                }
                else
                {


                    Console.WriteLine("No hay canciones con ese criterio y/o valor");
                    return listcanciones;

                }





            }

            return listcanciones;
        }
        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)

        {   string criterio_1= criterio;
            Playlist playlist = new Playlist(nombrePlaylist);
            Playlistespotifai.Add(playlist);
            
            foreach (Cancion cancioncita in listcanciones)
            {
                if (criterio_1 == "Genero" || criterio_1=="Artista")
                {
                    if (cancioncita.Genero == valorCriterio || cancioncita.Artista==valorCriterio)
                    {
                        playlist.Usuario_playlist.Add(cancioncita);

                    }
                    else if (cancioncita.Genero != valorCriterio || cancioncita.Artista != valorCriterio)
                    {   
                        //Console.WriteLine("Error");
                        continue;
                    }


                }
                /*if (criterio_1 == "Artista")
                {
                    if (cancioncita.Artista == valorCriterio)
                    {
                        playlist.Usuario_playlist.Add(cancioncita);

                    }
                    else if (cancioncita.Genero != valorCriterio)
                    {
                        //Console.WriteLine("Error");
                        continue;
                    }

                }*/




            }
            
            for( int i=0 ; i< Playlistespotifai.Count; i++)
            {
                /*if (Playlistespotifai.Count == 0)
                {
                    Playlistespotifai.Add(playlist);
                }*/
                if (playlist.Nombre_playlist == nombrePlaylist && count!=0)
                {
                    Console.WriteLine("No se puede agregar nombres iguales de playlist");
                    

                }
                
                else
                {
                    Playlistespotifai.Add(playlist);
                    break;
                }
            }
            count++;
            
            
           

            return true;
            /*Playlistespotifai.Add(playlist);
            
            foreach(Playlist elegir in Playlistespotifai)
            {   
                foreach (Cancion enumerador in listcanciones)
                {
                    if (criterio_1 == "Genero")
                    {
                        if (enumerador.Genero == valorCriterio)
                        {
                            playlist.Usuario_playlist.Add(enumerador);

                        }
                        else
                        {
                            Console.WriteLine("No hay playlist con ese criterio y/o valor");
                        }

                    }
                }

            }*/
            
         
            /*Playlist playlist = new Playlist(nombrePlaylist);

            Playlistespotifai.Add(playlist);

            
            foreach (Playlist lista_playlist in Playlistespotifai)
            {

                

                if (lista_playlist.Nombre_playlist == nombrePlaylist && ronda!=0)
                {
                    
                    Console.WriteLine("Ya hay una playlist con ese nombre");
                    
                    return false;
                    

                }
                ronda++;
                foreach (Cancion elemento in listcanciones)
                {
                    Console.WriteLine(elemento.Informacion());
                    
                    if (criterio == "Genero")

                    {
                        if (elemento.Genero == valorCriterio)
                        {
                            
                            playlist.Usuario_playlist.Add(elemento);


                            Console.WriteLine("true");
                            return true;

                        }
                        else
                        {
                            Console.WriteLine("No hay playlist con ese criterio y/o valor");
                            return false;
                        }

                    }

                    
                }  
             

            }

           return true; */  
        }
        
        public String VerMisPlaylists()
        {
            
            foreach (Playlist recorrido in Playlistespotifai)
            {   
                recorrido.Informacion_playlist();
                //Console.WriteLine(recorrido.Nombre_playlist);
                //Console.WriteLine(grupo[recorrido.Nombre_playlist].Album);
                /*if (grupo.ContainsKey(recorrido.Nombre_playlist))
                {
                    Cancion cancioncita = grupo[recorrido.Nombre_playlist];
                    Console.WriteLine(cancioncita.Nombre);

                }*/

               

            }
            return "";
        }













    }

}


