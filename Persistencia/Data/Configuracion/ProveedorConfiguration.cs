using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistensia.Data.Configuracion;
public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
        builder.ToTable("proveedor");

        builder.HasOne(p => p.TipoPersona)
        .WithMany(p => p.Proveedors)
        .HasForeignKey(p => p.IdTipoPersonaFk);

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Proveedors)
        .HasForeignKey(p => p.IdMunicipioFk);

        builder
       .HasMany(p => p.Insumos)
       .WithMany(r => r.Proveedores)
       .UsingEntity<InsumoProveedor>(

           j => j
           .HasOne(pt => pt.Insumo)
           .WithMany(t => t.InsumoProveedors)
           .HasForeignKey(ut => ut.IdInsumoFk),

           j => j
           .HasOne(et => et.Proveedor)
           .WithMany(et => et.InsumoProveedors)
           .HasForeignKey(el => el.IdProveedorFk),

           j =>
           {
               j.ToTable("userRol");
               j.HasKey(t => new { t.IdProveedorFk, t.IdInsumoFk });

           });
    }
}
