﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mgptechRestAPI.Infra.Data;

namespace mgptechRestAPI.Infra.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20210228230342_clientes")]
    partial class clientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Ambiente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.CanalComunicacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("CanalComunicacao");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Procedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Procedimento");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tempo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoMedio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoRapido")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Setor");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.SubCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("SubCategoria");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Agenda", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.CanalComunicacao", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Procedimento", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Role", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Ambiente", "Ambiente")
                        .WithMany("Roles")
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Setor", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.SubCategoria", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.User", b =>
                {
                    b.HasOne("mgptechRestAPI.Domain.Entities.Ambiente", "Ambiente")
                        .WithMany("Users")
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("mgptechRestAPI.Domain.Entities.Ambiente", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
