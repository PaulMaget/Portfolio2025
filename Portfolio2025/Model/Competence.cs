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
	public static string? ToString(this CompetenceCategory category) {
		return category switch {
			CompetenceCategory.Languages => "Langages",
			CompetenceCategory.Frameworks => "Frameworks",
			_ => null
		};
	}
}

public static class Competences
{
	public static Competence CSharp => new() {
		Name = "C#",
		Logo = Icons.Custom.FileFormats.FileImage,
		Description = "Description",
		Category = CompetenceCategory.Languages,
	};
}