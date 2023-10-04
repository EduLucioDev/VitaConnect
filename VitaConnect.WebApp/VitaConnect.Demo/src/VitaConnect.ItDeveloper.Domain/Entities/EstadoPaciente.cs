using VitaConnect.ItDeveloper.Domain.Entities.Base;

namespace VitaConnect.ItDeveloper.Domain.Entities
{
	/// <summary>
	/// Classe que representa o estado de um paciente no domínio do aplicativo.
	/// </summary>
	public class EstadoPaciente : EntityBase
	{
		public string? Descricao { get; set; }
		public ICollection<Paciente>? Pacientes { get; set; }
	}
}
