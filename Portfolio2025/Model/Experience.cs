namespace Portfolio2025.Model;

public record Experience
{
    public required string Name { get; set; }
    public required string Organization { get; set; }
    public required string Year { get; set; }
    public required string ShortHtmlDescription { get; set; }
    public required string HtmlDescription { get; set; }
    public string? ImageUrl { get; set; }// = "https://placehold.co/50x50";
    public List<Competence> Competences { get; set; } = [];
}

public static class ExperienceExtensions
{
    public static int GetId(this Experience experience)
    {
        return Experiences.All.Select((e, i) => new { e, i })
            .FirstOrDefault(x => x.e == experience)?.i ?? -1;
    }
}

public static class Experiences
{
    public static List<Experience> All => [StageMJC];

    public static Experience StageMJC { get; } = new() {
        Name = "Animateur bénévole",
        Organization = "MJC Manosque",
        Year = "2022",
        Competences = [
            Competences.Unity,
            //Competences.Pedagogie,
            //Competences.GestionDeProjet,
        ],
        ShortHtmlDescription = """
        <p>
            Animation de deux stages de création de jeux vidéo pour des jeunes de 12 à 25 ans.
        </p>
        """,
        HtmlDescription = """
        <p>
            En 2022, avec l'accord de la MJC de Manosque, j'ai animé à deux reprises des stages de création de jeux vidéo d'une semaine pour des jeunes de 12 à 25 ans avec le logiciel Unity.
        </p>
        <img src="/images/MJC_photo1.png" alt="Photo prise lors d'un des stages" style="width: 50%" />
        <p>
            À chaque fois, je me préparais plusieurs semaines à l'avance afin de définir le sujet et d’adapter ma pédagogie.
        </p>
        <p>
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