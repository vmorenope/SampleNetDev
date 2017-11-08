using System;
using System.Collections.Generic;

namespace DBFirts.Models.Models
{
    public partial class Amcatalogos
    {
        public int CatalogoId { get; set; }
        public int ClasificacionId { get; set; }
        public string CatalogoCodigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Catalogo { get; set; }
        public string UnidadMedidaId { get; set; }
        public decimal? PesoComercial { get; set; }
        public decimal? PesoNeto { get; set; }
        public decimal? StockActual { get; set; }
        public decimal? StockMinimo { get; set; }
        public decimal? StockMaximo { get; set; }
        public byte? ClasificacionAbcid { get; set; }
        public bool? CatalogoActivoFijo { get; set; }
        public bool? CatalogoPalmacen { get; set; }
        public bool? CatalogoPcompras { get; set; }
        public bool? CatalogoPventas { get; set; }
        public bool? CatalogoPproduccion { get; set; }
        public int? CatalogoAlmacenId { get; set; }
        public bool? CatalogoFechaVencimiento { get; set; }
        public byte? CatalogoImpuestoId { get; set; }
        public string PartidaArancelaria { get; set; }
        public bool? EsAfectoPercepcion { get; set; }
        public int? AlmacenUbicacionId { get; set; }
        public string CatalogoRutaImagen { get; set; }
        public byte CatalogoEstadoId { get; set; }
        public int RegistroUsuarioId { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
