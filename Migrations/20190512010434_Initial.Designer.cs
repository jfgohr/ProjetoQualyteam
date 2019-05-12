﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoQualyteam.Models.Dao;

namespace ProjetoQualyteam.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20190512010434_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("aaa.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Anexo")
                        .IsRequired()
                        .HasColumnName("anexo");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnName("categoria");

                    b.Property<string>("Processo")
                        .IsRequired()
                        .HasColumnName("processo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo");

                    b.HasKey("Id")
                        .HasName("id");

                    b.ToTable("documento");
                });
#pragma warning restore 612, 618
        }
    }
}
