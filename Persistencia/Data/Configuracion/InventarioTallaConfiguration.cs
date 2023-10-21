using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistensia.Data.Configuracion;
public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
{
    public void Configure(EntityTypeBuilder<InventarioTalla> builder)
    {
        builder.ToTable("inventarioTalla");

        builder.HasOne(p => p.Inventario)
        .WithMany(p => p.InventarioTallas)
        .HasForeignKey(p => p.IdInventarioFk);

        builder.HasOne(p => p.Talla)
        .WithMany(p => p.InventarioTallas)
        .HasForeignKey(p => p.IdTallaFk);
    }
}
