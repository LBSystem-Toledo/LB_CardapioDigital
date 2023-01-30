using LB_CardapioDigital.Models;
using LB_CardapioDigital.Services.Interfaces;
using System.Net.Http.Json;
using System.Text;

namespace LB_CardapioDigital.Services
{
    public class PontoCarneService: IPontoCarneService
    {
        private readonly HttpClient _httpClient;
        public PontoCarneService(HttpClient httpClient) { _httpClient= httpClient; }

        public async Task<IEnumerable<PontoCarne>?> GetPontoCarneAsync(string token, string cdProduto)
        {
            _httpClient.DefaultRequestHeaders.Add("token", Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
            return await _httpClient.GetFromJsonAsync<IEnumerable<PontoCarne>>("/cardapio/v1/PontoCarne?Cd_produto=" + cdProduto);
        }
    }
}
