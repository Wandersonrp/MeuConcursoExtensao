using MeuConcurso.Shared.Responses.Ibge;

namespace MeuConcurso.WebAssembly.Services.Ibge;

public interface IIbgeService
{
    Task<ResponseStateJson[]> GetStatesAsync();
    Task<IEnumerable<ResponseCityJson>> GetCitiesAsync(int stateId);
}