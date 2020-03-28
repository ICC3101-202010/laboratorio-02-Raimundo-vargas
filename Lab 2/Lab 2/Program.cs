using System;

namespace Lab_2
{
    class Programa
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a este gestor de musica!");
            string x = "s";
            Espotifai inicio = new Espotifai();
            while (x=="s")
            {
                Console.WriteLine("Que quieres hacer?, agregar una cancion o ver todas las canciones?(agregar/ver)");
                string respuesta = Console.ReadLine();
                if (respuesta == "agregar")
                {
                    Console.WriteLine("Nombre de la cancion:");
                    string nombrecancion = Console.ReadLine();
                    Console.WriteLine("Album de la cancion:");
                    string album = Console.ReadLine();
                    Console.WriteLine("Nombre del artista:");
                    string artista = Console.ReadLine();
                    Console.WriteLine("Genero de la cancion:");
                    string genero = Console.ReadLine();
                    Cancion cancion = new Cancion(nombrecancion, album, artista, genero);
                    inicio.AgregarCancion(cancion);
                }
                else if (respuesta == "ver")
                {
                    inicio.VarCanciones();
                }
                else
                {
                    x = "";
                }
            }
        }
    }
}
