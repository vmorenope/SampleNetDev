using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class GamovimientosTransferencias
    {
        public int MovimientoTransferenciaId { get; set; }
        public int MovimientoIdSalida { get; set; }
        public int MovimientoIdIngreso { get; set; }
        public int? MotivoGrupoId { get; set; }
        public string Observaciones { get; set; }
        public byte EstadoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
