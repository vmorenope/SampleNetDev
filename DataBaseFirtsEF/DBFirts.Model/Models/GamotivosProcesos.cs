using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class GamotivosProcesos
    {
        public byte MotivoProcesoId { get; set; }
        public string MotivoProceso { get; set; }
        public byte EstadoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
