using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Espotifai
    {
        
        public string Pedircancion()
        {
            Console.WriteLine("Introduzca una cancion");
            String cancion;
            cancion = Console.ReadLine();
            Console.WriteLine("La cancion introducida es: " + cancion);
            return cancion;
        }

    }
}
