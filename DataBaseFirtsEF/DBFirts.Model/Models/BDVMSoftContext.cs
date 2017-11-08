using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirts.Models.Models
{
    public partial class BDVMSoftContext : DbContext
    {
        public virtual DbSet<Amcatalogos> Amcatalogos { get; set; }
        public virtual DbSet<Galmacenes> Galmacenes { get; set; }
        public virtual DbSet<GalmacenesMotivos> GalmacenesMotivos { get; set; }
        public virtual DbSet<GalmacenesMotivosUsuarios> GalmacenesMotivosUsuarios { get; set; }
        public virtual DbSet<GalmacenesUbicaciones> GalmacenesUbicaciones { get; set; }
        public virtual DbSet<Gamotivos> Gamotivos { get; set; }
        public virtual DbSet<GamotivosProcesos> GamotivosProcesos { get; set; }
        public virtual DbSet<GamovimientosTransferencias> GamovimientosTransferencias { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Peliculas> Peliculas { get; set; }

        // Unable to generate entity type for table 'dbo.GAUbicacionNiveles'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.;Database=BDVMSoft;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amcatalogos>(entity =>
            {
                entity.HasKey(e => e.CatalogoId);

                entity.ToTable("AMCatalogos");

                entity.Property(e => e.Catalogo)
                    .IsRequired()
                    .HasMaxLength(130)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogoActivoFijo).HasDefaultValueSql("((0))");

                entity.Property(e => e.CatalogoCodigo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogoEstadoId).HasDefaultValueSql("((2))");

                entity.Property(e => e.CatalogoPalmacen)
                    .HasColumnName("CatalogoPAlmacen")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CatalogoPcompras)
                    .HasColumnName("CatalogoPCompras")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CatalogoPproduccion)
                    .HasColumnName("CatalogoPProduccion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CatalogoPventas)
                    .HasColumnName("CatalogoPVentas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CatalogoRutaImagen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionAbcid).HasColumnName("ClasificacionABCId");

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartidaArancelaria)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PesoComercial).HasColumnType("money");

                entity.Property(e => e.PesoNeto).HasColumnType("money");

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockActual).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.StockMaximo).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.StockMinimo).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.UnidadMedidaId)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Galmacenes>(entity =>
            {
                entity.HasKey(e => e.AlmacenId);

                entity.ToTable("GAlmacenes");

                entity.Property(e => e.Almacen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EsPrincipal).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsValorizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstablecimientoId).HasDefaultValueSql("((1))");

                entity.Property(e => e.EstadoId).HasDefaultValueSql("((2))");

                entity.Property(e => e.ExistenciaTipoId).HasDefaultValueSql("((1))");

                entity.Property(e => e.GeneraAsientoContable).HasDefaultValueSql("((0))");

                entity.Property(e => e.MetodoValuacionId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");

                entity.Property(e => e.SoloCodigoBarras).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GalmacenesMotivos>(entity =>
            {
                entity.HasKey(e => e.AlmacenMotivoId);

                entity.ToTable("GAlmacenesMotivos");

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GalmacenesMotivosUsuarios>(entity =>
            {
                entity.HasKey(e => new { e.AlmacenMotivoId, e.UsuarioId });

                entity.ToTable("GAlmacenesMotivosUsuarios");

                entity.Property(e => e.EstadoId).HasDefaultValueSql("((2))");

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GalmacenesUbicaciones>(entity =>
            {
                entity.HasKey(e => e.AlmacenUbicacionId);

                entity.ToTable("GAlmacenesUbicaciones");

                entity.Property(e => e.EstadoId).HasDefaultValueSql("((2))");

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Gamotivos>(entity =>
            {
                entity.HasKey(e => e.MotivoId);

                entity.ToTable("GAMotivos");

                entity.Property(e => e.MotivoId).ValueGeneratedOnAdd();

                entity.Property(e => e.EstadoId).HasDefaultValueSql("((2))");

                entity.Property(e => e.LetipoOperacionId)
                    .HasColumnName("LETipoOperacionId")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoTipoId)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GamotivosProcesos>(entity =>
            {
                entity.HasKey(e => e.MotivoProcesoId);

                entity.ToTable("GAMotivosProcesos");

                entity.Property(e => e.MotivoProcesoId).ValueGeneratedOnAdd();

                entity.Property(e => e.EstadoId).HasDefaultValueSql("((2))");

                entity.Property(e => e.MotivoProceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GamovimientosTransferencias>(entity =>
            {
                entity.HasKey(e => e.MovimientoTransferenciaId);

                entity.ToTable("GAMovimientosTransferencias");

                entity.Property(e => e.EstadoId).HasDefaultValueSql("((2))");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegistroUsuarioId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.Property(e => e.FechaEstreno).HasColumnType("datetime");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });
        }
    }
}
