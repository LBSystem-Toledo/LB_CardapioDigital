using LB_CardapioDigital.Models;

namespace LB_CardapioDigital.Services.Interfaces
{
    public interface IAdicionalService
    {
        Task<IEnumerable<Adicional>?> GetAdicionaisAsync(string token, string cdProduto);
    }
}
