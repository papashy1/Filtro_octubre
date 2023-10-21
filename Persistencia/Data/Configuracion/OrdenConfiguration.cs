using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistensia.Data.Configuracion;
public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        builder.ToTable("orden");

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Ordens)
        .HasForeignKey(p => p.IdEmpleadoFk);

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.Ordens)
        .HasForeignKey(p => p.IdClienteFk);

        builder.HasOne(p => p.Estado)
        .WithMany(p => p.Ordens)
        .HasForeignKey(p => p.IdEstadoFk);
    }
}
