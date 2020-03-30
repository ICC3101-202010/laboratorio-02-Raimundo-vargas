using System;

namespace Lab_2
{
    class Programa
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a este gestor de musica!");
            string x = "1";
            Espotifai inicio = new Espotifai();          
            while (x=="1")
            {
                Console.WriteLine("Que quieres hacer?");
                Console.WriteLine("1: agregar una cancion");
                Console.WriteLine("2: ver todas las canciones ");
                Console.WriteLine("3: ver por criterio");
                Console.WriteLine("4: agregar playlist");
                Console.WriteLine("5: ver playlist");
                string respuesta = Console.ReadLine();
                if (respuesta == "1")
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
                else if (respuesta == "2")
                {
                    inicio.VarCanciones();
                }
                else if (respuesta == "3")
                {
                    Console.WriteLine("criterio a escojer (album, nombre, genero, artista):");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Valor");
                    string valor = Console.ReadLine();
                    inicio.CancionesPorCriterio(criterio, valor);                  
                }
                else if (respuesta == "4")
                {
                    Console.WriteLine("criterio a escojer (album, nombre, genero, artista):");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Valor del Criterio");
                    string valorCriterio = Console.ReadLine();
                    Console.WriteLine("Nombre para la playlist");
                    string nombrePlaylist = Console.ReadLine();
                    inicio.GenerarPlaylist(criterio, valorCriterio, nombrePlaylist);
                }
                else if (respuesta == "5")
                {                   
                    Console.WriteLine(inicio.VerMisPlaylists());
                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta, desea seguir?");
                    Console.WriteLine("1: Seguir");
                    Console.WriteLine("Cualquier otro valor: No seguir");
                    x = Console.ReadLine();
                }
            }
        }
    }
}
