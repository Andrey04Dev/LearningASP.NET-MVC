using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASP.NET_MVC.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public bool  EstaEnGaleria { get; set; }
        public string  Genero { get; set; }
    }
}