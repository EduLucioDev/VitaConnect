using Microsoft.EntityFrameworkCore;
using VitaConnect.ItDeveloper.Domain.Entities;

/// <summary>
/// Classe que representa a conexão com o banco de dados e define as tabelas correspondentes às entidades.
/// </summary>
namespace VitaConnect.ItDeveloper.Data.Data.ORM
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Paciente> Paciente { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
