using System.ComponentModel;

namespace VitaConnect.ItDeveloper.Domain.Enums
{
	public enum TipoPaciente
	{
		[Description("Conveniado")] Conveniado = 1,
		[Description("Particular")] Particular,
		[Description("Outros")] Outros
	}
}
