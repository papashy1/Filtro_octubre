﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CargoDescripcion")
                        .HasColumnType("longtext");

                    b.Property<decimal>("SueldoBase")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("cargo", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipioFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdMunicipioFk");

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorDescripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("color", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreDepartamento")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.DetalleOrden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadProducir")
                        .HasColumnType("int");

                    b.Property<int>("IdColorFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrendaFk")
                        .HasColumnType("int");

                    b.Property<int>("cantidadProducida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdColorFk");

                    b.HasIndex("IdEstadoFk");

                    b.HasIndex("IdOrdenFk");

                    b.HasIndex("IdPrendaFk");

                    b.ToTable("detalleOrden", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInventarioFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTallaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdVentaFk")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnit")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("IdInventarioFk");

                    b.HasIndex("IdTallaFk");

                    b.HasIndex("IdVentaFk");

                    b.ToTable("detalleVenta", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCargoFk")
                        .HasColumnType("int");

                    b.Property<string>("IdEmpleado")
                        .HasColumnType("longtext");

                    b.Property<int>("IdMunicipioFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCargoFk");

                    b.HasIndex("IdMunicipioFk");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdMunicipioFk")
                        .HasColumnType("int");

                    b.Property<string>("Nit")
                        .HasColumnType("longtext");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("longtext");

                    b.Property<string>("RepresentanteLegal")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdMunicipioFk");

                    b.ToTable("empresa", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EstadoDescripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("IdTipoEstadoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoEstadoFk");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FormaPagoDescripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("formaPago", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GeneroDescription")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("genero", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Insumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreInsumo")
                        .HasColumnType("longtext");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnit")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("insumo", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.InsumoPrenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdInsumoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrendaFk")
                        .HasColumnType("int");

                    b.Property<int>("InsumoPrendaCantidad")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInsumoFk");

                    b.HasIndex("IdPrendaFk");

                    b.ToTable("insumoPrenda", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.InsumoProveedor", b =>
                {
                    b.Property<int>("IdProveedorFk")
                        .HasColumnType("int");

                    b.Property<int>("IdInsumoFk")
                        .HasColumnType("int");

                    b.HasKey("IdProveedorFk", "IdInsumoFk");

                    b.HasIndex("IdInsumoFk");

                    b.ToTable("userRol", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodInv")
                        .HasColumnType("int");

                    b.Property<int>("IdPrendaFk")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorVtaCop")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorVtaUsd")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("IdPrendaFk");

                    b.ToTable("inventario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.InventarioTalla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdInventarioFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTallaFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInventarioFk");

                    b.HasIndex("IdTallaFk");

                    b.ToTable("inventarioTalla", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreMunicipio")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("municipio", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrdenFecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdEmpleadoFk");

                    b.HasIndex("IdEstadoFk");

                    b.ToTable("orden", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Prenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdGeneroFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoProteccionFk")
                        .HasColumnType("int");

                    b.Property<string>("NombrePrenda")
                        .HasColumnType("longtext");

                    b.Property<decimal>("ValorUnitCop")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorUnitUsd")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadoFk");

                    b.HasIndex("IdGeneroFk");

                    b.HasIndex("IdTipoProteccionFk");

                    b.ToTable("prenda", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipioFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("NitProveedor")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreProveedor")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdMunicipioFk");

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("proveedor", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdUserFk");

                    b.ToTable("refreshToken", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Talla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TallaDescripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("talla", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoEstado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TipoEstadoDescripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("tipoEstado", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipoPersona")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("tipoPersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoProteccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TipoProteccionDescripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("tipoProteccion", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int");

                    b.HasKey("IdUserFk", "IdRolFk");

                    b.HasIndex("IdRolFk");

                    b.ToTable("userRols", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadofk")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaPagoFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("VentaFecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdEmpleadofk");

                    b.HasIndex("IdFormaPagoFk");

                    b.ToTable("venta", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Cliente", b =>
                {
                    b.HasOne("Dominio.Entities.Municipio", "Municipio")
                        .WithMany("Clientes")
                        .HasForeignKey("IdMunicipioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoPersona", "TipoPersona")
                        .WithMany("Clientes")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.HasOne("Dominio.Entities.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Dominio.Entities.DetalleOrden", b =>
                {
                    b.HasOne("Dominio.Entities.Color", "Color")
                        .WithMany("DetalleOrdens")
                        .HasForeignKey("IdColorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Estado", "Estado")
                        .WithMany("DetalleOrdens")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Orden", "Orden")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdOrdenFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Prenda", "Prenda")
                        .WithMany("DetalleOrdens")
                        .HasForeignKey("IdPrendaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Estado");

                    b.Navigation("Orden");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Dominio.Entities.DetalleVenta", b =>
                {
                    b.HasOne("Dominio.Entities.Inventario", "Inventario")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdInventarioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Talla", "Talla")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdTallaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Venta", "Venta")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdVentaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Talla");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Dominio.Entities.Empleado", b =>
                {
                    b.HasOne("Dominio.Entities.Cargo", "Cargo")
                        .WithMany("Empleados")
                        .HasForeignKey("IdCargoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Municipio", "Municipio")
                        .WithMany("Empleados")
                        .HasForeignKey("IdMunicipioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Dominio.Entities.Empresa", b =>
                {
                    b.HasOne("Dominio.Entities.Municipio", "Municipio")
                        .WithMany("Empresas")
                        .HasForeignKey("IdMunicipioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Dominio.Entities.Estado", b =>
                {
                    b.HasOne("Dominio.Entities.TipoEstado", "TipoEstado")
                        .WithMany("Estados")
                        .HasForeignKey("IdTipoEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoEstado");
                });

            modelBuilder.Entity("Dominio.Entities.InsumoPrenda", b =>
                {
                    b.HasOne("Dominio.Entities.Insumo", "Insumo")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("IdInsumoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Prenda", "Prenda")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("IdPrendaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Dominio.Entities.InsumoProveedor", b =>
                {
                    b.HasOne("Dominio.Entities.Insumo", "Insumo")
                        .WithMany("InsumoProveedors")
                        .HasForeignKey("IdInsumoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Proveedor", "Proveedor")
                        .WithMany("InsumoProveedors")
                        .HasForeignKey("IdProveedorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.HasOne("Dominio.Entities.Prenda", "Prenda")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdPrendaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Dominio.Entities.InventarioTalla", b =>
                {
                    b.HasOne("Dominio.Entities.Inventario", "Inventario")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("IdInventarioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Talla", "Talla")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("IdTallaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Talla");
                });

            modelBuilder.Entity("Dominio.Entities.Municipio", b =>
                {
                    b.HasOne("Dominio.Entities.Departamento", "Departamentos")
                        .WithMany("Municipios")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Orden", b =>
                {
                    b.HasOne("Dominio.Entities.Cliente", "Cliente")
                        .WithMany("Ordens")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Empleado", "Empleado")
                        .WithMany("Ordens")
                        .HasForeignKey("IdEmpleadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Estado", "Estado")
                        .WithMany("Ordens")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Dominio.Entities.Prenda", b =>
                {
                    b.HasOne("Dominio.Entities.Estado", "Estado")
                        .WithMany("Prendas")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Genero", "Genero")
                        .WithMany("Prendas")
                        .HasForeignKey("IdGeneroFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoProteccion", "TipoProteccion")
                        .WithMany("Prendas")
                        .HasForeignKey("IdTipoProteccionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Genero");

                    b.Navigation("TipoProteccion");
                });

            modelBuilder.Entity("Dominio.Entities.Proveedor", b =>
                {
                    b.HasOne("Dominio.Entities.Municipio", "Municipio")
                        .WithMany("Proveedors")
                        .HasForeignKey("IdMunicipioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoPersona", "TipoPersona")
                        .WithMany("Proveedors")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.HasOne("Dominio.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.HasOne("Dominio.Entities.Rol", "Rol")
                        .WithMany("UsersRols")
                        .HasForeignKey("IdRolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.User", "Usuario")
                        .WithMany("UsersRols")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Dominio.Entities.Venta", b =>
                {
                    b.HasOne("Dominio.Entities.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Empleado", "Empleado")
                        .WithMany("Ventas")
                        .HasForeignKey("IdEmpleadofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.FormaPago", "FormaPago")
                        .WithMany("Ventas")
                        .HasForeignKey("IdFormaPagoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("FormaPago");
                });

            modelBuilder.Entity("Dominio.Entities.Cargo", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Dominio.Entities.Cliente", b =>
                {
                    b.Navigation("Ordens");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Dominio.Entities.Color", b =>
                {
                    b.Navigation("DetalleOrdens");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("Dominio.Entities.Empleado", b =>
                {
                    b.Navigation("Ordens");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Dominio.Entities.Estado", b =>
                {
                    b.Navigation("DetalleOrdens");

                    b.Navigation("Ordens");

                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Dominio.Entities.FormaPago", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Dominio.Entities.Genero", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Dominio.Entities.Insumo", b =>
                {
                    b.Navigation("InsumoPrendas");

                    b.Navigation("InsumoProveedors");
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Dominio.Entities.Municipio", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Empleados");

                    b.Navigation("Empresas");

                    b.Navigation("Proveedors");
                });

            modelBuilder.Entity("Dominio.Entities.Orden", b =>
                {
                    b.Navigation("DetalleOrdenes");
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Prenda", b =>
                {
                    b.Navigation("DetalleOrdens");

                    b.Navigation("InsumoPrendas");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Proveedor", b =>
                {
                    b.Navigation("InsumoProveedors");
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Navigation("UsersRols");
                });

            modelBuilder.Entity("Dominio.Entities.Talla", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoEstado", b =>
                {
                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Proveedors");
                });

            modelBuilder.Entity("Dominio.Entities.TipoProteccion", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UsersRols");
                });

            modelBuilder.Entity("Dominio.Entities.Venta", b =>
                {
                    b.Navigation("DetalleVentas");
                });
#pragma warning restore 612, 618
        }
    }
}
