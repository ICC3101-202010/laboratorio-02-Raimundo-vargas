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
                Console.WriteLine("Que quieres hacer?, agregar una cancion, ver todas las canciones o ver por criterio?(agregar/ver/ver por criterio)");
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
                else if (respuesta == "ver por criterio")
                {

                    Console.WriteLine("criterio a escojer (album, nombre, genero, artista):");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Valor");
                    string valor = Console.ReadLine();
                    inicio.CancionesPorCriterio(criterio, valor);  
                }
                else
                {
                    x = "";
                }
            }
        }
    }
}
