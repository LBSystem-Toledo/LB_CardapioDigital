using LB_CardapioDigital.Models;

namespace LB_CardapioDigital.Services.Interfaces
{
    public interface IObservacaoService
    {
        Task<IEnumerable<Observacao>?> GetObservacoesAsync(string token, string cdProduto);
    }
}
