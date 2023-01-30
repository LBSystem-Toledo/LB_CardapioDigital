using LB_CardapioDigital.Models;
using LB_CardapioDigital.Services.Interfaces;
using System.Net.Http.Json;
using System.Text;

namespace LB_CardapioDigital.Services
{
    public class ObservacaoService: IObservacaoService
    {
        private readonly HttpClient _httpClient;
        public ObservacaoService(HttpClient httpClient) { _httpClient= httpClient; }

        public async Task<IEnumerable<Observacao>?> GetObservacoesAsync(string token, string cdProduto)
        {
            _httpClient.DefaultRequestHeaders.Add("token", Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
            return await _httpClient.GetFromJsonAsync<IEnumerable<Observacao>>("/cardapio/v1/Observacoes?Cd_produto=" + cdProduto);
        }
    }
}
