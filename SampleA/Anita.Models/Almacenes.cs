namespace Anita.Models
{
    public class Almacenes
    {
        public int AlmacenId { get; set; }
        public string Almacen { get; set; }
        public int ExistenciaTipoId { get; set; }
        public int EstablecimientoId { get; set; }
        public bool EsPrincipal { get; set; }
        public bool EsValorizado { get; set; }
    }
}