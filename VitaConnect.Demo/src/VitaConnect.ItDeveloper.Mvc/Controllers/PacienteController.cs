using Microsoft.AspNetCore.Mvc;

namespace VitaConnect.ItDeveloper.Mvc.Controllers
{
	[Route("")]
	[Route("gestao-paciente")]
	[Route("gestao-pacientes")]
	public class PacienteController : BaseController
	{
		[Route("pacientes")]
		[Route("obter-pacientes")]
		public IActionResult Index()
		{
			return View();
		}
		[Route("detalhe-de-paciente/{id}")]
		public IActionResult DetalheDePaciente(String id)
		{
			return View();
		}
	}
}
