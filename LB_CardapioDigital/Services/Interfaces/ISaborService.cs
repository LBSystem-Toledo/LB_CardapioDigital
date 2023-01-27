using LB_CardapioDigital.Models;

namespace LB_CardapioDigital.Services.Interfaces
{
    public interface ISaborService
    {
        Task<IEnumerable<Sabor>?> GetSaboresAsync(string token, string cdProduto);
    }
}
