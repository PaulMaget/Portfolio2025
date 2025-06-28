using MudBlazor;

namespace Portfolio2025.Model;

public record Competence
{
    public required string Name { get; set; }
	public required string Logo { get; set; }
	public required string HtmlDescription { get; set; }
	public required CompetenceCategory Category { get; set; }
}

public enum CompetenceCategory
{
	Languages,
	Frameworks,
    Tools,
}

public static class CompetenceExtensions
{
	public static string GetName(this CompetenceCategory category) {
		return category switch {
			CompetenceCategory.Languages => "Langages",
			CompetenceCategory.Frameworks => "Frameworks",
			CompetenceCategory.Tools => "Outils",
			_ => ""
		};
	}

    public static int GetId(this Competence competence)
    {
        return Competences.All.Select((c, i) => new { c, i })
            .FirstOrDefault(x => x.c == competence)?.i ?? -1;
    }
}

public static class Competences
{
	public static List<Competence> All => [CSharp, JavaScript, Angular, Unity, CSharp, CSharp, CSharp, CSharp];

	public static Competence CSharp { get; } = new()
	{
        Name = "C#",
		Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/1200px-Logo_C_sharp.svg.png",
		HtmlDescription = "Le langage haut niveau, orienté objet de Microsoft,<br>l'entreprise américaine notamment responsable de Flight Simulator 2020.",
		Category = CompetenceCategory.Languages,
	};

	public static Competence JavaScript { get; } = new()
	{
        Name = "JavaScript",
		Logo = "https://lh3.googleusercontent.com/proxy/nuWxyZIEBmlwkLPiIpq_bJ4eXDw9uozT2D6WSBxvR4NYB3bMZ9T1TrYNao1zQL9MivRNV33D9QeJiDbVManBCLt2Yw8muTBeeOF3ghlbhT2NiQFFScHqgFbwGqFMTKHop6gMf6jQz9kqkPH42mdpaJcx",
        HtmlDescription = """
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

	public static Competence Angular { get; } = new()
	{
        Name = "Angular",
		Logo = "https://brandlogos.net/wp-content/uploads/2025/04/angular_icon-logo_brandlogos.net_jn7wi-512x542.png",
		HtmlDescription = """
			P poeifhj qespoihjf qpeoihfj qe f
			fspeiqh epfih q.<br />
			<br />
			fqiueh efliquh efliuh.
			""",
		Category = CompetenceCategory.Frameworks,
	};

    public static Competence Unity { get; } = new()
    {
        Name = "Unity",
        Logo = "https://cdn-icons-png.flaticon.com/512/5969/5969346.png",
        HtmlDescription = """
			P poeifhj qespoihjf qpeoihfj qe f
			fspeiqh epfih q.<br />
			<br />
			fqiueh efliquh efliuh.
			""",
        Category = CompetenceCategory.Tools,
    };
}