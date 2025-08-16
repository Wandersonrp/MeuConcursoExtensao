namespace MeuConcurso.Shared.Requests;
public sealed record RequestSaveUserPreferencesJson
{    
    public Dictionary<string, string> Cities { get; set; }
    public HashSet<string> PublicAgencies { get; set; }    

    public RequestSaveUserPreferencesJson()
    {        
        Cities = [];
        PublicAgencies = [];
    }
}
