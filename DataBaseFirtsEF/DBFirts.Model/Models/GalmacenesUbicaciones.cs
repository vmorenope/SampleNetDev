using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class GalmacenesUbicaciones
    {
        public int AlmacenUbicacionId { get; set; }
        public int AlmacenId { get; set; }
        public byte ZonaId { get; set; }
        public byte SeccionId { get; set; }
        public byte NivelId { get; set; }
        public byte EstadoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
