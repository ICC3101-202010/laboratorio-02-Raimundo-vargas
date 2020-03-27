using System;

namespace Lab_2
{
    class Programa
    {
        static void Main()
        {

            Espotifai cancion = new Espotifai();  
            string cancionnueva = "";
            cancionnueva = cancion.Pedircancion();
            Console.WriteLine(cancionnueva);
        }
    }

}
