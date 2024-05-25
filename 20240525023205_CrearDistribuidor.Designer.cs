﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T2_ESCATE_ALEXANDER.Datos;

#nullable disable

namespace T2_ESCATE_ALEXANDER.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240525023205_CrearDistribuidor")]
    partial class CrearDistribuidor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("T2_ESCATE_ALEXANDER.Models.Distribuidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDistribuidor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Distribuidor");
                });
#pragma warning restore 612, 618
        }
    }
}
