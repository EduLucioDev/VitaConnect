using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitaConnect.ItDeveloper.Domain.Entities;

namespace VitaConnect.ItDeveloper.Data.Mappings
{
    public class EstdoPacienteMap : IEntityTypeConfiguration<EstadoPaciente>
    {
        public void Configure(EntityTypeBuilder<EstadoPaciente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).HasColumnType("varchar(30)")
                .IsRequired().HasColumnName("Descricao");
            builder.HasMany(p => p.Pacientes)
                .WithOne(p => p.EstadoPaciente);
                //.OnDelete(DeleteBehavior.Cascade);

        }
    }
}
