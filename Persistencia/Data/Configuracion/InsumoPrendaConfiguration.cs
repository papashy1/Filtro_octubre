using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistensia.Data.Configuracion;
public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
{
    public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
    {
        builder.ToTable("insumoPrenda");

        builder.HasOne(p => p.Insumo)
        .WithMany(p => p.InsumoPrendas)
        .HasForeignKey(p => p.IdInsumoFk);

        builder.HasOne(p => p.Prenda)
        .WithMany(p => p.InsumoPrendas)
        .HasForeignKey(p => p.IdPrendaFk);
    }
}
