using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class Galmacenes
    {
        public int AlmacenId { get; set; }
        public string Almacen { get; set; }
        public byte ExistenciaTipoId { get; set; }
        public int EstablecimientoId { get; set; }
        public bool? EsPrincipal { get; set; }
        public bool? EsValorizado { get; set; }
        public bool? SoloCodigoBarras { get; set; }
        public bool? GeneraAsientoContable { get; set; }
        public byte MetodoValuacionId { get; set; }
        public byte EstadoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
