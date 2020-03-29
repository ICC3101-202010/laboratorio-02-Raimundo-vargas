using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Espotifai
    {
        public List<Cancion> canciones;
        public List<Cancion> listaespecifica;
        public Espotifai()
        {
            canciones = new List<Cancion>();
            listaespecifica = new List<Cancion>();
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
            switch(criterio)
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
                    listaespecifica.Clear();
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
                    listaespecifica.Clear();
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
                    listaespecifica.Clear();
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
                    listaespecifica.Clear();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            return listaespecifica;
        }
    }
}
