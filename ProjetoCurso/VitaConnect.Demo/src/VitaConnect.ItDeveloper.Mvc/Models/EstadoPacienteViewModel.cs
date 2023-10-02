using VitaConnect.ItDeveloper.Domain.Entities;

namespace VitaConnect.ItDeveloper.Mvc.Models
{
	public class EstadoPacienteViewModel
	{
		public Guid Id { get; set; }
		public String? Descricao { get; set; }
		public ICollection<Paciente>? Pacientes { get; set; }
	}
}
