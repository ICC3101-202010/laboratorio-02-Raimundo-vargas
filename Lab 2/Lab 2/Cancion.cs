﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Cancion
    {
        private string nombre;
        private string album;
        private string artista;
        private string genero;
        public Cancion(string nombrestr, string albumstr, string artistastr, string generostr)
        {
            nombre = nombrestr;
            album = albumstr;
            artista = artistastr;
            genero = generostr;
        }
        public string Informacion()
        {
            string info = (" genero: " + genero + "," + " artista: " + artista + "," + " album: " + album + "," + " nombre: " + nombre);
            return info;
        }
    }
}
