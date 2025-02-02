﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OportunidadeAPI.Data;

#nullable disable

namespace OportunidadeAPI.Migrations
{
    [DbContext(typeof(OportunidadeAPIContext))]
    [Migration("20240606215914_InitialCreated")]
    partial class InitialCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Oportunidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("HorasFolga")
                        .HasColumnType("smallint");

                    b.Property<short>("HorasSono")
                        .HasColumnType("smallint");

                    b.Property<long>("NivelAprendizado")
                        .HasColumnType("bigint");

                    b.Property<string>("NivelSurto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("QtdErro")
                        .HasColumnType("bigint");

                    b.Property<int>("QtdHora")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Oportunidade");
                });
#pragma warning restore 612, 618
        }
    }
}
