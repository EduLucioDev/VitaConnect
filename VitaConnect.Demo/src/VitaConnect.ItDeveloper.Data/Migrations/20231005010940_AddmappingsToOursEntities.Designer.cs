﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VitaConnect.ItDeveloper.Data.Data.ORM;

#nullable disable

namespace VitaConnect.ItDeveloper.Data.Migrations
{
    [DbContext(typeof(ITDeveloperDbContext))]
    [Migration("20231005010940_AddmappingsToOursEntities")]
    partial class AddmappingsToOursEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VitaConnect.ItDeveloper.Domain.Entities.EstadoPaciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Descricao");

                    b.HasKey("Id");

                    b.ToTable("EstadoPaciente", (string)null);
                });

            modelBuilder.Entity("VitaConnect.ItDeveloper.Domain.Entities.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Cpf")
                        .IsFixedLength();

                    b.Property<DateTime>("DataInternacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Email");

                    b.Property<Guid>("EstadoPacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Motivo")
                        .HasColumnType("varchar(90)")
                        .HasColumnName("Motivo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)")
                        .HasColumnName("Nome");

                    b.Property<string>("Rg")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Rg");

                    b.Property<DateTime>("RgDataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("RgOrgao")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("RgOrgao");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("TipoPaciente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoPacienteId");

                    b.ToTable("Paciente", (string)null);
                });

            modelBuilder.Entity("VitaConnect.ItDeveloper.Domain.Entities.Paciente", b =>
                {
                    b.HasOne("VitaConnect.ItDeveloper.Domain.Entities.EstadoPaciente", "EstadoPaciente")
                        .WithMany("Pacientes")
                        .HasForeignKey("EstadoPacienteId")
                        .IsRequired();

                    b.Navigation("EstadoPaciente");
                });

            modelBuilder.Entity("VitaConnect.ItDeveloper.Domain.Entities.EstadoPaciente", b =>
                {
                    b.Navigation("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
