using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VitaConnect.ItDeveloper.Domain.Entities;
using VitaConnect.ItDeveloper.Domain.Enums;

namespace VitaConnect.ItDeveloper.Mvc.Models
{
	public class PacienteViewModel
	{
		[Key]
		[DisplayName(displayName: "Id do Paciente")]
		public string Id { get; set; }

		public Guid EstadoPacienteId { get; set; }
		public virtual EstadoPacienteViewModel? EstadoPaciente { get; set; }

		public string? Nome { get; set; }
		[Display(Name = "Data Nascimento")]
		[DataType(DataType.DateTime, ErrorMessage = "O campo {0} está inválido")]
		public DateTime DataNascimento { get; set; }
		[Display(Name = "Data de Internação")]
		[DataType(DataType.DateTime, ErrorMessage = "O campo {0} está inválido")]
		public DateTime DataInternacao { get; set; }
		public string? Email { get; set; }
		public bool Ativo { get; set; }
		public string? Cpf { get; set; }
		public TipoPaciente TipoPaciente { get; set; }
		public Sexo Sexo { get; set; }
		public string? Rg { get; set; }
		public string? RgOrgao { get; set; }
		[Display(Name = "Data de emissão do RG")]
		[DataType(DataType.DateTime, ErrorMessage = "O campo {0} está inválido")]
		public DateTime RgDataEmissao { get; set; }
		public string? Motivo { get; set; }
	}
}
