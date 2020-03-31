using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Playlist
    {
        public string nombreplaylist;
        public List<Cancion> playlists = new List<Cancion>();
        public Playlist(string nombreplaylistm, List<Cancion> canciones)
        {
            nombreplaylist = nombreplaylistm;
            playlists = canciones;
        }
        public string VerInformacionplaylist()
        {
            if (playlists.Count == 0)
            {
                return ("No hay canciones en la playlist");
            }   
            else
            {
                string variable = "";
                for (int i = 0; i < playlists.Count; i++)
                    variable += (playlists[i].Informacion());
                    variable += "\n";
                return variable;
            }
        }
    }
}
