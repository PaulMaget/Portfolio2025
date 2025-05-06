using MudBlazor;

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
		Logo = Icons.Custom.FileFormats.FileImage,
		Description = "Description",
		Category = CompetenceCategory.Languages,
	};

	public static Competence JavaScript => new()
	{
		Name = "JavaScript",
		Logo = Icons.Custom.FileFormats.FileImage,
		Description = """
			P poeifhj qespoihjf qpeoihfj qe f
			fspeiqh epfih q.<br />
			<br />
			fqiueh efliquh efliuh.
			""",
		Category = CompetenceCategory.Languages,
	};

	public static Competence Angular => new()
	{
		Name = "Angular",
		Logo = Icons.Custom.FileFormats.FileImage,
		Description = """
			P poeifhj qespoihjf qpeoihfj qe f
			fspeiqh epfih q.<br />
			<br />
			fqiueh efliquh efliuh.
			""",
		Category = CompetenceCategory.Frameworks,
	};
}