using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistensia.Data.Configuracion;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");
        builder.Property(p => p.Username).HasMaxLength(50).IsRequired();


        builder.Property(p => p.Password)
       .HasMaxLength(255)
       .IsRequired();

        builder.Property(p => p.Email)
        .HasMaxLength(100)
        .IsRequired();

        builder
       .HasMany(p => p.Rols)
       .WithMany(r => r.Users)
       .UsingEntity<UserRol>(

           j => j
           .HasOne(pt => pt.Rol)
           .WithMany(t => t.UsersRols)
           .HasForeignKey(ut => ut.IdRolFk),

           j => j
           .HasOne(et => et.Usuario)
           .WithMany(et => et.UsersRols)
           .HasForeignKey(el => el.IdUserFk),

           j =>
           {
               j.ToTable("userRols");
               j.HasKey(t => new { t.IdUserFk, t.IdRolFk });

           });

        builder.HasMany(p => p.RefreshTokens)
        .WithOne(p => p.User)
        .HasForeignKey(p => p.IdUserFk);
    }
}
