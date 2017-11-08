using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class GalmacenesMotivosUsuarios
    {
        public int AlmacenMotivoId { get; set; }
        public int UsuarioId { get; set; }
        public byte EstadoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
