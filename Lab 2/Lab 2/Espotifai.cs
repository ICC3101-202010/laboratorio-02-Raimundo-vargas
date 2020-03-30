using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Espotifai
    {
        public List<Cancion> canciones;
        public List<Cancion> listaespecifica;
        public List<Playlist> listaplaylist;
        public Espotifai()
        
        {
            canciones = new List<Cancion>();           
            listaplaylist = new List<Playlist>();
        }
        public bool AgregarCancion(Cancion cancion)
         
        {
            for (int i = 0; i < canciones.Count; i++)
            {
                if (canciones[i].Informacion() == cancion.Informacion())
                    return false;
            }
            canciones.Add(cancion); 
            return true;
        }
        public void VarCanciones()
        {
            if (canciones.Count == 0)
                Console.WriteLine("No hay canciones en la lista");
            else
                for (int i = 0; i < canciones.Count; i++)
                    Console.WriteLine(canciones[i].Informacion());
        }
        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            listaespecifica = new List<Cancion>();
            switch (criterio)
            {
                case "album":
                    for (int i = 0; i < canciones.Count; i++)
                    {                     
                        if (canciones[i].album == valor)
                        {
                            listaespecifica.Add(canciones[i]);
                        }
                    }
                    for (int i = 0; i < listaespecifica.Count; i++)
                        Console.WriteLine(listaespecifica[i].Informacion());                  
                    break;
                case ("nombre"):
                    for (int i = 0; i < canciones.Count; i++)
                    {
                        if (canciones[i].nombre == valor)
                        {
                            listaespecifica.Add(canciones[i]);
                        }
                    }
                    for (int i = 0; i < listaespecifica.Count; i++)
                        Console.WriteLine(listaespecifica[i].Informacion());                
                    break;
                case ("genero"):
                    for (int i = 0; i < canciones.Count; i++)
                    {
                        if (canciones[i].genero == valor)
                        {
                            listaespecifica.Add(canciones[i]);
                        }
                    }
                    for (int i = 0; i < listaespecifica.Count; i++)
                        Console.WriteLine(listaespecifica[i].Informacion());                    
                    break;
                case ("artista"):
                    for (int i = 0; i < canciones.Count; i++)
                    {
                        if (canciones[i].artista == valor)
                        {
                            listaespecifica.Add(canciones[i]);
                        }
                    }
                    for (int i = 0; i < listaespecifica.Count; i++)
                        Console.WriteLine(listaespecifica[i].Informacion());                    
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            return listaespecifica;
        }       
        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)
        {
            string existencia = "";
            for (int i = 0; i < listaplaylist.Count; i++)
            {
                if (nombrePlaylist == listaplaylist[i].nombreplaylist)
                {

                    existencia = "F";

                }
                else
                    continue;
            }
            if (existencia == "")
            {
                List<Cancion> f = CancionesPorCriterio(criterio, valorCriterio);
                Playlist listaplaylistprueba = new Playlist(nombrePlaylist, f);
                listaplaylist.Add(listaplaylistprueba);
                return true;
            }
            else
            {
                Console.WriteLine("La playlist no se pudo hacer por que ya hay una PlaYlist con ese nombre, por favor intentar denuevo");
                Console.WriteLine(" ");
                return false;
            }        
        }
        public string VerMisPlaylists()
        {            
            string vermisplaylist = "";
            for (int i = 0; i < listaplaylist.Count; i++)
            {
                vermisplaylist += "Nombre de la playlist: \n";
                vermisplaylist += listaplaylist[i].nombreplaylist;
                vermisplaylist += "\n";
                vermisplaylist += listaplaylist[i].VerInformacionplaylist();
                vermisplaylist += "\n";
            }
            return vermisplaylist;
        }
    }
}
