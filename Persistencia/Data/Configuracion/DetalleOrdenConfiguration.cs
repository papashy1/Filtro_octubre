using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistensia.Data.Configuracion;
public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {
        builder.ToTable("detalleOrden");

        builder.HasOne(p => p.Orden)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.IdOrdenFk);

        builder.HasOne(p => p.Prenda)
        .WithMany(p => p.DetalleOrdens)
        .HasForeignKey(p => p.IdPrendaFk);

        builder.HasOne(p => p.Color)
        .WithMany(p => p.DetalleOrdens)
        .HasForeignKey(p => p.IdColorFk);
    
        builder.HasOne(p => p.Estado)
        .WithMany(p => p.DetalleOrdens)
        .HasForeignKey(p => p.IdEstadoFk);
    }
}
