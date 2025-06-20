using MudBlazor;
using static System.Net.WebRequestMethods;

namespace Portfolio2025.Model;

public record Competence
{
	public required string Name { get; set; }
	public required string Logo { get; set; }
	public required string Description { get; set; }
	public required CompetenceCategory Category { get; set; }
}

public enum CompetenceCategory
{
	Languages,
	Frameworks
}

public static class CompetenceExtensions
{
	public static string GetName(this CompetenceCategory category) {
		return category switch {
			CompetenceCategory.Languages => "Langages",
			CompetenceCategory.Frameworks => "Frameworks",
			_ => ""
		};
	}
}

public static class Competences
{
	public static Competence[] All => [CSharp, CSharp, JavaScript, Angular, CSharp, CSharp, CSharp, CSharp, CSharp];

	public static Competence CSharp => new() {
		Name = "C#",
		Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/1200px-Logo_C_sharp.svg.png",
		Description = "Le langage haut niveau, orienté objet de Microsoft,<br>l'entreprise américaine notamment responsable de Flight Simulator 2020.",
		Category = CompetenceCategory.Languages,
	};

	public static Competence JavaScript => new()
	{
		Name = "JavaScript",
		Logo = "https://lh3.googleusercontent.com/proxy/nuWxyZIEBmlwkLPiIpq_bJ4eXDw9uozT2D6WSBxvR4NYB3bMZ9T1TrYNao1zQL9MivRNV33D9QeJiDbVManBCLt2Yw8muTBeeOF3ghlbhT2NiQFFScHqgFbwGqFMTKHop6gMf6jQz9kqkPH42mdpaJcx",
        Description = """
			P poeifhj qespoihjf qpeoihfj qe f
			fspeiqh epfih q.<br />
			<br>
			<br>
			<br>
			<br>
			fqiueh efliquh efliuh.
			""",
		Category = CompetenceCategory.Languages,
	};

	public static Competence Angular => new()
	{
		Name = "Angular",
		Logo = "https://brandlogos.net/wp-content/uploads/2025/04/angular_icon-logo_brandlogos.net_jn7wi-512x542.png",
		Description = """
			P poeifhj qespoihjf qpeoihfj qe f
			fspeiqh epfih q.<br />
			<br />
			fqiueh efliquh efliuh.
			""",
		Category = CompetenceCategory.Frameworks,
	};
}