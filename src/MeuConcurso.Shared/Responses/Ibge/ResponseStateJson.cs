namespace MeuConcurso.Shared.Responses.Ibge;
public sealed record ResponseStateJson
{
    public int Id { get; set; }
    public string? Sigla { get; set; }
    public string? Nome { get; set; }

    public override string ToString()
    {                
        return $"{Nome}/{Sigla}";
    }
}
