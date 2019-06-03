﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Programacion_1.Models;

namespace Programacion_1.Migrations
{
    [DbContext(typeof(ProyectoContext))]
    partial class ProyectoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Programacion_1.Models.Categoria", b =>
                {
                    b.Property<int>("Id_Categoria")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id_Categoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Programacion_1.Models.Cliente", b =>
                {
                    b.Property<int>("Id_Cliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Numero_Telefonico")
                        .IsRequired();

                    b.HasKey("Id_Cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Programacion_1.Models.Factura", b =>
                {
                    b.Property<int>("Id_Factura")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<string>("Fecha_Realizada");

                    b.Property<int>("Id_Cliente");

                    b.Property<int>("Id_Producto");

                    b.Property<decimal>("Subtotal");

                    b.Property<decimal>("Total");

                    b.HasKey("Id_Factura");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Programacion_1.Models.Guia_de_Remision", b =>
                {
                    b.Property<int>("Id_Guia_de_Remision")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Fecha_de_Llegada");

                    b.Property<int>("Id_Proveedor");

                    b.Property<decimal>("Total");

                    b.HasKey("Id_Guia_de_Remision");

                    b.HasIndex("Id_Proveedor");

                    b.ToTable("Guia_de_Remisions");
                });

            modelBuilder.Entity("Programacion_1.Models.Guia_de_Remision_Item", b =>
                {
                    b.Property<int>("Id_Guia_de_Remision_Item")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<int>("Id_Guia_de_Remision");

                    b.Property<int>("Id_Producto");

                    b.Property<decimal>("subTotal");

                    b.HasKey("Id_Guia_de_Remision_Item");

                    b.HasIndex("Id_Guia_de_Remision");

                    b.HasIndex("Id_Producto");

                    b.ToTable("Guia_de_Remision_Items");
                });

            modelBuilder.Entity("Programacion_1.Models.Inventario", b =>
                {
                    b.Property<int>("Id_Inventario")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad_Total");

                    b.Property<int>("Id_Producto");

                    b.HasKey("Id_Inventario");

                    b.HasIndex("Id_Producto");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("Programacion_1.Models.Marca", b =>
                {
                    b.Property<int>("Id_Marca")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id_Marca");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Programacion_1.Models.Producto", b =>
                {
                    b.Property<int>("Id_Producto")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id_Categoria");

                    b.Property<int>("Id_Marca");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Precio")
                        .IsRequired();

                    b.HasKey("Id_Producto");

                    b.HasIndex("Id_Categoria");

                    b.HasIndex("Id_Marca");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Programacion_1.Models.Proveedor", b =>
                {
                    b.Property<int>("Id_Proveedor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Detalles")
                        .IsRequired();

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Numero_Telefonico")
                        .IsRequired();

                    b.HasKey("Id_Proveedor");

                    b.ToTable("Proveedors");
                });

            modelBuilder.Entity("Programacion_1.Models.Guia_de_Remision", b =>
                {
                    b.HasOne("Programacion_1.Models.Proveedor", "Proveedor")
                        .WithMany("Guia_de_Remisions")
                        .HasForeignKey("Id_Proveedor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Programacion_1.Models.Guia_de_Remision_Item", b =>
                {
                    b.HasOne("Programacion_1.Models.Guia_de_Remision", "Guia_de_Remision")
                        .WithMany("Guia_de_Remision_Items")
                        .HasForeignKey("Id_Guia_de_Remision")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Programacion_1.Models.Producto", "Producto")
                        .WithMany("Guia_de_Remision_Items")
                        .HasForeignKey("Id_Producto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Programacion_1.Models.Inventario", b =>
                {
                    b.HasOne("Programacion_1.Models.Producto", "Producto")
                        .WithMany("Inventarios")
                        .HasForeignKey("Id_Producto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Programacion_1.Models.Producto", b =>
                {
                    b.HasOne("Programacion_1.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("Id_Categoria")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Programacion_1.Models.Marca", "Marca")
                        .WithMany("Productos")
                        .HasForeignKey("Id_Marca")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
