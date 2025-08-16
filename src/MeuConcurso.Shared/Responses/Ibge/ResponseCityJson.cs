namespace MeuConcurso.Shared.Responses.Ibge;
public sealed record ResponseCityJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
}
