using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class Gamotivos
    {
        public byte MotivoId { get; set; }
        public string Motivo { get; set; }
        public string MotivoTipoId { get; set; }
        public byte MotivoGrupoId { get; set; }
        public string LetipoOperacionId { get; set; }
        public byte EstadoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
