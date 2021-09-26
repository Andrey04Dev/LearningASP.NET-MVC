using LearningASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASP.NET_MVC.DAL
{
    public class PeliculaRepository
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula()
                {
                    Titulo = "Rapidos y Furioso",
                    EstaEnGaleria = true,
                    Genero = "Acción"
                },
                new Pelicula()
                {
                    Titulo = "La Casa Embrujada",
                    EstaEnGaleria = true,
                    Genero = "Terror"
                },
                new Pelicula()
                {
                    Titulo = "Deadpool",
                    EstaEnGaleria = false,
                    Genero = "Acción"
                },

            };
        }
    }
}