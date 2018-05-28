﻿// <auto-generated />
using System;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicRegisters.Data.Migrations
{
    [DbContext(typeof(BasicRegistersContext))]
    partial class BasicRegistersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BasicRegisters.Domain.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessKey")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UserID")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BasicRegisters.Domain.Entidades.Conta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apelido");

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataDeCadastro");

                    b.Property<DateTime>("DataDeExclusao");

                    b.Property<bool>("Excluido");

                    b.Property<string>("Nome");

                    b.Property<Guid>("UsuarioDeCadastroId");

                    b.Property<Guid>("UsuarioDeExlusaoId");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}
