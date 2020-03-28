using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Espotifai
    {
        public List<Cancion> canciones;
        public Espotifai()
        {
            canciones = new List<Cancion>();           
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
        
    }
}
