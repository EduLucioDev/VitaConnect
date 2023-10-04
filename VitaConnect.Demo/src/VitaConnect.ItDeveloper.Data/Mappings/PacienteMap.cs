﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitaConnect.ItDeveloper.Domain.Entities;

namespace VitaConnect.ItDeveloper.Data.Mappings
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(80)")
                .HasColumnName("Nome");

            builder.Property(e => e.Email).HasColumnName("Email")
                .HasColumnType("varchar(150)");

            builder.Property(c => c.Cpf)
                .HasMaxLength(11).IsFixedLength(true)
                .HasColumnName("Cpf").HasColumnType("varchar(11)");

            builder.Property(r => r.Rg)
                .HasMaxLength(15)
                .HasColumnName("Rg")
                .HasColumnType("varchar(15)");

            builder.Property(o => o.RgOrgao)
                .HasColumnName("RgOrgao")
                .HasColumnType("varchar(10)");

            builder.Property(o => o.Motivo)
                .HasColumnName("Motivo")
                .HasColumnType("varchar(90)");

            // 1:1 => Paciente : EstadoPaciente OU 0:N => EstadoPaciente : Paciente
            builder.HasOne(ep => ep.EstadoPaciente)
                .WithMany(p => p.Pacientes)
                .HasForeignKey(fk => fk.EstadoPacienteId)
                .HasPrincipalKey(p => p.Id);

            builder.ToTable(nameof(Paciente));
        }
    }
}
