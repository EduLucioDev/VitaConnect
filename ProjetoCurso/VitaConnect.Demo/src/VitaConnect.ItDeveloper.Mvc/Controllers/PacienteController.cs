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
			var paciente = ObterPacientes();
			return View(paciente);
		}
		[Route("detalhe-de-paciente/{id}")]
		public IActionResult DetalheDePaciente(String id)
		{
			var detalhePaciente = ObterPaciente(id);
			if (detalhePaciente == null) { return NotFound(); }
			return View(detalhePaciente);
		}



		[HttpPost("adicionar-paciente")]
		public async Task<IActionResult> AdicionarPaciente()
		{
			return View();
		}

		private List<Paciente> ObterPacientes()
		{
			#region Cria Paciente
			var Paciente = new List<Paciente>()
			{
				new Paciente()
				{
					Nome = "Pedro Henrique",
					Idade = 18,
					Cpf = "32184596305",
					Bairro = "Aririu da Formiga",
					Cidade = "Palhoça",
					Sexo ="M",
					Telefones = new List<Telefone>()
					{
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Residencial",Numero = "48431562599"},
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Comercial",Numero = "48301555583"},
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Celular",Numero = "48991543587"}
					}
				},
				new Paciente()
				{
					Nome = "Maria Antunieta",
					Cpf = "22184457305",
					Sexo = "M",
					Telefones = new List<Telefone>()
					{
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Residencial",Numero = "48331557525"},
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Comercial",Numero = "48301542423"},
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Celular",Numero = "47991381173"}
					}
				},
				new Paciente()
				{
					Nome = "Jorge Fagundes",
					Cpf = "10884422305",
					Telefones = new List<Telefone>()
					{
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Residencial",Numero = "11421557777"},
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Comercial",Numero = "11301542323"},
						new Telefone() {Id = Guid.NewGuid(), TipoDeTelefone ="Celular",Numero = "11991845431"}
					}
				}
			};
			return Paciente;
		}
		private Paciente? ObterPaciente(string id)
		{
			var pacientes = ObterPacientes();
			if (pacientes != null && id != string.Empty) 
			{
				var paciente = pacientes.FirstOrDefault(p => p.Nome.Contains(id));
				if (paciente != null)
				{
					return paciente;
				}
			}
			return null;
		}
		#endregion


	}



	public class Paciente
	{
		public Paciente()
		{
			Id = Guid.NewGuid();
			Telefones = new HashSet<Telefone>();
		}
		public Guid Id { get; set; }
		public string? Nome { get; set; }
		public string? Cpf { get; set; }
		public string? Bairro { get; set; }
		public ICollection<Telefone> Telefones { get; set; }
		public string Cidade { get; set; }
		public int Idade { get; set; }
		public string Sexo { get; internal set; }
	}
	public class Telefone
	{
		public Guid Id { get; set; }
		public string? TipoDeTelefone { get; set; }
		public string? Numero { get; set; }
	}
}
