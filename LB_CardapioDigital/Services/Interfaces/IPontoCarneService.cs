using LB_CardapioDigital.Models;

namespace LB_CardapioDigital.Services.Interfaces
{
    public interface IPontoCarneService
    {
        Task<IEnumerable<PontoCarne>?> GetPontoCarneAsync(string token, string cdProduto);
    }
}
