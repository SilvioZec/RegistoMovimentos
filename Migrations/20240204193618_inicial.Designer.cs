﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistoMovimentos.Persistence;

#nullable disable

namespace RegistoMovimentos.Migrations
{
    [DbContext(typeof(DBWorker))]
    [Migration("20240204193618_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RegistoMovimentos.Business_data.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Designacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marcador")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Nif")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("RegistoMovimentos.Business_data.Movimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marcador")
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Tipo_movimentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("Tipo_movimentoId");

                    b.ToTable("Movimentos");
                });

            modelBuilder.Entity("RegistoMovimentos.Business_data.Tipo_movimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos_movimento");
                });

            modelBuilder.Entity("RegistoMovimentos.Business_data.Movimento", b =>
                {
                    b.HasOne("RegistoMovimentos.Business_data.Cliente", "Cliente")
                        .WithMany("Movimentos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistoMovimentos.Business_data.Tipo_movimento", "Tipo_movimento")
                        .WithMany("Movimentos")
                        .HasForeignKey("Tipo_movimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Tipo_movimento");
                });

            modelBuilder.Entity("RegistoMovimentos.Business_data.Cliente", b =>
                {
                    b.Navigation("Movimentos");
                });

            modelBuilder.Entity("RegistoMovimentos.Business_data.Tipo_movimento", b =>
                {
                    b.Navigation("Movimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
