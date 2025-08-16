using MeuConcurso.Shared.Responses.Ibge;
using System.Net.Http.Json;

namespace MeuConcurso.WebAssembly.Services.Ibge;

public sealed class IbgeService : IIbgeService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<IbgeService> _logger;

    public IbgeService(IHttpClientFactory httpClientFactory, ILogger<IbgeService> logger)
    {
        _httpClientFactory = httpClientFactory;
        _logger = logger;
    }

    public async Task<IEnumerable<ResponseCityJson>> GetCitiesAsync(int stateId)
    {
        var client = _httpClientFactory.CreateClient(name: "Ibge");

        try
        {
            var cities = await client.GetFromJsonAsync<IEnumerable<ResponseCityJson>>($"localidades/estados/{stateId}/municipios");

            return cities ?? [];
        }
        catch(Exception ex)
        {
            _logger.LogError("Ocorreu um erro ao buscar os as cidades no site do IBGE: {Error}", ex);
        }
        
        return [];
    }

    public async Task<ResponseStateJson[]> GetStatesAsync()
    {
        var client = _httpClientFactory.CreateClient(name: "Ibge");

        try
        {
            var states = await client.GetFromJsonAsync<ResponseStateJson[]>("localidades/estados?orderBy=nome");

            return states ?? [];
        }
        catch(Exception ex)
        {
            _logger.LogError("Ocorreu um erro ao buscar os estados brasileiros no site do IBGE: {Error}", ex);
        }

        return [];
    }
}
