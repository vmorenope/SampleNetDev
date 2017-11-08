using System;

namespace DBFirts.Models.Models
{
    public partial class GalmacenesMotivos
    {
        public int AlmacenMotivoId { get; set; }
        public int AlmacenId { get; set; }
        public int MotivoId { get; set; }
        public int DocumentoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
