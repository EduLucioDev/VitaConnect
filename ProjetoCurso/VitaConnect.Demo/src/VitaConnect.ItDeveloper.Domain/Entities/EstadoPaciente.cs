namespace VitaConnect.ItDeveloper.Domain.Entities
{
	public class EstadoPaciente
	{
		public Guid Id { get; set; }
		public String? Descricao { get; set; }
		public ICollection<Paciente>? Pacientes { get; set; }
	}
}
