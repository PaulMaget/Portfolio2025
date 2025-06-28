namespace Portfolio2025.Model;

public record Experience
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Organization { get; init; }
    public required string Year { get; init; }
    public required string ShortHtmlDescription { get; init; }
    public required string HtmlDescription { get; init; }
    public string? ImageUrl { get; init; }// = "https://placehold.co/50x50";
}

public static class Experiences
{
    public static Experience[] All => [StageMJC];

    public static Experience StageMJC => new() {
        Id = 0,
        Name = "Animateur bénévole",
        Organization = "MJC Manosque",
        Year = "2022",
        ShortHtmlDescription = """
        <p>
            Animation de deux stages de création de jeux vidéo pour des jeunes de 12 à 25 ans.
        </p>
        """,
        HtmlDescription = """
        <p>
            Avec l'accord de la MJC de Manosque, j'ai animé à deux reprises des stages de création de jeux vidéo d'une semaine pour des jeunes de 12 à 25 ans avec le logiciel Unity.
        </p>
        <img src="/images/MJC_photo1.png" alt="Photo prise lors d'un des stages" style="width: 50%" />
        <p>
            À chaque fois, je me préparais plusieurs semaines à l'avance afin de définir le sujet et d’adapter ma pédagogie.<br>
            Le premier jeu était en 2D et le second en 3D. En raison du temps limité, nous avons utilisé des ressources gratuites et j’ai limité les programmes complexes en privilégiant le visual scripting.
        </p>
        <img src="/images/MJC_photo2.png" alt="Photo prise lors d'un des stages" style="width: 30%" />
        <p>
            Ces stages ont permis d’initier les participants à l’utilisation d’Unity et à la conception de jeux vidéo. De mon côté, ils m'ont formé au rôle de pédagogue et de chef de projet, des compétences qui m'ont ensuite été précieuses en BUT.
        </p>
        """,
        ImageUrl = "/images/MJC_photo1.png",
    };
}