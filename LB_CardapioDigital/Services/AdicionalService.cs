using LB_CardapioDigital.Models;
using LB_CardapioDigital.Services.Interfaces;
using System.Net.Http.Json;
using System.Text;

namespace LB_CardapioDigital.Services
{
    public class AdicionalService: IAdicionalService
    {
        private readonly HttpClient _httpClient;
        public AdicionalService(HttpClient httpClient) { _httpClient = httpClient; }

        public async Task<IEnumerable<Adicional>?> GetAdicionaisAsync(string token, string cdProduto)
        {
            _httpClient.DefaultRequestHeaders.Add("token", Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
            return await _httpClient.GetFromJsonAsync<IEnumerable<Adicional>>("/cardapio/v1/Adicional?Cd_produto=" + cdProduto);
        }
    }
}
