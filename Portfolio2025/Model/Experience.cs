namespace Portfolio2025.Model;

public record Experience
{
    public required string Name { get; init; }
    public required string Organization { get; init; }
    public required string Year { get; init; }
    public required string ShortHtmlDescription { get; init; }
    public required string HtmlDescription { get; init; }
}

public static class Experiences
{
    public static Experience StageMJC => new() {
        Name = "...",
        Organization = "MJC Manosque",
        Year = "2022",
        ShortHtmlDescription = """
        <p>
            
        </p>
        """,
        HtmlDescription = """

        """
    };
}