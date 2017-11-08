using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class Peliculas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
    }
}
