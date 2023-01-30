using LB_CardapioDigital.Models;
using LB_CardapioDigital.Services.Interfaces;
using System.Net.Http.Json;
using System.Text;

namespace LB_CardapioDigital.Services
{
    public class SaborService: ISaborService
    {
        private readonly HttpClient _httpClient;
        public SaborService(HttpClient httpClient) { _httpClient= httpClient; }

        public async Task<IEnumerable<Sabor>?> GetSaboresAsync(string token, string cdProduto)
        {
            _httpClient.DefaultRequestHeaders.Add("token", Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
            return await _httpClient.GetFromJsonAsync<IEnumerable<Sabor>>("/cardapio/v1/Sabor?Cd_produto=" + cdProduto);
        }
    }
}
